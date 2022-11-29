using Exam_WindowsForms.Model;
using Exam_WindowsForms.Persistence;
using Exam_WindowsForms.Persistence.util;
using Exam_WindowsForms.View.Professeur;
using System.Data.SqlClient;

namespace QCM_WindowForms
{
    public partial class InterfaceAdmin : Form
    {
        public static InterfaceAdmin instance;
        public Exam exam { get; set; }
        private ExamDAO examDAO;

        private DatabaseConnectionManager databaseConnectionManager;
        private SqlConnection connection;
        private Professeur professeurStatic { get; set; }
        public InterfaceAdmin(Professeur professeurStatic)
        {
            databaseConnectionManager = new DatabaseConnectionManager();
            connection = databaseConnectionManager.getConnection();
            examDAO = new ExamDAO(this.connection);
            InitializeComponent();
            //instance = this;
            this.professeurStatic = professeurStatic;
        }

        private void InterfaceAdmin_Load(object sender, EventArgs e)
        {
            panelAjouterNouveauExam.Visible = false;
            panelAjouterQuestions.Visible = false;

        }

        private void buttonAjouterExam_Click(object sender, EventArgs e)
        {
            panelAjouterNouveauExam.Visible = true;
        }

        private void buttonValiderCreationExams_Click(object sender, EventArgs e)
        {
            string examNom = textBoxNomExam.Text;
            int dureeExam = (int)numericUpDownDureeExam.Value;
            DateTime dateDebut = dateTimePicker1.Value.Date;
            MessageBox.Show(dateDebut.ToString());
            if (examNom != "" && dureeExam != 0)
            {
                exam = new Exam();
                exam.Nom = examNom;
                exam.Duree = dureeExam;
                exam.DateDebut = dateDebut;
                exam.Professeur = professeurStatic;
                exam = examDAO.create(exam);
            }

            MessageBox.Show("Votre Exam a bien été créer");
            panelAjouterQuestions.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonAjouterQuestionChoixMultiple_Click(object sender, EventArgs e)
        {
            FormQCM questionChoixMultiple = new FormQCM(this.exam);
            questionChoixMultiple.ShowDialog();
        }

        private void buttonAjouterQuestionSimple_Click(object sender, EventArgs e)
        {
            FormQuestionSimple question = new FormQuestionSimple(this.exam);
            question.ShowDialog();
        }
    }
}