namespace Hastane_Otomasyonu
{
    partial class SekreterGirisiSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SekreterGirisiSayfasi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSifremiUnuttum = new System.Windows.Forms.Button();
            this.TxtSfre = new System.Windows.Forms.TextBox();
            this.TxtTC = new System.Windows.Forms.TextBox();
            this.SifreLabel = new System.Windows.Forms.Label();
            this.TcLabel = new System.Windows.Forms.Label();
            this.BtnKayitOl = new System.Windows.Forms.Button();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.BtnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(229, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSifremiUnuttum
            // 
            this.BtnSifremiUnuttum.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSifremiUnuttum.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSifremiUnuttum.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnSifremiUnuttum.Location = new System.Drawing.Point(302, 343);
            this.BtnSifremiUnuttum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSifremiUnuttum.Name = "BtnSifremiUnuttum";
            this.BtnSifremiUnuttum.Size = new System.Drawing.Size(181, 49);
            this.BtnSifremiUnuttum.TabIndex = 20;
            this.BtnSifremiUnuttum.Text = "Şifremi Unuttum";
            this.BtnSifremiUnuttum.UseVisualStyleBackColor = false;
            this.BtnSifremiUnuttum.Click += new System.EventHandler(this.BtnSifremiUnuttum_Click);
            // 
            // TxtSfre
            // 
            this.TxtSfre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSfre.Location = new System.Drawing.Point(105, 243);
            this.TxtSfre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSfre.Name = "TxtSfre";
            this.TxtSfre.Size = new System.Drawing.Size(377, 32);
            this.TxtSfre.TabIndex = 19;
            // 
            // TxtTC
            // 
            this.TxtTC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTC.Location = new System.Drawing.Point(105, 172);
            this.TxtTC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTC.Name = "TxtTC";
            this.TxtTC.Size = new System.Drawing.Size(377, 32);
            this.TxtTC.TabIndex = 18;
            // 
            // SifreLabel
            // 
            this.SifreLabel.AutoSize = true;
            this.SifreLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SifreLabel.Location = new System.Drawing.Point(98, 216);
            this.SifreLabel.Name = "SifreLabel";
            this.SifreLabel.Size = new System.Drawing.Size(50, 24);
            this.SifreLabel.TabIndex = 17;
            this.SifreLabel.Text = "Şifre";
            // 
            // TcLabel
            // 
            this.TcLabel.AutoSize = true;
            this.TcLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcLabel.ForeColor = System.Drawing.Color.Black;
            this.TcLabel.Location = new System.Drawing.Point(98, 144);
            this.TcLabel.Name = "TcLabel";
            this.TcLabel.Size = new System.Drawing.Size(136, 24);
            this.TcLabel.TabIndex = 16;
            this.TcLabel.Text = "T.C. Kimlik No";
            // 
            // BtnKayitOl
            // 
            this.BtnKayitOl.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnKayitOl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKayitOl.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnKayitOl.Location = new System.Drawing.Point(105, 343);
            this.BtnKayitOl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnKayitOl.Name = "BtnKayitOl";
            this.BtnKayitOl.Size = new System.Drawing.Size(181, 49);
            this.BtnKayitOl.TabIndex = 15;
            this.BtnKayitOl.Text = "Kayıt Ol";
            this.BtnKayitOl.UseVisualStyleBackColor = false;
            this.BtnKayitOl.Click += new System.EventHandler(this.BtnKayitOl_Click);
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnGiris.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGiris.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnGiris.Location = new System.Drawing.Point(105, 287);
            this.BtnGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(379, 49);
            this.BtnGiris.TabIndex = 14;
            this.BtnGiris.Text = "Giriş Yap";
            this.BtnGiris.UseVisualStyleBackColor = false;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnGeri.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeri.ForeColor = System.Drawing.Color.White;
            this.BtnGeri.Location = new System.Drawing.Point(12, 12);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(39, 38);
            this.BtnGeri.TabIndex = 22;
            this.BtnGeri.Text = "<";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // SekreterGirisiSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(583, 433);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSifremiUnuttum);
            this.Controls.Add(this.TxtSfre);
            this.Controls.Add(this.TxtTC);
            this.Controls.Add(this.SifreLabel);
            this.Controls.Add(this.TcLabel);
            this.Controls.Add(this.BtnKayitOl);
            this.Controls.Add(this.BtnGiris);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SekreterGirisiSayfasi";
            this.Text = "Sekreter Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSifremiUnuttum;
        private System.Windows.Forms.TextBox TxtSfre;
        private System.Windows.Forms.TextBox TxtTC;
        private System.Windows.Forms.Label SifreLabel;
        private System.Windows.Forms.Label TcLabel;
        private System.Windows.Forms.Button BtnKayitOl;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Button BtnGeri;
    }
}