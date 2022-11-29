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
    public partial class FormQuestionSimple : Form
    {
        private QuestionOuverteDAO questionOuverteDAO;
        private QuestionOuverte questionOuverte;
        private Exam exam { get; set; }

        private DatabaseConnectionManager databaseConnectionManager;
        private SqlConnection connection;
        public FormQuestionSimple(Exam exam)
        {
            databaseConnectionManager = new DatabaseConnectionManager();
            connection = databaseConnectionManager.getConnection();
            questionOuverteDAO = new QuestionOuverteDAO(this.connection);

            InitializeComponent();
            this.exam = exam;
        }

        private void buttonValiderQuestionSimple_Click(object sender, EventArgs e)
        {
            string Enonce = textBoxQuestionSimple.Text;
            int nombrePoints = (int)numericUpDownNombrePointsQS.Value;
            if (Enonce != "")
            {
                questionOuverte = new QuestionOuverte();
                questionOuverte.Enonce = Enonce;
                questionOuverte.nombrePoint = nombrePoints;
                questionOuverte.Exam = exam;

                questionOuverte = questionOuverteDAO.create(questionOuverte);
            }

            MessageBox.Show("La question a bien été ajouter");
            questionOuverte = null;
        }

        private void numericUpDownNombrePointsQS_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
