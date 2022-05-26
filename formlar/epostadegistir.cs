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
    public partial class epostadegistir : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public static string SqlCon = @"Data Source=DESKTOP-E6GDS73\SQLEXPRESS02;Initial Catalog=okanalpturk;Integrated Security=True";
        public epostadegistir()
        {
            InitializeComponent();
        }

     
        private void epostadegistir_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == textBox2.Text.Trim())
            {
                con = new SqlConnection(SqlCon);
                string sorgu = "UPDATE tablo_calisan SET UyePosta=@UyePosta";
                cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@UyePosta", textBox2.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("E-Posta başarıyla güncellendi!");
            }
            else
            {
                MessageBox.Show("E-Postalar eşleşmedi!\nLütfen yeniden giriniz.");
            }

        }
    }
}
