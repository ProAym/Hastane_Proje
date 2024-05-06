using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Proje
{
    public partial class FrmHastaEkran : Form
    {
        public FrmHastaEkran()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            FrmGirisler FrmHastaDetay = new FrmGirisler();
            FrmHastaDetay.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           FrmHastaDetay FrmHastaDetay = new FrmHastaDetay();
           FrmHastaDetay.Show();
           this.Hide();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {
            //LblTc.Text = Hastatc;

            // Ad Soyad çekme
            //SqlCommand komut = new SqlCommand("Select Hastaad,Hastasoyad From Tbl_Hastalar where Hastatc=@d1", bgldetay.baglanti());
           // komut.Parameters.AddWithValue("@d1", LblTc.Text);
            //SqlDataReader dr = komut.ExecuteReader();
            //while (dr.Read())
            //{
                //LblAdsoyad.Text = dr[0].ToString() + " " + dr[1].ToString();
            //}
            //bgldetay.baglanti().Close();

           // randevugecmislistele();

            //Branşları comboboxa aktarma
            //SqlCommand komut2 = new SqlCommand("Select Bransad From Tbl_Branslar", bgldetay.baglanti());
           // SqlDataReader dr2 = komut2.ExecuteReader();
            //while (dr2.Read())
            //{
               // CmbBrans.Items.Add(dr2[0].ToString());
            //}
            //bgldetay.baglanti().Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FrmHastaGuncelle FrmHastaGuncelle = new FrmHastaGuncelle();
            FrmHastaGuncelle.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            FrmRandevuListe FrmRandevuListe = new FrmRandevuListe();
            FrmRandevuListe.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
