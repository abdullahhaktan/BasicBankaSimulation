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

namespace BankaTest
{
    public partial class Form4: Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=DbBanka;Integrated Security=True;Encrypt=False;");


        public string hesap;
        private void Form4_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_HAREKET WHERE ALICI=@P1", conn);
            cmd.Parameters.AddWithValue("@P1", hesap);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM TBL_HAREKET WHERE GONDEREN=@P1", conn);
            cmd1.Parameters.AddWithValue("@P1", hesap);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt2 = new DataTable();
            da1.Fill(dt2);
            dataGridView2.DataSource = dt2;
            conn.Close();

        }
    }
}
