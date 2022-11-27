namespace QCM_WindowForms
{
    partial class FormQCM
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
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.textBoxProposition = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAjouterProposition = new System.Windows.Forms.Button();
            this.Enonce = new System.Windows.Forms.Label();
            this.VaalideProposition = new System.Windows.Forms.Button();
            this.panelProposition = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelListeProposition = new System.Windows.Forms.Label();
            this.buttonValideQCM = new System.Windows.Forms.Button();
            this.panelProposition.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(418, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 29);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Faux";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton
            // 
            this.radioButton.AutoSize = true;
            this.radioButton.Location = new System.Drawing.Point(312, 16);
            this.radioButton.Name = "radioButton";
            this.radioButton.Size = new System.Drawing.Size(65, 29);
            this.radioButton.TabIndex = 18;
            this.radioButton.TabStop = true;
            this.radioButton.Text = "vrai";
            this.radioButton.UseVisualStyleBackColor = true;
            // 
            // textBoxProposition
            // 
            this.textBoxProposition.Location = new System.Drawing.Point(3, 16);
            this.textBoxProposition.Name = "textBoxProposition";
            this.textBoxProposition.Size = new System.Drawing.Size(285, 31);
            this.textBoxProposition.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 31);
            this.textBox1.TabIndex = 16;
            // 
            // buttonAjouterProposition
            // 
            this.buttonAjouterProposition.Location = new System.Drawing.Point(81, 138);
            this.buttonAjouterProposition.Name = "buttonAjouterProposition";
            this.buttonAjouterProposition.Size = new System.Drawing.Size(285, 34);
            this.buttonAjouterProposition.TabIndex = 15;
            this.buttonAjouterProposition.Text = "Ajouter Proposition";
            this.buttonAjouterProposition.UseVisualStyleBackColor = true;
            // 
            // Enonce
            // 
            this.Enonce.AutoSize = true;
            this.Enonce.Location = new System.Drawing.Point(81, 44);
            this.Enonce.Name = "Enonce";
            this.Enonce.Size = new System.Drawing.Size(69, 25);
            this.Enonce.TabIndex = 20;
            this.Enonce.Text = "Enoncé";
            // 
            // VaalideProposition
            // 
            this.VaalideProposition.BackColor = System.Drawing.Color.Green;
            this.VaalideProposition.ForeColor = System.Drawing.Color.White;
            this.VaalideProposition.Location = new System.Drawing.Point(3, 68);
            this.VaalideProposition.Name = "VaalideProposition";
            this.VaalideProposition.Size = new System.Drawing.Size(200, 34);
            this.VaalideProposition.TabIndex = 21;
            this.VaalideProposition.Text = "Validé Proposition";
            this.VaalideProposition.UseVisualStyleBackColor = false;
            // 
            // panelProposition
            // 
            this.panelProposition.Controls.Add(this.VaalideProposition);
            this.panelProposition.Controls.Add(this.textBoxProposition);
            this.panelProposition.Controls.Add(this.radioButton);
            this.panelProposition.Controls.Add(this.radioButton2);
            this.panelProposition.Location = new System.Drawing.Point(81, 187);
            this.panelProposition.Name = "panelProposition";
            this.panelProposition.Size = new System.Drawing.Size(601, 117);
            this.panelProposition.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(606, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 33);
            this.comboBox1.TabIndex = 23;
            // 
            // labelListeProposition
            // 
            this.labelListeProposition.AutoSize = true;
            this.labelListeProposition.Location = new System.Drawing.Point(608, 12);
            this.labelListeProposition.Name = "labelListeProposition";
            this.labelListeProposition.Size = new System.Drawing.Size(186, 25);
            this.labelListeProposition.TabIndex = 24;
            this.labelListeProposition.Text = "Liste des propositions";
            // 
            // buttonValideQCM
            // 
            this.buttonValideQCM.Location = new System.Drawing.Point(84, 364);
            this.buttonValideQCM.Name = "buttonValideQCM";
            this.buttonValideQCM.Size = new System.Drawing.Size(220, 34);
            this.buttonValideQCM.TabIndex = 25;
            this.buttonValideQCM.Text = "Validé question";
            this.buttonValideQCM.UseVisualStyleBackColor = true;
            // 
            // FormQCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonValideQCM);
            this.Controls.Add(this.buttonAjouterProposition);
            this.Controls.Add(this.labelListeProposition);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panelProposition);
            this.Controls.Add(this.Enonce);
            this.Controls.Add(this.textBox1);
            this.Name = "FormQCM";
            this.Text = "Question Choix multiple";
            this.Load += new System.EventHandler(this.FormQuestionChoixMultiple_Load);
            this.panelProposition.ResumeLayout(false);
            this.panelProposition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radioButton2;
        private RadioButton radioButton;
        private TextBox textBoxProposition;
        private TextBox textBox1;
        private Button buttonAjouterProposition;
        private Label Enonce;
        private Button VaalideProposition;
        private Panel panelProposition;
        private ComboBox comboBox1;
        private Label labelListeProposition;
        private Button buttonValideQCM;
    }
}