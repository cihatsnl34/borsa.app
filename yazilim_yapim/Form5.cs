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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        //Veri tabanı bağlama
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-0GKB0TH;Initial Catalog=borsa;Integrated Security=True");
        //----------------------------------------------------------------
        private void Form5_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand command = new SqlCommand("Select * from kullanicii WHERE kullanici_rol='s'", baglan);
            SqlDataReader reader = command.ExecuteReader();
            baglan.Close();
        }

        public string s1, s2, s3, s4, s5, s6, s7, s8;

        private void button2_Click(object sender, EventArgs e)
        {
            aliciEkran alici1 = new aliciEkran();
            alici1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand command = new SqlCommand("Select * from kullanicii WHERE kullanici_rol='a'", baglan);
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
            string kayit = "insert into aliciSoyut(aliciS_ad,aliciS_soyad,aliciS_kullaniciad,aliciS_password,aliciS_tc,aliciS_tel,aliciS_email,aliciS_adres,aliciS_para) values" +
            " (@aliciS_ad,@aliciS_soyad,@aliciS_kullaniciad,@aliciS_password,@aliciS_tc,@aliciS_tel,@aliciS_email,@aliciS_adres,@para)";
            SqlCommand komut = new SqlCommand(kayit, baglan);
            komut.Parameters.AddWithValue("@aliciS_ad", s1);
            komut.Parameters.AddWithValue("@aliciS_soyad", s2);
            komut.Parameters.AddWithValue("@aliciS_kullaniciad", s3);
            komut.Parameters.AddWithValue("@aliciS_password", s4);
            komut.Parameters.AddWithValue("@aliciS_tc", s5);
            komut.Parameters.AddWithValue("@aliciS_tel", s6);
            komut.Parameters.AddWithValue("@aliciS_email", s7);
            komut.Parameters.AddWithValue("@aliciS_adres", s8);
            komut.Parameters.AddWithValue("@para",textBox1.Text);
            komut.ExecuteNonQuery();
            textBox1.Clear();
            MessageBox.Show("Para eklendi");

            baglan.Close();
        }
    }
}
