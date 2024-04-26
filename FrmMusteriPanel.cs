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
    public partial class FrmMusteriPanel : Form
    {
        public FrmMusteriPanel()
        {
            InitializeComponent();
        }

        public string ad, soyad,plaka;
        sqlbaglantisi bgl = new sqlbaglantisi();
        
       

        private void FrmMusteriPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otoparkProjeDataSet2.Tbl_ParkYerleri' table. You can move, or remove it, as needed.
            this.tbl_ParkYerleriTableAdapter2.Fill(this.otoparkProjeDataSet2.Tbl_ParkYerleri);
            


            LblAd.Text = ad;
            LblSoyad.Text = soyad;
            LblPlaka.Text = plaka;

            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_ParkYerleri where Plakakod="+plaka,bgl.baglanti());
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;

            CmbAractip.Items.Add("1"); CmbAractip.Items.Add("2"); CmbAractip.Items.Add("3");
            CmbSure.Items.Add("30"); CmbSure.Items.Add("60"); CmbSure.Items.Add("120"); CmbSure.Items.Add("365");

            //SqlCommand komut = new SqlCommand("Select ParkYeriKod from Tbl_ParkYerleri where ParkYeriDurum='Musait'", bgl.baglanti());
            //SqlDataReader dr = komut.ExecuteReader();
            //while (dr.Read())
            //{
            //    CmbParkYer.Items.Add(dr[0]);

            //}
            //bgl.baglanti().Close();
        }

        private void BtnAboneol_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Abonelikler (Abonelik_Sure,Abonelik_Tip) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbSure.Text);
            komut.Parameters.AddWithValue("@p2", CmbAractip.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            
            MessageBox.Show("Başarıyla abone olundu. Park Yeriniz : " + CmbParkYer.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //////////////////

            SqlCommand komut3 = new SqlCommand("Update Tbl_ParkYerleri set ParkYeriSure=@p1,Plakakod=@p2,ParkYeriDurum='Dolu'where ParkYeriKod=@p3)", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",CmbSure.Text);
            komut3.Parameters.AddWithValue("@p2",LblPlaka.Text);
            komut3.Parameters.AddWithValue("@p3",CmbParkYer.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();


        }

        private void CmbAractip_SelectedIndexChanged(object sender, EventArgs e)
        {

            CmbParkYer.Items.Clear();
            SqlCommand komut2 = new SqlCommand("Select ParkYeriKod From Tbl_ParkYerleri where ParkYeriBoyut=@p1 and ParkYeriDurum='Musait'",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", CmbAractip.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbParkYer.Items.Add(dr2[0]);

            }
            bgl.baglanti().Close();
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
