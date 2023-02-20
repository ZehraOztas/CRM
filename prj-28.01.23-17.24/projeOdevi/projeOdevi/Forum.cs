using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Common;
using System.Net.Mail;
using System.Net;
using System.ComponentModel.DataAnnotations;

namespace projeOdevi
{
    public partial class Forum : Form
    {
        public Forum()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VJ6APHI\\SQLEXPRESS;Initial Catalog=CRM;Integrated Security=True");

        private void Forumcs_Load(object sender, EventArgs e)
        {
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VJ6APHI\\SQLEXPRESS;Initial Catalog=CRM;Integrated Security=True");
                baglanti.Open();
                SqlCommand kontrol = new SqlCommand("SELECT * FROM Musteri WHERE ep=@ep1", baglanti);
                // kontrol.Parameters.AddWithValue("@as", cbxAlici.Text);
                kontrol.Parameters.AddWithValue("@ep1", txtMail.Text);
                string baslik = txtBaslik.Text;
                string icerik = txtIcerik.Text;
                DateTime bugun = DateTime.Now;

                SqlDataReader oku = kontrol.ExecuteReader();
                if (oku.Read())
                {
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    string tarih = DateTime.Now.ToString();
                    string mailadress = ("cRmProject1@outlook.com");
                    string sifre = ("Crm1234!");
                    string smptsrvr = "smtp.office365.com";
                    string kime = (oku["ep"].ToString());
                    string konu = ("baslik");
                    string yaz = ("Merhaba, " + (oku["ad"].ToString()) + "YZN Şirketten " + tarih + "\n" + icerik + "\n" + "\n" + "İyi Günler");
                    smtpserver.Credentials = new NetworkCredential(mailadress, sifre);
                    smtpserver.Port = 587;
                    smtpserver.Host = smptsrvr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadress);
                    mail.To.Add(kime);
                    mail.Subject = konu;
                    mail.Body = yaz;
                    smtpserver.Send(mail);
                    MessageBox.Show("Mailiniz başarıyla gönderilmiştir.");
                    baglanti.Close();
                    
                    baglanti.Open();
                    SqlCommand kaydet = new SqlCommand("INSERT INTO Forum(mesaj,baslik,gonderen,gonderilen,tarih)VALUES(@mesaj,@baslik,@gonderen,@gonderilen,@tarih)", baglanti);
                    kaydet.Parameters.AddWithValue("@mesaj", icerik);
                    kaydet.Parameters.AddWithValue("@baslik", baslik);
                    kaydet.Parameters.AddWithValue("@gonderen", PersonelBilgileri.Pad);
                    kaydet.Parameters.AddWithValue("@gonderilen", txtAd.Text);
                    kaydet.Parameters.AddWithValue("@tarih", bugun);
                    kaydet.ExecuteNonQuery();
                    MessageBox.Show("Kaydedildi.");
                }

                else
                {
                    MessageBox.Show("Mail adresiniz veya e-posta adresiniz yanlış! Lütfen bilgilerinizi kontrol ederek tekrar deneyiniz.");
                }
                baglanti.Close();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Gönderi İçin Ek Dosya Seçebilirsiniz.";
            ofd.ShowDialog();
            lblKonum.Text = ofd.FileName;*/
        }

        private void Forum_Load(object sender, EventArgs e)
        {// TODO: Bu kod satırı 'cRMDataSet9.Musteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.musteriTableAdapter.Fill(this.cRMDataSet9.Musteri);

            baglanti.Open();
            SqlCommand doldur = new SqlCommand("SELECT DISTINCT ad FROM [Musteri] JOIN [forum] ON Musteri.ad=forum.gonderilen", baglanti);
            doldur.Parameters.AddWithValue("@tpid", Convert.ToInt32(PersonelBilgileri.pid));
            SqlDataReader dr = doldur.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());

                //comboBox1.Items.Add(dr[0].ToString()+' ' + dr[1].ToString());
            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand arama = new SqlCommand("SELECT Musteri.ad,Musteri.ep,Forum.mesaj FROM [Musteri] JOIN [forum] ON Musteri.ad=forum.gonderilen ", baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(arama);

            da.Fill(dt);

            arama.ExecuteNonQuery();

            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {           
            
        }

        private void pnlforum_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand arama = new SqlCommand("SELECT Musteri.ad,Musteri.ep,Forum.mesaj FROM [Musteri] JOIN [forum] ON Musteri.ad=forum.gonderilen WHERE (ad like '%'+@ad+'%')", baglanti);
            arama.Parameters.AddWithValue("@ad", comboBox1.SelectedItem);
            //arama.Parameters.AddWithValue("@soyad", comboBox1.SelectedItem);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(arama);

            da.Fill(dt);

            arama.ExecuteNonQuery();

            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void pnlMailGonder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            txtAd.Text = row.Cells[0].Value.ToString();
            txtMail.Text = row.Cells[1].Value.ToString();

            pnlMailGonder.Visible = true;
            pnlforum.Visible= false;
        }
    }
}
