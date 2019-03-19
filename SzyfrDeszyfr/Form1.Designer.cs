namespace SzyfrDeszyfr
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_szyfr = new System.Windows.Forms.Button();
            this.btn_deszyfr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 29);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(317, 20);
            this.txtPath.TabIndex = 0;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(55, 55);
            this.txtKey.MaxLength = 11;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(274, 20);
            this.txtKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ścieżka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Klucz:";
            // 
            // btn_szyfr
            // 
            this.btn_szyfr.Location = new System.Drawing.Point(101, 81);
            this.btn_szyfr.Name = "btn_szyfr";
            this.btn_szyfr.Size = new System.Drawing.Size(75, 23);
            this.btn_szyfr.TabIndex = 4;
            this.btn_szyfr.Text = "Szyfruj";
            this.btn_szyfr.UseVisualStyleBackColor = true;
            this.btn_szyfr.Click += new System.EventHandler(this.btn_szyfr_Click);
            // 
            // btn_deszyfr
            // 
            this.btn_deszyfr.Location = new System.Drawing.Point(182, 81);
            this.btn_deszyfr.Name = "btn_deszyfr";
            this.btn_deszyfr.Size = new System.Drawing.Size(75, 23);
            this.btn_deszyfr.TabIndex = 5;
            this.btn_deszyfr.Text = "Deszyfruj";
            this.btn_deszyfr.UseVisualStyleBackColor = true;
            this.btn_deszyfr.Click += new System.EventHandler(this.btn_deszyfr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 118);
            this.Controls.Add(this.btn_deszyfr);
            this.Controls.Add(this.btn_szyfr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_szyfr;
        private System.Windows.Forms.Button btn_deszyfr;
    }
}

