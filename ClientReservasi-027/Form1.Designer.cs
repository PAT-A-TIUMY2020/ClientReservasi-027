namespace ClientReservasi_027
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtPemesanan = new System.Windows.Forms.DataGridView();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxNoTlf = new System.Windows.Forms.TextBox();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.textBoxIDLokasi = new System.Windows.Forms.TextBox();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btHapus = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.wCFReservasiDataSet1 = new ClientReservasi_027.WCFReservasiDataSet1();
            this.pemesananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pemesananTableAdapter = new ClientReservasi_027.WCFReservasiDataSet1TableAdapters.PemesananTableAdapter();
            this.wCFReservasiDataSet = new ClientReservasi_027.WCFReservasiDataSet();
            this.wCFReservasiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wCFReservasiDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pemesananBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pemesananTableAdapter1 = new ClientReservasi_027.WCFReservasiDataSetTableAdapters.PemesananTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtPemesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wCFReservasiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesananBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wCFReservasiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wCFReservasiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wCFReservasiDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesananBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Reservasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "No Telfon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "JumlahPemesanan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Lokasi";
            // 
            // dtPemesanan
            // 
            this.dtPemesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPemesanan.Location = new System.Drawing.Point(45, 275);
            this.dtPemesanan.Name = "dtPemesanan";
            this.dtPemesanan.RowTemplate.Height = 24;
            this.dtPemesanan.Size = new System.Drawing.Size(660, 150);
            this.dtPemesanan.TabIndex = 5;
            this.dtPemesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPemesanan_CellContentClick);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(203, 35);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(325, 22);
            this.textBoxID.TabIndex = 6;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(202, 78);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(326, 22);
            this.textBoxNama.TabIndex = 7;
            // 
            // textBoxNoTlf
            // 
            this.textBoxNoTlf.Location = new System.Drawing.Point(203, 123);
            this.textBoxNoTlf.Name = "textBoxNoTlf";
            this.textBoxNoTlf.Size = new System.Drawing.Size(325, 22);
            this.textBoxNoTlf.TabIndex = 8;
            this.textBoxNoTlf.TextChanged += new System.EventHandler(this.textBoxNoTlf_TextChanged);
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Location = new System.Drawing.Point(202, 167);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(326, 22);
            this.textBoxJumlah.TabIndex = 9;
            this.textBoxJumlah.TextChanged += new System.EventHandler(this.textBoxJumlah_TextChanged);
            // 
            // textBoxIDLokasi
            // 
            this.textBoxIDLokasi.Location = new System.Drawing.Point(203, 214);
            this.textBoxIDLokasi.Name = "textBoxIDLokasi";
            this.textBoxIDLokasi.Size = new System.Drawing.Size(325, 22);
            this.textBoxIDLokasi.TabIndex = 10;
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(595, 42);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(75, 23);
            this.btSimpan.TabIndex = 11;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(595, 98);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 12;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(595, 159);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(75, 23);
            this.btHapus.TabIndex = 13;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(595, 220);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 14;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // wCFReservasiDataSet1
            // 
            this.wCFReservasiDataSet1.DataSetName = "WCFReservasiDataSet1";
            this.wCFReservasiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pemesananBindingSource
            // 
            this.pemesananBindingSource.DataMember = "Pemesanan";
            this.pemesananBindingSource.DataSource = this.wCFReservasiDataSet1;
            // 
            // pemesananTableAdapter
            // 
            this.pemesananTableAdapter.ClearBeforeFill = true;
            // 
            // wCFReservasiDataSet
            // 
            this.wCFReservasiDataSet.DataSetName = "WCFReservasiDataSet";
            this.wCFReservasiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wCFReservasiDataSetBindingSource
            // 
            this.wCFReservasiDataSetBindingSource.DataSource = this.wCFReservasiDataSet;
            this.wCFReservasiDataSetBindingSource.Position = 0;
            // 
            // wCFReservasiDataSetBindingSource1
            // 
            this.wCFReservasiDataSetBindingSource1.DataSource = this.wCFReservasiDataSet;
            this.wCFReservasiDataSetBindingSource1.Position = 0;
            // 
            // pemesananBindingSource1
            // 
            this.pemesananBindingSource1.DataMember = "Pemesanan";
            this.pemesananBindingSource1.DataSource = this.wCFReservasiDataSetBindingSource;
            // 
            // pemesananTableAdapter1
            // 
            this.pemesananTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.textBoxIDLokasi);
            this.Controls.Add(this.textBoxJumlah);
            this.Controls.Add(this.textBoxNoTlf);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.dtPemesanan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPemesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wCFReservasiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesananBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wCFReservasiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wCFReservasiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wCFReservasiDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesananBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtPemesanan;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxNoTlf;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.TextBox textBoxIDLokasi;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btClear;
        private WCFReservasiDataSet1 wCFReservasiDataSet1;
        private System.Windows.Forms.BindingSource pemesananBindingSource;
        private WCFReservasiDataSet1TableAdapters.PemesananTableAdapter pemesananTableAdapter;
        private System.Windows.Forms.BindingSource wCFReservasiDataSetBindingSource;
        private WCFReservasiDataSet wCFReservasiDataSet;
        private System.Windows.Forms.BindingSource wCFReservasiDataSetBindingSource1;
        private System.Windows.Forms.BindingSource pemesananBindingSource1;
        private WCFReservasiDataSetTableAdapters.PemesananTableAdapter pemesananTableAdapter1;
    }
}

