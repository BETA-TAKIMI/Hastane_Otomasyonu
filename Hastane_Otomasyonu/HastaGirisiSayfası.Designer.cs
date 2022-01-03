namespace Hastane_Otomasyonu
{
    partial class HastaGirisiSayfası
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaGirisiSayfası));
            this.BtnGiris = new System.Windows.Forms.Button();
            this.BtnKayitOl = new System.Windows.Forms.Button();
            this.TcLabel = new System.Windows.Forms.Label();
            this.SifreLabel = new System.Windows.Forms.Label();
            this.TxtTC = new System.Windows.Forms.TextBox();
            this.TxtSfre = new System.Windows.Forms.TextBox();
            this.BtnSifremiUnuttum = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnGiris.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGiris.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnGiris.Location = new System.Drawing.Point(139, 247);
            this.BtnGiris.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(284, 40);
            this.BtnGiris.TabIndex = 6;
            this.BtnGiris.Text = "Giriş Yap";
            this.BtnGiris.UseVisualStyleBackColor = false;
            this.BtnGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnKayitOl
            // 
            this.BtnKayitOl.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnKayitOl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKayitOl.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnKayitOl.Location = new System.Drawing.Point(139, 292);
            this.BtnKayitOl.Margin = new System.Windows.Forms.Padding(2);
            this.BtnKayitOl.Name = "BtnKayitOl";
            this.BtnKayitOl.Size = new System.Drawing.Size(136, 40);
            this.BtnKayitOl.TabIndex = 7;
            this.BtnKayitOl.Text = "Kayıt Ol";
            this.BtnKayitOl.UseVisualStyleBackColor = false;
            this.BtnKayitOl.Click += new System.EventHandler(this.BtnKayitOl_Click);
            // 
            // TcLabel
            // 
            this.TcLabel.AutoSize = true;
            this.TcLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcLabel.ForeColor = System.Drawing.Color.Black;
            this.TcLabel.Location = new System.Drawing.Point(134, 131);
            this.TcLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TcLabel.Name = "TcLabel";
            this.TcLabel.Size = new System.Drawing.Size(112, 19);
            this.TcLabel.TabIndex = 8;
            this.TcLabel.Text = "T.C. Kimlik No";
            this.TcLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SifreLabel
            // 
            this.SifreLabel.AutoSize = true;
            this.SifreLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SifreLabel.Location = new System.Drawing.Point(134, 189);
            this.SifreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SifreLabel.Name = "SifreLabel";
            this.SifreLabel.Size = new System.Drawing.Size(41, 19);
            this.SifreLabel.TabIndex = 9;
            this.SifreLabel.Text = "Şifre";
            this.SifreLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtTC
            // 
            this.TxtTC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTC.Location = new System.Drawing.Point(139, 153);
            this.TxtTC.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTC.Name = "TxtTC";
            this.TxtTC.Size = new System.Drawing.Size(284, 27);
            this.TxtTC.TabIndex = 10;
            // 
            // TxtSfre
            // 
            this.TxtSfre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSfre.Location = new System.Drawing.Point(139, 211);
            this.TxtSfre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSfre.Name = "TxtSfre";
            this.TxtSfre.Size = new System.Drawing.Size(284, 27);
            this.TxtSfre.TabIndex = 11;
            // 
            // BtnSifremiUnuttum
            // 
            this.BtnSifremiUnuttum.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSifremiUnuttum.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSifremiUnuttum.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnSifremiUnuttum.Location = new System.Drawing.Point(287, 292);
            this.BtnSifremiUnuttum.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSifremiUnuttum.Name = "BtnSifremiUnuttum";
            this.BtnSifremiUnuttum.Size = new System.Drawing.Size(136, 40);
            this.BtnSifremiUnuttum.TabIndex = 12;
            this.BtnSifremiUnuttum.Text = "Şifremi Unuttum";
            this.BtnSifremiUnuttum.UseVisualStyleBackColor = false;
            this.BtnSifremiUnuttum.Click += new System.EventHandler(this.BtnSifremiUnuttum_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(232, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // HastaGirisiSayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(581, 375);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSifremiUnuttum);
            this.Controls.Add(this.TxtSfre);
            this.Controls.Add(this.TxtTC);
            this.Controls.Add(this.SifreLabel);
            this.Controls.Add(this.TcLabel);
            this.Controls.Add(this.BtnKayitOl);
            this.Controls.Add(this.BtnGiris);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HastaGirisiSayfası";
            this.Text = "Hasta Girişi";
            this.Load += new System.EventHandler(this.HastaGirisiSayfası_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Button BtnKayitOl;
        private System.Windows.Forms.Label TcLabel;
        private System.Windows.Forms.Label SifreLabel;
        private System.Windows.Forms.TextBox TxtTC;
        private System.Windows.Forms.TextBox TxtSfre;
        private System.Windows.Forms.Button BtnSifremiUnuttum;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}