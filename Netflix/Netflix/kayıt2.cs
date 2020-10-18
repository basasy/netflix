using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Netflix
{
    public partial class kayıt2 : Form
    {
        public kayıt2()
        {
            InitializeComponent();
            
        }
        int secim = 0;
        
        private void aksiyon_Click(object sender, EventArgs e)
        {
            string[] program = new string[2];
            string[] puan = new string[2];
            string[] program_ID = new string[2];
            if (secim<3)
            {   
                    aksiyon.Enabled = false;
                    
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
                    baglanti.Open();

                    OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND tur.tur_ID=1 ORDER BY program.puan DESC", baglanti);
                    OleDbDataReader aranmis = komut.ExecuteReader();
                int iki = 0;
                    while (aranmis.Read())
                    {
                       if(iki<2)
                    {
                        program[iki] = aranmis.GetValue(1).ToString();
                        puan[iki] = aranmis.GetValue(5).ToString();
                        program_ID[iki] = aranmis.GetValue(0).ToString();
                        Console.WriteLine(program[iki]);
                        Console.WriteLine(program[iki]);
                        iki++;
                    }
                        
                    }
                    if(secim==0)
                {
                    label1.Text = program[0] + "\nPuan:" + puan[0];
                    label4.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox1.Visible = true;
                    pictureBox4.Visible = true;
                }
                    else if(secim==1)
                {
                    label2.Text = program[0] + "\nPuan:" + puan[0];
                    label5.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox5.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox2.Visible = true;
                    pictureBox5.Visible = true;
                }
                    else if(secim==2)
                {
                    label3.Text = program[0] + "\nPuan:" + puan[0];
                    label6.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox6.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox6.Visible = true;
                    pictureBox3.Visible = true;
                }
                secim++;

                baglanti.Close();
                
            }
            
            
        }

        private void macera_Click(object sender, EventArgs e)
        {
            string[] program = new string[2];
            string[] puan = new string[2];
            string[] program_ID = new string[2];
            if (secim < 3)
            {
                macera.Enabled = false;

                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND tur.tur_ID=11 ORDER BY program.puan DESC", baglanti);
                OleDbDataReader aranmis = komut.ExecuteReader();
                int iki = 0;
                while (aranmis.Read())
                {
                    if (iki < 2)
                    {
                        program[iki] = aranmis.GetValue(1).ToString();
                        puan[iki] = aranmis.GetValue(5).ToString();
                        program_ID[iki] = aranmis.GetValue(0).ToString();
                        Console.WriteLine(program[iki]);
                        Console.WriteLine(program[iki]);
                        iki++;
                    }

                }
                if (secim == 0)
                {
                    label1.Text = program[0] + "\nPuan:" + puan[0];
                    label4.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox1.Visible = true;
                    pictureBox4.Visible = true;
                }
                else if (secim == 1)
                {
                    label2.Text = program[0] + "\nPuan:" + puan[0];
                    label5.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox5.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox2.Visible = true;
                    pictureBox5.Visible = true;
                }
                else if (secim == 2)
                {
                    label3.Text = program[0] + "\nPuan:" + puan[0];
                    label6.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox6.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox6.Visible = true;
                    pictureBox3.Visible = true;
                }
                secim++;

                baglanti.Close();

            }
        }

        private void belgesel_Click(object sender, EventArgs e)
        {
            string[] program = new string[2];
            string[] puan = new string[2];
            string[] program_ID = new string[2];
            if (secim < 3)
            {
                belgesel.Enabled = false;

                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND tur.tur_ID=2 ORDER BY program.puan DESC", baglanti);
                OleDbDataReader aranmis = komut.ExecuteReader();
                int iki = 0;
                while (aranmis.Read())
                {
                    if (iki < 2)
                    {
                        program[iki] = aranmis.GetValue(1).ToString();
                        puan[iki] = aranmis.GetValue(5).ToString();
                        program_ID[iki] = aranmis.GetValue(0).ToString();
                        Console.WriteLine(program[iki]);
                        Console.WriteLine(program[iki]);
                        iki++;
                    }

                }
                if (secim == 0)
                {
                    label1.Text = program[0] + "\nPuan:" + puan[0];
                    label4.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox1.Visible = true;
                    pictureBox4.Visible = true;
                }
                else if (secim == 1)
                {
                    label2.Text = program[0] + "\nPuan:" + puan[0];
                    label5.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox5.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox2.Visible = true;
                    pictureBox5.Visible = true;
                }
                else if (secim == 2)
                {
                    label3.Text = program[0] + "\nPuan:" + puan[0];
                    label6.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox6.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox6.Visible = true;
                    pictureBox3.Visible = true;
                }
                secim++;

                baglanti.Close();
            }
        }

        private void bilimkurgu_Click(object sender, EventArgs e)
        {
            string[] program = new string[2];
            string[] puan = new string[2];
            string[] program_ID = new string[2];
            if (secim < 3)
            {
                bilimkurgu.Enabled = false;

                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND tur.tur_ID=3 ORDER BY program.puan DESC", baglanti);
                OleDbDataReader aranmis = komut.ExecuteReader();
                int iki = 0;
                while (aranmis.Read())
                {
                    if (iki < 2)
                    {
                        program[iki] = aranmis.GetValue(1).ToString();
                        puan[iki] = aranmis.GetValue(5).ToString();
                        program_ID[iki] = aranmis.GetValue(0).ToString();
                        Console.WriteLine(program[iki]);
                        Console.WriteLine(program[iki]);
                        iki++;
                    }

                }
                if (secim == 0)
                {
                    label1.Text = program[0] + "\nPuan:" + puan[0];
                    label4.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox1.Visible = true;
                    pictureBox4.Visible = true;
                }
                else if (secim == 1)
                {
                    label2.Text = program[0] + "\nPuan:" + puan[0];
                    label5.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox5.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox2.Visible = true;
                    pictureBox5.Visible = true;
                }
                else if (secim == 2)
                {
                    label3.Text = program[0] + "\nPuan:" + puan[0];
                    label6.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox6.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox6.Visible = true;
                    pictureBox3.Visible = true;
                }
                secim++;

                baglanti.Close();
            }
        }

        private void cocuk_Click(object sender, EventArgs e)
        {
            string[] program = new string[2];
            string[] puan = new string[2];
            string[] program_ID = new string[2];
            if (secim < 3)
            {
                cocuk.Enabled = false;

                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND tur.tur_ID=4 ORDER BY program.puan DESC", baglanti);
                OleDbDataReader aranmis = komut.ExecuteReader();
                int iki = 0;
                while (aranmis.Read())
                {
                    if (iki < 2)
                    {
                        program[iki] = aranmis.GetValue(1).ToString();
                        puan[iki] = aranmis.GetValue(5).ToString();
                        program_ID[iki] = aranmis.GetValue(0).ToString();
                        Console.WriteLine(program[iki]);
                        Console.WriteLine(program[iki]);
                        iki++;
                    }

                }
                if (secim == 0)
                {
                    label1.Text = program[0] + "\nPuan:" + puan[0];
                    label4.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox1.Visible = true;
                    pictureBox4.Visible = true;
                }
                else if (secim == 1)
                {
                    label2.Text = program[0] + "\nPuan:" + puan[0];
                    label5.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox5.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox2.Visible = true;
                    pictureBox5.Visible = true;
                }
                else if (secim == 2)
                {
                    label3.Text = program[0] + "\nPuan:" + puan[0];
                    label6.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox6.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox6.Visible = true;
                    pictureBox3.Visible = true;
                }
                secim++;

                baglanti.Close();
            }
        }

        private void drama_Click(object sender, EventArgs e)
        {
            string[] program = new string[2];
            string[] puan = new string[2];
            string[] program_ID = new string[2];
            if (secim < 3)
            {
                drama.Enabled = false;

                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND tur.tur_ID=5 ORDER BY program.puan DESC", baglanti);
                OleDbDataReader aranmis = komut.ExecuteReader();
                int iki = 0;
                while (aranmis.Read())
                {
                    if (iki < 2)
                    {
                        program[iki] = aranmis.GetValue(1).ToString();
                        puan[iki] = aranmis.GetValue(5).ToString();
                        program_ID[iki] = aranmis.GetValue(0).ToString();
                        Console.WriteLine(program[iki]);
                        Console.WriteLine(program[iki]);
                        iki++;
                    }

                }
                if (secim == 0)
                {
                    label1.Text = program[0] + "\nPuan:" + puan[0];
                    label4.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox1.Visible = true;
                    pictureBox4.Visible = true;
                }
                else if (secim == 1)
                {
                    label2.Text = program[0] + "\nPuan:" + puan[0];
                    label5.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox5.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox2.Visible = true;
                    pictureBox5.Visible = true;
                }
                else if (secim == 2)
                {
                    label3.Text = program[0] + "\nPuan:" + puan[0];
                    label6.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox6.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox6.Visible = true;
                    pictureBox3.Visible = true;
                }
                secim++;

                baglanti.Close();
            }
        }

        private void gerilim_Click(object sender, EventArgs e)
        {
            string[] program = new string[2];
            string[] puan = new string[2];
            string[] program_ID = new string[2];
            if (secim < 3)
            {
                gerilim.Enabled = false;

                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND tur.tur_ID=6 ORDER BY program.puan DESC", baglanti);
                OleDbDataReader aranmis = komut.ExecuteReader();
                int iki = 0;
                while (aranmis.Read())
                {
                    if (iki < 2)
                    {
                        program[iki] = aranmis.GetValue(1).ToString();
                        puan[iki] = aranmis.GetValue(5).ToString();
                        program_ID[iki] = aranmis.GetValue(0).ToString();
                        Console.WriteLine(program[iki]);
                        Console.WriteLine(program[iki]);
                        iki++;
                    }

                }
                if (secim == 0)
                {
                    label1.Text = program[0] + "\nPuan:" + puan[0];
                    label4.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox1.Visible = true;
                    pictureBox4.Visible = true;
                }
                else if (secim == 1)
                {
                    label2.Text = program[0] + "\nPuan:" + puan[0];
                    label5.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox5.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox2.Visible = true;
                    pictureBox5.Visible = true;
                }
                else if (secim == 2)
                {
                    label3.Text = program[0] + "\nPuan:" + puan[0];
                    label6.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox6.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox6.Visible = true;
                    pictureBox3.Visible = true;
                }
                secim++;

                baglanti.Close();
            }
        }

        private void komedi_Click(object sender, EventArgs e)
        {
            string[] program = new string[2];
            string[] puan = new string[2];
            string[] program_ID = new string[2];
            if (secim < 3)
            {
                komedi.Enabled = false;

                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND tur.tur_ID=7 ORDER BY program.puan DESC", baglanti);
                OleDbDataReader aranmis = komut.ExecuteReader();
                int iki = 0;
                while (aranmis.Read())
                {
                    if (iki < 2)
                    {
                        program[iki] = aranmis.GetValue(1).ToString();
                        puan[iki] = aranmis.GetValue(5).ToString();
                        program_ID[iki] = aranmis.GetValue(0).ToString();
                        Console.WriteLine(program[iki]);
                        Console.WriteLine(program[iki]);
                        iki++;
                    }

                }
                if (secim == 0)
                {
                    label1.Text = program[0] + "\nPuan:" + puan[0];
                    label4.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox1.Visible = true;
                    pictureBox4.Visible = true;
                }
                else if (secim == 1)
                {
                    label2.Text = program[0] + "\nPuan:" + puan[0];
                    label5.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox5.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox2.Visible = true;
                    pictureBox5.Visible = true;
                }
                else if (secim == 2)
                {
                    label3.Text = program[0] + "\nPuan:" + puan[0];
                    label6.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox6.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox6.Visible = true;
                    pictureBox3.Visible = true;
                }
                secim++;

                baglanti.Close();
            }
        }

        private void korku_Click(object sender, EventArgs e)
        {
            string[] program = new string[2];
            string[] puan = new string[2];
            string[] program_ID = new string[2];
            if (secim < 3)
            {
                korku.Enabled = false;

                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND tur.tur_ID=8 ORDER BY program.puan DESC", baglanti);
                OleDbDataReader aranmis = komut.ExecuteReader();
                int iki = 0;
                while (aranmis.Read())
                {
                    if (iki < 2)
                    {
                        program[iki] = aranmis.GetValue(1).ToString();
                        puan[iki] = aranmis.GetValue(5).ToString();
                        program_ID[iki] = aranmis.GetValue(0).ToString();
                        Console.WriteLine(program[iki]);
                        Console.WriteLine(program[iki]);
                        iki++;
                    }

                }
                if (secim == 0)
                {
                    label1.Text = program[0] + "\nPuan:" + puan[0];
                    label4.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox1.Visible = true;
                    pictureBox4.Visible = true;
                }
                else if (secim == 1)
                {
                    label2.Text = program[0] + "\nPuan:" + puan[0];
                    label5.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox5.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox2.Visible = true;
                    pictureBox5.Visible = true;
                }
                else if (secim == 2)
                {
                    label3.Text = program[0] + "\nPuan:" + puan[0];
                    label6.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox6.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox6.Visible = true;
                    pictureBox3.Visible = true;
                }
                secim++;

                baglanti.Close();
            }
        }

        private void romantik_Click(object sender, EventArgs e)
        {
            string[] program = new string[2];
            string[] puan = new string[2];
            string[] program_ID = new string[2];
            if (secim < 3)
            {
                romantik.Enabled = false;

                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND tur.tur_ID=9 ORDER BY program.puan DESC", baglanti);
                OleDbDataReader aranmis = komut.ExecuteReader();
                int iki = 0;
                while (aranmis.Read())
                {
                    if (iki < 2)
                    {
                        program[iki] = aranmis.GetValue(1).ToString();
                        puan[iki] = aranmis.GetValue(5).ToString();
                        program_ID[iki] = aranmis.GetValue(0).ToString();
                        Console.WriteLine(program[iki]);
                        Console.WriteLine(program[iki]);
                        iki++;
                    }

                }
                if (secim == 0)
                {
                    label1.Text = program[0] + "\nPuan:" + puan[0];
                    label4.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox1.Visible = true;
                    pictureBox4.Visible = true;
                }
                else if (secim == 1)
                {
                    label2.Text = program[0] + "\nPuan:" + puan[0];
                    label5.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox5.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox2.Visible = true;
                    pictureBox5.Visible = true;
                }
                else if (secim == 2)
                {
                    label3.Text = program[0] + "\nPuan:" + puan[0];
                    label6.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox6.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox6.Visible = true;
                    pictureBox3.Visible = true;
                }
                secim++;

                baglanti.Close();
            }
        }

        private void bilimdoga_Click(object sender, EventArgs e)
        {
            string[] program = new string[2];
            string[] puan = new string[2];
            string[] program_ID = new string[2];
            if (secim < 3)
            {
                bilimdoga.Enabled = false;

                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND tur.tur_ID=10 ORDER BY program.puan DESC", baglanti);
                OleDbDataReader aranmis = komut.ExecuteReader();
                int iki = 0;
                while (aranmis.Read())
                {
                    if (iki < 2)
                    {
                        program[iki] = aranmis.GetValue(1).ToString();
                        puan[iki] = aranmis.GetValue(5).ToString();
                        program_ID[iki] = aranmis.GetValue(0).ToString();
                        Console.WriteLine(program[iki]);
                        Console.WriteLine(program[iki]);
                        iki++;
                    }

                }
                if (secim == 0)
                {
                    label1.Text = program[0] + "\nPuan:" + puan[0];
                    label4.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox1.Visible = true;
                    pictureBox4.Visible = true;
                }
                else if (secim == 1)
                {
                    label2.Text = program[0] + "\nPuan:" + puan[0];
                    label5.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox5.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox2.Visible = true;
                    pictureBox5.Visible = true;
                }
                else if (secim == 2)
                {
                    label3.Text = program[0] + "\nPuan:" + puan[0];
                    label6.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox6.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox6.Visible = true;
                    pictureBox3.Visible = true;
                }
                secim++;

                baglanti.Close();
            }
        }

        private void reality_Click(object sender, EventArgs e)
        {
            string[] program = new string[2];
            string[] puan = new string[2];
            string[] program_ID = new string[2];
            if (secim < 3)
            {
                reality.Enabled = false;

                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND tur.tur_ID=12 ORDER BY program.puan DESC", baglanti);
                OleDbDataReader aranmis = komut.ExecuteReader();
                int iki = 0;
                while (aranmis.Read())
                {
                    if (iki < 2)
                    {
                        program[iki] = aranmis.GetValue(1).ToString();
                        puan[iki] = aranmis.GetValue(5).ToString();
                        program_ID[iki] = aranmis.GetValue(0).ToString();
                        Console.WriteLine(program[iki]);
                        Console.WriteLine(program[iki]);
                        iki++;
                    }

                }
                if (secim == 0)
                {
                    label1.Text = program[0] + "\nPuan:" + puan[0];
                    label4.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox1.Visible = true;
                    pictureBox4.Visible = true;
                }
                else if (secim == 1)
                {
                    label2.Text = program[0] + "\nPuan:" + puan[0];
                    label5.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox5.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox2.Visible = true;
                    pictureBox5.Visible = true;
                }
                else if (secim == 2)
                {
                    label3.Text = program[0] + "\nPuan:" + puan[0];
                    label6.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox6.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox6.Visible = true;
                    pictureBox3.Visible = true;
                }
                secim++;

                baglanti.Close();
            }
        }

        private void anime_Click(object sender, EventArgs e)
        {
            string[] program = new string[2];
            string[] puan = new string[2];
            string[] program_ID = new string[2];
            if (secim < 3)
            {
                aksiyon.Enabled = false;

                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.oleDb.12.0;Data Source=netflix_DB.accdb");
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("SELECT * FROM program, program_tur, tur WHERE program.program_ID = program_tur.program_ID AND tur.tur_ID = program_tur.tur_ID AND tur.tur_ID=13 ORDER BY program.puan DESC", baglanti);
                OleDbDataReader aranmis = komut.ExecuteReader();
                int iki = 0;
                while (aranmis.Read())
                {
                    if (iki < 2)
                    {
                        program[iki] = aranmis.GetValue(1).ToString();
                        puan[iki] = aranmis.GetValue(5).ToString();
                        program_ID[iki] = aranmis.GetValue(0).ToString();
                        Console.WriteLine(program[iki]);
                        Console.WriteLine(program[iki]);
                        iki++;
                    }

                }
                if (secim == 0)
                {
                    label1.Text = program[0] + "\nPuan:" + puan[0];
                    label4.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox1.Visible = true;
                    pictureBox4.Visible = true;
                }
                else if (secim == 1)
                {
                    label2.Text = program[0] + "\nPuan:" + puan[0];
                    label5.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox5.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox2.Visible = true;
                    pictureBox5.Visible = true;
                }
                else if (secim == 2)
                {
                    label3.Text = program[0] + "\nPuan:" + puan[0];
                    label6.Text = program[1] + "\nPuan: " + puan[1];
                    pictureBox3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[0] + ".jpg");
                    pictureBox6.BackgroundImage = Image.FromFile(Application.StartupPath + "\\splashart\\" + program_ID[1] + ".jpg");
                    pictureBox6.Visible = true;
                    pictureBox3.Visible = true;
                }
                secim++;

                baglanti.Close();
            }
        }

        private void tekrar_Click(object sender, EventArgs e)
        {
            aksiyon.Enabled = true;
            macera.Enabled = true;
            belgesel.Enabled = true;
            bilimkurgu.Enabled = true;
            cocuk.Enabled = true;
            drama.Enabled = true;
            gerilim.Enabled = true;
            komedi.Enabled = true;
            korku.Enabled = true;
            romantik.Enabled = true;
            bilimdoga.Enabled = true;
            reality.Enabled = true;
            anime.Enabled = true;
            label1.Text = "";
            label4.Text = "";
        
                    label2.Text = "";
                    label5.Text = "";
               
                    label3.Text = "";
                    label6.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            secim = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void devam_Click(object sender, EventArgs e)
        {
            this.Close();
            mesagge m = new mesagge();
            m.Location = new Point(390, 150);
            m.Show();
            

        }
    }
}
