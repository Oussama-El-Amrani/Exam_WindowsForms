using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam_WindowsForms.Persistence;
using Exam_WindowsForms.Persistence.util;
using QCM_WindowForms;

namespace Exam_WindowsForms.View.Professeur
{
    
    public partial class FormAuthProfesseurs : Form
    {
        //public static FormAuthProfesseurs instance;
        public Model.Professeur professeur { get; set; }
        private ProfesseurDAO professeurDAO;
        private DatabaseConnectionManager databaseConnectionManager;
        protected internal SqlConnection connection;
        public FormAuthProfesseurs()
        {
            databaseConnectionManager = new DatabaseConnectionManager();
            connection = databaseConnectionManager.getConnection();
            professeurDAO = new ProfesseurDAO(this.connection);
            this.professeur = new Model.Professeur();
            InitializeComponent();
            //instance = this;
        }
        
        private void FormAuthProfesseurs_Load(object sender, EventArgs e)
        {
            
            panelInscriptionProf.Visible = false;
            buttonCrrerExam.Visible = false;
            //List des professeur dans comboBox
            //ProfesseurDAO professeurDAO = new ProfesseurDAO(connection);
            //List<Model.Professeur> professeurs = professeurDAO.findAll();
            //foreach (var professeur in professeurs)
            //{
            //    comboBoxListProfesseur.Items.Add(professeur.NomComplet);
            //}

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCrrerExam_Click(object sender, EventArgs e)
        {
            var examInterfaceAdmin = new InterfaceAdmin(professeur);

            examInterfaceAdmin.ShowDialog();
        }

        private void buttonCreerCompte_Click(object sender, EventArgs e)
        {
            panelInscriptionProf.Visible = true;
        }

        private void buttonValidationCrreationCompte_Click(object sender, EventArgs e)
        {
            string nomComplet = textBoxNomComplet.Text;
            string cne = textBoxCNE.Text;
            string email = textBoxEmailProf.Text;

            //if (nomComplet != "" && cne != "" && email != "")
            //{
                this.professeur = new Model.Professeur();
                this.professeur.NomComplet = nomComplet;
                this.professeur.Cne = cne;
                this.professeur.Email = email;
                this.professeur = professeurDAO.create(professeur);
            //}

            MessageBox.Show("Vous avez bien créer votre compte");
            buttonCrrerExam.Visible = true;
        }
    }
}
