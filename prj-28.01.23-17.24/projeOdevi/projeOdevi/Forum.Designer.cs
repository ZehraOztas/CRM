namespace projeOdevi
{
    partial class Forum
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
            this.components = new System.ComponentModel.Container();
            this.cRMDataSet7 = new projeOdevi.CRMDataSet7();
            this.cRMDataSet8 = new projeOdevi.CRMDataSet8();
            this.pnlMailGonder = new System.Windows.Forms.Panel();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEKdosaya = new System.Windows.Forms.Button();
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtIcerik = new System.Windows.Forms.TextBox();
            this.lblKonum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRMDataSet9 = new projeOdevi.CRMDataSet9();
            this.musteriTableAdapter = new projeOdevi.CRMDataSet9TableAdapters.MusteriTableAdapter();
            this.isim = new projeOdevi.isim();
            this.isimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.İsimTableAdapter = new projeOdevi.isimTableAdapters.İsimTableAdapter();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.pnlforum = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet8)).BeginInit();
            this.pnlMailGonder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isimBindingSource)).BeginInit();
            this.pnlforum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cRMDataSet7
            // 
            this.cRMDataSet7.DataSetName = "CRMDataSet7";
            this.cRMDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cRMDataSet8
            // 
            this.cRMDataSet8.DataSetName = "CRMDataSet8";
            this.cRMDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlMailGonder
            // 
            this.pnlMailGonder.Controls.Add(this.txtAd);
            this.pnlMailGonder.Controls.Add(this.txtBaslik);
            this.pnlMailGonder.Controls.Add(this.txtMail);
            this.pnlMailGonder.Controls.Add(this.label1);
            this.pnlMailGonder.Controls.Add(this.btnEKdosaya);
            this.pnlMailGonder.Controls.Add(this.btnGonder);
            this.pnlMailGonder.Controls.Add(this.txtIcerik);
            this.pnlMailGonder.Controls.Add(this.lblKonum);
            this.pnlMailGonder.Controls.Add(this.label3);
            this.pnlMailGonder.Controls.Add(this.label2);
            this.pnlMailGonder.Controls.Add(this.lblAd);
            this.pnlMailGonder.Location = new System.Drawing.Point(1, 1);
            this.pnlMailGonder.Name = "pnlMailGonder";
            this.pnlMailGonder.Size = new System.Drawing.Size(1138, 626);
            this.pnlMailGonder.TabIndex = 2;
            this.pnlMailGonder.Visible = false;
            this.pnlMailGonder.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMailGonder_Paint);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(157, 50);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(447, 25);
            this.txtAd.TabIndex = 12;
            // 
            // txtBaslik
            // 
            this.txtBaslik.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBaslik.Location = new System.Drawing.Point(158, 116);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(446, 25);
            this.txtBaslik.TabIndex = 11;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(157, 84);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(446, 25);
            this.txtMail.TabIndex = 10;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mail Adresi:";
            // 
            // btnEKdosaya
            // 
            this.btnEKdosaya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnEKdosaya.Enabled = false;
            this.btnEKdosaya.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEKdosaya.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEKdosaya.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEKdosaya.Location = new System.Drawing.Point(612, 332);
            this.btnEKdosaya.Name = "btnEKdosaya";
            this.btnEKdosaya.Size = new System.Drawing.Size(29, 26);
            this.btnEKdosaya.TabIndex = 8;
            this.btnEKdosaya.Text = "...";
            this.btnEKdosaya.UseVisualStyleBackColor = false;
            this.btnEKdosaya.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnGonder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGonder.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGonder.Location = new System.Drawing.Point(514, 394);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(89, 33);
            this.btnGonder.TabIndex = 7;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtIcerik
            // 
            this.txtIcerik.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIcerik.Location = new System.Drawing.Point(159, 156);
            this.txtIcerik.Multiline = true;
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(447, 202);
            this.txtIcerik.TabIndex = 6;
            // 
            // lblKonum
            // 
            this.lblKonum.AutoSize = true;
            this.lblKonum.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKonum.Location = new System.Drawing.Point(156, 361);
            this.lblKonum.Name = "lblKonum";
            this.lblKonum.Size = new System.Drawing.Size(52, 18);
            this.lblKonum.TabIndex = 3;
            this.lblKonum.Text = "Konum:";
            this.lblKonum.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(76, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "İçerik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(77, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Başlık:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(62, 57);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(57, 18);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Alıcı Adı:";
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "Musteri";
            this.musteriBindingSource.DataSource = this.cRMDataSet9;
            // 
            // cRMDataSet9
            // 
            this.cRMDataSet9.DataSetName = "CRMDataSet9";
            this.cRMDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // isim
            // 
            this.isim.DataSetName = "isim";
            this.isim.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // isimBindingSource
            // 
            this.isimBindingSource.DataMember = "İsim";
            this.isimBindingSource.DataSource = this.isim;
            // 
            // İsimTableAdapter
            // 
            this.İsimTableAdapter.ClearBeforeFill = true;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // pnlforum
            // 
            this.pnlforum.Controls.Add(this.comboBox1);
            this.pnlforum.Controls.Add(this.dataGridView1);
            this.pnlforum.Location = new System.Drawing.Point(1, 1);
            this.pnlforum.Name = "pnlforum";
            this.pnlforum.Size = new System.Drawing.Size(1138, 626);
            this.pnlforum.TabIndex = 3;
            this.pnlforum.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlforum_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(480, 26);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1114, 521);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Forum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1138, 627);
            this.Controls.Add(this.pnlMailGonder);
            this.Controls.Add(this.pnlforum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Forum";
            this.Text = "Forumcs";
            this.Load += new System.EventHandler(this.Forum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet8)).EndInit();
            this.pnlMailGonder.ResumeLayout(false);
            this.pnlMailGonder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isimBindingSource)).EndInit();
            this.pnlforum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CRMDataSet7 cRMDataSet7;
        private CRMDataSet8 cRMDataSet8;
        private System.Windows.Forms.Panel pnlMailGonder;
        private System.Windows.Forms.Button btnEKdosaya;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtIcerik;
        private System.Windows.Forms.Label lblKonum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaslik;
        private CRMDataSet9 cRMDataSet9;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private CRMDataSet9TableAdapters.MusteriTableAdapter musteriTableAdapter;
        private isim isim;
        private System.Windows.Forms.BindingSource isimBindingSource;
        private isimTableAdapters.İsimTableAdapter İsimTableAdapter;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Panel pnlforum;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAd;
    }
}