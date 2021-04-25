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

        private void button1_Click(object sender, EventArgs e)
        {
            
            baglan.Open();
            string select = "Select * from kullanicii";
            SqlDataAdapter da = new SqlDataAdapter(select, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
            
            
        }
    }
}
