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
    public partial class admin_arayuz : Form
    {

        public static string SqlCon = @"Data Source=DESKTOP-E6GDS73\SQLEXPRESS02;Initial Catalog=okanalpturk;Integrated Security=True";
        public SqlConnection con = new SqlConnection(SqlCon);
        public SqlCommand cmd;
        public SqlDataAdapter da = new SqlDataAdapter();

        mail ma = new mail();


        public admin_arayuz()
        {
            InitializeComponent();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

       
     
        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifredegistir sd = new sifredegistir();
            sd.ShowDialog();
        }

        private void ePostaDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            epostadegistir ed = new epostadegistir();
            ed.ShowDialog();
        }

        private void admin_arayuz_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Uyeislemleri ui = new Uyeislemleri();
            ui.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OnayBasvuru ob = new OnayBasvuru();
            ob.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            taleplerim t = new taleplerim();
            t.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sifredegistir sd = new sifredegistir();
            sd.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            epostadegistir epd = new epostadegistir();
            epd.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            mesaj m = new mesaj();
            m.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            izin i = new izin();
            i.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            prim p = new prim();
            p.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            taleponay to = new taleponay();
            to.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Basvuru ba = new Basvuru();
            ba.ShowDialog();
        }
    }
}
