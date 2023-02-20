using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Drawing.Text;
using System.Runtime.ConstrainedExecution;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel.DataAnnotations;

namespace projeOdevi
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }

        private void temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtBt.Clear();
            txtCyer.Clear();
            txtEp.Clear();
            txtGorev.Clear();
            txtMesaj.Clear();
            txtTel.Clear();
            txtSt.Clear();
            cbxDurum.Text = "";
            txtAd.Focus();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VJ6APHI\\SQLEXPRESS;Initial Catalog=CRM;Integrated Security=True");
        private void Musteriler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cRMDataSet6.Musteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musteriTableAdapter4.Fill(this.cRMDataSet6.Musteri);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            SqlCommand arama = new SqlCommand("SELECT * FROM Musteri WHERE ad LIKE '%'+ @ad+ '%'", baglanti);
            arama.Parameters.AddWithValue("@ad", txtArama.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(arama);
            da.Fill(dt);
            dtMusteri.DataSource = dt;
            baglanti.Open();
            arama.ExecuteNonQuery();
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtMusteri.Visible = false;
            pnlGiris.Visible = false;
            temizle();

            pnlKisiEkle.Visible = true;
            btnIptal.Visible = true;

            txtAd.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand ekle = new SqlCommand("INSERT INTO Musteri(ad,soyad,ep,tel,calistigi_yer,gorevi,baslangic_tarihi,iletisim_tarihi,mesaj,durum)VALUES(@ad,@sad,@ep,@tel,@cyer,@gorevi,@bt,@it,@mesaj,@durum)", baglanti);
                baglanti.Open();
                ekle.Parameters.AddWithValue("@ad", txtAd.Text);
                ekle.Parameters.AddWithValue("@sad", txtSoyad.Text);
                ekle.Parameters.AddWithValue("@ep", txtEp.Text);
                ekle.Parameters.AddWithValue("@tel", txtTel.Text);
                ekle.Parameters.AddWithValue("@cyer", txtCyer.Text);
                ekle.Parameters.AddWithValue("@gorevi", txtGorev.Text);
                ekle.Parameters.AddWithValue("@bt", value: System.Data.SqlDbType.Date).Value = Convert.ToDateTime(txtBt.Text);
                ekle.Parameters.AddWithValue("@it", value: System.Data.SqlDbType.Date).Value = Convert.ToDateTime(txtSt.Text);
                ekle.Parameters.AddWithValue("@mesaj", txtMesaj.Text);
                ekle.Parameters.AddWithValue("@durum", cbxDurum.Text);
                ekle.ExecuteNonQuery();
                MessageBox.Show("Başarıyla kaydedilmiştir.");
                temizle();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            baglanti.Close();
        }

        private void dtMusteri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            pnlKisiEkle.Visible = false;
            pnlGiris.Visible = true;
            dtMusteri.Visible = true;
            
        }

        private void pnlGiris_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtMusteri_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKisiSil_Click(object sender, EventArgs e)
        {           
            DialogResult cevap= MessageBox.Show("Seçili kişiyi silmek istiyor musunuz?","Silme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                foreach (DataGridViewRow drow in dtMusteri.SelectedRows)  //Seçili Satırları Silme
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    string sql = "DELETE FROM Musteri WHERE m_id=@id";
                    SqlCommand komut = new SqlCommand(sql, baglanti);
                    komut.Parameters.AddWithValue("@id", id);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                } 
                baglanti.Close();
                MessageBox.Show("Kayıt başarıyla silinmiştir.");
                this.musteriTableAdapter4.Fill(this.cRMDataSet6.Musteri);
            }
        }
        private void btnYenile_Click(object sender, EventArgs e)
        {
            pnlGuncelle.Visible = true;
            pnlGiris.Visible = false;
            dtMusteri.Visible = false;

            baglanti.Open();
            txtId.Text = dtMusteri.CurrentRow.Cells[0].Value.ToString();
            txtGad.Text = dtMusteri.CurrentRow.Cells[1].Value.ToString();
            txtGsad.Text = dtMusteri.CurrentRow.Cells[2].Value.ToString();
            txtGtel.Text = dtMusteri.CurrentRow.Cells[4].Value.ToString();
            txtGep.Text = dtMusteri.CurrentRow.Cells[3].Value.ToString();
            txtGcyer.Text = dtMusteri.CurrentRow.Cells[5].Value.ToString();
            txtGgorev.Text = dtMusteri.CurrentRow.Cells[6].Value.ToString();
            txtGbt.Text = dtMusteri.CurrentRow.Cells[7].Value.ToString();
            txtGit.Text = dtMusteri.CurrentRow.Cells[8].Value.ToString();
            cbxGdurum.Text = dtMusteri.CurrentRow.Cells[9].Value.ToString();
            baglanti.Close();

            txtGad.Focus();
        }

        private void pnlKisiEkle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGkapat_Click(object sender, EventArgs e)
        {
            pnlGuncelle.Visible= false;
            pnlGiris.Visible = true;
            dtMusteri.Visible = true;
            this.musteriTableAdapter4.Fill(this.cRMDataSet6.Musteri);
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void pnlGuncelle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("UPDATE Musteri SET ad=@ad, soyad=@sad, ep=@ep , tel=@tel, calistigi_yer=@cyer ,gorevi=@gorev ,baslangic_tarihi=@bt ,iletisim_tarihi=@it, durum=@durum WHERE m_id=@id",baglanti);
            update.Parameters.AddWithValue("@ad",txtGad.Text);
            update.Parameters.AddWithValue("@sad", txtGsad.Text);
            update.Parameters.AddWithValue("@ep", txtGep.Text);
            update.Parameters.AddWithValue("@tel", txtGtel.Text);
            update.Parameters.AddWithValue("@cyer", txtGcyer.Text);
            update.Parameters.AddWithValue("@gorev",txtGgorev.Text);
            update.Parameters.AddWithValue("@bt", Convert.ToDateTime(txtGbt.Text));
            update.Parameters.AddWithValue("@it", Convert.ToDateTime(txtGit.Text));
            update.Parameters.AddWithValue("@durum", cbxGdurum.Text);
            update.Parameters.AddWithValue("@id", txtId.Text);
            baglanti.Open();
            update.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yaptığınız değişiklikler başarıyla kaydedildi");
            txtGad.Clear();
            txtGsad.Clear();
            txtGbt.Clear();
            txtGcyer.Clear();
            txtGep.Clear();
            txtGgorev.Clear();
            txtGit.Clear();
            txtGorev.Clear();
            txtGtel.Clear();
            cbxGdurum.Text = "";
            txtGad.Focus();
            this.musteriTableAdapter4.Fill(this.cRMDataSet6.Musteri);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Gönderi İçin Ek Dosya Seçebilirsiniz.";
            ofd.ShowDialog();
            lblKonum.Text = ofd.FileName;
        }
    }
}