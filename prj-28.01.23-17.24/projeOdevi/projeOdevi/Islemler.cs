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

namespace projeOdevi
{
    public partial class Islemler : Form
    {
        public Islemler()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-VJ6APHI\\SQLEXPRESS;Initial Catalog=CRM;Integrated Security=True");

        private void Islemler_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand ara = new SqlCommand("SELECT * From Musteri WHERE ad LIKE +@ad+ '%' OR soyad LIKE + @sad +'%'",baglan);
            ara.Parameters.AddWithValue("@ad",txtAra.Text);
            ara.Parameters.AddWithValue("@sad",txtAra.Text);
            SqlDataAdapter da = new SqlDataAdapter(ara);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtIslemler.DataSource= dt;
            baglan.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {

        }

        private void cbxSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxSec.SelectedIndex)
            {
                case 0:
                    baglan.Open();
                    SqlCommand all = new SqlCommand("SELECT * FROM Musteri", baglan);
                    SqlDataAdapter da = new SqlDataAdapter(all);
                    DataSet ds = new DataSet();
                    da.Fill(ds,"Musteriler");
                    all.ExecuteNonQuery();
                    dtIslemler.DataSource= ds;
                    dtIslemler.DataMember = "Musteriler";
                    baglan.Close();
                    break;
              
                case 1:
                    baglan.Open();
                    SqlCommand gorus = new SqlCommand("SELECT * FROM Musteri Where durum=@d", baglan);
                    gorus.Parameters.AddWithValue("@d",cbxSec.Text=="Görüşülüyor");
                    SqlDataAdapter da1 = new SqlDataAdapter(gorus);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1, "Gorus");
                    gorus.ExecuteNonQuery();
                    dtIslemler.DataSource = ds1;
                    dtIslemler.DataMember = "Gorus";
                    baglan.Close();
                    break;

                case 2:
                    baglan.Open();
                    SqlCommand teksun = new SqlCommand("SELECT * FROM Musteri Where durum=@d", baglan);
                    teksun.Parameters.AddWithValue("@d", cbxSec.Text);
                    SqlDataAdapter da2 = new SqlDataAdapter(teksun);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2, "Tek_Sun");
                    teksun.ExecuteNonQuery();
                    dtIslemler.DataSource = ds2;
                    dtIslemler.DataMember = "Tek_Sun";
                    baglan.Close();
                    break;
               
                case 3:
                    baglan.Open();
                    SqlCommand tekred = new SqlCommand("SELECT * FROM Musteri Where durum=@d", baglan);
                    tekred.Parameters.AddWithValue("@d", cbxSec.Text);
                    SqlDataAdapter da3 = new SqlDataAdapter(tekred);
                    DataSet ds3 = new DataSet();
                    da3.Fill(ds3, "Tek_Red"); 
                    tekred.ExecuteNonQuery();
                    dtIslemler.DataSource = ds3;
                    dtIslemler.DataMember = "Tek_Red";
                    baglan.Close();
                    break;

                case 4:
                    baglan.Open();
                    SqlCommand sozHaz = new SqlCommand("SELECT * FROM Musteri Where durum=@d", baglan);
                    sozHaz.Parameters.AddWithValue("@d", cbxSec.Text);
                    SqlDataAdapter da4 = new SqlDataAdapter(sozHaz);
                    DataSet ds4 = new DataSet();
                    da4.Fill(ds4, "Soz_Haz");
                    sozHaz.ExecuteNonQuery();
                    dtIslemler.DataSource = ds4;
                    dtIslemler.DataMember = "Soz_Haz";
                    baglan.Close();
                    break;

                case 5:
                    baglan.Open();
                    SqlCommand sozImza = new SqlCommand("SELECT * FROM Musteri Where durum=@d", baglan);
                    sozImza.Parameters.AddWithValue("@d", cbxSec.Text);
                    SqlDataAdapter da5 = new SqlDataAdapter(sozImza);
                    DataSet ds5 = new DataSet();
                    da5.Fill(ds5, "Imza");
                    sozImza.ExecuteNonQuery();
                    dtIslemler.DataSource = ds5;
                    dtIslemler.DataMember = "Imza";
                    baglan.Close();
                    break;

                case 6:
                    baglan.Open();
                    SqlCommand siparisVerildi = new SqlCommand("SELECT * FROM Musteri Where durum=@d", baglan);
                    siparisVerildi.Parameters.AddWithValue("@d", cbxSec.Text);
                    SqlDataAdapter da6 = new SqlDataAdapter(siparisVerildi);
                    DataSet ds6 = new DataSet();
                    da6.Fill(ds6, "Siparis_Verildi");
                    baglan.Close();
                    break;

                case 7:
                    baglan.Open();
                    SqlCommand uretiliyor = new SqlCommand("SELECT * FROM Musteri Where durum=@d", baglan);
                    uretiliyor.Parameters.AddWithValue("@d", cbxSec.Text);
                    SqlDataAdapter da7 = new SqlDataAdapter(uretiliyor);
                    DataSet ds7 = new DataSet();
                    da7.Fill(ds7, "Uretiliyor");
                    baglan.Close();
                    break;

                case 8:
                    baglan.Open();
                    SqlCommand yolda = new SqlCommand("SELECT * FROM Musteri Where durum=@d", baglan);
                    yolda.Parameters.AddWithValue("@d", cbxSec.Text);
                    SqlDataAdapter da8 = new SqlDataAdapter(yolda);
                    DataSet ds8 = new DataSet();
                    da8.Fill(ds8, "Soz_Haz");
                    baglan.Close();
                    break;

                case 9:
                    baglan.Open();
                    SqlCommand teslim = new SqlCommand("SELECT * FROM Musteri Where durum=@d", baglan);
                    teslim.Parameters.AddWithValue("@d", cbxSec.Text);
                    SqlDataAdapter da9 = new SqlDataAdapter(teslim);
                    DataSet ds9 = new DataSet();
                    da9.Fill(ds9, "Teslim");
                    baglan.Close();
                    break;

                case 10:
                    baglan.Open();
                    SqlCommand kontrol = new SqlCommand("SELECT * FROM Musteri Where durum=@d", baglan);
                    kontrol.Parameters.AddWithValue("@d", cbxSec.Text);
                    SqlDataAdapter da10 = new SqlDataAdapter(kontrol);
                    DataSet ds10 = new DataSet();
                    da10.Fill(ds10, "Soz_Haz");
                    baglan.Close();
                    break;

                case 11:
                    baglan.Open();
                    SqlCommand tamamlandi = new SqlCommand("SELECT * FROM Musteri Where durum=@d", baglan);
                    tamamlandi.Parameters.AddWithValue("@d", cbxSec.Text);
                    SqlDataAdapter da11 = new SqlDataAdapter(tamamlandi);
                    DataSet ds11 = new DataSet();
                    da11.Fill(ds11, "Soz_Haz");
                    baglan.Close();
                    break;
            }
        }
    }
}
