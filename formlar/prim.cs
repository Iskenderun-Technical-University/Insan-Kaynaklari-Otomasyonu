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
    public partial class prim : Form
    {
        public static string SqlCon = @"Data Source=DESKTOP-E6GDS73\SQLEXPRESS02;Initial Catalog=okanalpturk;Integrated Security=True";
        public SqlConnection con = new SqlConnection(SqlCon);
        public SqlCommand cmd;
        public SqlDataAdapter da = new SqlDataAdapter();

        public prim()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu2 = "select *from tablo_calisan where essizid='" + id.eId.ToString().Trim() + "'";

            con.Open();
            SqlCommand komut = new SqlCommand(sorgu2, con);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label3.Text = dr["UyeAd"].ToString().Trim();
            }
            con.Close();
            string sorgu = "INSERT INTO tablo_talep(Gonderenad,PrimOnayDurumu,Gonderenid,PrimTalepMiktari,BasvuruTarihi,Aciklama) VALUES (@Gonderenad,@PrimOnayDurumu,@Gonderenid,@PrimTalepMiktari,@BasvuruTarihi,@Aciklama) ";
            con.Open();
            cmd = new SqlCommand(sorgu,con);
            cmd.Parameters.AddWithValue("@Aciklama", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@PrimTalepMiktari", textBox1.Text);           
            cmd.Parameters.AddWithValue("@Gonderenid", id.eId.ToString().Trim());    
            cmd.Parameters.AddWithValue("@BasvuruTarihi", DateTime.Now);
            cmd.Parameters.AddWithValue("@PrimOnayDurumu", "Onay Bekliyor");
            cmd.Parameters.AddWithValue("@Gonderenad",label3.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Talebiniz Alındı!");


        }
        private void textbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void prim_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
        }
    }
}
