﻿namespace Hastane_Otomasyonu
{
    partial class SekreterSifremiUnuttumSayfasi
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
            this.BtnVazgec = new System.Windows.Forms.Button();
            this.TxtSfre = new System.Windows.Forms.TextBox();
            this.TxtTC = new System.Windows.Forms.TextBox();
            this.YeniSifreLabel = new System.Windows.Forms.Label();
            this.TcLabel = new System.Windows.Forms.Label();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVazgec
            // 
            this.BtnVazgec.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnVazgec.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVazgec.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnVazgec.Location = new System.Drawing.Point(262, 278);
            this.BtnVazgec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVazgec.Name = "BtnVazgec";
            this.BtnVazgec.Size = new System.Drawing.Size(181, 49);
            this.BtnVazgec.TabIndex = 26;
            this.BtnVazgec.Text = "Vazgeç";
            this.BtnVazgec.UseVisualStyleBackColor = false;
            this.BtnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);
            // 
            // TxtSfre
            // 
            this.TxtSfre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSfre.Location = new System.Drawing.Point(168, 164);
            this.TxtSfre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSfre.Name = "TxtSfre";
            this.TxtSfre.Size = new System.Drawing.Size(377, 32);
            this.TxtSfre.TabIndex = 25;
            // 
            // TxtTC
            // 
            this.TxtTC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTC.Location = new System.Drawing.Point(168, 87);
            this.TxtTC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTC.Name = "TxtTC";
            this.TxtTC.Size = new System.Drawing.Size(377, 32);
            this.TxtTC.TabIndex = 24;
            // 
            // YeniSifreLabel
            // 
            this.YeniSifreLabel.AutoSize = true;
            this.YeniSifreLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YeniSifreLabel.Location = new System.Drawing.Point(161, 137);
            this.YeniSifreLabel.Name = "YeniSifreLabel";
            this.YeniSifreLabel.Size = new System.Drawing.Size(95, 24);
            this.YeniSifreLabel.TabIndex = 23;
            this.YeniSifreLabel.Text = "Yeni Şifre";
            // 
            // TcLabel
            // 
            this.TcLabel.AutoSize = true;
            this.TcLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcLabel.ForeColor = System.Drawing.Color.Black;
            this.TcLabel.Location = new System.Drawing.Point(161, 60);
            this.TcLabel.Name = "TcLabel";
            this.TcLabel.Size = new System.Drawing.Size(136, 24);
            this.TcLabel.TabIndex = 22;
            this.TcLabel.Text = "T.C. Kimlik No";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnGuncelle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuncelle.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnGuncelle.Location = new System.Drawing.Point(168, 224);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(379, 49);
            this.BtnGuncelle.TabIndex = 21;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // SekreterSifremiUnuttumSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(704, 390);
            this.Controls.Add(this.BtnVazgec);
            this.Controls.Add(this.TxtSfre);
            this.Controls.Add(this.TxtTC);
            this.Controls.Add(this.YeniSifreLabel);
            this.Controls.Add(this.TcLabel);
            this.Controls.Add(this.BtnGuncelle);
            this.Name = "SekreterSifremiUnuttumSayfasi";
            this.Text = "Sekreter Şifremi Unuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVazgec;
        private System.Windows.Forms.TextBox TxtSfre;
        private System.Windows.Forms.TextBox TxtTC;
        private System.Windows.Forms.Label YeniSifreLabel;
        private System.Windows.Forms.Label TcLabel;
        private System.Windows.Forms.Button BtnGuncelle;
    }
}