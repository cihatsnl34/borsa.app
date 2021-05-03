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
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
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
