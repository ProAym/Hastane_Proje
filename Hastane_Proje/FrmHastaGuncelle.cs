using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hastane_Proje
{
    public partial class FrmHastaGuncelle : Form
    {
        private readonly sqlbaglanti bglkayıt = new sqlbaglanti();
        public string tcno;

        public FrmHastaGuncelle()
        {
            InitializeComponent();
        }

        private void FrmHastaGuncelle_Load(object sender, EventArgs e)
        {
            MskTc.Text = tcno;

            // Retrieve and display patient information
            SqlCommand komut = new SqlCommand("SELECT Hastaad, Hastasoyad, Hastacinsiyet FROM Tbl_Hastalar WHERE Hastatc = @p1", bglkayıt.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                TxtAd.Text = dr["Hastaad"].ToString();
                TxtSoyad.Text = dr["Hastasoyad"].ToString();
                label8.Text = dr["Hastacinsiyet"].ToString();
            }
            bglkayıt.baglanti().Close();

            // Make unchangeable fields read-only or disabled
            TxtAd.ReadOnly = true;
            TxtSoyad.ReadOnly = true;
            label8.Enabled = false;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Merhaba " + TxtAd.Text + ", bilgileriniz güncellensin mi?", "Hasta Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                // Update patient information
                SqlCommand komut1 = new SqlCommand("UPDATE Tbl_Hastalar SET Hastatel = @p1, Hastasifre = @p2 WHERE Hastatc = @p3", bglkayıt.baglanti());
                komut1.Parameters.AddWithValue("@p1", MskTel.Text);
                komut1.Parameters.AddWithValue("@p2", TxtSifre.Text);
                komut1.Parameters.AddWithValue("@p3", MskTc.Text);
                komut1.ExecuteNonQuery();
                bglkayıt.baglanti().Close();
                MessageBox.Show("Bilgileriniz başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
