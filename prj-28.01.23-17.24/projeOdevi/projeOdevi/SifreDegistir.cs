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
    public partial class SifreDegistir : Form
    {
        public SifreDegistir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtsifre.Text == "" || txtysifre.Text == "" || txtytsifre.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız.");
            }

            else
            {
                if (txtsifre.Text == PersonelBilgileri.sifre && txtysifre.Text == txtytsifre.Text)
                {
                    SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VJ6APHI\\SQLEXPRESS;Initial Catalog=CRM;Integrated Security=True");
                    baglanti.Open();
                    SqlCommand sifre = new SqlCommand("UPDATE Personel SET sifre=@sifre where P_id=@id",baglanti);
                    sifre.Parameters.AddWithValue("@id", PersonelBilgileri.pid);
                    sifre.Parameters.AddWithValue("@sifre",txtytsifre.Text);
                    sifre.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Şifreniz başarıyla değiştirildi.");
                    PersonelBilgileri.sifre = txtytsifre.Text;
                }
                else if (txtsifre.Text != PersonelBilgileri.sifre || txtysifre.Text.Trim() != txtytsifre.Text.Trim())
                {
                    MessageBox.Show("Bilgi tutarsızlığı! Lütfen şifrelerinizi kontrol ederek tekrar deneyiniz.");
                }
            }
        }

        private void pbxGorme_Click(object sender, EventArgs e)
        {
            pbxGorme.Visible = false;
            pbxGor.Visible = true;
            txtsifre.PasswordChar = '\0';
            txtysifre.PasswordChar = '\0';
            txtytsifre.PasswordChar= '\0';
        }

        private void pbxGor_Click(object sender, EventArgs e)
        {

            pbxGorme.Visible = true;
            pbxGor.Visible = false;
            txtsifre.PasswordChar = '*';
            txtysifre.PasswordChar = '*';
            txtytsifre.PasswordChar = '*';
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
