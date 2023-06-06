
namespace ArtırmaEksiltme
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
            this.btnArttır = new System.Windows.Forms.Button();
            this.btnEksilt = new System.Windows.Forms.Button();
            this.btnSonuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArttır
            // 
            this.btnArttır.Location = new System.Drawing.Point(114, 137);
            this.btnArttır.Name = "btnArttır";
            this.btnArttır.Size = new System.Drawing.Size(165, 27);
            this.btnArttır.TabIndex = 0;
            this.btnArttır.Text = "Arttır";
            this.btnArttır.UseVisualStyleBackColor = true;
            this.btnArttır.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnEksilt
            // 
            this.btnEksilt.Location = new System.Drawing.Point(114, 205);
            this.btnEksilt.Name = "btnEksilt";
            this.btnEksilt.Size = new System.Drawing.Size(165, 32);
            this.btnEksilt.TabIndex = 1;
            this.btnEksilt.Text = "Eksilt";
            this.btnEksilt.UseVisualStyleBackColor = true;
            this.btnEksilt.Click += new System.EventHandler(this.btnEksilt_Click);
            // 
            // btnSonuc
            // 
            this.btnSonuc.Location = new System.Drawing.Point(114, 288);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(165, 33);
            this.btnSonuc.TabIndex = 2;
            this.btnSonuc.Text = "Sonuc";
            this.btnSonuc.UseVisualStyleBackColor = true;
            this.btnSonuc.Click += new System.EventHandler(this.btnSonuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSonuc);
            this.Controls.Add(this.btnEksilt);
            this.Controls.Add(this.btnArttır);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArttır;
        private System.Windows.Forms.Button btnEksilt;
        private System.Windows.Forms.Button btnSonuc;
    }
}

