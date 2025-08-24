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


namespace BankaTest
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=DbBanka;Integrated Security=True;Encrypt=False;");


        public string hesap;

        private void Form2_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_KISILER WHERE HESAP_NO=@P1", conn);
            cmd.Parameters.AddWithValue("@P1", hesap);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblAdSoyad.Text = dr[1].ToString() + " " + dr[2].ToString();
                lblHesapNo.Text = dr[5].ToString();
                lblTelefonNo.Text = dr[4].ToString();
                lblTcKimlik.Text = dr[3].ToString();
            }
            else
            {
                MessageBox.Show("Hesap bilgileri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

        }

        private void lblHesapNo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE TBL_KISILER SET BAKIYE=BAKIYE+@P1 WHERE HESAP_NO=@P2",conn);
            cmd.Parameters.AddWithValue("@P1", decimal.Parse(txtTutar.Text));
            cmd.Parameters.AddWithValue("@P2", lblHesapNo.Text);
            conn.Close();

            conn.Open();
            SqlCommand cmd1 = new SqlCommand("UPDATE TBL_KISILER SET BAKIYE=BAKIYE-@P1 WHERE HESAP_NO=@P2", conn);
            cmd.Parameters.AddWithValue("@P1", decimal.Parse(txtTutar.Text));
            cmd.Parameters.AddWithValue("@P2", hesap);
            conn.Close();

            conn.Open();
            SqlCommand cmd2 = new SqlCommand("INSERT INTO TBL_HAREKET (GONDEREN,ALICI,TUTAR) VALUES (@P1,@P2,@P3)", conn);
            cmd2.Parameters.AddWithValue("@P1", hesap);
            cmd2.Parameters.AddWithValue("@P2", lblHesapNo.Text);
            cmd2.Parameters.AddWithValue("@P3", decimal.Parse(txtTutar.Text));
            cmd2.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("İşlem başarılı...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnHareketler_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.hesap = lblHesapNo.Text;
            frm4.Show();
        }
    }
}
