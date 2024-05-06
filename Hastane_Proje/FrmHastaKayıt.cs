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
using Microsoft.SqlServer.Server;

namespace Hastane_Proje
{
    public partial class FrmHastaKayıt : Form
    {
        public FrmHastaKayıt()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        void temizle()
        {
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            MskTc.Text = "";
            maskedTextBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            TxtSifre.Text = "";
            
        }

        private void BtnKayıt_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text == "" || TxtSoyad.Text == "" || MskTc.Text == "" || maskedTextBox1.Text == "" || TxtSifre.Text == "")
            {
                MessageBox.Show("Boş kalan alanları lütfen doldurunuz .", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM Tbl_Hastalar WHERE HastaTC = @tc", bgl.baglanti());
                kontrolKomut.Parameters.AddWithValue("@tc", MskTc.Text);
                int tcExist = (int)kontrolKomut.ExecuteScalar();
                if (tcExist > 0)
                {
                    MessageBox.Show("Girdiğiniz TC kimlik numarası zaten kullanımda.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Kayıt işleminden çık
                }

                SqlCommand komutkayıt = new SqlCommand("INSERT INTO Tbl_Hastalar (HastaAd, HastaSoyad, HastaTC, HastaTelefon, HastaCinsiyet, HastaSifre) VALUES (@e1, @e2, @e3, @e4, @e5, @e6)", bgl.baglanti());
                komutkayıt.Parameters.AddWithValue("@e1", TxtAd.Text);
                komutkayıt.Parameters.AddWithValue("@e2", TxtSoyad.Text);
                komutkayıt.Parameters.AddWithValue("@e3", MskTc.Text);
                komutkayıt.Parameters.AddWithValue("@e4", maskedTextBox1.Text);
                komutkayıt.Parameters.AddWithValue("@e5", label8.Text);
                komutkayıt.Parameters.AddWithValue("@e6", TxtSifre.Text);
                komutkayıt.ExecuteNonQuery();
                bgl.baglanti().Close();
                if (label8.Text == "True")
                {
                    MessageBox.Show("Kayıt yapılmıştır " + TxtAd.Text + " Bey", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kayıt yapılmıştır " + TxtAd.Text + " Hanım", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                temizle();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
        }

        
        private void FrmHastaKayıt_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
