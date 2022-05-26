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
    public partial class taleponay : Form
    {

        public static string SqlCon = @"Data Source=DESKTOP-E6GDS73\SQLEXPRESS02;Initial Catalog=okanalpturk;Integrated Security=True";
        public SqlConnection con = new SqlConnection(SqlCon);
        public SqlCommand cmd;
        public SqlDataAdapter da = new SqlDataAdapter();
        public taleponay()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            izin();
            prim();

        }

        private void taleponay_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            radioButton1.Checked = true;          
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label2.Text = "Başvuru Reddedildi!";
                string sorgu = "update tablo_izin set IzinOnayDurumu='" + label2.Text.Trim() + "' where basvuruno='" +comboBox1.SelectedItem+ "'";
                con.Open();
                SqlCommand nk = new SqlCommand(sorgu, con);
                nk.ExecuteNonQuery();
                con.Close();
                label11.Text = "Başvuru Reddedildi!";
                MessageBox.Show("Başvuru Reddedildi!");


            }
            else if (radioButton2.Checked==true)
            {
                label2.Text = "Başvuru Reddedildi!";
                string sorgu = "update tablo_talep set PrimOnayDurumu='" + label2.Text.Trim() + "' where basvuruid='" + comboBox1.SelectedItem + "'";
                con.Open();
                SqlCommand nk = new SqlCommand(sorgu, con);
                nk.ExecuteNonQuery();
                con.Close();
                label11.Text = "Başvuru Reddedildi!";
                MessageBox.Show("Başvuru Reddedildi!");
            }
        }
         public void izin()
        {
            if (radioButton1.Checked == true)
            {
                
                int k;

                k = Convert.ToInt32(comboBox1.SelectedItem);
                con.Open();
                cmd = new SqlCommand("select *from tablo_izin where basvuruno='" + k + "' ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    label9.Text = dr["basvuranid"].ToString();
                    label10.Text = dr["BasvuruTarihi"].ToString();
                    label11.Text = dr["IzinOnayDurumu"].ToString();
                    label12.Text = dr["IzinBaslangicTarihi"].ToString();
                    label13.Text = dr["IzinBitisTarihi"].ToString();
                    label14.Text = dr["IzinTalepEdenKisi"].ToString();
                    richTextBox1.Text = dr["Aciklama"].ToString();

                }
                con.Close();

            }
        }
        public void prim()
        {
            if (radioButton2.Checked == true)
            {
                
                int k;

                k = Convert.ToInt32(comboBox1.SelectedItem);
                con.Open();
                cmd = new SqlCommand("select *from tablo_talep where basvuruid='" + k + "' ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    label9.Text = dr["BasvuruTarihi"].ToString();
                    label10.Text = dr["PrimTalepMiktari"].ToString();
                    label11.Text = dr["PrimOnayDurumu"].ToString();
                    label12.Text = dr["Gonderenid"].ToString();
                    label13.Text = dr["Gonderenad"].ToString();
                    richTextBox1.Text = dr["Aciklama"].ToString();



                }

                con.Close();

            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text= "";
            richTextBox1.Text = "";

            comboBox1.Items.Clear();
            comboBox1.Text = "";
            con.Open();
            cmd = new SqlCommand("select *from tablo_izin", con);
            SqlDataReader drr = cmd.ExecuteReader();
            while (drr.Read())
            {
                if (drr["basvuruno"] != comboBox1.Items)

                { comboBox1.Items.Add(drr["basvuruno"]); }
                else { }
            }
            con.Close();
            label8.Visible = true;
            label14.Visible = true;

            label3.Text = "Başvuran id :";
            label4.Text = "Başvuru Tarihi :";
            label5.Text = "İzin Onay Durumu :";
            label6.Text = "İzin Başlangıç Tarihi :";
            label7.Text = "İzin Bitiş Tarihi :";
            label8.Text = "İzin Talep Eden Kişi :";


            izin();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            con.Open();
            cmd = new SqlCommand("select *from tablo_talep", con);
            SqlDataReader drr;
            drr = cmd.ExecuteReader();
            while (drr.Read())
            {
                if (drr["basvuruid"] != comboBox1.Items)

                { comboBox1.Items.Add(drr["basvuruid"]); }
                else { }
            }
            con.Close();
            label3.Text = "Başvuru Tarihi";
            label4.Text = "Prim Talep Miktarı :";
            label5.Text = "Prim Onay Durumu :";
            label6.Text = "Gonderenid :";
            label7.Text = "Gonderen Kişi :";

            label8.Visible = false;
            label14.Visible = false;

            prim();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                label2.Text = "Başvuru Onaylandı!";
                string sorgu = "update tablo_izin set IzinOnayDurumu='" + label2.Text.Trim() + "' where basvuruno='" + comboBox1.SelectedItem + "'";
                con.Open();
                SqlCommand nk = new SqlCommand(sorgu, con);
                nk.ExecuteNonQuery();
                con.Close();
                label11.Text = "Başvuru Onaylandı!";
                MessageBox.Show("Başvuru Onaylandı!");


            }
        
            else if (radioButton2.Checked==true)
            {
                label2.Text = "Başvuru Onaylandı!";
                string sorgu = "update tablo_talep set PrimOnayDurumu='" + label2.Text.Trim() + "' where basvuruid='" + comboBox1.SelectedItem + "'";
                con.Open();
                SqlCommand nk = new SqlCommand(sorgu, con);
                nk.ExecuteNonQuery();
                con.Close();
                label11.Text = "Başvuru Onaylandı!";
                MessageBox.Show("Başvuru Onaylandı!");

            }
        
        
        
        }
    }
}
