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
    
    public partial class DoktorKayitOlSayfasi : Form
    {
        SqlCommand komut1;
        public DoktorKayitOlSayfasi()
        {
            InitializeComponent();
        }
       
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-TIGD7V0; Initial Catalog = Db_Hastane; Integrated Security = True");
        private void BtnKaydiTamamla_Click(object sender, EventArgs e)
        {


            String sorgu = "INSERT INTO tbl_doktorlar(Doktorİsim,DoktorSoyİsim,DoktorTCNo,DoktorYas,DoktorCinsiyet,DoktorHesKodu,DoktorTelefon,DoktorMail,DoktorUzmanlıkAlan,DoktorSifre) VALUES (@Doktorİsim,@DoktorSoyİsim,@DoktorTCNo,@DoktorYas,@DoktorCinsiyet,@DoktorHesKodu,@DoktorTelefon,@DoktorMail,@DoktorUzmanlıkAlan,@DoktorSifre)";
            komut1 = new SqlCommand(sorgu, baglanti);

            komut1.Parameters.AddWithValue("@Doktorİsim", TxtAd.Text);
            komut1.Parameters.AddWithValue("@DoktorSoyİsim", TxtSyd.Text);
            komut1.Parameters.AddWithValue("@DoktorTCNo", TxtTc.Text);
            komut1.Parameters.AddWithValue("@DoktorYas", TxtYas.Text);
            komut1.Parameters.AddWithValue("@DoktorCinsiyet", CmbBxCnsyt.Text);
            komut1.Parameters.AddWithValue("@DoktorHesKodu", TxtHskd.Text);
            komut1.Parameters.AddWithValue("@DoktorTelefon", MskTxtTelefon.Text);
            komut1.Parameters.AddWithValue("@DoktorMail", TxtMail.Text);
            komut1.Parameters.AddWithValue("@DoktorUzmanlıkAlan", TxtBrans.Text);
            komut1.Parameters.AddWithValue("@DoktorSifre", TxtSfre.Text);
            baglanti.Open();
            komut1.ExecuteNonQuery();
            MessageBox.Show("Kaydınız Başarıyla Yapıldı Şifreniz:" + TxtSfre.Text);

            baglanti.Close();
        }
    }
}
