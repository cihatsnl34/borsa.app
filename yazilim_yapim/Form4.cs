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
    public partial class Form4 : Form
    {

        //Veri tabanı bağlama
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-0GKB0TH;Initial Catalog=borsa;Integrated Security=True");
        //----------------------------------------------------------------
        public Form4()
        {
            InitializeComponent();
        }
        public void verilerigöster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            baglan.Open();
            
            verilerigöster("Select * from kullanicii WHERE kullanici_rol='s'");
            
            
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
