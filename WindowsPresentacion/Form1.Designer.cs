namespace WindowsPresentacion
{
    partial class Form1
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
            this.btnAfinarViolin = new System.Windows.Forms.Button();
            this.btnAfinarGuitarra = new System.Windows.Forms.Button();
            this.btnAfinarPiano = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAfinarViolin
            // 
            this.btnAfinarViolin.Location = new System.Drawing.Point(286, 61);
            this.btnAfinarViolin.Name = "btnAfinarViolin";
            this.btnAfinarViolin.Size = new System.Drawing.Size(188, 68);
            this.btnAfinarViolin.TabIndex = 0;
            this.btnAfinarViolin.Text = "Afinar Violin";
            this.btnAfinarViolin.UseVisualStyleBackColor = true;
            this.btnAfinarViolin.Click += new System.EventHandler(this.btnAfinarViolin_Click);
            // 
            // btnAfinarGuitarra
            // 
            this.btnAfinarGuitarra.Location = new System.Drawing.Point(284, 158);
            this.btnAfinarGuitarra.Name = "btnAfinarGuitarra";
            this.btnAfinarGuitarra.Size = new System.Drawing.Size(189, 70);
            this.btnAfinarGuitarra.TabIndex = 1;
            this.btnAfinarGuitarra.Text = "Afinar Guitarra";
            this.btnAfinarGuitarra.UseVisualStyleBackColor = true;
            this.btnAfinarGuitarra.Click += new System.EventHandler(this.btnAfinarGuitarra_Click);
            // 
            // btnAfinarPiano
            // 
            this.btnAfinarPiano.Location = new System.Drawing.Point(281, 260);
            this.btnAfinarPiano.Name = "btnAfinarPiano";
            this.btnAfinarPiano.Size = new System.Drawing.Size(192, 62);
            this.btnAfinarPiano.TabIndex = 2;
            this.btnAfinarPiano.Text = "Afinar Piano";
            this.btnAfinarPiano.UseVisualStyleBackColor = true;
            this.btnAfinarPiano.Click += new System.EventHandler(this.btnAfinarPiano_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAfinarPiano);
            this.Controls.Add(this.btnAfinarGuitarra);
            this.Controls.Add(this.btnAfinarViolin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAfinarViolin;
        private System.Windows.Forms.Button btnAfinarGuitarra;
        private System.Windows.Forms.Button btnAfinarPiano;
    }
}

