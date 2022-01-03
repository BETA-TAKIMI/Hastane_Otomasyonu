namespace Hastane_Otomasyonu
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.HastaneAdiLabel = new System.Windows.Forms.Label();
            this.BtnHastaGirisi = new System.Windows.Forms.Button();
            this.BtnDoktorGirisi = new System.Windows.Forms.Button();
            this.BtnSekreterGirisi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HastaneAdiLabel
            // 
            this.HastaneAdiLabel.AutoSize = true;
            this.HastaneAdiLabel.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaneAdiLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.HastaneAdiLabel.Location = new System.Drawing.Point(138, 220);
            this.HastaneAdiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HastaneAdiLabel.Name = "HastaneAdiLabel";
            this.HastaneAdiLabel.Size = new System.Drawing.Size(298, 39);
            this.HastaneAdiLabel.TabIndex = 0;
            this.HastaneAdiLabel.Text = "BETA HASTANESİ";
            this.HastaneAdiLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnHastaGirisi
            // 
            this.BtnHastaGirisi.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnHastaGirisi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHastaGirisi.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnHastaGirisi.Location = new System.Drawing.Point(58, 284);
            this.BtnHastaGirisi.Margin = new System.Windows.Forms.Padding(2);
            this.BtnHastaGirisi.Name = "BtnHastaGirisi";
            this.BtnHastaGirisi.Size = new System.Drawing.Size(124, 48);
            this.BtnHastaGirisi.TabIndex = 1;
            this.BtnHastaGirisi.Text = "Hasta Girişi";
            this.BtnHastaGirisi.UseVisualStyleBackColor = false;
            this.BtnHastaGirisi.Click += new System.EventHandler(this.BtnHastaGirisi_Click);
            // 
            // BtnDoktorGirisi
            // 
            this.BtnDoktorGirisi.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnDoktorGirisi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoktorGirisi.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnDoktorGirisi.Location = new System.Drawing.Point(224, 284);
            this.BtnDoktorGirisi.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDoktorGirisi.Name = "BtnDoktorGirisi";
            this.BtnDoktorGirisi.Size = new System.Drawing.Size(124, 48);
            this.BtnDoktorGirisi.TabIndex = 2;
            this.BtnDoktorGirisi.Text = "Doktor Girişi";
            this.BtnDoktorGirisi.UseVisualStyleBackColor = false;
            this.BtnDoktorGirisi.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnSekreterGirisi
            // 
            this.BtnSekreterGirisi.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSekreterGirisi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSekreterGirisi.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnSekreterGirisi.Location = new System.Drawing.Point(384, 284);
            this.BtnSekreterGirisi.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSekreterGirisi.Name = "BtnSekreterGirisi";
            this.BtnSekreterGirisi.Size = new System.Drawing.Size(124, 48);
            this.BtnSekreterGirisi.TabIndex = 3;
            this.BtnSekreterGirisi.Text = "Sekreter Girişi";
            this.BtnSekreterGirisi.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(578, 385);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSekreterGirisi);
            this.Controls.Add(this.BtnDoktorGirisi);
            this.Controls.Add(this.BtnHastaGirisi);
            this.Controls.Add(this.HastaneAdiLabel);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HastaneAdiLabel;
        private System.Windows.Forms.Button BtnHastaGirisi;
        private System.Windows.Forms.Button BtnDoktorGirisi;
        private System.Windows.Forms.Button BtnSekreterGirisi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

