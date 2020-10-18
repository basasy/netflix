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
    public partial class Form2 : Form
    {
        public Form2(string kullanici_id)
        {
            InitializeComponent();
            buton_ekle(butonlar);
            this.kullanici_id = kullanici_id;
            k_bilgileri();
        }
        List<Button> butonlar = new List<Button>();
        string kullanici_id;
        string adi, tipi, sure, puan, program_ID;
        string bolum = "";
        private List<Button> buton_ekle(List<Button> butonlar)
        {
            
            for (int x = 1; x <=75; x++)
            {
                if(x!=33)
                {
                    var buttonName = string.Format("button{0}", x);
                    Button tbx = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
                    butonlar.Add(tbx);
                }
                
                
            }
            return butonlar;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void k_bilgileri()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select*from kullanici'", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {
                if (aranmis["kullanıcı_ID"].ToString() == this.kullanici_id )
                {
                    k_ismi.Text = aranmis.GetValue(1).ToString();

                }

            }
            baglanti.Close();
        }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {

        }

        private void button44_Click(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {

        }

        private void button48_Click(object sender, EventArgs e)
        {

        }

        private void button50_Click(object sender, EventArgs e)
        {

        }

        private void button52_Click(object sender, EventArgs e)
        {

        }

        private void button54_Click(object sender, EventArgs e)
        {

        }

        private void button57_Click(object sender, EventArgs e)
        {

        }

        private void button63_Click(object sender, EventArgs e)
        {

        }

        private void arama_Click(object sender, EventArgs e)
        {
            tur.Visible = true;
            ad.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            
            
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=1", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {
                
                adi = aranmis.GetValue(1).ToString();
                tipi= aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString()+",";
                program_ID = aranmis.GetValue(0).ToString();
                              

            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi,tipi,sure,puan,program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=2", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=3", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=4", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=5", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
        

            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=6", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=7", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=8", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=9", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=10", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=11", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=12", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=13", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=14", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=15", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=20", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=16", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=17", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=18", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=19", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=21", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=22", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {

            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=23", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=24", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=25", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=26", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=27", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=28", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button29_Click(object sender, EventArgs e)
        {
           
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=29", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=30", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=31", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=32", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=33", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=34", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=35", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=36", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button38_Click_1(object sender, EventArgs e)
        {
            
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=37", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=38", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=39", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=40", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=41", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button43_Click_1(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=42", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button44_Click_1(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=43", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=44", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button46_Click_1(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=45", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            

            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=46", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button48_Click_1(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=47", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=48", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button50_Click_1(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=49", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string tur = "";
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();


            }
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, sure, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            baglanti.Close();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=50", baglanti);           
            string tur = "";           
            OleDbDataReader aranmis = komut.ExecuteReader();           
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for(int i=1;i<=bolum_sayisi;i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();
        }

        private void button52_Click_1(object sender, EventArgs e)
        {

            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=51", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }
            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=52", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

           
            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();

        }

        private void button54_Click_1(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=53", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

           
            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();

        }

        private void button55_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=54", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

          
            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=55", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();
        }

        private void button57_Click_1(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=56", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=57", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=58", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close(); 
        }

        private void button60_Click(object sender, EventArgs e)
        {

            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=59", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=60", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=61", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();
        }

        private void button63_Click_1(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=62", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();
        }

        private void button64_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=63", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();
        }

        private void button65_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=64", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();
            }


            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();
        }

        private void button66_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=65", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();
        }

        private void button67_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=66", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();
        }

        private void button68_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=67", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();
        }

        private void button69_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=68", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=69", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();
        }

        private void button71_Click(object sender, EventArgs e)
        {

            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=70", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();
        }

        private void button72_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=71", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();
        }

        private void button73_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=72", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();
        }

        private void button74_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=73", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();
        }

        private void button75_Click(object sender, EventArgs e)
        {

            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND program.program_ID=74", baglanti);
            string tur = "";
            OleDbDataReader aranmis = komut.ExecuteReader();
            while (aranmis.Read())
            {

                adi = aranmis.GetValue(1).ToString();
                tipi = aranmis.GetValue(2).ToString();
                sure = aranmis.GetValue(4).ToString();
                puan = aranmis.GetValue(5).ToString();
                tur += aranmis.GetValue(9).ToString() + ",";
                program_ID = aranmis.GetValue(0).ToString();
                bolum = aranmis.GetValue(3).ToString();


            }

            int bolum_sayisi = Int32.Parse(bolum);
            int bolum_suresi = Int32.Parse(sure);
            bolum_suresi = bolum_suresi / bolum_sayisi;
            bolum = bolum_suresi.ToString();
            program_bilgi bilgi = new program_bilgi(kullanici_id, adi, tipi, bolum, puan, program_ID);
            bilgi.StartPosition = FormStartPosition.Manual;
            bilgi.Location = new Point(390, 150);
            bilgi.Show();
            bilgi.tur.Text = tur;
            bilgi.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID + ".jpg");
            bilgi.bolum.Visible = true;
            bilgi.bolum.Items.Clear();
            for (int i = 1; i <= bolum_sayisi; i++)
            {
                bilgi.bolum.Items.Add(i);
            }
            bilgi.tur.Text = tur;
            baglanti.Close();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tur_CheckedChanged(object sender, EventArgs e)
        {
            isim.Visible = false;
            tur_liste.Visible = true;
            tur_liste.Items.Clear();
            
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM tur", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            
            while (aranmis.Read())
            {
                tur_liste.Items.Add(aranmis.GetValue(1).ToString());

            }
            baglanti.Close();
            
           
            

        }

        private void ad_CheckedChanged(object sender, EventArgs e)
        {
            tur_liste.Visible = false;
            isim.Visible = true;
           
        }

        private void tur_liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();
           
            
            for(int i=0;i<butonlar.Count;i++)
            {
                butonlar[i].Visible = false;
            }
            OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID", baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            string ıd ="";
            int id;
            while (aranmis.Read())
            {
                if(aranmis["turler"].ToString() == tur_liste.Text)
                {
                    ıd = aranmis.GetValue(0).ToString();
                    id = Int32.Parse(ıd)-1;
                    Console.WriteLine(id);
                    // Console.WriteLine(butonlar[id].Name);
                    butonlar[id].Visible = true;

                }

            }
            baglanti.Close();
        }

        private void isim_TextChanged(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
            baglanti.Open();
            string query = "SELECT * FROM program WHERE program.program LIKE " + "'" + isim.Text + "%" + "'";
            //Console.WriteLine(query);
            for (int i = 0; i < butonlar.Count; i++)
            {
                butonlar[i].Visible = false;
            }
            OleDbCommand komut = new OleDbCommand(query, baglanti);
            OleDbDataReader aranmis = komut.ExecuteReader();
            Console.WriteLine(query);
            int id;
            while (aranmis.Read())
            {
                id = Int32.Parse(aranmis.GetValue(0).ToString())-1;
                butonlar[id].Visible = true;

            }
            baglanti.Close();
        }
    }
}
