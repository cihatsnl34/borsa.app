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
    public partial class aliciEkran : Form
    {
        Form1 form1 = new Form1();
        public string saticiadi,aliciadi,kullanici_ad;
        public int urunfiyat,istegimiktar,alicipara,saticiid,uruntoplamfiat,uruntoplam,aliciSonPara,aliciId,saticiPara;
        public aliciEkran()
        {
            InitializeComponent();
        }
        //Veri tabanı bağlama
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-0GKB0TH;Initial Catalog=borsa;Integrated Security=True");
        //----------------------------------------------------------------
        public void verilerigöster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }
        
        private void aliciEkran_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            baglan.Open();
            kullanici_ad = label4.Text;
            MessageBox.Show(kullanici_ad);
            
            verilerigöster("Select satici_id,satici_ad,satici_soyad,satici_ürünad,satici_ürünmiktar,satici_ürünfiyat from satici");
            SqlCommand command = new SqlCommand("Select * from alici ", baglan);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["alici_kullaniciad"].ToString()==kullanici_ad)
                {
                     
                    aliciadi= reader["alici_ad"].ToString();
                    alicipara = int.Parse(reader["alici_para"].ToString());
                    aliciId = int.Parse(reader["alici_id"].ToString());
                }   
               
            }
            

            baglan.Close();
            
            saticiadi= dataGridView1.CurrentRow.Cells[0].Value.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            form1.Show();
            this.Hide();
        }
        
        SqlCommand cmd;
        SqlCommand cd;
        SqlCommand cm;
        private void button3_Click(object sender, EventArgs e)
        {
            istegimiktar = int.Parse(textBox3.Text);
            uruntoplamfiat = istegimiktar * urunfiyat;
            uruntoplam =int.Parse( textBox2.Text )- int.Parse( textBox3.Text);
            uruntoplam.ToString();
            
            
            saticiid = int.Parse(textBox4.Text);
            //SqlCommand command1 = new SqlCommand("Select * from satici ", baglan);
            //SqlDataReader reader1 = command1.ExecuteReader();
            //while (reader1.Read())
            //{
            //    if (reader1["satici_id"].ToString() == saticiid.ToString())
            //    {


            //        saticiPara = int.Parse(reader1["satici_para"].ToString());

            //    }

            //}
            //reader1.Close();
            //urunfiyat += saticiPara;
            if (int.Parse(textBox3.Text) <= int.Parse(textBox2.Text))
            {
                if (alicipara>=int.Parse(textBox3.Text)*urunfiyat)
                {
                    cmd = new SqlCommand("update satici set satici_para=@urunfiyat,satici_ürünmiktar=@uruntoplam where satici_id=@saticiid", baglan);
                    
                    baglan.Open();
                    cmd.Parameters.AddWithValue("@saticiid", saticiid);
                    cmd.Parameters.AddWithValue("@urunfiyat", uruntoplamfiat);
                    cmd.Parameters.AddWithValue("@uruntoplam", uruntoplam.ToString());
                    cmd.ExecuteNonQuery();
                    
                    aliciSonPara = alicipara - uruntoplamfiat;
                    cd = new SqlCommand("update alici set alici_para=@aliciSonPara where alici_id=@aliciId", baglan);
                    cd.Parameters.AddWithValue("@aliciId", aliciId.ToString());
                    cd.Parameters.AddWithValue("@aliciSonPara", aliciSonPara);
                    cd.ExecuteNonQuery();
                    MessageBox.Show("Satın alma işlemi gerçekleşmiştir " + aliciadi + " Beyden " + saticiadi + " Beye " + uruntoplamfiat + " TL para aktarılmıştır....");
                    urunfiyat = urunfiyat + ((urunfiyat *10)/100);
                    cm = new SqlCommand("update satici set satici_ürünfiyat=@urunfiyat where satici_id=@saticiid", baglan);
                    cm.Parameters.AddWithValue("@saticiid", saticiid);
                    cm.Parameters.AddWithValue("@urunfiyat", urunfiyat.ToString());
                    cm.ExecuteNonQuery();
                    MessageBox.Show(urunfiyat.ToString());
                    baglan.Close();
                }
                
                else
                {
                    MessageBox.Show("Paranız yetersizdir...");
                    MessageBox.Show(urunfiyat.ToString());

                }

            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
            urunfiyat =int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
        }
    }
}
