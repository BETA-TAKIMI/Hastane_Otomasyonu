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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnHastaGirisi = new System.Windows.Forms.Button();
            this.BtnDoktorGirisi = new System.Windows.Forms.Button();
            this.BtnSekreterGirisi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(184, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "BETA HASTANESİ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnHastaGirisi
            // 
            this.BtnHastaGirisi.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnHastaGirisi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHastaGirisi.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnHastaGirisi.Location = new System.Drawing.Point(77, 350);
            this.BtnHastaGirisi.Name = "BtnHastaGirisi";
            this.BtnHastaGirisi.Size = new System.Drawing.Size(166, 49);
            this.BtnHastaGirisi.TabIndex = 1;
            this.BtnHastaGirisi.Text = "Hasta Girişi";
            this.BtnHastaGirisi.UseVisualStyleBackColor = false;
            // 
            // BtnDoktorGirisi
            // 
            this.BtnDoktorGirisi.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnDoktorGirisi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoktorGirisi.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnDoktorGirisi.Location = new System.Drawing.Point(298, 350);
            this.BtnDoktorGirisi.Name = "BtnDoktorGirisi";
            this.BtnDoktorGirisi.Size = new System.Drawing.Size(166, 49);
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
            this.BtnSekreterGirisi.Location = new System.Drawing.Point(512, 350);
            this.BtnSekreterGirisi.Name = "BtnSekreterGirisi";
            this.BtnSekreterGirisi.Size = new System.Drawing.Size(166, 49);
            this.BtnSekreterGirisi.TabIndex = 3;
            this.BtnSekreterGirisi.Text = "Sekreter Girişi";
            this.BtnSekreterGirisi.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(281, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 206);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(771, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSekreterGirisi);
            this.Controls.Add(this.BtnDoktorGirisi);
            this.Controls.Add(this.BtnHastaGirisi);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHastaGirisi;
        private System.Windows.Forms.Button BtnDoktorGirisi;
        private System.Windows.Forms.Button BtnSekreterGirisi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

