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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTC = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
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
            this.BtnGiris.Location = new System.Drawing.Point(194, 282);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(378, 49);
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
            this.BtnKayitOl.Location = new System.Drawing.Point(194, 337);
            this.BtnKayitOl.Name = "BtnKayitOl";
            this.BtnKayitOl.Size = new System.Drawing.Size(182, 49);
            this.BtnKayitOl.TabIndex = 7;
            this.BtnKayitOl.Text = "Kayıt Ol";
            this.BtnKayitOl.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(190, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "T.C. Kimlik No";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtTC
            // 
            this.TxtTC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTC.Location = new System.Drawing.Point(194, 172);
            this.TxtTC.Name = "TxtTC";
            this.TxtTC.Size = new System.Drawing.Size(378, 32);
            this.TxtTC.TabIndex = 10;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSifre.Location = new System.Drawing.Point(194, 244);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(378, 32);
            this.TxtSifre.TabIndex = 11;
            // 
            // BtnSifremiUnuttum
            // 
            this.BtnSifremiUnuttum.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSifremiUnuttum.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSifremiUnuttum.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnSifremiUnuttum.Location = new System.Drawing.Point(390, 337);
            this.BtnSifremiUnuttum.Name = "BtnSifremiUnuttum";
            this.BtnSifremiUnuttum.Size = new System.Drawing.Size(182, 49);
            this.BtnSifremiUnuttum.TabIndex = 12;
            this.BtnSifremiUnuttum.Text = "Şifremi Unuttum";
            this.BtnSifremiUnuttum.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(336, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 108);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // HastaGirisiSayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(775, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSifremiUnuttum);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnKayitOl);
            this.Controls.Add(this.BtnGiris);
            this.Name = "HastaGirisiSayfası";
            this.Text = "Hasta Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Button BtnKayitOl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTC;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Button BtnSifremiUnuttum;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}