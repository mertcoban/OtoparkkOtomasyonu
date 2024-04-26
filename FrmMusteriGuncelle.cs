using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtoparkOtomasyonu
{
    public partial class FrmMusteriGuncelle : Form
    {
        public FrmMusteriGuncelle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmAboneGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otoparkProjeDataSet3.Tbl_Musteriler' table. You can move, or remove it, as needed.
            this.tbl_MusterilerTableAdapter.Fill(this.otoparkProjeDataSet3.Tbl_Musteriler);
            CmbAracTip.Items.Add("1"); CmbAracTip.Items.Add("2"); CmbAracTip.Items.Add("3");

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Musteriler set MusteriAd=@p1,MusteriSoyad=@p2,MusteriMail=@p3,MusteriPlaka=@p5,MusteriAracTip=@p6,MusteriAboneSure=@p7,MusteriSifre=@p8 where MusteriTel=@p4",bgl.baglanti());
            
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtMail.Text);
            komut.Parameters.AddWithValue("@p4", MskTel.Text);
            komut.Parameters.AddWithValue("@p5", TxtPlaka.Text);
            komut.Parameters.AddWithValue("@p6", CmbAracTip.Text);
            komut.Parameters.AddWithValue("@p7", TxtSure.Text);
            komut.Parameters.AddWithValue("@p8", TxtSifre.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);




        }
    }
}
