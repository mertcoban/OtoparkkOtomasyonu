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
    public partial class FrmAdminPanel : Form
    {
        public FrmAdminPanel()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button3_Click(object sender, EventArgs e)
        {
            FrmMusteriGuncelle fr = new FrmMusteriGuncelle();
            fr.Show();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        public string k_ad;
        private void FrmAdminPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otoparkProjeDataSet5.Tbl_ParkYerleri' table. You can move, or remove it, as needed.
            this.tbl_ParkYerleriTableAdapter.Fill(this.otoparkProjeDataSet5.Tbl_ParkYerleri);
            LblKullaniciad.Text = k_ad;

            SqlCommand komutsay = new SqlCommand("SELECT COUNT(*) FROM Tbl_ParkYerleri WHERE ParkYeriDurum='Musait'",bgl.baglanti());
            SqlDataReader dr = komutsay.ExecuteReader();

            if (dr.Read())
            {
                LblBosYer.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
            
            ////////////////////////
            
            SqlCommand komutsaydolu = new SqlCommand("SELECT COUNT(*) FROM Tbl_ParkYerleri WHERE ParkYeriDurum='Dolu'", bgl.baglanti());
            SqlDataReader dr2 = komutsaydolu.ExecuteReader();

            if (dr2.Read())
            {
                LblDoluYer.Text = dr2[0].ToString();
            }
            bgl.baglanti().Close();



        }

        private void BtnAboneGoruntu_Click(object sender, EventArgs e)
        {
            FrmMusteriGoruntule fr = new FrmMusteriGoruntule();
            fr.Show();

        }

        private void BtnSorgula_Click(object sender, EventArgs e)
        {
            SqlCommand komutplaka = new SqlCommand("Select ParkYeriKod From Tbl_ParkYerleri where Plakakod=@p1", bgl.baglanti());
            komutplaka.Parameters.AddWithValue("@p1", TxtPlaka.Text);
            SqlDataReader dr = komutplaka.ExecuteReader();

            if (dr.Read())
            {
                LblSorgu.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();


        }
    }
}
