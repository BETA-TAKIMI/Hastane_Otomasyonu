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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoktorGirisiSayfasi hst = new DoktorGirisiSayfasi();
            hst.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnHastaGirisi_Click(object sender, EventArgs e)
        {
            HastaGirisiSayfası hst = new HastaGirisiSayfası();
            hst.Show();
            this.Hide();
        }

        private void BtnSekreterGirisi_Click(object sender, EventArgs e)
        {
            SekreterGirisiSayfasi hst = new SekreterGirisiSayfasi();
            hst.Show();
            this.Hide();
        }
    }
}
