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
using Exam_WindowsForms.Model;
using Exam_WindowsForms.Persistence;
using Exam_WindowsForms.Persistence.util;

namespace QCM_WindowForms
{
    public partial class FormQCM : Form
    {
        private QuestionChoixMultipleDAO qcmDAO;
        private QuestionChoixMultiple qcm;

        private PropositionDAO propositionDAO;
        private Proposition proposition { get; set; }
        private Exam exam { get; set; }

        private DatabaseConnectionManager databaseConnectionManager;
        private SqlConnection connection;
        public FormQCM(Exam exam)
        {
            databaseConnectionManager = new DatabaseConnectionManager();
            connection = databaseConnectionManager.getConnection();
            qcmDAO = new QuestionChoixMultipleDAO(this.connection);
            propositionDAO = new PropositionDAO(this.connection);
            InitializeComponent();
            this.exam = exam;
            panelProposition.Visible = false;
        }

        private void buttonValiderQCM_Click(object sender, EventArgs e)
        {
            string enonce = textBoxEnonce.Text;
            int nombrePoints = (int)numericUpDownNombrePointsQCM.Value;
            if (enonce != "" && nombrePoints != 0)
            {
                qcm = new QuestionChoixMultiple();
                qcm.Enonce = enonce;
                qcm.nombrePoint = nombrePoints;
                qcm.Exam = exam;
                qcm = qcmDAO.create(qcm);
            }

            MessageBox.Show("la question a bien éte enregister");
        }
        private void FormQuestionChoixMultiple_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonAjouterProposition_Click(object sender, EventArgs e)
        {
            panelProposition.Visible = true;
        }

        private void VaalideProposition_Click(object sender, EventArgs e)
        {
            string enonceProposition = textBoxProposition.Text;

            if (enonceProposition != "")
            {
                proposition = new Proposition();
                proposition.Contenu = enonceProposition;
                proposition.QCM = qcm;
                if (radioButtonFaux.Checked)
                {
                    proposition.Vrai = false;
                }
                if (radioButtonVrai.Checked)
                {
                    proposition.Vrai = true;
                }

                proposition = propositionDAO.create(proposition);
                proposition = null;
            }

            MessageBox.Show("Votre propositio a été ajouter");
            panelProposition.Visible = false;
        }
    }
}
