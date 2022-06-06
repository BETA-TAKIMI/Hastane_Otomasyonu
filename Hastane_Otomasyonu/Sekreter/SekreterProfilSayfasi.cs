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

            //Doktorları Datagridview' e aktarma

            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("Select * from tbl_doktorlar", baglanti);
            da4.Fill(dt4);
            dataGridViewDoktor.DataSource = dt4;

            //Formun ilk açılışında comboboxlara branşları aktarma
            baglanti.Open();
            SqlCommand command3 = new SqlCommand("Select BransAd from tbl_Branslar", baglanti);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox1.Items.Add(dr3[0]);
            }
            baglanti.Close();

            //Barnşalrı Datagridview' e aktarma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_Branslar", baglanti);
            da.Fill(dt);
            dataGridViewBrans.DataSource = dt;


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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Doktor ekleme
            baglanti.Open();
            SqlCommand command = new SqlCommand("Insert into tbl_doktorlar (Doktorİsim, DoktorSoyİsim, DoktorUzmanlıkAlan, DoktorTCNo, DoktorSifre) values (@p1, @p2, @p3, @p4, @p5)", baglanti);
            command.Parameters.AddWithValue("@p1", txtFirstName.Text);
            command.Parameters.AddWithValue("@p2", txtLastName.Text);
            command.Parameters.AddWithValue("@p3", comboBox1.Text);
            command.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@p5", txtPassword.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Doktor eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtFirstName.Clear();
            txtLastName.Clear();
            comboBox1.Text = "";
            maskedTextBox1.Clear();
            txtPassword.Clear();
        }

        private void dataGridViewDoktor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Datagridviewde bir alana tıklandığında içerisindeki bilgilerin textboxlara aktarılması
            int chosen = dataGridViewDoktor.SelectedCells[0].RowIndex;
            txtFirstName.Text = dataGridViewDoktor.Rows[chosen].Cells[1].Value.ToString();
            txtLastName.Text = dataGridViewDoktor.Rows[chosen].Cells[2].Value.ToString();
            comboBox1.Text = dataGridViewDoktor.Rows[chosen].Cells[9].Value.ToString();
            maskedTextBox1.Text = dataGridViewDoktor.Rows[chosen].Cells[3].Value.ToString();
            txtPassword.Text = dataGridViewDoktor.Rows[chosen].Cells[10].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Doktor silme
            baglanti.Open();
            SqlCommand command = new SqlCommand("Delete from tbl_doktorlar where DoktorTCNo = @p1", baglanti);
            command.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Seçilen doktor silindi.");
            txtFirstName.Clear();
            txtLastName.Clear();
            comboBox1.Text = "";
            maskedTextBox1.Clear();
            txtPassword.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //TC Kimlik Numarası maskedtextbox' ta bulunan doktoru güncelleme
            baglanti.Open();
            SqlCommand command = new SqlCommand("Update tbl_doktorlar set Doktorİsim = @p1, DoktorSoyİsim = @p2, DoktorUzmanlıkAlan = @p3, DoktorSifre = @p5 where DoktorTCNo = @p4", baglanti);
            command.Parameters.AddWithValue("@p1", txtFirstName.Text);
            command.Parameters.AddWithValue("@p2", txtLastName.Text);
            command.Parameters.AddWithValue("@p3", comboBox1.Text);
            command.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@p5", txtPassword.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Doktor güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtFirstName.Clear();
            txtLastName.Clear();
            comboBox1.Text = "";
            maskedTextBox1.Clear();
            txtPassword.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("Insert into tbl_Branslar (BransAd) values (@p1)", baglanti);
            command.Parameters.AddWithValue("@p1", txtBrans.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Branş eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtBrans.Clear();
        }

        private void dataGridViewBrans_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //Datagridviewde bir alana tıklandığında içerisindeki bilgilerin textboxlara aktarılması
            int chosen = dataGridViewBrans.SelectedCells[0].RowIndex;
            txtID.Text = dataGridViewBrans.Rows[chosen].Cells[0].Value.ToString();
            txtBrans.Text = dataGridViewBrans.Rows[chosen].Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Baranş silme
            baglanti.Open();
            SqlCommand command = new SqlCommand("Delete from tbl_Branslar where Brasnid = @p1", baglanti);
            command.Parameters.AddWithValue("@p1", txtID.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Seçilen branş silindi.");
            txtID.Clear();
            txtBrans.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ID' si txtID' de bulunan branşı güncelleme
            baglanti.Open();
            SqlCommand command = new SqlCommand("Update tbl_Branslar set BransAd = @p2 where Brasnid = @p1", baglanti);
            command.Parameters.AddWithValue("@p1", txtID.Text);
            command.Parameters.AddWithValue("@p2", txtBrans.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Branş güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtID.Clear();
            txtBrans.Clear();
        }
    }
}
