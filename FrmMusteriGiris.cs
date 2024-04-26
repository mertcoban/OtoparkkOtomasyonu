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
    public partial class FrmMusteriGiris : Form
    {
        public FrmMusteriGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void LnkKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FrmMusteriKayit fr = new FrmMusteriKayit();
            fr.Show();
            

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Musteriler Where MusteriMail=@p1 and MusteriSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TxtMail.Text);
            komut.Parameters.AddWithValue("@p2",TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            

            

            if (dr.Read())
            {
                FrmMusteriPanel fr = new FrmMusteriPanel();

                fr.ad = dr["MusteriAd"].ToString();
                fr.soyad = dr["MusteriSoyad"].ToString();
                fr.plaka = dr["MusteriPlaka"].ToString();
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Mail Adresi veya Şifre");

            }

            bgl.baglanti().Close();

        }
    }
}
