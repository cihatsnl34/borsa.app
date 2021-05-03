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
using System.Collections;

namespace yazilim_yapim
{
    public partial class Form1 : Form
    {   //Veri tabanı bağlama
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-0GKB0TH;Initial Catalog=borsa;Integrated Security=True");
        //----------------------------------------------------------------
        public string kullanici_ad;
        public string kullanici_password;
        public string kullanici_rol;
        public Form1()
        {

            InitializeComponent();

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            baglan.Open();
            SqlCommand command = new SqlCommand("Select * from kullanicii", baglan);
            SqlDataReader reader = command.ExecuteReader();
            
            string username = textBox1.Text;
            string pass = textBox2.Text;
                if (username != "" && pass != "")
                {
               
                while (reader.Read())
                    {
                         kullanici_ad = reader["kullanici_ad"].ToString();
                         kullanici_password = reader["kullanici_password"].ToString();
                         kullanici_rol = reader["kullanici_rol"].ToString();
                        if (username == kullanici_ad && pass == kullanici_password && kullanici_rol=="m"&&radioButton1.Checked) // veriler veri tabınından çekilecek.
                        {
                            MessageBox.Show("Admin Paneline Yöneliyorsunuz...");
                            label4.Text = "Giriş Yapıldı...";
                            Form4 form4 = new Form4();
                            this.Hide();
                            form4.Show();
                            break;
                            
                        }
                       else if (username == kullanici_ad && pass == kullanici_password && kullanici_rol == "a" && radioButton2.Checked) // veriler veri tabınından çekilecek.
                        {
                            MessageBox.Show("alici Paneline Yöneliyorsunuz...");
                            label4.Text = "Giriş Yapıldı...";
                            aliciEkran alici = new aliciEkran();
                            alici.Show();
                            this.Hide();
                            break;

                        }
                       else if (username == kullanici_ad && pass == kullanici_password && kullanici_rol == "s" && radioButton3.Checked) // veriler veri tabınından çekilecek.
                        {
                            MessageBox.Show("satici Paneline Yöneliyorsunuz...");
                            label4.Text = "Giriş Yapıldı...";
                            saticiEkran satici = new saticiEkran();
                            satici.Show();
                            this.Hide();
                            break;

                        }
                    else
                    {
                        label4.Text = "KULLANICI ADI VE YA ŞİFRE YA DA ROL YANLIŞTIR...";
                    }
                }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ve ya parola boş bırakılamaz.....");
                }  
                baglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();

        }
    }
}
