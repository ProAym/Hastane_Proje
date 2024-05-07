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

namespace Hastane_Proje
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        sqlbaglanti bgldetay = new sqlbaglanti();

        public string hastatc;

        void randevugecmislistele()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = bgldetay.baglanti())
            {
                string query = "SELECT * FROM Tbl_Randevular WHERE HastaTC = @HastaTC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@HastaTC", LblTc.Text);
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dt);
                }
            }
            dataGridView1.DataSource = dt;
        }

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            LblTc.Text = hastatc;

            // Ad Soyad çekme
            using (SqlConnection connection = bgldetay.baglanti())
            {
                string query = "SELECT Hastaad, Hastasoyad FROM Tbl_Hastalar WHERE HastaTC = @HastaTC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@HastaTC", LblTc.Text);
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        LblAdsoyad.Text = dr["Hastaad"].ToString() + " " + dr["Hastasoyad"].ToString();
                    }
                }
            }

            randevugecmislistele();

            //Branşları comboboxa aktarma
            using (SqlConnection connection = bgldetay.baglanti())
            {
                string query = "SELECT Bransad FROM Tbl_Branslar";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader dr2 = command.ExecuteReader();
                    while (dr2.Read())
                    {
                        CmbBrans.Items.Add(dr2["Bransad"].ToString());
                    }
                }
            }
        }

        // Branş seçtikten sonra combobox'a o branşdaki doktorları ekledik
        // Branş seçtikten sonra combobox'a o branşdaki doktorları ekledik
        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Text = "";
            CmbDoktor.Items.Clear();

            using (SqlConnection connection = bgldetay.baglanti())
            {
                string query = "SELECT Doktorad, Doktorsoyad FROM Tbl_Doktorlar WHERE Doktorbrans = @Doktorbrans";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Doktorbrans", CmbBrans.Text);
                    SqlDataReader dr3 = command.ExecuteReader();
                    while (dr3.Read())
                    {
                        CmbDoktor.Items.Add(dr3["Doktorad"].ToString() + " " + dr3["Doktorsoyad"].ToString());
                    }
                }
            }
        }

        // aktif randevular
        // aktif randevular
        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = bgldetay.baglanti())
            {
                string query = "SELECT * FROM Tbl_Randevular WHERE Randevubrans = @Randevubrans AND Randevudoktor = @Randevudoktor AND Randevudurum = 0";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Randevubrans", CmbBrans.Text);
                    command.Parameters.AddWithValue("@Randevudoktor", CmbDoktor.Text);
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dt);
                }
            }
            dataGridView2.DataSource = dt;
        }

        private void LnkGuncelle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaGuncelle frmguncelle = new FrmHastaGuncelle();
            frmguncelle.tcno = LblTc.Text;
            frmguncelle.Show();
        }

        private void BtnRandevu_Click(object sender, EventArgs e)
        {
            if ( CmbDoktor.Text == "" || CmbBrans.Text == "" || RchSikayet.Text == "")
            {
                MessageBox.Show("Boş kalan alanları lütfen doldurunuz .", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand komutrandevu = new SqlCommand("update Tbl_Randevular set Randevudurum=1,Hastatc=@r1,Randevuhastasikayet=@r2 ", bgldetay.baglanti());
                komutrandevu.Parameters.AddWithValue("@r1", LblTc.Text);
                komutrandevu.Parameters.AddWithValue("@r2", RchSikayet.Text);
                komutrandevu.ExecuteNonQuery();
                bgldetay.baglanti().Close();
                MessageBox.Show(CmbDoktor.Text + " Bey ' den " + CmbBrans.Text + " için randevu alındı .", "Tebrikler " + LblAdsoyad.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbBrans.Text = "";
                CmbDoktor.Text = "";
                RchSikayet.Text = "";
                randevugecmislistele();
            }

        }

        private void Txtid_TextChanged(object sender, EventArgs e)
        {

        }
        private void LogoutUser()
        {
            FrmGirisler FrmGirisler = new FrmGirisler();
            FrmGirisler.Show();

            // Hide or close the current form
            this.Hide();
        }
          
        private void BtnCikis_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LogoutUser();
            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            FrmGirisler FrmGirisler = new FrmGirisler();
            FrmGirisler.Show();

            // Hide or close the current form
            this.Hide();
        }

       
    }
}
