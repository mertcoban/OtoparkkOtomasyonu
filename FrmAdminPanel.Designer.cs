
namespace OtoparkOtomasyonu
{
    partial class FrmAdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblDoluYer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblBosYer = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSorgula = new System.Windows.Forms.Button();
            this.TxtPlaka = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblSorgu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.LblKullaniciad = new System.Windows.Forms.Label();
            this.BtnHasilat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnAboneGoruntu = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnKayitsizGir = new System.Windows.Forms.Button();
            this.BtnKayitsizCik = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.parkYeriBoyutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkYeriDurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkYeriSureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakakodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkYeriKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblParkYerleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoparkProjeDataSet5 = new OtoparkOtomasyonu.OtoparkProjeDataSet5();
            this.tbl_ParkYerleriTableAdapter = new OtoparkOtomasyonu.OtoparkProjeDataSet5TableAdapters.Tbl_ParkYerleriTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblParkYerleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkProjeDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblDoluYer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblBosYer);
            this.groupBox1.Controls.Add(this.Lbl1);
            this.groupBox1.Location = new System.Drawing.Point(477, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // LblDoluYer
            // 
            this.LblDoluYer.AutoSize = true;
            this.LblDoluYer.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDoluYer.Location = new System.Drawing.Point(181, 83);
            this.LblDoluYer.Name = "LblDoluYer";
            this.LblDoluYer.Size = new System.Drawing.Size(31, 24);
            this.LblDoluYer.TabIndex = 13;
            this.LblDoluYer.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dolu Yer :";
            // 
            // LblBosYer
            // 
            this.LblBosYer.AutoSize = true;
            this.LblBosYer.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBosYer.Location = new System.Drawing.Point(181, 37);
            this.LblBosYer.Name = "LblBosYer";
            this.LblBosYer.Size = new System.Drawing.Size(31, 24);
            this.LblBosYer.TabIndex = 9;
            this.LblBosYer.Text = "...";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl1.Location = new System.Drawing.Point(25, 37);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(102, 24);
            this.Lbl1.TabIndex = 8;
            this.Lbl1.Text = "Boş Yer :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Plaka  :";
            // 
            // BtnSorgula
            // 
            this.BtnSorgula.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSorgula.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSorgula.Location = new System.Drawing.Point(225, 79);
            this.BtnSorgula.Name = "BtnSorgula";
            this.BtnSorgula.Size = new System.Drawing.Size(111, 30);
            this.BtnSorgula.TabIndex = 11;
            this.BtnSorgula.Text = "Sorgula";
            this.BtnSorgula.UseVisualStyleBackColor = false;
            this.BtnSorgula.Click += new System.EventHandler(this.BtnSorgula_Click);
            // 
            // TxtPlaka
            // 
            this.TxtPlaka.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPlaka.Location = new System.Drawing.Point(162, 31);
            this.TxtPlaka.Name = "TxtPlaka";
            this.TxtPlaka.Size = new System.Drawing.Size(174, 30);
            this.TxtPlaka.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblSorgu);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtPlaka);
            this.groupBox2.Controls.Add(this.BtnSorgula);
            this.groupBox2.Location = new System.Drawing.Point(778, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 175);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // LblSorgu
            // 
            this.LblSorgu.AutoSize = true;
            this.LblSorgu.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSorgu.Location = new System.Drawing.Point(171, 123);
            this.LblSorgu.Name = "LblSorgu";
            this.LblSorgu.Size = new System.Drawing.Size(28, 23);
            this.LblSorgu.TabIndex = 13;
            this.LblSorgu.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(42, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "KONUM :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnCikis);
            this.groupBox3.Controls.Add(this.LblKullaniciad);
            this.groupBox3.Controls.Add(this.BtnHasilat);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(138, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 175);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.Red;
            this.BtnCikis.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.Location = new System.Drawing.Point(191, 69);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(120, 51);
            this.BtnCikis.TabIndex = 17;
            this.BtnCikis.Text = "ÇIKIŞ ";
            this.BtnCikis.UseVisualStyleBackColor = false;
            // 
            // LblKullaniciad
            // 
            this.LblKullaniciad.AutoSize = true;
            this.LblKullaniciad.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKullaniciad.Location = new System.Drawing.Point(187, 24);
            this.LblKullaniciad.Name = "LblKullaniciad";
            this.LblKullaniciad.Size = new System.Drawing.Size(27, 20);
            this.LblKullaniciad.TabIndex = 1;
            this.LblKullaniciad.Text = "...";
            // 
            // BtnHasilat
            // 
            this.BtnHasilat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnHasilat.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHasilat.Location = new System.Drawing.Point(6, 69);
            this.BtnHasilat.Name = "BtnHasilat";
            this.BtnHasilat.Size = new System.Drawing.Size(181, 51);
            this.BtnHasilat.TabIndex = 11;
            this.BtnHasilat.Text = "HASILAT RAPORU";
            this.BtnHasilat.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOŞGELDİN";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnSil);
            this.groupBox4.Controls.Add(this.BtnGuncelle);
            this.groupBox4.Controls.Add(this.BtnAboneGoruntu);
            this.groupBox4.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(7, 193);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(285, 239);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ABONELİK İŞLEMLERİ";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSil.Location = new System.Drawing.Point(47, 178);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(187, 55);
            this.BtnSil.TabIndex = 0;
            this.BtnSil.Text = "MÜŞTERİ SİL";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnGuncelle.Location = new System.Drawing.Point(47, 117);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(187, 55);
            this.BtnGuncelle.TabIndex = 0;
            this.BtnGuncelle.Text = "MÜŞTERİ GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnAboneGoruntu
            // 
            this.BtnAboneGoruntu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnAboneGoruntu.Location = new System.Drawing.Point(47, 56);
            this.BtnAboneGoruntu.Name = "BtnAboneGoruntu";
            this.BtnAboneGoruntu.Size = new System.Drawing.Size(187, 55);
            this.BtnAboneGoruntu.TabIndex = 0;
            this.BtnAboneGoruntu.Text = "MÜŞTERİLERİ GÖRÜNTÜLE";
            this.BtnAboneGoruntu.UseVisualStyleBackColor = false;
            this.BtnAboneGoruntu.Click += new System.EventHandler(this.BtnAboneGoruntu_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnKayitsizGir);
            this.groupBox5.Controls.Add(this.BtnKayitsizCik);
            this.groupBox5.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(7, 450);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(285, 316);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "KAYITSIZ ARAÇ İŞLEMLERİ";
            // 
            // BtnKayitsizGir
            // 
            this.BtnKayitsizGir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnKayitsizGir.Location = new System.Drawing.Point(25, 90);
            this.BtnKayitsizGir.Name = "BtnKayitsizGir";
            this.BtnKayitsizGir.Size = new System.Drawing.Size(229, 55);
            this.BtnKayitsizGir.TabIndex = 0;
            this.BtnKayitsizGir.Text = "KAYITSIZ ARAÇ GİRİŞ";
            this.BtnKayitsizGir.UseVisualStyleBackColor = false;
            this.BtnKayitsizGir.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnKayitsizCik
            // 
            this.BtnKayitsizCik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnKayitsizCik.Location = new System.Drawing.Point(25, 151);
            this.BtnKayitsizCik.Name = "BtnKayitsizCik";
            this.BtnKayitsizCik.Size = new System.Drawing.Size(229, 55);
            this.BtnKayitsizCik.TabIndex = 0;
            this.BtnKayitsizCik.Text = "KAYITSIZ ARAÇ ÇIKIŞ";
            this.BtnKayitsizCik.UseVisualStyleBackColor = false;
            this.BtnKayitsizCik.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataGridView1);
            this.groupBox7.Location = new System.Drawing.Point(370, 193);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(859, 536);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parkYeriBoyutDataGridViewTextBoxColumn,
            this.parkYeriDurumDataGridViewTextBoxColumn,
            this.parkYeriSureDataGridViewTextBoxColumn,
            this.plakakodDataGridViewTextBoxColumn,
            this.parkYeriKodDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblParkYerleriBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(853, 515);
            this.dataGridView1.TabIndex = 0;
            // 
            // parkYeriBoyutDataGridViewTextBoxColumn
            // 
            this.parkYeriBoyutDataGridViewTextBoxColumn.DataPropertyName = "ParkYeriBoyut";
            this.parkYeriBoyutDataGridViewTextBoxColumn.HeaderText = "ParkYeriBoyut";
            this.parkYeriBoyutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parkYeriBoyutDataGridViewTextBoxColumn.Name = "parkYeriBoyutDataGridViewTextBoxColumn";
            this.parkYeriBoyutDataGridViewTextBoxColumn.Width = 125;
            // 
            // parkYeriDurumDataGridViewTextBoxColumn
            // 
            this.parkYeriDurumDataGridViewTextBoxColumn.DataPropertyName = "ParkYeriDurum";
            this.parkYeriDurumDataGridViewTextBoxColumn.HeaderText = "ParkYeriDurum";
            this.parkYeriDurumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parkYeriDurumDataGridViewTextBoxColumn.Name = "parkYeriDurumDataGridViewTextBoxColumn";
            this.parkYeriDurumDataGridViewTextBoxColumn.Width = 125;
            // 
            // parkYeriSureDataGridViewTextBoxColumn
            // 
            this.parkYeriSureDataGridViewTextBoxColumn.DataPropertyName = "ParkYeriSure";
            this.parkYeriSureDataGridViewTextBoxColumn.HeaderText = "ParkYeriSure";
            this.parkYeriSureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parkYeriSureDataGridViewTextBoxColumn.Name = "parkYeriSureDataGridViewTextBoxColumn";
            this.parkYeriSureDataGridViewTextBoxColumn.Width = 125;
            // 
            // plakakodDataGridViewTextBoxColumn
            // 
            this.plakakodDataGridViewTextBoxColumn.DataPropertyName = "Plakakod";
            this.plakakodDataGridViewTextBoxColumn.HeaderText = "Plakakod";
            this.plakakodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.plakakodDataGridViewTextBoxColumn.Name = "plakakodDataGridViewTextBoxColumn";
            this.plakakodDataGridViewTextBoxColumn.Width = 125;
            // 
            // parkYeriKodDataGridViewTextBoxColumn
            // 
            this.parkYeriKodDataGridViewTextBoxColumn.DataPropertyName = "ParkYeriKod";
            this.parkYeriKodDataGridViewTextBoxColumn.HeaderText = "ParkYeriKod";
            this.parkYeriKodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parkYeriKodDataGridViewTextBoxColumn.Name = "parkYeriKodDataGridViewTextBoxColumn";
            this.parkYeriKodDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblParkYerleriBindingSource
            // 
            this.tblParkYerleriBindingSource.DataMember = "Tbl_ParkYerleri";
            this.tblParkYerleriBindingSource.DataSource = this.otoparkProjeDataSet5;
            // 
            // otoparkProjeDataSet5
            // 
            this.otoparkProjeDataSet5.DataSetName = "OtoparkProjeDataSet5";
            this.otoparkProjeDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ParkYerleriTableAdapter
            // 
            this.tbl_ParkYerleriTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1272, 778);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAdminPanel";
            this.Text = "Admin Paneli";
            this.Load += new System.EventHandler(this.FrmAdminPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblParkYerleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkProjeDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblDoluYer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblBosYer;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSorgula;
        private System.Windows.Forms.TextBox TxtPlaka;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblKullaniciad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnAboneGoruntu;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnKayitsizGir;
        private System.Windows.Forms.Button BtnKayitsizCik;
        private System.Windows.Forms.Button BtnHasilat;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OtoparkProjeDataSet5 otoparkProjeDataSet5;
        private System.Windows.Forms.BindingSource tblParkYerleriBindingSource;
        private OtoparkProjeDataSet5TableAdapters.Tbl_ParkYerleriTableAdapter tbl_ParkYerleriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkYeriBoyutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkYeriDurumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkYeriSureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakakodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkYeriKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label LblSorgu;
        private System.Windows.Forms.Label label4;
    }
}