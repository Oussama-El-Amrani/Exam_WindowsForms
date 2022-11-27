namespace Exam_WindowsForms.View.Professeur
{
    partial class FormAuthProfesseurs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCreerCompteProf = new System.Windows.Forms.Label();
            this.ChoisirCompteProf = new System.Windows.Forms.Label();
            this.comboBoxListProfesseur = new System.Windows.Forms.ComboBox();
            this.textBoxNomComplet = new System.Windows.Forms.TextBox();
            this.textBoxCNE = new System.Windows.Forms.TextBox();
            this.labelNomCompletProf = new System.Windows.Forms.Label();
            this.panelInscriptionProd = new System.Windows.Forms.Panel();
            this.labelCNEProf = new System.Windows.Forms.Label();
            this.buttonCreerCompte = new System.Windows.Forms.Button();
            this.buttonValidationCrreationCompte = new System.Windows.Forms.Button();
            this.labelEmailProf = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCrrerExam = new System.Windows.Forms.Button();
            this.panelInscriptionProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCreerCompteProf
            // 
            this.labelCreerCompteProf.AutoSize = true;
            this.labelCreerCompteProf.Location = new System.Drawing.Point(32, 30);
            this.labelCreerCompteProf.Name = "labelCreerCompteProf";
            this.labelCreerCompteProf.Size = new System.Drawing.Size(0, 25);
            this.labelCreerCompteProf.TabIndex = 0;
            // 
            // ChoisirCompteProf
            // 
            this.ChoisirCompteProf.AutoSize = true;
            this.ChoisirCompteProf.Location = new System.Drawing.Point(511, 30);
            this.ChoisirCompteProf.Name = "ChoisirCompteProf";
            this.ChoisirCompteProf.Size = new System.Drawing.Size(217, 25);
            this.ChoisirCompteProf.TabIndex = 1;
            this.ChoisirCompteProf.Text = "Veuillez choisir un compte";
            // 
            // comboBoxListProfesseur
            // 
            this.comboBoxListProfesseur.FormattingEnabled = true;
            this.comboBoxListProfesseur.Location = new System.Drawing.Point(511, 75);
            this.comboBoxListProfesseur.Name = "comboBoxListProfesseur";
            this.comboBoxListProfesseur.Size = new System.Drawing.Size(217, 33);
            this.comboBoxListProfesseur.TabIndex = 2;
            // 
            // textBoxNomComplet
            // 
            this.textBoxNomComplet.Location = new System.Drawing.Point(0, 42);
            this.textBoxNomComplet.Name = "textBoxNomComplet";
            this.textBoxNomComplet.Size = new System.Drawing.Size(351, 31);
            this.textBoxNomComplet.TabIndex = 4;
            // 
            // textBoxCNE
            // 
            this.textBoxCNE.Location = new System.Drawing.Point(3, 118);
            this.textBoxCNE.Name = "textBoxCNE";
            this.textBoxCNE.Size = new System.Drawing.Size(348, 31);
            this.textBoxCNE.TabIndex = 5;
            // 
            // labelNomCompletProf
            // 
            this.labelNomCompletProf.AutoSize = true;
            this.labelNomCompletProf.Location = new System.Drawing.Point(3, 0);
            this.labelNomCompletProf.MaximumSize = new System.Drawing.Size(200, 1000);
            this.labelNomCompletProf.Name = "labelNomCompletProf";
            this.labelNomCompletProf.Size = new System.Drawing.Size(122, 25);
            this.labelNomCompletProf.TabIndex = 6;
            this.labelNomCompletProf.Text = "Nom complet";
            // 
            // panelInscriptionProd
            // 
            this.panelInscriptionProd.Controls.Add(this.textBox1);
            this.panelInscriptionProd.Controls.Add(this.labelCNEProf);
            this.panelInscriptionProd.Controls.Add(this.labelEmailProf);
            this.panelInscriptionProd.Controls.Add(this.buttonValidationCrreationCompte);
            this.panelInscriptionProd.Controls.Add(this.textBoxCNE);
            this.panelInscriptionProd.Controls.Add(this.textBoxNomComplet);
            this.panelInscriptionProd.Controls.Add(this.labelNomCompletProf);
            this.panelInscriptionProd.Location = new System.Drawing.Point(47, 80);
            this.panelInscriptionProd.Name = "panelInscriptionProd";
            this.panelInscriptionProd.Size = new System.Drawing.Size(351, 309);
            this.panelInscriptionProd.TabIndex = 4;
            // 
            // labelCNEProf
            // 
            this.labelCNEProf.AutoSize = true;
            this.labelCNEProf.Location = new System.Drawing.Point(0, 90);
            this.labelCNEProf.Name = "labelCNEProf";
            this.labelCNEProf.Size = new System.Drawing.Size(39, 25);
            this.labelCNEProf.TabIndex = 5;
            this.labelCNEProf.Text = "cne";
            // 
            // buttonCreerCompte
            // 
            this.buttonCreerCompte.Location = new System.Drawing.Point(47, 40);
            this.buttonCreerCompte.Name = "buttonCreerCompte";
            this.buttonCreerCompte.Size = new System.Drawing.Size(112, 34);
            this.buttonCreerCompte.TabIndex = 7;
            this.buttonCreerCompte.Text = "Crrer Compte";
            this.buttonCreerCompte.UseVisualStyleBackColor = true;
            // 
            // buttonValidationCrreationCompte
            // 
            this.buttonValidationCrreationCompte.Location = new System.Drawing.Point(0, 275);
            this.buttonValidationCrreationCompte.Name = "buttonValidationCrreationCompte";
            this.buttonValidationCrreationCompte.Size = new System.Drawing.Size(112, 34);
            this.buttonValidationCrreationCompte.TabIndex = 7;
            this.buttonValidationCrreationCompte.Text = "Valider";
            this.buttonValidationCrreationCompte.UseVisualStyleBackColor = true;
            // 
            // labelEmailProf
            // 
            this.labelEmailProf.AutoSize = true;
            this.labelEmailProf.Location = new System.Drawing.Point(3, 180);
            this.labelEmailProf.Name = "labelEmailProf";
            this.labelEmailProf.Size = new System.Drawing.Size(54, 25);
            this.labelEmailProf.TabIndex = 8;
            this.labelEmailProf.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 31);
            this.textBox1.TabIndex = 8;
            // 
            // buttonCrrerExam
            // 
            this.buttonCrrerExam.Location = new System.Drawing.Point(511, 355);
            this.buttonCrrerExam.Name = "buttonCrrerExam";
            this.buttonCrrerExam.Size = new System.Drawing.Size(112, 34);
            this.buttonCrrerExam.TabIndex = 8;
            this.buttonCrrerExam.Text = "Creer Exam";
            this.buttonCrrerExam.UseVisualStyleBackColor = true;
            this.buttonCrrerExam.Click += new System.EventHandler(this.buttonCrrerExam_Click);
            // 
            // FormAuthProfesseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCrrerExam);
            this.Controls.Add(this.buttonCreerCompte);
            this.Controls.Add(this.panelInscriptionProd);
            this.Controls.Add(this.comboBoxListProfesseur);
            this.Controls.Add(this.ChoisirCompteProf);
            this.Controls.Add(this.labelCreerCompteProf);
            this.Name = "FormAuthProfesseurs";
            this.Text = "Authentification Professeur";
            this.panelInscriptionProd.ResumeLayout(false);
            this.panelInscriptionProd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelCreerCompteProf;
        private Label ChoisirCompteProf;
        private ComboBox comboBoxListProfesseur;
        private TextBox textBoxNomComplet;
        private TextBox textBoxCNE;
        private Label labelNomCompletProf;
        private Panel panelInscriptionProd;
        private TextBox textBox1;
        private Label labelCNEProf;
        private Label labelEmailProf;
        private Button buttonValidationCrreationCompte;
        private Button buttonCreerCompte;
        private Button buttonCrrerExam;
    }
}