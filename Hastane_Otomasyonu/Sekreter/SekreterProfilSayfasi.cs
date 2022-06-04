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
                TxtSfre.Text = dr["SekreterSifre"].ToString();
                lblAdSoyad.Text= dr["Sekreterİsim"].ToString() + " " + dr["SekreterSoyİsim"].ToString();
                lblTC.Text = dr["SekreterTCNo"].ToString();
            }
            baglanti.Close();

            //Branşları Datagridview' e aktarma

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from tbl_Branslar", baglanti);
            da1.Fill(dt1);
            dtBrans.DataSource = dt1;

            //Doktorları Datagridview' e aktarma (Doktorların isimlerini ad boşluk soyad şeklinde Doktorlar sütunu içerisine yazar

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (Doktorİsim + ' ' + DoktorSoyİsim) as Doktorlar, DoktorUzmanlıkAlan from tbl_doktorlar", baglanti);
            da2.Fill(dt2);
            dtDoktor.DataSource = dt2;

            //Comboboxa Branşları aktarma
            baglanti.Open();
            SqlCommand command2 = new SqlCommand("Select BransAd from tbl_Branslar", baglanti);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBranch.Items.Add(dr2[0]);
            }
            baglanti.Close();
            //duyuruları çekme
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Select * from tbl_duyurular", baglanti);
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tbl_sekreter set SekreterHesKodu='" + TxtHesKodu.Text + "', SekreterMail='" + TxtMail.Text + "', SekreterYas='" + Int32.Parse(TxtYas.Text) + "',SekreterTelefon='" + TxtTelefon.Text + "',  SekreterCinsiyet='" + LblCinsiyet.Text + "', SekreterSifre='" + TxtSfre.Text + "' where SekreterTCNo=@SekreterTCNo", baglanti);
            komut.Parameters.AddWithValue("SekreterTCNo", tcno.Trim());
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("Insert into tbl_randevular (RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor) values (@p1, @p2, @p3, @p4)", baglanti);
            command.Parameters.AddWithValue("@p1", maskDate.Text);
            command.Parameters.AddWithValue("@p2", maskTime.Text);
            command.Parameters.AddWithValue("@p3", cmbBranch.Text);
            command.Parameters.AddWithValue("@p4", cmbDoctor.Text);
            command.ExecuteNonQuery();
           baglanti.Close();
            MessageBox.Show("Randevu oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Branş Comboboxına tıklanınca direkt ilgili branşa ait doktorlar listelensin
            baglanti.Open();
            cmbDoctor.Items.Clear();
            SqlCommand command3 = new SqlCommand("Select Doktorİsim, DoktorSoyİsim from tbl_doktorlar where DoktorUzmanlıkAlan = @p1", baglanti);
            command3.Parameters.AddWithValue("@p1", cmbBranch.Text);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            baglanti.Close();
        }

        private void btnDuyuru_Click(object sender, EventArgs e)
        {
            //Duyuru oluşturma
            baglanti.Open();
            SqlCommand command = new SqlCommand("Insert into tbl_duyurular (Duyuru) values (@p1)", baglanti);
            command.Parameters.AddWithValue("@p1", rtbDuyuru.Text);
            command.ExecuteNonQuery();
           baglanti.Close();
            MessageBox.Show("Duyuru oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            rtbDuyuru.Clear();
        }

        
    }
}
