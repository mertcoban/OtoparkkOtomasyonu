
namespace OtoparkOtomasyonu
{
    partial class FrmMusteriGoruntule
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.otoparkProjeDataSet4 = new OtoparkOtomasyonu.OtoparkProjeDataSet4();
            this.tblMusterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MusterilerTableAdapter = new OtoparkOtomasyonu.OtoparkProjeDataSet4TableAdapters.Tbl_MusterilerTableAdapter();
            this.musteriAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriPlakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAracTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAboneSureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkProjeDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusterilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(1, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1215, 608);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            this.dataGridView1.Size = new System.Drawing.Size(1209, 587);
            this.dataGridView1.TabIndex = 0;
            // 
            // otoparkProjeDataSet4
            // 
            this.otoparkProjeDataSet4.DataSetName = "OtoparkProjeDataSet4";
            this.otoparkProjeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMusterilerBindingSource
            // 
            this.tblMusterilerBindingSource.DataMember = "Tbl_Musteriler";
            this.tblMusterilerBindingSource.DataSource = this.otoparkProjeDataSet4;
            // 
            // tbl_MusterilerTableAdapter
            // 
            this.tbl_MusterilerTableAdapter.ClearBeforeFill = true;
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
            // FrmAboneGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1228, 619);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAboneGoruntule";
            this.Text = "Aboneler";
            this.Load += new System.EventHandler(this.FrmAboneGoruntule_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkProjeDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusterilerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OtoparkProjeDataSet4 otoparkProjeDataSet4;
        private System.Windows.Forms.BindingSource tblMusterilerBindingSource;
        private OtoparkProjeDataSet4TableAdapters.Tbl_MusterilerTableAdapter tbl_MusterilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriPlakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAracTipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAboneSureDataGridViewTextBoxColumn;
    }
}