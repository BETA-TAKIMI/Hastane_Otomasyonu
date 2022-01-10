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
    public partial class DoktorSifremiUnuttumSayfasi : Form
    {
        public DoktorSifremiUnuttumSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-TIGD7V0; Initial Catalog = Db_Hastane; Integrated Security = True");

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtTC.Text == "" || TxtSfre.Text == "")
            {

                MessageBox.Show("TC ve Şifre Boş Bırakılamaz!.....");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update tbl_doktorlar set DoktorTCNo='" + TxtTC.Text + "',DoktorSifre='" + TxtSfre.Text + "' where DoktorTCNo='" + TxtTC.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Şifre Güncellendi...");
                DoktorGirisiSayfasi hst = new DoktorGirisiSayfasi();
                hst.Show();
                this.Hide();

                baglanti.Close();


            }
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {

        }
    }
}
