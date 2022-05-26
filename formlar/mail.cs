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

namespace okanalpturk_IK
{
    public partial class mail : Form
    {
        public static string SqlCon = @"Data Source=DESKTOP-E6GDS73\SQLEXPRESS02;Initial Catalog=okanalpturk;Integrated Security=True";
        public SqlConnection con = new SqlConnection(SqlCon);
        public SqlCommand cmd;
        public SqlDataAdapter da;

        mesaj m = new mesaj();
        public mail()
        {
            InitializeComponent();
        }
        
        private void mail_Load(object sender, EventArgs e)
        {
           
            
            con.Open();
            da = new SqlDataAdapter("SELECT gonderilmetarihi,gonderenad,konu,ileti FROM tablo_mesaj where aliciid = '" + id.eId.ToString().Trim() + "' ",con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            con.Close();

           

            con = new SqlConnection(SqlCon);
            con.Open();
            SqlDataAdapter daa = new SqlDataAdapter("SELECT gonderilmetarihi,gonderenad,konu,ileti,aliciad,aliciid FROM tablo_mesaj where gonderenid = '" + id.eId.ToString().Trim() + "' ", con);
            DataTable tabloo = new DataTable();
            daa.Fill(tabloo);
            dataGridView2.DataSource = tabloo;
            con.Close();

            




        }

        private void button1_Click(object sender, EventArgs e)
        {

           

        }

        private void tabPage_mesajyaz_Click(object sender, EventArgs e)
        {
            m.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
