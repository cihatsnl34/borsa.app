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
        public void verilerigöstersoyut(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();   
            verilerigöster("Select * from satici");
            baglan.Close();
            
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            verilerigöstersoyut("Select * from saticiSoyut ");
            baglan.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglan.Open();

          
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                        string ekle = "insert into satici(satici_ad,satici_soyad,satici_kullaniciad,satici_password,satici_tc,satici_tel,satici_email,satici_adres,satici_ürünad,satici_ürünmiktar,satici_ürünfiyat) values" +
                 " (@satici_ad,@satici_soyad,@satici_kullaniciad,@satici_password,@satici_tc,@satici_tel,@satici_email,@satici_adres,@urun_adi,@urun_miktari,@urun_fiyati)";
                        SqlCommand komut = new SqlCommand(ekle, baglan);
                    komut.Parameters.AddWithValue("@satici_ad", dataGridView1.Rows[i].Cells[1].Value.ToString());
                    komut.Parameters.AddWithValue("@satici_soyad", dataGridView1.Rows[i].Cells[2].Value.ToString());
                    komut.Parameters.AddWithValue("@satici_kullaniciad", dataGridView1.Rows[i].Cells[3].Value.ToString());
                    komut.Parameters.AddWithValue("@satici_password", dataGridView1.Rows[i].Cells[4].Value.ToString());
                    komut.Parameters.AddWithValue("@satici_tc", dataGridView1.Rows[i].Cells[5].Value.ToString());
                    komut.Parameters.AddWithValue("@satici_tel", dataGridView1.Rows[i].Cells[6].Value.ToString());
                    komut.Parameters.AddWithValue("@satici_email", dataGridView1.Rows[i].Cells[7].Value.ToString());
                    komut.Parameters.AddWithValue("@satici_adres", dataGridView1.Rows[i].Cells[8].Value.ToString());
                    komut.Parameters.AddWithValue("@urun_adi", dataGridView1.Rows[i].Cells[9].Value.ToString());
                    komut.Parameters.AddWithValue("@urun_miktari", dataGridView1.Rows[i].Cells[10].Value.ToString());
                    komut.Parameters.AddWithValue("@urun_fiyati", dataGridView1.Rows[i].Cells[11].Value.ToString());
                    komut.ExecuteNonQuery();
                
            }
            string sorgu = "delete from saticiSoyut ";
            SqlCommand komut1 = new SqlCommand(sorgu, baglan);
            komut1.ExecuteNonQuery();
            verilerigöstersoyut("Select * from saticiSoyut ");
            baglan.Close();


        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from saticiSoyut where saticiS_id=@saticiS_id";
           SqlCommand komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@saticiS_id", Convert.ToInt32(txtId.Text));
            baglan.Open();
            komut.ExecuteNonQuery();
            verilerigöstersoyut("Select * from saticiSoyut ");
            baglan.Close();
            //baglan.Open();
            //SqlCommand komut = new SqlCommand("Delete From saticiSoyut where saticiS_id=("+id +")",baglan);
            //komut.ExecuteNonQuery();
            //baglan.Close();
        }

       

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
