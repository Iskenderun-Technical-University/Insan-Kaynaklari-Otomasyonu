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
    public partial class sifredegistir : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public static string SqlCon = @"Data Source=DESKTOP-E6GDS73\SQLEXPRESS02;Initial Catalog=okanalpturk;Integrated Security=True";


        public sifredegistir()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);

            da = new SqlDataAdapter();

            con.Open();
            string sorgu2 = "Select sifre from tablo_calisan where essizid =@essizid ";

            SqlCommand komut = new SqlCommand(sorgu2, con);
            komut.Parameters.AddWithValue("@essizid", id.eId.ToString());

            komut.ExecuteNonQuery();
            da.SelectCommand = komut;
            DataTable dt = new DataTable();
            da.Fill(dt);


            con.Close();

            if (txt_eskipw.Text.Trim() == dt.Rows[0]["sifre"].ToString().Trim())
            {

                if (textBox1.Text == textBox2.Text)
                {
                    string sorgu = "UPDATE tablo_calisan SET sifre=@sifre";
                    cmd = new SqlCommand(sorgu, con);
                    cmd.Parameters.AddWithValue("@sifre", textBox2.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Şifre başarıyla güncellendi!");
                }
                else
                {
                    MessageBox.Show("Yeni şifreler eşleşmedi!\nLütfen yeniden giriniz.");
                }

            }
            else
            {
                MessageBox.Show("Eski şifre hatalı!");
            }
        }
    }
}
