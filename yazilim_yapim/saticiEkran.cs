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

namespace yazilim_yapim
{
    public partial class saticiEkran : Form
    {
        public saticiEkran()
        {
            InitializeComponent();
        }
        //Veri tabanı bağlama
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-0GKB0TH;Initial Catalog=borsa;Integrated Security=True");
        //----------------------------------------------------------------
        public string kullaniciad;
       
        private void saticiEkran_Load(object sender, EventArgs e)
        {
            baglan.Open();
            Form1 form1 = new Form1();
            kullaniciad = label1.Text;
            MessageBox.Show(label1.Text);

            verilerigöster("Select satici_ad,satici_soyad,satici_ürünad,satici_ürünmiktar,satici_ürünfiyat from satici");

            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        public void verilerigöster(string veriler)
        {
            
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
