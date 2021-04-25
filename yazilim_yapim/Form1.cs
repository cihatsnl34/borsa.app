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
 
                if (radioButton1.Checked) // admin giriş

                {
                if (username != "" && pass != "")
                {

                    while (reader.Read())
                    {
                        string kullanici_ad = reader["kullanici_ad"].ToString();
                        string kullanici_password = reader["kullanici_password"].ToString();
                        string kullanici_rol = reader["kullanici_rol"].ToString();
                        if (username == kullanici_ad && pass == kullanici_password && kullanici_rol=="admin") // veriler veri tabınından çekilecek.
                        {
                            MessageBox.Show("Admin Paneline Yöneliyorsunuz...");
                        }
                        else
                        {
                            MessageBox.Show("Yanlış Kullanıcı adı ya da şifre admin şifresi ile uyuşmuyor");

                        }
                    }
                }

                else
                {
                    MessageBox.Show("Kullanıcı adı ve ya parola boş bırakılamaz.....");
                }
                }
                else if (radioButton2.Checked) // Alıcı giriş
                {
                if (username != "" && pass != "")
                {
                    while (reader.Read())
                    {
                        string kullanici_ad = reader["kullanici_ad"].ToString();
                        string kullanici_password = reader["kullanici_password"].ToString();
                        string kullanici_rol = reader["kullanici_rol"].ToString();

                        if (username == kullanici_ad && pass == kullanici_password && kullanici_rol == "alici") // veriler veri tabınından çekilecek.
                        {
                            MessageBox.Show("Alıcı Paneline Yöneliyorsunuz...");
                        }
                        else
                        {
                            MessageBox.Show("Yanlış Kullanıcı adı ya da şifre.....");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ve ya parola boş bırakılamaz.....");
                }
                }
                else if (radioButton3.Checked) // Satici giriş
                {
                if (username != "" && pass != "")
                {
                    while (reader.Read())
                    {
                        string kullanici_ad = reader["kullanici_ad"].ToString();
                        string kullanici_password = reader["kullanici_password"].ToString();
                        string kullanici_rol = reader["kullanici_rol"].ToString();
                        if (username == kullanici_ad && pass == kullanici_password && kullanici_rol == "satici") // veriler veri tabınından çekilecek.
                        {
                            MessageBox.Show("Satıcı Yöneliyorsunuz...");
                        }
                        else
                        {
                            MessageBox.Show("Yanlış Kullanıcı adı ya da şifre.....");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ve ya parola boş bırakılamaz.....");
                }
                }
               
            
            baglan.Close();
        }

       
    }
}
