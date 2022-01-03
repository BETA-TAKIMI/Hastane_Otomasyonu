using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    public partial class DoktorGirisiSayfası : Form
    {
        private PictureBox pictureBox1;
        private Button BtnSifremiUnuttum;
        private TextBox TxtSfre;
        private TextBox TxtTC;
        private Label SifreLabel;
        private Label TcLabel;
        private Button BtnKayitOl;
        private Button BtnGiris;

        public DoktorGirisiSayfası()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorGirisiSayfası));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSifremiUnuttum = new System.Windows.Forms.Button();
            this.TxtSfre = new System.Windows.Forms.TextBox();
            this.TxtTC = new System.Windows.Forms.TextBox();
            this.SifreLabel = new System.Windows.Forms.Label();
            this.TcLabel = new System.Windows.Forms.Label();
            this.BtnKayitOl = new System.Windows.Forms.Button();
            this.BtnGiris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(239, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSifremiUnuttum
            // 
            this.BtnSifremiUnuttum.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSifremiUnuttum.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSifremiUnuttum.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnSifremiUnuttum.Location = new System.Drawing.Point(294, 292);
            this.BtnSifremiUnuttum.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSifremiUnuttum.Name = "BtnSifremiUnuttum";
            this.BtnSifremiUnuttum.Size = new System.Drawing.Size(136, 40);
            this.BtnSifremiUnuttum.TabIndex = 20;
            this.BtnSifremiUnuttum.Text = "Şifremi Unuttum";
            this.BtnSifremiUnuttum.UseVisualStyleBackColor = false;
            // 
            // TxtSfre
            // 
            this.TxtSfre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSfre.Location = new System.Drawing.Point(146, 213);
            this.TxtSfre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSfre.Name = "TxtSfre";
            this.TxtSfre.Size = new System.Drawing.Size(284, 27);
            this.TxtSfre.TabIndex = 19;
            // 
            // TxtTC
            // 
            this.TxtTC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTC.Location = new System.Drawing.Point(146, 155);
            this.TxtTC.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTC.Name = "TxtTC";
            this.TxtTC.Size = new System.Drawing.Size(284, 27);
            this.TxtTC.TabIndex = 18;
            // 
            // SifreLabel
            // 
            this.SifreLabel.AutoSize = true;
            this.SifreLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SifreLabel.Location = new System.Drawing.Point(141, 191);
            this.SifreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SifreLabel.Name = "SifreLabel";
            this.SifreLabel.Size = new System.Drawing.Size(41, 19);
            this.SifreLabel.TabIndex = 17;
            this.SifreLabel.Text = "Şifre";
            // 
            // TcLabel
            // 
            this.TcLabel.AutoSize = true;
            this.TcLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcLabel.ForeColor = System.Drawing.Color.Black;
            this.TcLabel.Location = new System.Drawing.Point(141, 133);
            this.TcLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TcLabel.Name = "TcLabel";
            this.TcLabel.Size = new System.Drawing.Size(112, 19);
            this.TcLabel.TabIndex = 16;
            this.TcLabel.Text = "T.C. Kimlik No";
            // 
            // BtnKayitOl
            // 
            this.BtnKayitOl.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnKayitOl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKayitOl.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnKayitOl.Location = new System.Drawing.Point(146, 293);
            this.BtnKayitOl.Margin = new System.Windows.Forms.Padding(2);
            this.BtnKayitOl.Name = "BtnKayitOl";
            this.BtnKayitOl.Size = new System.Drawing.Size(136, 40);
            this.BtnKayitOl.TabIndex = 15;
            this.BtnKayitOl.Text = "Kayıt Ol";
            this.BtnKayitOl.UseVisualStyleBackColor = false;
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnGiris.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGiris.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnGiris.Location = new System.Drawing.Point(146, 248);
            this.BtnGiris.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(284, 40);
            this.BtnGiris.TabIndex = 14;
            this.BtnGiris.Text = "Giriş Yap";
            this.BtnGiris.UseVisualStyleBackColor = false;
            // 
            // DoktorGirisiSayfası
            // 
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(578, 376);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSifremiUnuttum);
            this.Controls.Add(this.TxtSfre);
            this.Controls.Add(this.TxtTC);
            this.Controls.Add(this.SifreLabel);
            this.Controls.Add(this.TcLabel);
            this.Controls.Add(this.BtnKayitOl);
            this.Controls.Add(this.BtnGiris);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DoktorGirisiSayfası";
            this.Text = "Doktor Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
