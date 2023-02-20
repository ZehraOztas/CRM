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
using System.Drawing.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;
using System.Net;
using System.Runtime.CompilerServices;

namespace projeOdevi
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VJ6APHI\\SQLEXPRESS;Initial Catalog=CRM;Integrated Security=True");
            baglanti.Open();

            SqlCommand kontrol = new SqlCommand("SELECT * FROM Personel WHERE tc=@tc and sifre=@sifre", baglanti);
            kontrol.Parameters.AddWithValue("@tc", txtKadi.Text);
            kontrol.Parameters.AddWithValue("@sifre", txtSifre.Text);
            SqlDataAdapter da = new SqlDataAdapter(kontrol);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //SqlDataReader oku = kontrol.ExecuteReader();
            if (dt.Rows.Count>0)
            {
                PersonelBilgileri.pid = Convert.ToInt32(dt.Rows[0]["P_id"].ToString());
                PersonelBilgileri.Pad = dt.Rows[0]["ad"].ToString();
                PersonelBilgileri.Psad = dt.Rows[0]["soyad"].ToString();
                PersonelBilgileri.Pfoto = dt.Rows[0]["foto"].ToString();
                PersonelBilgileri.tc = dt.Rows[0]["tc"].ToString();
                PersonelBilgileri.dt = Convert.ToDateTime(dt.Rows[0]["dogum_tarihi"]);
                PersonelBilgileri.gorev = dt.Rows[0]["gorev"].ToString();
                PersonelBilgileri.tel1 =dt.Rows[0]["tel1"].ToString();
                PersonelBilgileri.tel2 = dt.Rows[0]["tel2"].ToString();
                PersonelBilgileri.ep1 = dt.Rows[0]["ep1"].ToString();
                PersonelBilgileri.ep2 = dt.Rows[0]["ep2"].ToString();
                PersonelBilgileri.adres = dt.Rows[0]["adres"].ToString();
                PersonelBilgileri.il = dt.Rows[0]["il"].ToString();
                PersonelBilgileri.ilce = dt.Rows[0]["ilce"].ToString();
                PersonelBilgileri.sifre= dt.Rows[0]["sifre"].ToString();
                PersonelBilgileri.yetki = Convert.ToInt32(dt.Rows[0]["yetki"]);
                PersonelBilgileri.cinsiyet = dt.Rows[0]["cinsiyet"].ToString();
               

                AnaSayfa f = new AnaSayfa();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı işlem yapıldı. Lütfen kullanıcı adınızı veya şifrenizi kontrol ederek tekrar deneyiniz.");
                txtKadi.Clear();
                txtSifre.Clear();
                txtKadi.Focus();
            }
            baglanti.Close();
            
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?", "Çıkış Yap", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (cevap == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void lblUnut_Click(object sender, EventArgs e)
        {
            sifreunuttum f = new sifreunuttum();
            f.Show();
            this.Hide();
        }

        private void btnSifreYenile_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pbxGorme.Visible= false;
            pbxGor.Visible = true;
            txtSifre.PasswordChar = '\0';
        }

        private void pbxGor_Click(object sender, EventArgs e)
        {
            pbxGorme.Visible = true;
            pbxGor.Visible = false;
            txtSifre.PasswordChar = '*';
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
