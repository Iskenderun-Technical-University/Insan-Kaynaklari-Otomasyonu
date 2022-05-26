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
    public partial class taleplerim : Form
    {
        public static string SqlCon = @"Data Source=DESKTOP-E6GDS73\SQLEXPRESS02;Initial Catalog=okanalpturk;Integrated Security=True";
        public SqlConnection con = new SqlConnection(SqlCon);
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public taleplerim()
        {
            InitializeComponent();
        }

        private void taleplerim_Load(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("SELECT BasvuruTarihi,PrimTalepMiktari,PrimOnayDurumu FROM tablo_talep where Gonderenid = '" + id.eId.ToString().Trim() + "' ", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            con.Close();

            con.Open();
            SqlDataAdapter daa;
            daa = new SqlDataAdapter("SELECT IzinBaslangicTarihi,IzinBitisTarihi,IzinOnayDurumu,Aciklama,BasvuruTarihi FROM tablo_izin where basvuranid = '" + id.eId.ToString().Trim() + "' ", con);
            DataTable tabloo = new DataTable();

            daa.Fill(tabloo);
            dataGridView2.DataSource = tabloo;
            con.Close();



        }
    }
}
