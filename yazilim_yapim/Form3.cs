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
            baglan.Close();
            
        }
        public string s1, s2, s3, s4, s5, s6, s7, s8;
        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand command = new SqlCommand("Select * from kullanicii WHERE kullanici_rol='s'", baglan);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
               
                s1 = reader["kullanici_isim"].ToString();
                s2 = reader["kullanici_soyad"].ToString();
                s3 = reader["kullanici_ad"].ToString();
                s4 = reader["kullanici_password"].ToString();
                s5 = reader["kullanici_tc"].ToString();
                s6 = reader["kullanici_tel"].ToString();
                s7 = reader["kullanici_email"].ToString();
                s8 = reader["kullanici_adres"].ToString();
            }
            reader.Close();
            string kayit = "insert into saticiSoyut(saticiS_ad,saticiS_soyad,saticiS_kullaniciad,saticiS_password,saticiS_tc,saticiS_tel,saticiS_email,saticiS_adres,saticiS_ürünad,saticiS_ürünmiktar,saticiS_ürünfiyat) values" +
                " (@saticiS_ad,@saticiS_soyad,@saticiS_kullaniciad,@saticiS_password,@saticiS_tc,@saticiS_tel,@saticiS_email,@saticiS_adres,@urun_adi,@urun_miktari,@urun_fiyati)";
            SqlCommand komut = new SqlCommand(kayit, baglan);
            komut.Parameters.AddWithValue("@saticiS_ad", s1);
            komut.Parameters.AddWithValue("@saticiS_soyad", s2);
            komut.Parameters.AddWithValue("@saticiS_kullaniciad", s3);
            komut.Parameters.AddWithValue("@saticiS_password", s4);
            komut.Parameters.AddWithValue("@saticiS_tc", s5);
            komut.Parameters.AddWithValue("@saticiS_tel", s6);
            komut.Parameters.AddWithValue("@saticiS_email",s7);
            komut.Parameters.AddWithValue("@saticiS_adres", s8);
            komut.Parameters.AddWithValue("@urun_adi", textBox1.Text);
            komut.Parameters.AddWithValue("@urun_miktari", textBox2.Text);
            komut.Parameters.AddWithValue("@urun_fiyati", textBox3.Text);
            komut.ExecuteNonQuery();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            MessageBox.Show("Ürün eklendi");
            baglan.Close();

        }
    }
}
