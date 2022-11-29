using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam_WindowsForms.View.Professeur;

namespace Exam_WindowsForms.View
{
    public partial class FormAuth : System.Windows.Forms.Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAuthProfesseur_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var formProfesseur = new FormAuthProfesseurs();
            formProfesseur.ShowDialog();
        }
    }
}
