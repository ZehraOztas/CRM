using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace projeOdevi
{
    public partial class sifreunuttum : Form
    {
        public sifreunuttum()
        {
            InitializeComponent();
        }

        private void btnSifreYenile_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VJ6APHI\\SQLEXPRESS;Initial Catalog=CRM;Integrated Security=True");
            baglanti.Open();
            SqlCommand kontrol = new SqlCommand("SELECT * FROM Personel WHERE ep1=@ep1", baglanti);
            kontrol.Parameters.AddWithValue("@ep1", txtSifreYenileEp.Text);

            SqlDataReader oku = kontrol.ExecuteReader();
            if (oku.Read())
            {
                SmtpClient smtpserver = new SmtpClient();
                MailMessage mail = new MailMessage();
                string tarih = DateTime.Now.ToString();
                string mailadress = ("cRmProject1@outlook.com");
                string sifre = ("Crm1234!");
                string smptsrvr = "smtp.office365.com";
                string kime = (oku["ep1"].ToString());
                string konu = ("Şifre Hatırlatma");
                string yaz = ("Merhaba," + (oku["ad"].ToString() + oku["soyad"].ToString()) + "\n" + "YZN Şirketten " + tarih + " tarihinde şifre unuttum talebinde bulundunuz" + "\n" + "Parolanız:" + oku["sifre"].ToString() + "\nİyi Günler");
                smtpserver.Credentials = new NetworkCredential(mailadress, sifre);
                smtpserver.Port = 587;
                smtpserver.Host = smptsrvr;
                smtpserver.EnableSsl = true;
                mail.From = new MailAddress(mailadress);
                mail.To.Add(kime);
                mail.Subject = konu;
                mail.Body = yaz;
                smtpserver.Send(mail);
                MessageBox.Show("Şifreniz mail adresinize gönderilmiştir.");
                login form = new login();
                form.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Mail adresiniz yanlış! Lütfen bilgilerinizi kontrol ederek tekrar deneyiniz.");
            }
            baglanti.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            login f = new login();
            f.Show();
            this.Hide();
        }
    }
}
