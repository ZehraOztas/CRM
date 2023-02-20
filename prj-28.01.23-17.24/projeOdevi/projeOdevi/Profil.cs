using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeOdevi
{
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
        }

        string currentFilePath, newFileName, debugFolderPath, newFilePath, currentFileExtension;

        //string targetPath = @"C:\Users\oztas\OneDrive\Masaüstü\prj-26.12.22 -16.07\projeOdevi\projeOdevi\bin\Debug\personelResim";

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VJ6APHI\\SQLEXPRESS;Initial Catalog=CRM;Integrated Security=True");
        private void btnFoto_Click(object sender, EventArgs e)
        {
            //   try
            //   {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.FileName = "Resim Seç";
            dosya.Filter = "Resim Dosyası |*.jpg;*.jpeg;*.png |  Tüm Dosyalar |*.*\";";
            if (dosya.ShowDialog() == DialogResult.OK)
            {
                pbxProfil.ImageLocation = dosya.FileName;
            }

            currentFilePath = pbxProfil.ImageLocation;
            newFileName = PersonelBilgileri.Pad + PersonelBilgileri.Psad + "Profil";
            currentFileExtension = Path.GetExtension(currentFilePath); //Resim yolunu alır.
            debugFolderPath = Path.Combine(Application.StartupPath, "personelResim"+currentFileExtension);
            
            newFilePath = Path.Combine(debugFolderPath, newFileName);

            if (File.Exists(newFilePath))
            {
                File.Delete(newFilePath);
                System.IO.File.Copy(currentFilePath, newFilePath, true);
            }
               File.Copy(currentFilePath, newFilePath);

           // System.IO.File.Copy(currentFilePath, newFilePath, true);

            lblYer.Text = newFilePath;
            /* }
              catch (Exception hata)
              {
                  MessageBox.Show(hata.Message);
              } */
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {          
          //  try
            //{

                SqlCommand guncelle = new SqlCommand("UPDATE Personel SET tel1=@tel1, tel2=@tel2, ep1=@ep1, ep2=@ep2, adres=@adres, il=@il, ilce=@ilce ,foto=@foto WHERE tc=@tc", baglanti);
                baglanti.Open();
                guncelle.Parameters.AddWithValue("@tel1", txtTel1.Text);
                guncelle.Parameters.AddWithValue("@tel2", txtTel2.Text);
                guncelle.Parameters.AddWithValue("@ep1", txtEP1.Text);
                guncelle.Parameters.AddWithValue("@ep2", txtEP2.Text);
                guncelle.Parameters.AddWithValue("@adres", txtAdres.Text);
                guncelle.Parameters.AddWithValue("@il", cbbIl.Text);
                guncelle.Parameters.AddWithValue("@ilce", cbbIlce.Text);
                guncelle.Parameters.AddWithValue("@tc", txtTckn.Text);
                if (lblYer.Text==".")
                {
                guncelle.Parameters.AddWithValue("@foto", lblYer.Text);
                }
                else
                {
                    guncelle.Parameters.AddWithValue("@foto", lblYer.Text);
                }

                guncelle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yaptığınız Değişiklikler Kaydedildi");

                PersonelBilgileri.ep1 = txtEP1.Text;
                PersonelBilgileri.ep2 = txtEP2.Text;
                PersonelBilgileri.tel1 = txtTel1.Text;
                PersonelBilgileri.tel2 = txtTel2.Text;
                PersonelBilgileri.adres = txtAdres.Text;
                PersonelBilgileri.il = cbbIl.Text;
                PersonelBilgileri.ilce = cbbIlce.Text;
                PersonelBilgileri.Pfoto = lblYer.Text;

                pbxProfil.ImageLocation = lblYer.Text;
                pbxProfil.Load();

                AnaSayfa form = new AnaSayfa();
                form.pctB_kfoto.ImageLocation= lblYer.Text;
                form.pctB_kfoto.Load();

          /*  }
           catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }*/
          
        }

        private void txtGorev_TextChanged(object sender, EventArgs e)
        {

        }

        private void Profil_Load(object sender, EventArgs e)
        {
            txtTckn.Text = PersonelBilgileri.tc;
            txtAd.Text = PersonelBilgileri.Pad;
            txtSAd.Text = PersonelBilgileri.Psad;
            txtDt.Text = PersonelBilgileri.dt.ToString();
            txtGorev.Text = PersonelBilgileri.gorev;
            txtEP1.Text = PersonelBilgileri.ep1;
            txtEP2.Text = PersonelBilgileri.ep2;
            txtTel1.Text = PersonelBilgileri.tel1;
            txtTel2.Text =PersonelBilgileri.tel2;
            txtAdres.Text = PersonelBilgileri.adres;
            cbbIl.Text = PersonelBilgileri.il;
            cbbIlce.Text = PersonelBilgileri.ilce;
            pbxProfil.ImageLocation = PersonelBilgileri.Pfoto;
            lblYer.Text = PersonelBilgileri.Pfoto;
            pbxProfil.Load();

            if (PersonelBilgileri.cinsiyet == "Kadın")
            {
                rbKadin.Checked = true;
            }
            else 
            { 
                rbErkek.Checked = true;
            }            
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            txtEP1.Text = PersonelBilgileri.ep1;
            txtEP2.Text = PersonelBilgileri.ep2;
            txtTel1.Text = (PersonelBilgileri.tel1);
            txtTel2.Text = (PersonelBilgileri.tel2);
            txtAdres.Text = PersonelBilgileri.adres;
            cbbIl.Text = PersonelBilgileri.il;
            cbbIlce.Text = PersonelBilgileri.ilce;
            pbxProfil.ImageLocation = lblYer.Text;
        }

        private void cbbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void txtEP2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
