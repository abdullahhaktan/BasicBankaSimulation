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
using System.Runtime.InteropServices;

namespace BankaTest
{
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=DbBanka;Integrated Security=True;Encrypt=False;");

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapNo_Click(object sender, EventArgs e)
        {
            Random rndm = new Random();
            int sayi = rndm.Next(100000, 1000000);
            mskHesapNo.Text = sayi.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_KISILER(AD,SOYAD,TC,TELEFON,HESAP_NO,SIFRE) VALUES(@P1,@P2,@P3,@P4,@P5,@P6)", conn);
            cmd.Parameters.AddWithValue("@P1", txtAd.Text);
            cmd.Parameters.AddWithValue("@P2", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@P3", mskTc.Text);
            cmd.Parameters.AddWithValue("@P4", mskTelefon.Text);
            cmd.Parameters.AddWithValue("@P5", mskHesapNo.Text);
            cmd.Parameters.AddWithValue("@P6", txtSifre.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            conn.Open();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO TBL_HESAP(HESAP_NO, BAKIYE) VALUES(@P1, 0)", conn);
            cmd1.Parameters.AddWithValue("@P1", mskHesapNo.Text);
            cmd1.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Müşteri bilgileri sisteme kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
