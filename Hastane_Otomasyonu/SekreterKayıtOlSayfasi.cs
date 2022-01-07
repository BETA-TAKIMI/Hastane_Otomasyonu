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
    public partial class SekreterKayıtOlSayfasi : Form
    {
        SqlCommand komut;
        public SekreterKayıtOlSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-TIGD7V0; Initial Catalog = Db_Hastane; Integrated Security = True");


        private void BtnKaydiTamamla_Click(object sender, EventArgs e)
        {

            String sorgu = "INSERT INTO tbl_sekreter(Sekreterİsim,SekreterSoyİsim,SekreterTCNo,SekreterYas,SekreterCinsiyet,SekreterHesKodu,SekreterTelefon,SekreterMail,SekreterSifre) VALUES (@Sekreterİsim,@SekreterSoyİsim,@SekreterTCNo,@SekreterYas,@SekreterCinsiyet,@SekreterHesKodu,@SekreterTelefon,@SekreterMail,@SekreterSifre)";
            komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@Sekreterİsim", TxtAd.Text);
            komut.Parameters.AddWithValue("@SekreterSoyİsim", TxtSyd.Text);
            komut.Parameters.AddWithValue("@SekreterTCNo", TxtTc.Text);
            komut.Parameters.AddWithValue("@SekreterYas", TxtYas.Text);
            komut.Parameters.AddWithValue("@SekreterCinsiyet", CmbBxCnsyt.Text);
            komut.Parameters.AddWithValue("@SekreterHesKodu", TxtHskd.Text);
            komut.Parameters.AddWithValue("@SekreterTelefon", MskTxtTelefon.Text);
            komut.Parameters.AddWithValue("@SekreterMail", TxtMail.Text);
            komut.Parameters.AddWithValue("@SekreterSifre", TxtSfre.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            MessageBox.Show("Kaydınız Başarıyla Yapıldı Şifreniz:" + TxtSfre.Text);

            baglanti.Close();
        }

        private void BtnDoktorGirisi_Click(object sender, EventArgs e)
        {

        }

        private void TxtAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
