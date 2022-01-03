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
    public partial class HastaGirisiSayfası : Form
    {
        public HastaGirisiSayfası()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-TIGD7V0; Initial Catalog = Db_Hastane; Integrated Security = True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                String Sql = "select*from tbl_hastalar where HastaTCNo=@HastaTCNo AND HastaSifre=@HastaSifre";
                SqlParameter prm1 = new SqlParameter("HastaTCNo", TxtTC.Text.Trim());
                SqlParameter prm2 = new SqlParameter("HastaSifre", TxtSfre.Text.Trim());
                SqlCommand komut = new SqlCommand(Sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                //if (dt.Rows.Count > 0)
                //{
                //    FrmHastaDetay frm = new FrmHastaDetay();
                //    frm.Show();
                //    this.Hide();

                //}
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş.....");
            }


        }

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            KayıtOlSayfası hst = new KayıtOlSayfası();
            hst.Show();
            this.Hide();
        }

        private void HastaGirisiSayfası_Load(object sender, EventArgs e)
        {

        }

        private void BtnSifremiUnuttum_Click(object sender, EventArgs e)
        {

        }
    }
}
