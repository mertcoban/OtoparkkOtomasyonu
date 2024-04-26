using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyonu
{
    public partial class FrmMusteriGoruntule : Form
    {
        public FrmMusteriGoruntule()
        {
            InitializeComponent();
        }

        private void FrmAboneGoruntule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otoparkProjeDataSet4.Tbl_Musteriler' table. You can move, or remove it, as needed.
            this.tbl_MusterilerTableAdapter.Fill(this.otoparkProjeDataSet4.Tbl_Musteriler);

        }
    }
}
