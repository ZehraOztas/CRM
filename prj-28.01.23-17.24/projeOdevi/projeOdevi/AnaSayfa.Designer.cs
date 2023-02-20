namespace projeOdevi
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kapat = new System.Windows.Forms.PictureBox();
            this.pnlKullanici = new System.Windows.Forms.Panel();
            this.lblKad = new System.Windows.Forms.Label();
            this.pctB_kfoto = new System.Windows.Forms.PictureBox();
            this.pnlKısaMenu = new System.Windows.Forms.Panel();
            this.cks = new System.Windows.Forms.PictureBox();
            this.btnKfrm = new System.Windows.Forms.Button();
            this.btnKmenu = new System.Windows.Forms.Button();
            this.btnKislem = new System.Windows.Forms.Button();
            this.btnKprf = new System.Windows.Forms.Button();
            this.btnKmus = new System.Windows.Forms.Button();
            this.pnlUzunMenu = new System.Windows.Forms.Panel();
            this.cikis = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUfrm = new System.Windows.Forms.Button();
            this.btnUmenu = new System.Windows.Forms.Button();
            this.btnUislem = new System.Windows.Forms.Button();
            this.btnUmus = new System.Windows.Forms.Button();
            this.btnUprf = new System.Windows.Forms.Button();
            this.pnlAcilis = new System.Windows.Forms.Panel();
            this.btnOturum = new System.Windows.Forms.Button();
            this.btnSifre = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.pnlGecis = new System.Windows.Forms.Panel();
            this.pnlArkaPlan = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapat)).BeginInit();
            this.pnlKullanici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctB_kfoto)).BeginInit();
            this.pnlKısaMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cks)).BeginInit();
            this.pnlUzunMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).BeginInit();
            this.pnlAcilis.SuspendLayout();
            this.pnlArkaPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.kapat);
            this.panel2.Controls.Add(this.pnlKullanici);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1347, 92);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::projeOdevi.Properties.Resources.minus_sign_of_a_line_in_horizontal_position;
            this.pictureBox2.Location = new System.Drawing.Point(1282, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // kapat
            // 
            this.kapat.ErrorImage = null;
            this.kapat.Image = global::projeOdevi.Properties.Resources.close;
            this.kapat.Location = new System.Drawing.Point(1311, 12);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(15, 16);
            this.kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kapat.TabIndex = 0;
            this.kapat.TabStop = false;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // pnlKullanici
            // 
            this.pnlKullanici.Controls.Add(this.lblKad);
            this.pnlKullanici.Controls.Add(this.pctB_kfoto);
            this.pnlKullanici.Location = new System.Drawing.Point(1096, 19);
            this.pnlKullanici.Name = "pnlKullanici";
            this.pnlKullanici.Size = new System.Drawing.Size(238, 69);
            this.pnlKullanici.TabIndex = 2;
            // 
            // lblKad
            // 
            this.lblKad.AutoSize = true;
            this.lblKad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKad.Location = new System.Drawing.Point(79, 41);
            this.lblKad.Name = "lblKad";
            this.lblKad.Size = new System.Drawing.Size(86, 18);
            this.lblKad.TabIndex = 1;
            this.lblKad.Text = "Kullanıcı Adı";
            this.lblKad.Click += new System.EventHandler(this.lblKad_Click);
            // 
            // pctB_kfoto
            // 
            this.pctB_kfoto.Image = global::projeOdevi.Properties.Resources.profile;
            this.pctB_kfoto.Location = new System.Drawing.Point(6, 10);
            this.pctB_kfoto.Name = "pctB_kfoto";
            this.pctB_kfoto.Size = new System.Drawing.Size(67, 59);
            this.pctB_kfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctB_kfoto.TabIndex = 0;
            this.pctB_kfoto.TabStop = false;
            this.pctB_kfoto.Click += new System.EventHandler(this.pctB_kfoto_Click);
            // 
            // pnlKısaMenu
            // 
            this.pnlKısaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.pnlKısaMenu.Controls.Add(this.cks);
            this.pnlKısaMenu.Controls.Add(this.btnKfrm);
            this.pnlKısaMenu.Controls.Add(this.btnKmenu);
            this.pnlKısaMenu.Controls.Add(this.btnKislem);
            this.pnlKısaMenu.Controls.Add(this.btnKprf);
            this.pnlKısaMenu.Controls.Add(this.btnKmus);
            this.pnlKısaMenu.Location = new System.Drawing.Point(1, 92);
            this.pnlKısaMenu.Name = "pnlKısaMenu";
            this.pnlKısaMenu.Size = new System.Drawing.Size(83, 636);
            this.pnlKısaMenu.TabIndex = 8;
            // 
            // cks
            // 
            this.cks.ErrorImage = null;
            this.cks.Image = global::projeOdevi.Properties.Resources.logout;
            this.cks.Location = new System.Drawing.Point(44, 591);
            this.cks.Name = "cks";
            this.cks.Size = new System.Drawing.Size(19, 24);
            this.cks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cks.TabIndex = 12;
            this.cks.TabStop = false;
            this.cks.Click += new System.EventHandler(this.cks_Click);
            // 
            // btnKfrm
            // 
            this.btnKfrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnKfrm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKfrm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKfrm.Image = global::projeOdevi.Properties.Resources.typing;
            this.btnKfrm.Location = new System.Drawing.Point(-1, 234);
            this.btnKfrm.Name = "btnKfrm";
            this.btnKfrm.Size = new System.Drawing.Size(84, 59);
            this.btnKfrm.TabIndex = 5;
            this.btnKfrm.UseVisualStyleBackColor = false;
            this.btnKfrm.Click += new System.EventHandler(this.btnKfrm_Click);
            this.btnKfrm.MouseLeave += new System.EventHandler(this.btnKfrm_MouseLeave);
            this.btnKfrm.MouseHover += new System.EventHandler(this.btnKfrm_MouseHover);
            // 
            // btnKmenu
            // 
            this.btnKmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnKmenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKmenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKmenu.Image = global::projeOdevi.Properties.Resources.menu;
            this.btnKmenu.Location = new System.Drawing.Point(-1, 1);
            this.btnKmenu.Name = "btnKmenu";
            this.btnKmenu.Size = new System.Drawing.Size(84, 59);
            this.btnKmenu.TabIndex = 2;
            this.btnKmenu.UseVisualStyleBackColor = false;
            this.btnKmenu.Click += new System.EventHandler(this.btnKmenu_Click);
            this.btnKmenu.MouseLeave += new System.EventHandler(this.btnKmenu_MouseLeave);
            this.btnKmenu.MouseHover += new System.EventHandler(this.btnKmenu_MouseHover);
            // 
            // btnKislem
            // 
            this.btnKislem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnKislem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKislem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKislem.Image = global::projeOdevi.Properties.Resources.to_do_list1;
            this.btnKislem.Location = new System.Drawing.Point(-1, 177);
            this.btnKislem.Name = "btnKislem";
            this.btnKislem.Size = new System.Drawing.Size(84, 59);
            this.btnKislem.TabIndex = 4;
            this.btnKislem.UseVisualStyleBackColor = false;
            this.btnKislem.Click += new System.EventHandler(this.btnKislem_Click);
            this.btnKislem.MouseLeave += new System.EventHandler(this.btnKislem_MouseLeave);
            this.btnKislem.MouseHover += new System.EventHandler(this.btnKislem_MouseHover);
            // 
            // btnKprf
            // 
            this.btnKprf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnKprf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKprf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKprf.Image = global::projeOdevi.Properties.Resources.user__3_;
            this.btnKprf.Location = new System.Drawing.Point(-1, 60);
            this.btnKprf.Name = "btnKprf";
            this.btnKprf.Size = new System.Drawing.Size(84, 59);
            this.btnKprf.TabIndex = 2;
            this.btnKprf.UseVisualStyleBackColor = false;
            this.btnKprf.Click += new System.EventHandler(this.btnKprf_Click);
            this.btnKprf.MouseLeave += new System.EventHandler(this.btnKprf_MouseLeave);
            this.btnKprf.MouseHover += new System.EventHandler(this.btnKprf_MouseHover);
            // 
            // btnKmus
            // 
            this.btnKmus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnKmus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKmus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKmus.Image = global::projeOdevi.Properties.Resources.personal_data;
            this.btnKmus.Location = new System.Drawing.Point(-1, 119);
            this.btnKmus.Name = "btnKmus";
            this.btnKmus.Size = new System.Drawing.Size(84, 59);
            this.btnKmus.TabIndex = 3;
            this.btnKmus.UseVisualStyleBackColor = false;
            this.btnKmus.Click += new System.EventHandler(this.btnKmus_Click);
            this.btnKmus.MouseLeave += new System.EventHandler(this.btnKmus_MouseLeave);
            this.btnKmus.MouseHover += new System.EventHandler(this.btnKmus_MouseHover);
            // 
            // pnlUzunMenu
            // 
            this.pnlUzunMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.pnlUzunMenu.Controls.Add(this.cikis);
            this.pnlUzunMenu.Controls.Add(this.panel1);
            this.pnlUzunMenu.Controls.Add(this.btnUfrm);
            this.pnlUzunMenu.Controls.Add(this.btnUmenu);
            this.pnlUzunMenu.Controls.Add(this.btnUislem);
            this.pnlUzunMenu.Controls.Add(this.btnUmus);
            this.pnlUzunMenu.Controls.Add(this.btnUprf);
            this.pnlUzunMenu.Location = new System.Drawing.Point(1, 92);
            this.pnlUzunMenu.Name = "pnlUzunMenu";
            this.pnlUzunMenu.Size = new System.Drawing.Size(200, 636);
            this.pnlUzunMenu.TabIndex = 7;
            this.pnlUzunMenu.Visible = false;
            // 
            // cikis
            // 
            this.cikis.ErrorImage = null;
            this.cikis.Image = global::projeOdevi.Properties.Resources.logout;
            this.cikis.Location = new System.Drawing.Point(159, 591);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(19, 24);
            this.cikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cikis.TabIndex = 13;
            this.cikis.TabStop = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(197, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 58);
            this.panel1.TabIndex = 0;
            // 
            // btnUfrm
            // 
            this.btnUfrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnUfrm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUfrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUfrm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUfrm.Image = global::projeOdevi.Properties.Resources.typing;
            this.btnUfrm.Location = new System.Drawing.Point(-2, 233);
            this.btnUfrm.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnUfrm.Name = "btnUfrm";
            this.btnUfrm.Size = new System.Drawing.Size(202, 59);
            this.btnUfrm.TabIndex = 5;
            this.btnUfrm.Text = "  Forum";
            this.btnUfrm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUfrm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUfrm.UseVisualStyleBackColor = false;
            this.btnUfrm.Click += new System.EventHandler(this.btnUfrm_Click);
            this.btnUfrm.MouseLeave += new System.EventHandler(this.btnUfrm_MouseLeave);
            this.btnUfrm.MouseHover += new System.EventHandler(this.btnUfrm_MouseHover);
            // 
            // btnUmenu
            // 
            this.btnUmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnUmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUmenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUmenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUmenu.Image = global::projeOdevi.Properties.Resources.menu;
            this.btnUmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUmenu.Location = new System.Drawing.Point(3, 2);
            this.btnUmenu.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnUmenu.Name = "btnUmenu";
            this.btnUmenu.Size = new System.Drawing.Size(200, 59);
            this.btnUmenu.TabIndex = 2;
            this.btnUmenu.Text = "  Menü   ";
            this.btnUmenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUmenu.UseVisualStyleBackColor = false;
            this.btnUmenu.Click += new System.EventHandler(this.btnUmenu_Click);
            this.btnUmenu.MouseLeave += new System.EventHandler(this.btnUmenu_MouseLeave);
            this.btnUmenu.MouseHover += new System.EventHandler(this.btnUmenu_MouseHover);
            // 
            // btnUislem
            // 
            this.btnUislem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnUislem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUislem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUislem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUislem.Image = global::projeOdevi.Properties.Resources.to_do_list;
            this.btnUislem.Location = new System.Drawing.Point(0, 176);
            this.btnUislem.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnUislem.Name = "btnUislem";
            this.btnUislem.Size = new System.Drawing.Size(200, 59);
            this.btnUislem.TabIndex = 4;
            this.btnUislem.Text = "  İşlemler";
            this.btnUislem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUislem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUislem.UseVisualStyleBackColor = false;
            this.btnUislem.Click += new System.EventHandler(this.btnUislem_Click);
            this.btnUislem.MouseLeave += new System.EventHandler(this.btnUislem_MouseLeave);
            this.btnUislem.MouseHover += new System.EventHandler(this.btnUislem_MouseHover);
            // 
            // btnUmus
            // 
            this.btnUmus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnUmus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUmus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUmus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUmus.Image = global::projeOdevi.Properties.Resources.personal_data;
            this.btnUmus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUmus.Location = new System.Drawing.Point(0, 118);
            this.btnUmus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnUmus.Name = "btnUmus";
            this.btnUmus.Size = new System.Drawing.Size(200, 59);
            this.btnUmus.TabIndex = 3;
            this.btnUmus.Text = "  Müşteri";
            this.btnUmus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUmus.UseVisualStyleBackColor = false;
            this.btnUmus.Click += new System.EventHandler(this.btnUmus_Click);
            this.btnUmus.MouseLeave += new System.EventHandler(this.btnUmus_MouseLeave);
            this.btnUmus.MouseHover += new System.EventHandler(this.btnUmus_MouseHover);
            // 
            // btnUprf
            // 
            this.btnUprf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnUprf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUprf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUprf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUprf.Image = global::projeOdevi.Properties.Resources.user__3_;
            this.btnUprf.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUprf.Location = new System.Drawing.Point(0, 60);
            this.btnUprf.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnUprf.Name = "btnUprf";
            this.btnUprf.Size = new System.Drawing.Size(200, 59);
            this.btnUprf.TabIndex = 2;
            this.btnUprf.Text = "  Profil    ";
            this.btnUprf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUprf.UseVisualStyleBackColor = false;
            this.btnUprf.Click += new System.EventHandler(this.btnUprf_Click);
            this.btnUprf.MouseLeave += new System.EventHandler(this.btnUprf_MouseLeave);
            this.btnUprf.MouseHover += new System.EventHandler(this.btnUprf_MouseHover);
            // 
            // pnlAcilis
            // 
            this.pnlAcilis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.pnlAcilis.Controls.Add(this.btnOturum);
            this.pnlAcilis.Controls.Add(this.btnSifre);
            this.pnlAcilis.Controls.Add(this.btnProfil);
            this.pnlAcilis.Location = new System.Drawing.Point(1099, 92);
            this.pnlAcilis.Name = "pnlAcilis";
            this.pnlAcilis.Size = new System.Drawing.Size(240, 175);
            this.pnlAcilis.TabIndex = 15;
            this.pnlAcilis.Visible = false;
            this.pnlAcilis.MouseHover += new System.EventHandler(this.pnlAcilis_MouseHover);
            // 
            // btnOturum
            // 
            this.btnOturum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnOturum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOturum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOturum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOturum.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOturum.Location = new System.Drawing.Point(-1, 117);
            this.btnOturum.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnOturum.Name = "btnOturum";
            this.btnOturum.Size = new System.Drawing.Size(240, 59);
            this.btnOturum.TabIndex = 16;
            this.btnOturum.Text = "Oturumu Kapat";
            this.btnOturum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOturum.UseVisualStyleBackColor = false;
            this.btnOturum.Click += new System.EventHandler(this.btnOturum_Click);
            this.btnOturum.MouseLeave += new System.EventHandler(this.btnOturum_MouseLeave);
            this.btnOturum.MouseHover += new System.EventHandler(this.btnOturum_MouseHover);
            // 
            // btnSifre
            // 
            this.btnSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnSifre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSifre.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSifre.Location = new System.Drawing.Point(-1, 60);
            this.btnSifre.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnSifre.Name = "btnSifre";
            this.btnSifre.Size = new System.Drawing.Size(241, 59);
            this.btnSifre.TabIndex = 15;
            this.btnSifre.Text = "Şifre";
            this.btnSifre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSifre.UseVisualStyleBackColor = false;
            this.btnSifre.Click += new System.EventHandler(this.btnSifre_Click);
            this.btnSifre.MouseLeave += new System.EventHandler(this.btnSifre_MouseLeave);
            this.btnSifre.MouseHover += new System.EventHandler(this.btnSifre_MouseHover);
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProfil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProfil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProfil.Location = new System.Drawing.Point(-2, 3);
            this.btnProfil.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(241, 59);
            this.btnProfil.TabIndex = 14;
            this.btnProfil.Text = "Profil Bilgileri";
            this.btnProfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            this.btnProfil.MouseLeave += new System.EventHandler(this.btnProfil_MouseLeave);
            this.btnProfil.MouseHover += new System.EventHandler(this.btnProfil_MouseHover);
            // 
            // pnlGecis
            // 
            this.pnlGecis.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlGecis.Location = new System.Drawing.Point(201, 92);
            this.pnlGecis.Name = "pnlGecis";
            this.pnlGecis.Size = new System.Drawing.Size(1138, 633);
            this.pnlGecis.TabIndex = 16;
            this.pnlGecis.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGecis_Paint);
            // 
            // pnlArkaPlan
            // 
            this.pnlArkaPlan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlArkaPlan.Controls.Add(this.panel2);
            this.pnlArkaPlan.Controls.Add(this.pnlAcilis);
            this.pnlArkaPlan.Controls.Add(this.pnlKısaMenu);
            this.pnlArkaPlan.Controls.Add(this.pnlUzunMenu);
            this.pnlArkaPlan.Controls.Add(this.pnlGecis);
            this.pnlArkaPlan.Location = new System.Drawing.Point(-2, -3);
            this.pnlArkaPlan.Name = "pnlArkaPlan";
            this.pnlArkaPlan.Size = new System.Drawing.Size(1347, 726);
            this.pnlArkaPlan.TabIndex = 17;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1337, 719);
            this.Controls.Add(this.pnlArkaPlan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapat)).EndInit();
            this.pnlKullanici.ResumeLayout(false);
            this.pnlKullanici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctB_kfoto)).EndInit();
            this.pnlKısaMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cks)).EndInit();
            this.pnlUzunMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).EndInit();
            this.pnlAcilis.ResumeLayout(false);
            this.pnlArkaPlan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox kapat;
        private System.Windows.Forms.Panel pnlKısaMenu;
        private System.Windows.Forms.PictureBox cks;
        private System.Windows.Forms.Button btnKfrm;
        private System.Windows.Forms.Button btnKmenu;
        private System.Windows.Forms.Button btnKislem;
        private System.Windows.Forms.Button btnKprf;
        private System.Windows.Forms.Button btnKmus;
        private System.Windows.Forms.Panel pnlUzunMenu;
        private System.Windows.Forms.PictureBox cikis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUfrm;
        private System.Windows.Forms.Button btnUmenu;
        private System.Windows.Forms.Button btnUislem;
        private System.Windows.Forms.Button btnUprf;
        private System.Windows.Forms.Button btnUmus;
        private System.Windows.Forms.Button btnOturum;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnSifre;
        private System.Windows.Forms.Panel pnlGecis;
        public System.Windows.Forms.Panel pnlAcilis;
        public System.Windows.Forms.Label lblKad;
        public System.Windows.Forms.PictureBox pctB_kfoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel pnlKullanici;
        public System.Windows.Forms.Panel pnlArkaPlan;
    }
}

