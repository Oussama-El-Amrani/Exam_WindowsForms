namespace QCM_WindowForms
{
    partial class FormQuestionSimple
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
            this.labelEnonceeQuestionSimple = new System.Windows.Forms.Label();
            this.textBoxQuestionSimple = new System.Windows.Forms.TextBox();
            this.buttonValiderQuestionSimple = new System.Windows.Forms.Button();
            this.numericUpDownNombrePointsQS = new System.Windows.Forms.NumericUpDown();
            this.labeLNombrePointsQS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNombrePointsQS)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEnonceeQuestionSimple
            // 
            this.labelEnonceeQuestionSimple.AutoSize = true;
            this.labelEnonceeQuestionSimple.Location = new System.Drawing.Point(53, 80);
            this.labelEnonceeQuestionSimple.Name = "labelEnonceeQuestionSimple";
            this.labelEnonceeQuestionSimple.Size = new System.Drawing.Size(69, 25);
            this.labelEnonceeQuestionSimple.TabIndex = 0;
            this.labelEnonceeQuestionSimple.Text = "Enoncé";
            // 
            // textBoxQuestionSimple
            // 
            this.textBoxQuestionSimple.Location = new System.Drawing.Point(53, 125);
            this.textBoxQuestionSimple.Multiline = true;
            this.textBoxQuestionSimple.Name = "textBoxQuestionSimple";
            this.textBoxQuestionSimple.Size = new System.Drawing.Size(672, 189);
            this.textBoxQuestionSimple.TabIndex = 1;
            // 
            // buttonValiderQuestionSimple
            // 
            this.buttonValiderQuestionSimple.Location = new System.Drawing.Point(53, 364);
            this.buttonValiderQuestionSimple.Name = "buttonValiderQuestionSimple";
            this.buttonValiderQuestionSimple.Size = new System.Drawing.Size(187, 34);
            this.buttonValiderQuestionSimple.TabIndex = 2;
            this.buttonValiderQuestionSimple.Text = "Validé la question";
            this.buttonValiderQuestionSimple.UseVisualStyleBackColor = true;
            this.buttonValiderQuestionSimple.Click += new System.EventHandler(this.buttonValiderQuestionSimple_Click);
            // 
            // numericUpDownNombrePointsQS
            // 
            this.numericUpDownNombrePointsQS.Location = new System.Drawing.Point(545, 74);
            this.numericUpDownNombrePointsQS.Name = "numericUpDownNombrePointsQS";
            this.numericUpDownNombrePointsQS.Size = new System.Drawing.Size(180, 31);
            this.numericUpDownNombrePointsQS.TabIndex = 3;
            this.numericUpDownNombrePointsQS.ValueChanged += new System.EventHandler(this.numericUpDownNombrePointsQS_ValueChanged);
            // 
            // labeLNombrePointsQS
            // 
            this.labeLNombrePointsQS.AutoSize = true;
            this.labeLNombrePointsQS.Location = new System.Drawing.Point(545, 30);
            this.labeLNombrePointsQS.Name = "labeLNombrePointsQS";
            this.labeLNombrePointsQS.Size = new System.Drawing.Size(147, 25);
            this.labeLNombrePointsQS.TabIndex = 4;
            this.labeLNombrePointsQS.Text = "nombre de point";
            // 
            // FormQuestionSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeLNombrePointsQS);
            this.Controls.Add(this.numericUpDownNombrePointsQS);
            this.Controls.Add(this.buttonValiderQuestionSimple);
            this.Controls.Add(this.textBoxQuestionSimple);
            this.Controls.Add(this.labelEnonceeQuestionSimple);
            this.Name = "FormQuestionSimple";
            this.Text = "FormQuestionSimple";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNombrePointsQS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelEnonceeQuestionSimple;
        private TextBox textBoxQuestionSimple;
        private Button buttonValiderQuestionSimple;
        private NumericUpDown numericUpDownNombrePointsQS;
        private Label labeLNombrePointsQS;
    }
}