namespace Exam_WindowsForms.View
{
    partial class FormAuth
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
            this.labelAuth = new System.Windows.Forms.Label();
            this.buttonAuthProfesseur = new System.Windows.Forms.Button();
            this.buttonAuthEtudiant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAuth.Location = new System.Drawing.Point(22, 29);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(192, 54);
            this.labelAuth.TabIndex = 0;
            this.labelAuth.Text = "Vous êtes";
            // 
            // buttonAuthProfesseur
            // 
            this.buttonAuthProfesseur.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAuthProfesseur.Location = new System.Drawing.Point(260, 92);
            this.buttonAuthProfesseur.MaximumSize = new System.Drawing.Size(200, 200);
            this.buttonAuthProfesseur.Name = "buttonAuthProfesseur";
            this.buttonAuthProfesseur.Size = new System.Drawing.Size(200, 66);
            this.buttonAuthProfesseur.TabIndex = 1;
            this.buttonAuthProfesseur.Text = "Professeur";
            this.buttonAuthProfesseur.UseVisualStyleBackColor = true;
            this.buttonAuthProfesseur.Click += new System.EventHandler(this.buttonAuthProfesseur_Click);
            // 
            // buttonAuthEtudiant
            // 
            this.buttonAuthEtudiant.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAuthEtudiant.Location = new System.Drawing.Point(260, 205);
            this.buttonAuthEtudiant.Name = "buttonAuthEtudiant";
            this.buttonAuthEtudiant.Size = new System.Drawing.Size(200, 81);
            this.buttonAuthEtudiant.TabIndex = 2;
            this.buttonAuthEtudiant.Text = "Etudiant";
            this.buttonAuthEtudiant.UseVisualStyleBackColor = true;
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAuthEtudiant);
            this.Controls.Add(this.buttonAuthProfesseur);
            this.Controls.Add(this.labelAuth);
            this.Name = "FormAuth";
            this.Text = "Authentification";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAuth;
        private Button buttonAuthProfesseur;
        private Button buttonAuthEtudiant;
    }
}