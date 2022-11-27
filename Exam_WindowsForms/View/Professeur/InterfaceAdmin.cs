namespace QCM_WindowForms
{
    public partial class InterfaceAdmin : Form
    {
        public InterfaceAdmin()
        {
            InitializeComponent();
        }

        private void InterfaceAdmin_Load(object sender, EventArgs e)
        {

        }

        private void buttonAjouterExam_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonAjouterQuestionChoixMultiple_Click(object sender, EventArgs e)
        {
            FormQCM questionChoixMultiple = new FormQCM();
            questionChoixMultiple.ShowDialog();
        }

        private void buttonAjouterQuestionSimple_Click(object sender, EventArgs e)
        {
            FormQuestionSimple question = new FormQuestionSimple();
            question.ShowDialog();
        }
    }
}