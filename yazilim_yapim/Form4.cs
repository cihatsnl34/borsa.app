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
        //public void verilerigöstersoyut(string veriler)
        //{
        //    SqlDataAdapter da = new SqlDataAdapter(veriler, baglan);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);

        //    dataGridView1.DataSource = ds.Tables[0];

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            alici_onay.Enabled = false;
            alici_sil.Enabled = false;
            button5.Enabled = true;
            button6.Enabled = true;

            baglan.Open();   
            verilerigöster("Select * from satici");
            baglan.Close();
            
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            alici_onay.Enabled = false;
            alici_sil.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            alici_onay.Enabled = false;
            alici_sil.Enabled = false;
            button5.Enabled = true;
            button6.Enabled = true;

            baglan.Open();
            verilerigöster("Select * from saticiSoyut");
            baglan.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglan.Open();
            int i = int.Parse(dataGridView1.SelectedRows[0].Index.ToString());
            string ekle = "insert into satici(satici_ad,satici_soyad,satici_kullaniciad,satici_password,satici_tc,satici_tel,satici_email,satici_adres,satici_ürünad,satici_ürünmiktar,satici_ürünfiyat) values(@satici_ad,@satici_soyad,@satici_kullaniciad,@satici_password,@satici_tc,@satici_tel,@satici_email,@satici_adres,@urun_adi,@urun_miktari,@urun_fiyati)";
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
            string sorgu = "delete from saticiSoyut where saticiS_id=@saticiS_id";
            SqlCommand komut1 = new SqlCommand(sorgu, baglan);
            komut1.Parameters.AddWithValue("@saticiS_id", Convert.ToInt32(txtId.Text));
            komut1.ExecuteNonQuery();
            verilerigöster("Select * from saticiSoyut ");
            baglan.Close();

        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from saticiSoyut where saticiS_id=@saticiS_id";
           SqlCommand komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@saticiS_id", Convert.ToInt32(txtId.Text));
            baglan.Open();
            komut.ExecuteNonQuery();
            verilerigöster("Select * from saticiSoyut ");
            baglan.Close();
        }

       

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtaliciId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button6.Enabled = false;
            alici_onay.Enabled = true;
            alici_sil.Enabled = true;
            baglan.Open();
            verilerigöster("Select * from alici");
            baglan.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button6.Enabled = false;
            alici_onay.Enabled = true;
            alici_sil.Enabled = true;
            baglan.Open();
            verilerigöster("Select * from aliciSoyut ");
            baglan.Close();
        }

        private void alici_onay_Click(object sender, EventArgs e)
        {
            baglan.Open();
            int i = int.Parse(dataGridView1.SelectedRows[0].Index.ToString());
            string ekle = "insert into alici(alici_ad,alici_soyad,alici_kullaniciad,alici_password,alici_tc,alici_tel,alici_email,alici_adres,alici_para) values" +
         " (@alici_ad,@alici_soyad,@alici_kullaniciad,@alici_password,@alici_tc,@alici_tel,@alici_email,@alici_adres,@alici_para)";
                SqlCommand komut = new SqlCommand(ekle, baglan);
                komut.Parameters.AddWithValue("@alici_ad", dataGridView1.Rows[i].Cells[1].Value.ToString());
                komut.Parameters.AddWithValue("@alici_soyad", dataGridView1.Rows[i].Cells[2].Value.ToString());
                komut.Parameters.AddWithValue("@alici_kullaniciad", dataGridView1.Rows[i].Cells[3].Value.ToString());
                komut.Parameters.AddWithValue("@alici_password", dataGridView1.Rows[i].Cells[4].Value.ToString());
                komut.Parameters.AddWithValue("@alici_tc", dataGridView1.Rows[i].Cells[5].Value.ToString());
                komut.Parameters.AddWithValue("@alici_tel", dataGridView1.Rows[i].Cells[6].Value.ToString());
                komut.Parameters.AddWithValue("@alici_email", dataGridView1.Rows[i].Cells[7].Value.ToString());
                komut.Parameters.AddWithValue("@alici_adres", dataGridView1.Rows[i].Cells[8].Value.ToString());
                komut.Parameters.AddWithValue("@alici_para", dataGridView1.Rows[i].Cells[9].Value.ToString());
                komut.ExecuteNonQuery();
                string sorgu = "delete from aliciSoyut where aliciS_id=@aliciS_id";
                SqlCommand komut1 = new SqlCommand(sorgu, baglan);
                komut1.Parameters.AddWithValue("@aliciS_id", txtaliciId.Text);
                komut1.ExecuteNonQuery();
                baglan.Close();
        }

        private void alici_sil_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from aliciSoyut where aliciS_id=@aliciS_id";
            SqlCommand komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@aliciS_id", txtaliciId.Text);
            baglan.Open();
            komut.ExecuteNonQuery();
            verilerigöster("Select * from aliciSoyut ");
            baglan.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
