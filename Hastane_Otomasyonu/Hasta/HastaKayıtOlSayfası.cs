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
using Hastane_Otomasyonu.Models;

namespace Hastane_Otomasyonu
{
    public partial class HastaKayıtOlSayfası : Form
    {
        SqlCommand komut;

        public HastaKayıtOlSayfası()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-TIGD7V0; Initial Catalog = Db_Hastane; Integrated Security = True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnKaydiTamamla_Click(object sender, EventArgs e)
        {
            HastaModel hasta = new HastaModel(TxtAd.Text, TxtSyd.Text, int.Parse(TxtYas.Text), TxtTc.Text, MskTxtTelefon.Text, TxtHskd.Text, TxtMail.Text,TxtMail.Text, TxtSfre.Text,CmbBxCnsyt.Text);

            String sorgu = "INSERT INTO tbl_hastalar(Hastaİsim,HastaSoyİsim,HastaTCNo,HastaYas,HastaCinsiyet,HastaHesKodu,HastaTelefon,HastaMail,HastaSifre) VALUES (@Hastaİsim,@HastaSoyİsim,@HastaTCNo,@HastaYas,@HastaCinsiyet,@HastaHesKodu,@HastaTelefon,@HastaMail,@HastaSifre)";
            komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@Hastaİsim", TxtAd.Text);
            komut.Parameters.AddWithValue("@HastaSoyİsim", TxtSyd.Text);
            komut.Parameters.AddWithValue("@HastaTCNo", TxtTc.Text);
            komut.Parameters.AddWithValue("@HastaYas", TxtYas.Text);
            komut.Parameters.AddWithValue("@HastaCinsiyet", CmbBxCnsyt.Text);
            komut.Parameters.AddWithValue("@HastaHesKodu", TxtHskd.Text);
            komut.Parameters.AddWithValue("@HastaTelefon", MskTxtTelefon.Text);
            komut.Parameters.AddWithValue("@HastaMail", TxtMail.Text);
            komut.Parameters.AddWithValue("@HastaSifre", TxtSfre.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            MessageBox.Show("Kaydınız Başarıyla Yapıldı Şifreniz:" + TxtSfre.Text);

            baglanti.Close();
        }

        private void BtnHastaGirisi_Click(object sender, EventArgs e)
        {
           HastaGirisiSayfası frm = new  HastaGirisiSayfası( );
            frm.Show();
            this.Hide();
        }
    }
}
