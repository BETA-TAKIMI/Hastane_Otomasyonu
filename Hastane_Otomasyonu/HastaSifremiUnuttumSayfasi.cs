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
    public partial class HastaSifremiUnuttumSayfasi : Form
    {
        public HastaSifremiUnuttumSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-TIGD7V0; Initial Catalog = Db_Hastane; Integrated Security = True");

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtTC.Text == "" || TxtSfre.Text == "")
            {

                MessageBox.Show("Hatalı Giriş.....");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update tbl_hastalar set HastaTCNo='" + TxtTC.Text + "',HastaSifre='" + TxtSfre.Text + "' where HastaTCNo='" + TxtTC.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Şifre Güncellendi...");

                baglanti.Close();


            }
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            HastaGirisiSayfası hst = new HastaGirisiSayfası();
            hst.Show();
            this.Hide();
        }
    }
}
