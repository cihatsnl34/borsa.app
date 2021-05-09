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
    public partial class Form2 : Form

    {
        //Veri tabanı bağlama
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-0GKB0TH;Initial Catalog=borsa;Integrated Security=True");
        //----------------------------------------------------------------
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
            string ekle = textBox3.Text.ToLower();
            
             if (ekle=="s")
              {

                baglan.Open();

                string kayits = "insert into saticiSoyut(saticiS_kullaniciad,saticiS_password,saticiS_ad,saticiS_soyad,saticiS_tc,saticiS_tel,saticiS_email,saticiS_adres) values (@kullaniciadi,@parola,@isim,@soyisim,@tc,@email,@telefon,@adres)";
                SqlCommand komuts = new SqlCommand(kayits, baglan);
                komuts.Parameters.AddWithValue("@kullaniciadi", textBox1.Text);
                komuts.Parameters.AddWithValue("@parola", textBox2.Text);
                komuts.Parameters.AddWithValue("@isim", textBox4.Text);
                komuts.Parameters.AddWithValue("@soyisim", textBox5.Text);
                komuts.Parameters.AddWithValue("@tc", textBox6.Text);
                komuts.Parameters.AddWithValue("@email", textBox7.Text);
                komuts.Parameters.AddWithValue("@telefon", textBox8.Text);
                komuts.Parameters.AddWithValue("@adres", textBox9.Text);
                komuts.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt İşlemi Gerçekleşti.");
            }
            else if (ekle=="a")
            {
                baglan.Open();

                string kayita = "insert into aliciSoyut(aliciS_kullaniciad,aliciS_password,aliciS_ad,aliciS_soyad,aliciS_tc,aliciS_tel,aliciS_email,aliciS_adres) values (@kullaniciadi,@parola,@isim,@soyisim,@tc,@email,@telefon,@adres)";
                SqlCommand komuta = new SqlCommand(kayita, baglan);
                komuta.Parameters.AddWithValue("@kullaniciadi", textBox1.Text);
                komuta.Parameters.AddWithValue("@parola", textBox2.Text);
                
                komuta.Parameters.AddWithValue("@isim", textBox4.Text);
                komuta.Parameters.AddWithValue("@soyisim", textBox5.Text);
                komuta.Parameters.AddWithValue("@tc", textBox6.Text);
                komuta.Parameters.AddWithValue("@email", textBox7.Text);
                komuta.Parameters.AddWithValue("@telefon", textBox8.Text);
                komuta.Parameters.AddWithValue("@adres", textBox9.Text);
                komuta.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt İşlemi Gerçekleşti.");
            }
            
                baglan.Open();

                string kayit = "insert into kullanicii(kullanici_ad,kullanici_password,kullanici_rol,kullanici_isim,kullanici_soyad,kullanici_tc,kullanici_tel,kullanici_email,kullanici_adres) values (@kullaniciadi,@parola,@rol,@isim,@soyisim,@tc,@email,@telefon,@adres)";
                SqlCommand komut = new SqlCommand(kayit, baglan);
                komut.Parameters.AddWithValue("@kullaniciadi", textBox1.Text);
                komut.Parameters.AddWithValue("@parola", textBox2.Text);
                komut.Parameters.AddWithValue("@rol", textBox3.Text);
                komut.Parameters.AddWithValue("@isim", textBox4.Text);
                komut.Parameters.AddWithValue("@soyisim", textBox5.Text);
                komut.Parameters.AddWithValue("@tc", textBox6.Text);
                komut.Parameters.AddWithValue("@email", textBox7.Text);
                komut.Parameters.AddWithValue("@telefon", textBox8.Text);
                komut.Parameters.AddWithValue("@adres", textBox9.Text);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt İşlemi Gerçekleşti.");
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
