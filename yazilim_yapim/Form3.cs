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
    public partial class Form3 : Form
    { 
        //Veri tabanı bağlama
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-0GKB0TH;Initial Catalog=borsa;Integrated Security=True");
        //----------------------------------------------------------------
        public string urun_adi;
        public string urun_miktari;
        public string urun_fiyati;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            baglan.Open();
            SqlCommand command = new SqlCommand("Select * from kullanicii WHERE kullanici_rol='s'", baglan);
            SqlDataReader reader = command.ExecuteReader();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urun_adi = textBox1.Text;
            urun_miktari = textBox2.Text;
            urun_fiyati = textBox3.Text;

        }
    }
}
