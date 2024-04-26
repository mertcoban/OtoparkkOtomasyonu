
namespace OtoparkOtomasyonu
{
    partial class FrmMusteriGuncelle
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
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.MskTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPlaka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbAracTip = new System.Windows.Forms.ComboBox();
            this.TxtSure = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.otoparkProjeDataSet3 = new OtoparkOtomasyonu.OtoparkProjeDataSet3();
            this.tblMusterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MusterilerTableAdapter = new OtoparkOtomasyonu.OtoparkProjeDataSet3TableAdapters.Tbl_MusterilerTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteriAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriPlakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAracTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAboneSureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkProjeDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusterilerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnGuncelle.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(192, 527);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(154, 34);
            this.BtnGuncelle.TabIndex = 24;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // MskTel
            // 
            this.MskTel.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTel.Location = new System.Drawing.Point(188, 263);
            this.MskTel.Mask = "(999) 000-0000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(158, 30);
            this.MskTel.TabIndex = 3;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(190, 473);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(158, 30);
            this.TxtSifre.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(99, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Şifre :";
            // 
            // TxtPlaka
            // 
            this.TxtPlaka.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPlaka.Location = new System.Drawing.Point(188, 312);
            this.TxtPlaka.Name = "TxtPlaka";
            this.TxtPlaka.Size = new System.Drawing.Size(158, 30);
            this.TxtPlaka.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(87, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Plaka :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(69, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Telefon :";
            // 
            // TxtMail
            // 
            this.TxtMail.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Location = new System.Drawing.Point(188, 210);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(158, 30);
            this.TxtMail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mail Adresi :";
            // 
            // TxtAd
            // 
            this.TxtAd.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(188, 109);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(158, 30);
            this.TxtAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(114, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ad  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(67, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 32);
            this.label6.TabIndex = 25;
            this.label6.Text = "MÜŞTERİ GÜNCELLE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(53, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Araç Tipi :";
            // 
            // CmbAracTip
            // 
            this.CmbAracTip.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbAracTip.FormattingEnabled = true;
            this.CmbAracTip.Location = new System.Drawing.Point(190, 363);
            this.CmbAracTip.Name = "CmbAracTip";
            this.CmbAracTip.Size = new System.Drawing.Size(158, 32);
            this.CmbAracTip.TabIndex = 5;
            // 
            // TxtSure
            // 
            this.TxtSure.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSure.Location = new System.Drawing.Point(190, 419);
            this.TxtSure.Name = "TxtSure";
            this.TxtSure.Size = new System.Drawing.Size(158, 30);
            this.TxtSure.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(2, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "Abonelik Süre :";
            // 
            // otoparkProjeDataSet3
            // 
            this.otoparkProjeDataSet3.DataSetName = "OtoparkProjeDataSet3";
            this.otoparkProjeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMusterilerBindingSource
            // 
            this.tblMusterilerBindingSource.DataMember = "Tbl_Musteriler";
            this.tblMusterilerBindingSource.DataSource = this.otoparkProjeDataSet3;
            // 
            // tbl_MusterilerTableAdapter
            // 
            this.tbl_MusterilerTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(409, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1173, 525);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MÜŞTERİLER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriAdDataGridViewTextBoxColumn,
            this.musteriSoyadDataGridViewTextBoxColumn,
            this.musteriMailDataGridViewTextBoxColumn,
            this.musteriTelDataGridViewTextBoxColumn,
            this.musteriPlakaDataGridViewTextBoxColumn,
            this.musteriAracTipDataGridViewTextBoxColumn,
            this.musteriSifreDataGridViewTextBoxColumn,
            this.musteriAboneSureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblMusterilerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1167, 504);
            this.dataGridView1.TabIndex = 0;
            // 
            // musteriAdDataGridViewTextBoxColumn
            // 
            this.musteriAdDataGridViewTextBoxColumn.DataPropertyName = "MusteriAd";
            this.musteriAdDataGridViewTextBoxColumn.HeaderText = "MusteriAd";
            this.musteriAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriAdDataGridViewTextBoxColumn.Name = "musteriAdDataGridViewTextBoxColumn";
            this.musteriAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriSoyadDataGridViewTextBoxColumn
            // 
            this.musteriSoyadDataGridViewTextBoxColumn.DataPropertyName = "MusteriSoyad";
            this.musteriSoyadDataGridViewTextBoxColumn.HeaderText = "MusteriSoyad";
            this.musteriSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriSoyadDataGridViewTextBoxColumn.Name = "musteriSoyadDataGridViewTextBoxColumn";
            this.musteriSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriMailDataGridViewTextBoxColumn
            // 
            this.musteriMailDataGridViewTextBoxColumn.DataPropertyName = "MusteriMail";
            this.musteriMailDataGridViewTextBoxColumn.HeaderText = "MusteriMail";
            this.musteriMailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriMailDataGridViewTextBoxColumn.Name = "musteriMailDataGridViewTextBoxColumn";
            this.musteriMailDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriTelDataGridViewTextBoxColumn
            // 
            this.musteriTelDataGridViewTextBoxColumn.DataPropertyName = "MusteriTel";
            this.musteriTelDataGridViewTextBoxColumn.HeaderText = "MusteriTel";
            this.musteriTelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriTelDataGridViewTextBoxColumn.Name = "musteriTelDataGridViewTextBoxColumn";
            this.musteriTelDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriPlakaDataGridViewTextBoxColumn
            // 
            this.musteriPlakaDataGridViewTextBoxColumn.DataPropertyName = "MusteriPlaka";
            this.musteriPlakaDataGridViewTextBoxColumn.HeaderText = "MusteriPlaka";
            this.musteriPlakaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriPlakaDataGridViewTextBoxColumn.Name = "musteriPlakaDataGridViewTextBoxColumn";
            this.musteriPlakaDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriAracTipDataGridViewTextBoxColumn
            // 
            this.musteriAracTipDataGridViewTextBoxColumn.DataPropertyName = "MusteriAracTip";
            this.musteriAracTipDataGridViewTextBoxColumn.HeaderText = "MusteriAracTip";
            this.musteriAracTipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriAracTipDataGridViewTextBoxColumn.Name = "musteriAracTipDataGridViewTextBoxColumn";
            this.musteriAracTipDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriSifreDataGridViewTextBoxColumn
            // 
            this.musteriSifreDataGridViewTextBoxColumn.DataPropertyName = "MusteriSifre";
            this.musteriSifreDataGridViewTextBoxColumn.HeaderText = "MusteriSifre";
            this.musteriSifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriSifreDataGridViewTextBoxColumn.Name = "musteriSifreDataGridViewTextBoxColumn";
            this.musteriSifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriAboneSureDataGridViewTextBoxColumn
            // 
            this.musteriAboneSureDataGridViewTextBoxColumn.DataPropertyName = "MusteriAboneSure";
            this.musteriAboneSureDataGridViewTextBoxColumn.HeaderText = "MusteriAboneSure";
            this.musteriAboneSureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriAboneSureDataGridViewTextBoxColumn.Name = "musteriAboneSureDataGridViewTextBoxColumn";
            this.musteriAboneSureDataGridViewTextBoxColumn.Width = 125;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyad.Location = new System.Drawing.Point(188, 157);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(158, 30);
            this.TxtSoyad.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(82, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 24);
            this.label9.TabIndex = 31;
            this.label9.Text = "Soyad :";
            // 
            // FrmMusteriGuncelle
            // 
            this.AcceptButton = this.BtnGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1616, 603);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtSure);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmbAracTip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.MskTel);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPlaka);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmMusteriGuncelle";
            this.Text = "Müşteri Güncelle";
            this.Load += new System.EventHandler(this.FrmAboneGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.otoparkProjeDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusterilerBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.MaskedTextBox MskTel;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPlaka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbAracTip;
        private System.Windows.Forms.TextBox TxtSure;
        private System.Windows.Forms.Label label8;
        private OtoparkProjeDataSet3 otoparkProjeDataSet3;
        private System.Windows.Forms.BindingSource tblMusterilerBindingSource;
        private OtoparkProjeDataSet3TableAdapters.Tbl_MusterilerTableAdapter tbl_MusterilerTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriPlakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAracTipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAboneSureDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label9;
    }
}