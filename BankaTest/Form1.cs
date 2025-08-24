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
using System.Data.SqlClient;

namespace BankaTest
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=DbBanka;Integrated Security=True;Encrypt=False;");

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_KISILER WHERE HESAP_NO=@P1 AND SIFRE=@P2", conn);
            cmd.Parameters.AddWithValue("@P1", mskHesapNo.Text);
            cmd.Parameters.AddWithValue("@P2", txtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                Form2 frm2 = new Form2();
                frm2.hesap = mskHesapNo.Text;
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hesap numarası veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
