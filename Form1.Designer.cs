namespace TestGit
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnAvvia2 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.btnStop100 = new System.Windows.Forms.Button();
            this.btnAvvia100 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(68, 50);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt1.Size = new System.Drawing.Size(100, 270);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(246, 50);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt2.Size = new System.Drawing.Size(100, 270);
            this.txt2.TabIndex = 1;
            // 
            // btnAvvia2
            // 
            this.btnAvvia2.Location = new System.Drawing.Point(6, 55);
            this.btnAvvia2.Name = "btnAvvia2";
            this.btnAvvia2.Size = new System.Drawing.Size(56, 39);
            this.btnAvvia2.TabIndex = 2;
            this.btnAvvia2.Text = "avvia 2";
            this.btnAvvia2.UseVisualStyleBackColor = true;
            this.btnAvvia2.Click += new System.EventHandler(this.btnAvvia2_Click);
            // 
            // btnStop2
            // 
            this.btnStop2.Location = new System.Drawing.Point(6, 100);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(56, 37);
            this.btnStop2.TabIndex = 3;
            this.btnStop2.Text = "stoppa 2";
            this.btnStop2.UseVisualStyleBackColor = true;
            this.btnStop2.Click += new System.EventHandler(this.btnStop2_Click);
            // 
            // btnStop100
            // 
            this.btnStop100.Location = new System.Drawing.Point(184, 100);
            this.btnStop100.Name = "btnStop100";
            this.btnStop100.Size = new System.Drawing.Size(56, 37);
            this.btnStop100.TabIndex = 4;
            this.btnStop100.Text = "stoppa 100";
            this.btnStop100.UseVisualStyleBackColor = true;
            this.btnStop100.Click += new System.EventHandler(this.btnStop100_Click);
            // 
            // btnAvvia100
            // 
            this.btnAvvia100.Location = new System.Drawing.Point(184, 55);
            this.btnAvvia100.Name = "btnAvvia100";
            this.btnAvvia100.Size = new System.Drawing.Size(56, 39);
            this.btnAvvia100.TabIndex = 5;
            this.btnAvvia100.Text = "avvia 100";
            this.btnAvvia100.UseVisualStyleBackColor = true;
            this.btnAvvia100.Click += new System.EventHandler(this.btnAvvia100_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAvvia100);
            this.Controls.Add(this.btnStop100);
            this.Controls.Add(this.btnStop2);
            this.Controls.Add(this.btnAvvia2);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "frmMain";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnAvvia2;
        private System.Windows.Forms.Button btnStop2;
        private System.Windows.Forms.Button btnStop100;
        private System.Windows.Forms.Button btnAvvia100;
    }
}

