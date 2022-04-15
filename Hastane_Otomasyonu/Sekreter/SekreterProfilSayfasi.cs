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
    public partial class SekreterProfilSayfasi : Form
    {
        public SekreterProfilSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-TIGD7V0; Initial Catalog = Db_Hastane; Integrated Security = True");

        public string tcno;
        private void SekreterProfilSayfasi_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From tbl_sekreter where SekreterTCNo=@SekreterTCNo", baglanti);
            komut.Parameters.AddWithValue("SekreterTCNo", tcno.Trim());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

                LblSekreterIsimSoyisim.Text = dr["Sekreterİsim"].ToString() + " " + dr["SekreterSoyİsim"].ToString();
                TxtHesKodu.Text = dr["SekreterHesKodu"].ToString();
                TxtMail.Text = dr["SekreterMail"].ToString();
                TxtYas.Text = dr["SekreterYas"].ToString();
                TxtTelefon.Text = dr["SekreterTelefon"].ToString();
                LblCinsiyet.Text = dr["SekreterCinsiyet"].ToString();
                TxtYas.Text = dr["SekreterSifre"].ToString();
            }
            baglanti.Close();
        }
    }
}
