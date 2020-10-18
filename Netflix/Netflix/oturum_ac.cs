using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Netflix
{
    public partial class oturum_ac : Form
    {
        Form opener;
        public oturum_ac(Form giris_ekrani)
        {
            InitializeComponent();
            opener = giris_ekrani;

        }
        string kullanici_id;
        private void o_geri_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void o_email_TextChanged(object sender, EventArgs e)
        {

        }

 
    

        public void oturum_Click_1(object sender, EventArgs e)
        {

            // a.button1.Visible = false;

            // this.Visible = false;
            bool hata = true;
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("select*from kullanici '", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            while(aranmis.Read())
            {
                if(aranmis["email"].ToString() == o_email.Text && aranmis["password"].ToString()==o_sifre.Text)
                {
                    hata = false;
                    kullanici_id = aranmis.GetValue(0).ToString();
                    Console.WriteLine(kullanici_id);
                    opener.Hide();
                    this.Hide();
                    Form2 a = new Form2(kullanici_id);
                    a.Show();

                }
                
            }
            baglanti.Close();
            if(hata==true)
            {
                MessageBox.Show("Kullanıcı Adını veya Şifreyi Kontrol Ediniz!");
            }
            

            

            
              
        }
    }
}
