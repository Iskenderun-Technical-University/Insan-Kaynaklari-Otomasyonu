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
    public partial class basvurular : Form
    {
        public static string SqlCon = @"Data Source=DESKTOP-E6GDS73\SQLEXPRESS02;Initial Catalog=okanalpturk;Integrated Security=True";
        public SqlConnection con = new SqlConnection(SqlCon);
        public SqlCommand cmd;
        public SqlDataAdapter da;
       
        public basvurular()
        {
            InitializeComponent();
      
        }

        private void basvurular_Load(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("SELECT BasvuruTarihi,basvuruno,Ad,OnayDurumu FROM tablo_basvuru", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            con.Close();
        }
    }
}
