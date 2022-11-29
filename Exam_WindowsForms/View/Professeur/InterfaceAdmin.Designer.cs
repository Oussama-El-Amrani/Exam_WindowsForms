namespace QCM_WindowForms
{
    partial class InterfaceAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAjouterExam = new System.Windows.Forms.Button();
            this.buttonAjouterQCM = new System.Windows.Forms.Button();
            this.textBoxNomExam = new System.Windows.Forms.TextBox();
            this.labelExamNom = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDateExam = new System.Windows.Forms.Label();
            this.labelDureeExam = new System.Windows.Forms.Label();
            this.buttonValiderCreationExams = new System.Windows.Forms.Button();
            this.comboBoxListeExams = new System.Windows.Forms.ComboBox();
            this.labelListesExams = new System.Windows.Forms.Label();
            this.labelListeQuestions = new System.Windows.Forms.Label();
            this.comboBoxQuestions = new System.Windows.Forms.ComboBox();
            this.buttonAjouterQuestionSimple = new System.Windows.Forms.Button();
            this.panelAjouterNouveauExam = new System.Windows.Forms.Panel();
            this.panelAjouterQuestions = new System.Windows.Forms.Panel();
            this.panelListExamsQuestion = new System.Windows.Forms.Panel();
            this.numericUpDownDureeExam = new System.Windows.Forms.NumericUpDown();
            this.panelAjouterNouveauExam.SuspendLayout();
            this.panelAjouterQuestions.SuspendLayout();
            this.panelListExamsQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDureeExam)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAjouterExam
            // 
            this.buttonAjouterExam.Location = new System.Drawing.Point(12, 36);
            this.buttonAjouterExam.Name = "buttonAjouterExam";
            this.buttonAjouterExam.Size = new System.Drawing.Size(193, 34);
            this.buttonAjouterExam.TabIndex = 0;
            this.buttonAjouterExam.Text = "Ajouter Exam";
            this.buttonAjouterExam.UseVisualStyleBackColor = true;
            this.buttonAjouterExam.Click += new System.EventHandler(this.buttonAjouterExam_Click);
            // 
            // buttonAjouterQCM
            // 
            this.buttonAjouterQCM.Location = new System.Drawing.Point(14, 2);
            this.buttonAjouterQCM.Name = "buttonAjouterQCM";
            this.buttonAjouterQCM.Size = new System.Drawing.Size(290, 34);
            this.buttonAjouterQCM.TabIndex = 3;
            this.buttonAjouterQCM.Text = "Ajouter Question Choix Multiple";
            this.buttonAjouterQCM.UseVisualStyleBackColor = true;
            this.buttonAjouterQCM.Click += new System.EventHandler(this.buttonAjouterQuestionChoixMultiple_Click);
            // 
            // textBoxNomExam
            // 
            this.textBoxNomExam.Location = new System.Drawing.Point(3, 29);
            this.textBoxNomExam.Name = "textBoxNomExam";
            this.textBoxNomExam.Size = new System.Drawing.Size(178, 31);
            this.textBoxNomExam.TabIndex = 4;
            // 
            // labelExamNom
            // 
            this.labelExamNom.AutoSize = true;
            this.labelExamNom.Location = new System.Drawing.Point(10, 0);
            this.labelExamNom.Name = "labelExamNom";
            this.labelExamNom.Size = new System.Drawing.Size(132, 25);
            this.labelExamNom.TabIndex = 5;
            this.labelExamNom.Text = "Nom de l\'exam";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 31);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // labelDateExam
            // 
            this.labelDateExam.AutoSize = true;
            this.labelDateExam.Location = new System.Drawing.Point(3, 78);
            this.labelDateExam.Name = "labelDateExam";
            this.labelDateExam.Size = new System.Drawing.Size(181, 25);
            this.labelDateExam.TabIndex = 7;
            this.labelDateExam.Text = "Date début de l\'exam";
            this.labelDateExam.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDureeExam
            // 
            this.labelDureeExam.AutoSize = true;
            this.labelDureeExam.Location = new System.Drawing.Point(3, 160);
            this.labelDureeExam.Name = "labelDureeExam";
            this.labelDureeExam.Size = new System.Drawing.Size(139, 25);
            this.labelDureeExam.TabIndex = 9;
            this.labelDureeExam.Text = "Durée de l\'exam";
            // 
            // buttonValiderCreationExams
            // 
            this.buttonValiderCreationExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonValiderCreationExams.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonValiderCreationExams.Location = new System.Drawing.Point(0, 307);
            this.buttonValiderCreationExams.Name = "buttonValiderCreationExams";
            this.buttonValiderCreationExams.Size = new System.Drawing.Size(127, 51);
            this.buttonValiderCreationExams.TabIndex = 10;
            this.buttonValiderCreationExams.Text = "Valider";
            this.buttonValiderCreationExams.UseVisualStyleBackColor = false;
            this.buttonValiderCreationExams.Click += new System.EventHandler(this.buttonValiderCreationExams_Click);
            // 
            // comboBoxListeExams
            // 
            this.comboBoxListeExams.FormattingEnabled = true;
            this.comboBoxListeExams.Location = new System.Drawing.Point(3, 28);
            this.comboBoxListeExams.Name = "comboBoxListeExams";
            this.comboBoxListeExams.Size = new System.Drawing.Size(182, 33);
            this.comboBoxListeExams.TabIndex = 15;
            // 
            // labelListesExams
            // 
            this.labelListesExams.AutoSize = true;
            this.labelListesExams.Location = new System.Drawing.Point(3, 0);
            this.labelListesExams.Name = "labelListesExams";
            this.labelListesExams.Size = new System.Drawing.Size(143, 25);
            this.labelListesExams.TabIndex = 16;
            this.labelListesExams.Text = "Listes des exams";
            // 
            // labelListeQuestions
            // 
            this.labelListeQuestions.AutoSize = true;
            this.labelListeQuestions.Location = new System.Drawing.Point(3, 68);
            this.labelListeQuestions.Name = "labelListeQuestions";
            this.labelListeQuestions.Size = new System.Drawing.Size(154, 25);
            this.labelListeQuestions.TabIndex = 17;
            this.labelListeQuestions.Text = "Liste des question";
            // 
            // comboBoxQuestions
            // 
            this.comboBoxQuestions.FormattingEnabled = true;
            this.comboBoxQuestions.Location = new System.Drawing.Point(3, 109);
            this.comboBoxQuestions.Name = "comboBoxQuestions";
            this.comboBoxQuestions.Size = new System.Drawing.Size(182, 33);
            this.comboBoxQuestions.TabIndex = 18;
            // 
            // buttonAjouterQuestionSimple
            // 
            this.buttonAjouterQuestionSimple.Location = new System.Drawing.Point(369, 3);
            this.buttonAjouterQuestionSimple.Name = "buttonAjouterQuestionSimple";
            this.buttonAjouterQuestionSimple.Size = new System.Drawing.Size(233, 33);
            this.buttonAjouterQuestionSimple.TabIndex = 19;
            this.buttonAjouterQuestionSimple.Text = "Ajouter question Simple";
            this.buttonAjouterQuestionSimple.UseVisualStyleBackColor = true;
            this.buttonAjouterQuestionSimple.Click += new System.EventHandler(this.buttonAjouterQuestionSimple_Click);
            // 
            // panelAjouterNouveauExam
            // 
            this.panelAjouterNouveauExam.Controls.Add(this.numericUpDownDureeExam);
            this.panelAjouterNouveauExam.Controls.Add(this.labelExamNom);
            this.panelAjouterNouveauExam.Controls.Add(this.textBoxNomExam);
            this.panelAjouterNouveauExam.Controls.Add(this.dateTimePicker1);
            this.panelAjouterNouveauExam.Controls.Add(this.labelDateExam);
            this.panelAjouterNouveauExam.Controls.Add(this.labelDureeExam);
            this.panelAjouterNouveauExam.Controls.Add(this.buttonValiderCreationExams);
            this.panelAjouterNouveauExam.Location = new System.Drawing.Point(12, 91);
            this.panelAjouterNouveauExam.Name = "panelAjouterNouveauExam";
            this.panelAjouterNouveauExam.Size = new System.Drawing.Size(320, 361);
            this.panelAjouterNouveauExam.TabIndex = 20;
            // 
            // panelAjouterQuestions
            // 
            this.panelAjouterQuestions.Controls.Add(this.buttonAjouterQCM);
            this.panelAjouterQuestions.Controls.Add(this.buttonAjouterQuestionSimple);
            this.panelAjouterQuestions.Location = new System.Drawing.Point(336, 409);
            this.panelAjouterQuestions.Name = "panelAjouterQuestions";
            this.panelAjouterQuestions.Size = new System.Drawing.Size(591, 43);
            this.panelAjouterQuestions.TabIndex = 21;
            // 
            // panelListExamsQuestion
            // 
            this.panelListExamsQuestion.Controls.Add(this.labelListesExams);
            this.panelListExamsQuestion.Controls.Add(this.comboBoxListeExams);
            this.panelListExamsQuestion.Controls.Add(this.labelListeQuestions);
            this.panelListExamsQuestion.Controls.Add(this.comboBoxQuestions);
            this.panelListExamsQuestion.Location = new System.Drawing.Point(704, 12);
            this.panelListExamsQuestion.Name = "panelListExamsQuestion";
            this.panelListExamsQuestion.Size = new System.Drawing.Size(223, 157);
            this.panelListExamsQuestion.TabIndex = 22;
            // 
            // numericUpDownDureeExam
            // 
            this.numericUpDownDureeExam.Location = new System.Drawing.Point(13, 214);
            this.numericUpDownDureeExam.Name = "numericUpDownDureeExam";
            this.numericUpDownDureeExam.Size = new System.Drawing.Size(180, 31);
            this.numericUpDownDureeExam.TabIndex = 11;
            // 
            // InterfaceAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 454);
            this.Controls.Add(this.panelListExamsQuestion);
            this.Controls.Add(this.panelAjouterQuestions);
            this.Controls.Add(this.panelAjouterNouveauExam);
            this.Controls.Add(this.buttonAjouterExam);
            this.Name = "InterfaceAdmin";
            this.Text = "InterfaceAdmin";
            this.Load += new System.EventHandler(this.InterfaceAdmin_Load);
            this.panelAjouterNouveauExam.ResumeLayout(false);
            this.panelAjouterNouveauExam.PerformLayout();
            this.panelAjouterQuestions.ResumeLayout(false);
            this.panelListExamsQuestion.ResumeLayout(false);
            this.panelListExamsQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDureeExam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonAjouterExam;
        private Button buttonAjouterQCM;
        private TextBox textBoxNomExam;
        private Label labelExamNom;
        private DateTimePicker dateTimePicker1;
        private Label labelDateExam;
        private Label labelDureeExam;
        private Button buttonValiderCreationExams;
        private ComboBox comboBoxListeExams;
        private Label labelListesExams;
        private Label labelListeQuestions;
        private ComboBox comboBoxQuestions;
        private Button buttonAjouterQuestionSimple;
        private Panel panelAjouterNouveauExam;
        private Panel panelAjouterQuestions;
        private Panel panelListExamsQuestion;
        private NumericUpDown numericUpDownDureeExam;
    }
}