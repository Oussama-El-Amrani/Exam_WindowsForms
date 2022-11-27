using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QCM_WindowForms;

namespace Exam_WindowsForms.View.Professeur
{
    
    public partial class FormAuthProfesseurs : Form
    {
        private Model.Professeur professeur;
        public FormAuthProfesseurs()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCrrerExam_Click(object sender, EventArgs e)
        {
            var examInterfaceAdmin = new InterfaceAdmin();
            examInterfaceAdmin.ShowDialog();
        }
    }
}
