using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Netflix
{
    public partial class giris_ekrani : Form
    {
        
        public giris_ekrani()
        {
            
            InitializeComponent();
            
        }
        string[] aylar = {"Ocak","Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim",
            "Kasım", "Aralık" };
        string[] yillar = new string[40];
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
        
        private string[] yıl_ata(string[] yıl)
        {
            int baslangic=1980;
            
            for(int i=0;i<yıl.Length;i++)
            {
                yıl[i] = baslangic.ToString();
                baslangic++;
            }
            return yıl;
           
        }
        
        private void tarih()
        {
           yillar = yıl_ata(yillar);
            
            yıl.Items.AddRange(yillar);
            ay.Items.AddRange(aylar);
        }


        
        // Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\bin\Debug\Database4.mdb
        


        private void oturum_ac_Click(object sender, EventArgs e)
        {
            
            oturum_ac oturum = new oturum_ac(this);
            oturum.Show();
            
            
           
          
        }

        private void kayıt_ol_Click(object sender, EventArgs e)
        {
            kullanıcı_kayıt.Visible = true;
            tarih();

        }

        private void user_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            if(user_name.Text.Equals(""))
            {
                uyari.Text = "İsim kısmı boş bırakılamaz.";
            }
            else if(password.Text.Equals(""))
            {
                uyari.Text = "Lütfen bir şifre belirleyiniz.";
            }
            else if(gun.Text.Equals("") || ay.Text.Equals("") || yıl.Text.Equals(""))
            {
                uyari.Text = "Doğum tarihini eksik veya boş bırakmayınız.";
            }
            else
            {
                
                string tarih;
                tarih = gun.Text + "." + "5" + "." + yıl.Text;
              //  Console.WriteLine(tarih);
                try
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("insert into kullanici([user_name],[email],[password],[birthdate])values ('" + user_name.Text + "','" + email.Text +"','"+password.Text+"','"+tarih+ "')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    kayıt2 kayit2 = new kayıt2();
                    kayit2.Show();

                }
                catch(Exception erormsj)
                {
                    uyari.Text= "Bu e posta daha önce kullanılmışdır.";
                    baglanti.Close();
                }
                kullanıcı_kayıt.Visible = false;
                
                //OleDbCommand komut = new OleDbCommand("İnsert into kullanıcı (user_name,email,password,birthdate) values('" + user_name.Text.ToString()+"','" + email.Text.ToString()+"','" + password.Text.ToString()+"','" + tarih);
                // baglanti.Close();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanıcı_kayıt.Visible = false;
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
           // email.Text = "E-mail adresini gir ve heme şimdi dene";
        }

        private void ay_SelectedIndexChanged(object sender, EventArgs e)
        {
            gun.Items.Clear();
            for (int i=0;i<12;i++)
            {
                if(ay.Text.Equals(aylar[i]))
                {
                    if (i == 0 || i == 2 || i == 4 || i == 6 || i == 7 || i == 9 || i == 11)
                    {
                        int g_baslangic = 1;
                        string[] gunler = new string[31];
                        for (int j = 0; j < gunler.Length; j++)
                        {

                            gunler[j] = g_baslangic.ToString();
                            g_baslangic++;
                        }
                        
                        gun.Items.AddRange(gunler);
                    }
                    else if (i == 1)
                    {
                        int g_baslangic = 1;
                        string[] gunler = new string[29];
                        for (int j = 0; j < gunler.Length; j++)
                        {

                            gunler[j] = g_baslangic.ToString();
                            g_baslangic++;
                        }
                        gun.Items.AddRange(gunler);
                    }
                    else
                    {
                        int g_baslangic = 1;
                        string[] gunler = new string[30];
                        for (int j = 0; j < gunler.Length; j++)
                        {

                            gunler[j] = g_baslangic.ToString();
                            g_baslangic++;
                        }
                        gun.Items.AddRange(gunler);
                    }
                }
            }


        }

        private void kullanıcı_kayıt_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
