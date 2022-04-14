using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Hastane_Otomasyonu
{
    public partial class SekreterSifremiUnuttumSayfasi : Form
    {
        public SekreterSifremiUnuttumSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-TIGD7V0; Initial Catalog = Db_Hastane; Integrated Security = True");

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtTC.Text == "" || TxtSfre.Text == "")
            {

                MessageBox.Show("Tc ve Şifre Boş Bırakılamaz!.....");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update tbl_sekreter set sekreterTCNo='" + TxtTC.Text + "',sekreterSifre='" + TxtSfre.Text + "' where sekreterTCNo='" + TxtTC.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Şifre Güncellendi...");
               SekreterGirisiSayfasi hst = new SekreterGirisiSayfasi();
                hst.Show();
                this.Hide();

                baglanti.Close();


            }
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            SekreterGirisiSayfasi hst = new SekreterGirisiSayfasi();
            hst.Show();
            this.Hide();
        }
    }
}
