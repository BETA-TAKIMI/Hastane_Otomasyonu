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
                LblCinsiyet.Text = dr["HastaCinsiyet"].ToString();
                TxtSfre.Text = dr["HastaSifre"].ToString();
                LblAdSoyad.Text = dr["Hastaİsim"].ToString() + " " + dr["HastaSoyİsim"].ToString(); //İsim boşluk Soyisim yazdırma
                LblTC.Text= dr["HastaTCNo"].ToString();
            }
            baglanti.Close();

            //Geçmiş Randevu Çekme
            DataTable dt = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter("Select * from tbl_randevular where HastaTCNo = " + tcno, baglanti);
            data.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branş Çekme
            baglanti.Open();
            SqlCommand command2 = new SqlCommand("Select BransAd from tbl_Branslar", baglanti);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read()) //Veri okundukça combobox' a branşlar ekleniyor.
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            baglanti.Close();


        }
        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tbl_hastalar set HastaHesKodu='" + TxtHesKodu.Text + "', HastaMail='" + TxtMail.Text + "', HastaYas='"+ Int32.Parse(TxtYas.Text)+ "',HastaTelefon='" + TxtTelefon.Text + "',  HastaCinsiyet='" + LblCinsiyet.Text + "', HastaSifre='" + TxtSfre.Text + "' where HastaTCNo=@HastaTCNo", baglanti);
            komut.Parameters.AddWithValue("HastaTCNo", tcno.Trim());
            komut.ExecuteNonQuery();
            MessageBox.Show("Bilgileriniz Güncellendi...");
            baglanti.Close();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Anasayfa frm = new Anasayfa();
            frm.Show();
            this.Hide();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            //Eklemeden önce geçmişte eklenmiş olan isimleri temizleme işlemi yapılıyor.
            CmbDoktor.Items.Clear();
            //Doktorlar tablosunda branşı Combobox'ta yer alan Doktor adları ve doktor soyadlarını gösterir.
           
            SqlCommand command3 = new SqlCommand("Select Doktorİsim, DoktorSoyİsim from tbl_doktorlar where DoktorUzmanlıkAlan = @p1", baglanti);
            command3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read()) //Veri okundukça Doktor ismini gösterecek combobox' a İsim boşluk soyisim şeklinde ekleniyor.
            {
                CmbDoktor.Items.Add(dr3["Doktorİsim"].ToString() + " " + dr3["DoktorSoyİsim"].ToString());
            }
            baglanti.Close();
        }
    }
    }

