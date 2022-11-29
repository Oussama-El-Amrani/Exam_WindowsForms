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
            this.radioButtonFaux = new System.Windows.Forms.RadioButton();
            this.radioButtonVrai = new System.Windows.Forms.RadioButton();
            this.textBoxProposition = new System.Windows.Forms.TextBox();
            this.textBoxEnonce = new System.Windows.Forms.TextBox();
            this.buttonAjouterProposition = new System.Windows.Forms.Button();
            this.Enonce = new System.Windows.Forms.Label();
            this.VaalideProposition = new System.Windows.Forms.Button();
            this.panelProposition = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelListeProposition = new System.Windows.Forms.Label();
            this.buttonValideQCM = new System.Windows.Forms.Button();
            this.numericUpDownNombrePointsQCM = new System.Windows.Forms.NumericUpDown();
            this.labelNombrePointsQCM = new System.Windows.Forms.Label();
            this.buttonValiderQCM = new System.Windows.Forms.Button();
            this.panelProposition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNombrePointsQCM)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonFaux
            // 
            this.radioButtonFaux.AutoSize = true;
            this.radioButtonFaux.Location = new System.Drawing.Point(418, 16);
            this.radioButtonFaux.Name = "radioButtonFaux";
            this.radioButtonFaux.Size = new System.Drawing.Size(72, 29);
            this.radioButtonFaux.TabIndex = 19;
            this.radioButtonFaux.TabStop = true;
            this.radioButtonFaux.Text = "Faux";
            this.radioButtonFaux.UseVisualStyleBackColor = true;
            // 
            // radioButtonVrai
            // 
            this.radioButtonVrai.AutoSize = true;
            this.radioButtonVrai.Location = new System.Drawing.Point(312, 16);
            this.radioButtonVrai.Name = "radioButtonVrai";
            this.radioButtonVrai.Size = new System.Drawing.Size(65, 29);
            this.radioButtonVrai.TabIndex = 18;
            this.radioButtonVrai.TabStop = true;
            this.radioButtonVrai.Text = "vrai";
            this.radioButtonVrai.UseVisualStyleBackColor = true;
            // 
            // textBoxProposition
            // 
            this.textBoxProposition.Location = new System.Drawing.Point(3, 16);
            this.textBoxProposition.Name = "textBoxProposition";
            this.textBoxProposition.Size = new System.Drawing.Size(285, 31);
            this.textBoxProposition.TabIndex = 17;
            // 
            // textBoxEnonce
            // 
            this.textBoxEnonce.Location = new System.Drawing.Point(81, 55);
            this.textBoxEnonce.Name = "textBoxEnonce";
            this.textBoxEnonce.Size = new System.Drawing.Size(285, 31);
            this.textBoxEnonce.TabIndex = 16;
            // 
            // buttonAjouterProposition
            // 
            this.buttonAjouterProposition.Location = new System.Drawing.Point(81, 192);
            this.buttonAjouterProposition.Name = "buttonAjouterProposition";
            this.buttonAjouterProposition.Size = new System.Drawing.Size(285, 34);
            this.buttonAjouterProposition.TabIndex = 15;
            this.buttonAjouterProposition.Text = "Ajouter Proposition";
            this.buttonAjouterProposition.UseVisualStyleBackColor = true;
            this.buttonAjouterProposition.Click += new System.EventHandler(this.buttonAjouterProposition_Click);
            // 
            // Enonce
            // 
            this.Enonce.AutoSize = true;
            this.Enonce.Location = new System.Drawing.Point(81, 12);
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
            this.VaalideProposition.Click += new System.EventHandler(this.VaalideProposition_Click);
            // 
            // panelProposition
            // 
            this.panelProposition.Controls.Add(this.VaalideProposition);
            this.panelProposition.Controls.Add(this.textBoxProposition);
            this.panelProposition.Controls.Add(this.radioButtonVrai);
            this.panelProposition.Controls.Add(this.radioButtonFaux);
            this.panelProposition.Location = new System.Drawing.Point(81, 241);
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
            // numericUpDownNombrePointsQCM
            // 
            this.numericUpDownNombrePointsQCM.Location = new System.Drawing.Point(81, 140);
            this.numericUpDownNombrePointsQCM.Name = "numericUpDownNombrePointsQCM";
            this.numericUpDownNombrePointsQCM.Size = new System.Drawing.Size(180, 31);
            this.numericUpDownNombrePointsQCM.TabIndex = 26;
            // 
            // labelNombrePointsQCM
            // 
            this.labelNombrePointsQCM.AutoSize = true;
            this.labelNombrePointsQCM.Location = new System.Drawing.Point(81, 103);
            this.labelNombrePointsQCM.Name = "labelNombrePointsQCM";
            this.labelNombrePointsQCM.Size = new System.Drawing.Size(127, 25);
            this.labelNombrePointsQCM.TabIndex = 27;
            this.labelNombrePointsQCM.Text = "Nombre Ponts";
            // 
            // buttonValiderQCM
            // 
            this.buttonValiderQCM.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonValiderQCM.ForeColor = System.Drawing.Color.White;
            this.buttonValiderQCM.Location = new System.Drawing.Point(315, 131);
            this.buttonValiderQCM.Name = "buttonValiderQCM";
            this.buttonValiderQCM.Size = new System.Drawing.Size(192, 40);
            this.buttonValiderQCM.TabIndex = 28;
            this.buttonValiderQCM.Text = "Validé question";
            this.buttonValiderQCM.UseVisualStyleBackColor = false;
            this.buttonValiderQCM.Click += new System.EventHandler(this.buttonValiderQCM_Click);
            // 
            // FormQCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonValiderQCM);
            this.Controls.Add(this.labelNombrePointsQCM);
            this.Controls.Add(this.numericUpDownNombrePointsQCM);
            this.Controls.Add(this.buttonValideQCM);
            this.Controls.Add(this.buttonAjouterProposition);
            this.Controls.Add(this.labelListeProposition);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panelProposition);
            this.Controls.Add(this.Enonce);
            this.Controls.Add(this.textBoxEnonce);
            this.Name = "FormQCM";
            this.Text = "Question Choix multiple";
            this.Load += new System.EventHandler(this.FormQuestionChoixMultiple_Load);
            this.panelProposition.ResumeLayout(false);
            this.panelProposition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNombrePointsQCM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radioButtonFaux;
        private RadioButton radioButtonVrai;
        private TextBox textBoxProposition;
        private TextBox textBoxEnonce;
        private Button buttonAjouterProposition;
        private Label Enonce;
        private Button VaalideProposition;
        private Panel panelProposition;
        private ComboBox comboBox1;
        private Label labelListeProposition;
        private Button buttonValideQCM;
        private NumericUpDown numericUpDownNombrePointsQCM;
        private Label labelNombrePointsQCM;
        private Button buttonValiderQCM;
    }
}