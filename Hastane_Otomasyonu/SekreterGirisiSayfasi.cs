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
    public partial class SekreterGirisiSayfasi : Form
    {
        public SekreterGirisiSayfasi()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-TIGD7V0; Initial Catalog = Db_Hastane; Integrated Security = True");
        private void TxtTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSfre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                String Sql = "select*from tbl_sekreter where SekereterTCNo=@ SekereterTCNo AND  SekereterSifre=@ SekereterSifre";
                SqlParameter prm1 = new SqlParameter(" SekereterTCNo", TxtTC.Text.Trim());
                SqlParameter prm2 = new SqlParameter(" SekereterSifre", TxtSfre.Text.Trim());
                SqlCommand komut = new SqlCommand(Sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                //if (dt.Rows.Count > 0)
                //{
                //    FrmSekereterDetay frm = new FrmSekereterDetay();
                //    frm.Show();
                //    this.Hide();

                //}
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş.....");
            }
        }
    }
}
