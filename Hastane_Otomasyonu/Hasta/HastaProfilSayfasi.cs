using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
//using System.Data.SqlClient;
namespace Hastane_Otomasyonu
{
    public partial class HastaProfilSayfasi : Form
    {
        public HastaProfilSayfasi()
        {

            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-TIGD7V0; Initial Catalog = Db_Hastane; Integrated Security = True");


        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

        }
        public string tcno;
        private void HastaProfilSayfasi_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From tbl_hastalar where HastaTCNo=@HastaTCNo", baglanti);
            komut.Parameters.AddWithValue("HastaTCNo", tcno.Trim());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                
                lblHastaİsimSoyisim.Text = dr["Hastaİsim"].ToString()+" " + dr["HastaSoyİsim"].ToString();
                TxtHesKodu.Text = dr["HastaHesKodu"].ToString();
                TxtMail.Text = dr["HastaMail"].ToString();
                TxtYas.Text = dr["HastaYas"].ToString();
                TxtTelefon.Text = dr["HastaTelefon"].ToString();
                CmbBxCnsyt.Text = dr["HastaCinsiyet"].ToString();
                TxtSfre.Text = dr["HastaSifre"].ToString();
            }
            baglanti.Close();
        }

        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tbl_hastalar set HastaHesKodu='" + TxtHesKodu.Text + "', HastaMail='" + TxtMail.Text + "', HastaYas='"+ Int32.Parse(TxtYas.Text)+ "',HastaTelefon='" + TxtTelefon.Text + "',  HastaCinsiyet='" + CmbBxCnsyt.Text + "', HastaSifre='" + TxtSfre.Text + "' where HastaTCNo=@HastaTCNo", baglanti);
            komut.Parameters.AddWithValue("HastaTCNo", tcno.Trim());
            komut.ExecuteNonQuery();
            MessageBox.Show("Bilgileriniz Güncellendi...");
            baglanti.Close();
        }
       
    }
    }

