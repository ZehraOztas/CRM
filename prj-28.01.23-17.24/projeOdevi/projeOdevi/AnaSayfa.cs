using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeOdevi
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        public void cikisYap()
        {
            DialogResult cevap = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?", "Çıkış Yap", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (cevap == DialogResult.OK)
            {
                Application.Exit();
            }
            PersonelBilgileri.Pad = "";
            PersonelBilgileri.Psad = "";
            PersonelBilgileri.pid = 0;
            PersonelBilgileri.Pfoto = "";
            PersonelBilgileri.adres = "";
            PersonelBilgileri.cinsiyet = "";
            PersonelBilgileri.dt = DateTime.MinValue;
            PersonelBilgileri.ep1 = "";
            PersonelBilgileri.ep2 = "";
            PersonelBilgileri.il = "";
            PersonelBilgileri.ilce = "";
            PersonelBilgileri.sifre = "";
            PersonelBilgileri.tc = "";
            PersonelBilgileri.yetki = -1;

        }
        public void UzunMenuAc()
        {
            pnlKısaMenu.Visible = false;
            pnlUzunMenu.Visible = true;

          /*  pnlGecis.Width = 1140;
            pnlGecis.Height = 629;
            pnlGecis.Location = new Point(197, 89);*/
        }

        public void KısaMenuAc()
        {
            pnlKısaMenu.Visible = true;
            pnlUzunMenu.Visible = false;

          /*  pnlGecis.Width = 1257;
            pnlGecis.Height = 629;
            pnlGecis.Location = new Point(80, 89);*/
        }

        private void FormGetir(Form f)
        {
            pnlGecis.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            // f.FormBorderStyle = FormBorderStyle.None; //Forma hareketsizlik salıyor.
            pnlGecis.Controls.Add(f); // panel içinde açılmasını sağlıyor.
            f.Show();
        }

        private void btnKmenu_Click(object sender, EventArgs e)
        {
            UzunMenuAc();
        }

        private void btnUmenu_Click(object sender, EventArgs e)
        {
            KısaMenuAc();
        }

        private void cks_Click(object sender, EventArgs e)
        {
            cikisYap();
            
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            cikisYap();
           
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            cikisYap();
            
        }

        private void btnUmenu_MouseHover(object sender, EventArgs e)
        {
            btnUmenu.BackColor = Color.FromArgb(20, 40, 57);
        }

        private void btnUprf_MouseHover(object sender, EventArgs e)
        {
            btnUprf.BackColor = Color.FromArgb(20, 40, 57);
        }

        private void btnUmus_MouseHover(object sender, EventArgs e)
        {
            btnUmus.BackColor = Color.FromArgb(20, 40, 57);
        }

        private void btnUislem_MouseHover(object sender, EventArgs e)
        {
            btnUislem.BackColor = Color.FromArgb(20, 40, 57);
        }

        private void btnUfrm_MouseHover(object sender, EventArgs e)
        {
            btnUfrm.BackColor = Color.FromArgb(20, 40, 57);
        }

        private void btnKmenu_MouseHover(object sender, EventArgs e)
        {
            btnKmenu.BackColor = Color.FromArgb(20, 40, 57);
        }

        private void btnKprf_MouseHover(object sender, EventArgs e)
        {
            btnKprf.BackColor = Color.FromArgb(20, 40, 57);
        }

        private void btnKmus_MouseHover(object sender, EventArgs e)
        {
            btnKmus.BackColor = Color.FromArgb(20, 40, 57);
        }

        private void btnKislem_MouseHover(object sender, EventArgs e)
        {
            btnKislem.BackColor = Color.FromArgb(20, 40, 57);
        }

        private void btnKfrm_MouseHover(object sender, EventArgs e)
        {
            btnKfrm.BackColor = Color.FromArgb(20, 40, 57);
        }

        private void btnKmenu_MouseLeave(object sender, EventArgs e)
        {
            btnKmenu.BackColor = Color.FromArgb(26, 55, 77);
        }

        private void btnKprf_Click(object sender, EventArgs e)
        {
           
            Profil ekle = new Profil();
            FormGetir(ekle);
        }

        private void btnKprf_MouseLeave(object sender, EventArgs e)
        {
            btnKprf.BackColor = Color.FromArgb(26, 55, 77);
        }

        private void btnKmus_MouseLeave(object sender, EventArgs e)
        {
            btnKmus.BackColor = Color.FromArgb(26, 55, 77);
        }

        private void btnKislem_MouseLeave(object sender, EventArgs e)
        {
            btnKislem.BackColor = Color.FromArgb(26, 55, 77);
        }

        private void btnKfrm_MouseLeave(object sender, EventArgs e)
        {
            btnKfrm.BackColor = Color.FromArgb(26, 55, 77);
        }

        private void btnUmenu_MouseLeave(object sender, EventArgs e)
        {
            btnUmenu.BackColor = Color.FromArgb(26, 55, 77);
        }

        private void btnUprf_MouseLeave(object sender, EventArgs e)
        {
            btnUprf.BackColor = Color.FromArgb(26, 55, 77);
        }

        private void btnUmus_MouseLeave(object sender, EventArgs e)
        {
            btnUmus.BackColor = Color.FromArgb(26, 55, 77);
        }

        private void btnUislem_MouseLeave(object sender, EventArgs e)
        {
            btnUislem.BackColor = Color.FromArgb(26, 55, 77);
        }

        private void btnUfrm_MouseLeave(object sender, EventArgs e)
        {
            btnUfrm.BackColor = Color.FromArgb(26, 55, 77);
        }

        private void pctB_kfoto_Click(object sender, EventArgs e)
        {
            
            if (pnlAcilis.Visible == true)
            {
                pnlAcilis.Visible = false;
            }
            else
            {
                pnlAcilis.Visible = true;
            }

            
        }

        private void lblKad_Click(object sender, EventArgs e)
        {
            if (pnlAcilis.Visible == true)
            {
                pnlAcilis.Visible = false;
            }
            else
            {
                pnlAcilis.Visible = true;
            }
        }

        private void btnProfil_MouseHover(object sender, EventArgs e)
        {
            btnProfil.BackColor = Color.FromArgb(20, 40, 57);
        }

        private void btnSifre_MouseHover(object sender, EventArgs e)
        {
            btnSifre.BackColor = Color.FromArgb(20, 40, 57);
        }

        private void btnOturum_MouseHover(object sender, EventArgs e)
        {
            btnOturum.BackColor = Color.FromArgb(20, 40, 57);
        }

        private void btnProfil_MouseLeave(object sender, EventArgs e)
        {
            btnProfil.BackColor = Color.FromArgb(26, 55, 77);
        }

        private void btnSifre_MouseLeave(object sender, EventArgs e)
        {
            btnSifre.BackColor = Color.FromArgb(26, 55, 77);
        }

        private void btnOturum_MouseLeave(object sender, EventArgs e)
        {
            btnOturum.BackColor = Color.FromArgb(26, 55, 77);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblKad.Text = PersonelBilgileri.Pad+"  "+PersonelBilgileri.Psad;
            
            pctB_kfoto.ImageLocation = PersonelBilgileri.Pfoto;
            pctB_kfoto.Load();
        }

        private void pnlAcilis_MouseHover(object sender, EventArgs e)
        {
       
        }

        private void btnUprf_Click(object sender, EventArgs e)
        {
            KısaMenuAc();
            Profil ekle = new Profil();
            FormGetir(ekle);
           
        }

        private void btnUmus_Click(object sender, EventArgs e)
        {
            KısaMenuAc();
            Musteriler form = new Musteriler();
            FormGetir(form);
        }

        private void btnUislem_Click(object sender, EventArgs e)
        {
            KısaMenuAc();
            Islemler f = new Islemler();
            FormGetir(f);
        }

        private void btnUfrm_Click(object sender, EventArgs e)
        {
            KısaMenuAc();
            Forum form = new Forum();
            FormGetir(form);
        }

        private void btnKmus_Click(object sender, EventArgs e)
        {
            Musteriler form = new Musteriler();
            FormGetir(form);
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Profil form = new Profil();
            FormGetir(form);
            pnlAcilis.Visible= false;
        }

        private void pnlGecis_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOturum_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Oturumu kapatmak istiyor musunuz?", "Oturumu Kapat", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (cevap == DialogResult.OK)
            {
                login frm = new login();
                frm.ShowDialog();
                this.Hide();
            }
            PersonelBilgileri.Pad = "";
            PersonelBilgileri.Psad = "";
            PersonelBilgileri.pid = 0;
            PersonelBilgileri.Pfoto = "";
            PersonelBilgileri.adres = "";
            PersonelBilgileri.cinsiyet = "";
            PersonelBilgileri.dt = DateTime.MinValue;
            PersonelBilgileri.ep1 = "";
            PersonelBilgileri.ep2 = "";
            PersonelBilgileri.il = "";
            PersonelBilgileri.ilce = "";
            PersonelBilgileri.sifre = "";
            PersonelBilgileri.tc = "";
            PersonelBilgileri.yetki = -1;

        }

        private void btnSifre_Click(object sender, EventArgs e)
        {
            SifreDegistir f = new SifreDegistir();
            FormGetir(f);
            pnlAcilis.Visible= false;
        }

        private void btnKislem_Click(object sender, EventArgs e)
        {
            Islemler f = new Islemler();
            FormGetir(f);
        }

        private void btnKfrm_Click(object sender, EventArgs e)
        {
            Forum form = new Forum();
            FormGetir(form);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
