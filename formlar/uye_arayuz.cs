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
    public partial class uye_arayuz : Form
    {
        public static string SqlCon = @"Data Source=DESKTOP-E6GDS73\SQLEXPRESS02;Initial Catalog=okanalpturk;Integrated Security=True";
        public SqlConnection con = new SqlConnection(SqlCon);
        public SqlCommand cmd;
        public SqlDataAdapter da = new SqlDataAdapter();

        Basvuru bb = new Basvuru();
        mesaj m = new mesaj();
        mail ma = new mail();
        public uye_arayuz()
        {
            InitializeComponent();
        }

        private void btn_basvuruyap_Click(object sender, EventArgs e)
        {
            
        }

     
        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifredegistir sd = new sifredegistir();
            sd.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            con.Open();
            cmd = new SqlCommand("select *from tablo_mesaj", con);
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                label1.Text = dr["aliciid"].ToString();
            }

            con.Close();
            ma.ShowDialog();
        }

        private void ePostaDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            epostadegistir ed = new epostadegistir();
            ed.ShowDialog();
        }

      
        private void btn_uyegoruntule_Click(object sender, EventArgs e)
        {

        }

        private void uye_arayuz_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            basvurular b = new basvurular();
            b.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bb.ShowDialog();
        }

        private void btn_key_Click(object sender, EventArgs e)
        {
            sifredegistir sd = new sifredegistir();
            sd.ShowDialog();
        }

        private void btn_mail_Click(object sender, EventArgs e)
        {
            epostadegistir epd = new epostadegistir();
            epd.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            taleplerim t = new taleplerim();
            t.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            prim p = new prim();
            p.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            izin i = new izin();
            i.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
