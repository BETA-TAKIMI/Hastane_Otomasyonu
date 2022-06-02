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
    public partial class DoktorProfilSayfasi : Form
    {
        public DoktorProfilSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-TIGD7V0; Initial Catalog = Db_Hastane; Integrated Security = True");

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Anasayfa frm = new Anasayfa();
            frm.Show();
            this.Hide();
        }
        public string tcno;
        private void DoktorProfilSayfasi_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From tbl_doktorlar where DoktorTCNo=@DoktorTCNo", baglanti);
            komut.Parameters.AddWithValue("DoktorTCNo", tcno.Trim());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

                lblDoktorİsimSoyisim.Text = dr["Doktorİsim"].ToString() + " " + dr["DoktorSoyİsim"].ToString();
                TxtHesKodu.Text = dr["DoktorHesKodu"].ToString();
                TxtMail.Text = dr["DoktorMail"].ToString();
                TxtYas.Text = dr["DoktorYas"].ToString();
                TxtTelefon.Text = dr["DoktorTelefon"].ToString();
                LblCinsiyet.Text = dr["DoktorCinsiyet"].ToString();
                TxtSifre.Text = dr["DoktorSifre"].ToString();
                TxtUzmanlik.Text = dr["DoktorUzmanlıkAlan"].ToString();
                LblAdSoyad.Text = dr["Doktorİsim"].ToString() + " " + dr["DoktorSoyİsim"].ToString(); //İsim boşluk Soyisim yazdırma
                LblTC.Text = dr["DoktorTCNo"].ToString();
            }
            baglanti.Close();

            //Bu doktora ait randevu listesini getiren sorgu aşağıdadır.
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_randevular where RandevuDoktor = '" + LblAdSoyad.Text + "'", baglanti);
            da.Fill(dt);
            dtRandevuDetay.DataSource = dt;


            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from tbl_duyurular", baglanti);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tbl_doktorlar set DoktorHesKodu='" + TxtHesKodu.Text + "', DoktorMail='" + TxtMail.Text + "', DoktorYas='" + Int32.Parse(TxtYas.Text) + "',DoktorTelefon='" + TxtTelefon.Text + "',  DoktorCinsiyet='" + LblCinsiyet.Text + "', DoktorSifre='" + TxtSifre.Text + "' where DoktorTCNo=@DoktorTCNo", baglanti);
            komut.Parameters.AddWithValue("DoktorTCNo", tcno.Trim());
            komut.ExecuteNonQuery();
            MessageBox.Show("Bilgileriniz Güncellendi...");
            baglanti.Close();
        }

        private void dtRandevuDetay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void dtRandevuDetay_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dtRandevuDetay.SelectedCells[0].RowIndex;
            rtbRandevuDetay.Text = dtRandevuDetay.Rows[chosen].Cells[7].Value.ToString();
        }
    }
}
