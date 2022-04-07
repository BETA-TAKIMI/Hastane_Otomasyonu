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
using Hastane_Otomasyonu.Models;

namespace Hastane_Otomasyonu
{

    public partial class HastaProfilSayfasi : Form
    {
        public HastaModel h = new HastaModel();

        public HastaProfilSayfasi()
        {
            InitializeComponent();
            verilerigoster();


        }
        //SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-TIGD7V0; Initial Catalog = Db_Hastane; Integrated Security = True");

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void HastaProfilSayfasi_Load(object sender, EventArgs e)
        {

        }

        private void verilerigoster()

        {
            TxtHesKodu.Text = h.HastaHesKodu;
            TxtYas.Text = h.HastaYas.ToString();
            CmbBxCnsyt.Text = h.HastaCinsiyet;
            TxtMail.Text = h.HastaMail;
            TxtSfre.Text = h.HastaSifre;
            TxtTelefon.Text = h.HastaTelefon;

            /*
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select*from tbl_hastalar where HastaTCNo like'%" + h.HastaTCNo + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                TxtHesKodu.Text = oku["HastaHesKodu"].ToString();
                TxtYas.Text = oku["HastaYas"].ToString();
                CmbBxCnsyt.Text = oku["HastaCinsiyet"].ToString();
                TxtTelefon.Text = oku["HastaTelefon"].ToString();
                TxtMail.Text = oku["HastaMail"].ToString();
                TxtSfre.Text = oku["HastaSifre"].ToString();

            }


            baglanti.Close();
            */
        }

        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {


        }
    }
}
