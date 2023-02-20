namespace projeOdevi
{
    partial class Islemler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.dtIslemler = new System.Windows.Forms.DataGridView();
            this.cbxSec = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtIslemler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(13, 51);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(367, 25);
            this.txtAra.TabIndex = 0;
            this.txtAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYenile.Image = global::projeOdevi.Properties.Resources.refresh_arrow;
            this.btnYenile.Location = new System.Drawing.Point(426, 49);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(33, 28);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAra.Image = global::projeOdevi.Properties.Resources.loupe;
            this.btnAra.Location = new System.Drawing.Point(387, 50);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(33, 28);
            this.btnAra.TabIndex = 1;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // dtIslemler
            // 
            this.dtIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtIslemler.Location = new System.Drawing.Point(12, 100);
            this.dtIslemler.Name = "dtIslemler";
            this.dtIslemler.Size = new System.Drawing.Size(1071, 457);
            this.dtIslemler.TabIndex = 5;
            // 
            // cbxSec
            // 
            this.cbxSec.FormattingEnabled = true;
            this.cbxSec.Items.AddRange(new object[] {
            "Seçiniz",
            "Görüşülüyor",
            "Teklif Sunuldu",
            "Teklif Reddedildi",
            "Sözleşme Hazırlanıyor",
            "Anlaşma İmzalandı",
            "Sipariş Verildi",
            "Üretim Aşamasında",
            "Yola Çıktı",
            "Teslim Edildi",
            "Ürün Durumu Hakkında Görüşmeler Yapılıyor",
            "Tamamlandı"});
            this.cbxSec.Location = new System.Drawing.Point(761, 54);
            this.cbxSec.Name = "cbxSec";
            this.cbxSec.Size = new System.Drawing.Size(321, 21);
            this.cbxSec.TabIndex = 6;
            this.cbxSec.Text = "Seçiniz..";
            this.cbxSec.SelectedIndexChanged += new System.EventHandler(this.cbxSec_SelectedIndexChanged);
            // 
            // Islemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1122, 588);
            this.Controls.Add(this.cbxSec);
            this.Controls.Add(this.dtIslemler);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Islemler";
            this.Text = "Islemler";
            this.Load += new System.EventHandler(this.Islemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtIslemler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.DataGridView dtIslemler;
        private System.Windows.Forms.ComboBox cbxSec;
    }
}