using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Netflix
{
    public partial class program_bilgi : Form
    {
        public program_bilgi(string kullanici_id, string adi, string tipi, string sure, string puan, string program_ID)
        {
            InitializeComponent();
            this.kullanici_id = Int32.Parse(kullanici_id);
            // Console.WriteLine(kullanici_id);
            this.adi.Text = adi;
            this.tipi.Text = tipi;
            ilk_sure = sure;
            this.program_ID = Int32.Parse(program_ID);
            tarih.Text = "";
            doldur(sure, puan);

        }

        int i = 0, sure_bolum,metin;
        double  k_puani;
        int dakika = 0;
        int zaman, kullanici_id, program_ID, dakika1=0;
        public string sure1;
        string su_an, puan1, bolum_kal, ilk_sure;        
        bool kontrol = false;
        private void guncelle ()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");

            string tarih;
            tarih = DateTime.Now.ToString();

            // Console.WriteLine(tarih);
            if (kontrol == true)
            {
                baglanti.Open();
                Console.WriteLine("girdi guncelle");
                try
                {
                    string sqlkomut = "UPDATE kullaniciProgram set izleme_tarihi=" + "'"+this.tarih.Text+"'" + ",izleme_suresi =" + dakika1 + ",puan=" +"'" +this.puan.Text+"'" + ",bolum =" + "'"+ this.bolum.Text +"'"+ "WHERE program_ID = " + program_ID;
                    OleDbCommand komut1 = new OleDbCommand(sqlkomut, baglanti);
                    komut1.ExecuteNonQuery();
                    baglanti.Close();


                }
                catch (Exception erormsj)
                {
                    MessageBox.Show(erormsj.ToString());
                    baglanti.Close();
                }

            }
        }
        private void button2_Click(object sender, EventArgs e) //BURADa
        {
            
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            
            string tarih;
            tarih = DateTime.Now.ToString();
           
           // Console.WriteLine(tarih);
           if(kontrol == false)
            {
                baglanti.Open();
                Console.WriteLine("girdi");
                try
                {
                    kontrol = true;
                    OleDbCommand komut1 = new OleDbCommand("insert into kullaniciProgram([kullanıcı_ID],[program_ID],[izleme_suresi],[puan], [izleme_tarihi], [bolum])values ('" + kullanici_id + "','" + program_ID + "','" + dakika + "','" + puan.Text + "','" + tarih +  "','" + bolum.Text + "')", baglanti);
                    komut1.ExecuteNonQuery();
                    baglanti.Close();


                }
                catch (Exception erormsj)
                {
                    MessageBox.Show(erormsj.ToString());
                    baglanti.Close();
                }

            }
           else if(kontrol ==true)
            {
                guncelle();
            }

            this.Close();
            bolum.Visible = false;


        }
        void doldur(string sure, string puan)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();
            Console.WriteLine("edfsfa");
            OleDbCommand komut = new OleDbCommand("SELECT * FROM kullaniciProgram", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            Console.WriteLine("id: " + program_ID);
            while (aranmis.Read())
            {
                if (aranmis["program_ID"].ToString() == program_ID.ToString())
                {
                    kontrol = true;
                    su_an = aranmis.GetValue(1).ToString();              
                    tarih.Text = su_an;                
                    kal_bolum.Text = aranmis.GetValue(3).ToString();
                    Console.WriteLine(kal_bolum.Text);
                    dakika = Int32.Parse(aranmis.GetValue(2).ToString());
                    dakika1 = Int32.Parse(aranmis.GetValue(2).ToString());
                    this.puan.Text = aranmis.GetValue(4).ToString();
                    Console.WriteLine(dakika);
                    sure_bolum = Int32.Parse(sure);
                    sure_bolum = sure_bolum - dakika;
                    this.sure.Text = sure_bolum.ToString();
                   
                }

            }
            dakika = 0;
            if(kontrol==false)
            {
                sure_bolum = Int32.Parse(sure);
                puan1 = puan;
                k_puani = Convert.ToDouble(puan1);
                
                this.sure.Text = sure_bolum.ToString();
                this.puan.Text = puan1;
              

            }

            baglanti.Close();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sure1 = sure_bolum.ToString();
            zaman = Int32.Parse(sure1);
            metin = zaman;
            timer1.Start();
            su_an = DateTime.Now.ToString();
            tarih.Text = su_an;
            
        }

        private void puanla_Click(object sender, EventArgs e)
        {
            puan1 = puan.Text;
            k_puani = Convert.ToDouble(label5.Text);
            k_puani = k_puani * kullanici_id;
            k_puani += Convert.ToDouble(puan1);
            k_puani = k_puani / (kullanici_id + 1);
            puan.Text = k_puani.ToString();
            puan.Text = puan.Text.Remove(4);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!bolum.Text.Equals("Bölüm Seç"))
            {
                sure.Text = ilk_sure;
                sure_bolum = Int32.Parse(sure.Text);

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(i<10)
            {
                i++;
                string puanlar = i.ToString();
                label5.Text = puanlar;
            }
        }
            

        private void button4_Click(object sender, EventArgs e)
        {
            
            if(i > 0)
            {
                i--;
                string puanlar = i.ToString();
                label5.Text = puanlar;

            }
            
        }

        private void program_bilgi_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;

            

        }

        private void adi_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(metin!=0)
            {
                metin = zaman - dakika;
                dakika++;
                dakika1++;
               // Console.WriteLine(metin);
                sure.Text = metin.ToString();
            }
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Console.WriteLine(metin);

        }
    }
}
