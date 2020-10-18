namespace Netflix
{
    partial class giris_ekrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris_ekrani));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.oturum_ac = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.kayıt_ol = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.kal = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.birthdate = new System.Windows.Forms.Label();
            this.gun = new System.Windows.Forms.ComboBox();
            this.ay = new System.Windows.Forms.ComboBox();
            this.yıl = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.kaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.geri = new System.Windows.Forms.Button();
            this.uyari = new System.Windows.Forms.Label();
            this.kullanıcı_kayıt = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.kullanıcı_kayıt.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.oturum_ac);
            this.panel2.Location = new System.Drawing.Point(-4, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2055, 81);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(177, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 75);
            this.panel1.TabIndex = 0;
            // 
            // oturum_ac
            // 
            this.oturum_ac.BackColor = System.Drawing.Color.Red;
            this.oturum_ac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oturum_ac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oturum_ac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oturum_ac.Location = new System.Drawing.Point(1653, 12);
            this.oturum_ac.Name = "oturum_ac";
            this.oturum_ac.Size = new System.Drawing.Size(167, 43);
            this.oturum_ac.TabIndex = 6;
            this.oturum_ac.Text = "Oturum Aç";
            this.oturum_ac.UseVisualStyleBackColor = false;
            this.oturum_ac.Click += new System.EventHandler(this.oturum_ac_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(555, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(947, 226);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sınırsız film, dizi ve \r\nçok daha fazlası.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email.Location = new System.Drawing.Point(690, 583);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(453, 53);
            this.email.TabIndex = 4;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // kayıt_ol
            // 
            this.kayıt_ol.BackColor = System.Drawing.Color.Red;
            this.kayıt_ol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kayıt_ol.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıt_ol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kayıt_ol.Location = new System.Drawing.Point(1149, 583);
            this.kayıt_ol.Name = "kayıt_ol";
            this.kayıt_ol.Size = new System.Drawing.Size(250, 53);
            this.kayıt_ol.TabIndex = 5;
            this.kayıt_ol.Text = "Şimdi Deneyin >";
            this.kayıt_ol.UseVisualStyleBackColor = false;
            this.kayıt_ol.Click += new System.EventHandler(this.kayıt_ol_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(891, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 244);
            this.panel3.TabIndex = 0;
            // 
            // kal
            // 
            this.kal.AutoSize = true;
            this.kal.BackColor = System.Drawing.Color.Transparent;
            this.kal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.kal.Location = new System.Drawing.Point(188, 380);
            this.kal.Name = "kal";
            this.kal.Size = new System.Drawing.Size(61, 29);
            this.kal.TabIndex = 1;
            this.kal.Text = "İsim";
            // 
            // user_name
            // 
            this.user_name.BackColor = System.Drawing.Color.Gray;
            this.user_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.user_name.ForeColor = System.Drawing.Color.White;
            this.user_name.Location = new System.Drawing.Point(186, 412);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(427, 42);
            this.user_name.TabIndex = 2;
            this.user_name.TextChanged += new System.EventHandler(this.user_name_TextChanged);
            // 
            // birthdate
            // 
            this.birthdate.AutoSize = true;
            this.birthdate.BackColor = System.Drawing.Color.Transparent;
            this.birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.birthdate.Location = new System.Drawing.Point(181, 457);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(171, 29);
            this.birthdate.TabIndex = 3;
            this.birthdate.Text = "Doğum Tarihi";
            // 
            // gun
            // 
            this.gun.BackColor = System.Drawing.Color.Gray;
            this.gun.FormattingEnabled = true;
            this.gun.Location = new System.Drawing.Point(186, 489);
            this.gun.Name = "gun";
            this.gun.Size = new System.Drawing.Size(96, 39);
            this.gun.TabIndex = 4;
            // 
            // ay
            // 
            this.ay.BackColor = System.Drawing.Color.Gray;
            this.ay.FormattingEnabled = true;
            this.ay.Location = new System.Drawing.Point(288, 489);
            this.ay.Name = "ay";
            this.ay.Size = new System.Drawing.Size(199, 39);
            this.ay.TabIndex = 5;
            this.ay.SelectedIndexChanged += new System.EventHandler(this.ay_SelectedIndexChanged);
            // 
            // yıl
            // 
            this.yıl.BackColor = System.Drawing.Color.Gray;
            this.yıl.FormattingEnabled = true;
            this.yıl.Location = new System.Drawing.Point(493, 489);
            this.yıl.Name = "yıl";
            this.yıl.Size = new System.Drawing.Size(120, 39);
            this.yıl.TabIndex = 6;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label.Location = new System.Drawing.Point(181, 537);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(68, 29);
            this.label.TabIndex = 7;
            this.label.Text = "Şifre";
            this.label.Click += new System.EventHandler(this.label2_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Gray;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(186, 569);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(427, 42);
            this.password.TabIndex = 8;
            // 
            // kaydet
            // 
            this.kaydet.BackColor = System.Drawing.Color.Brown;
            this.kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kaydet.Location = new System.Drawing.Point(1650, 820);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(198, 55);
            this.kaydet.TabIndex = 9;
            this.kaydet.Text = "Kayıt Ol";
            this.kaydet.UseVisualStyleBackColor = false;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(890, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1036, 182);
            this.label2.TabIndex = 10;
            this.label2.Text = "İstediğiniz yerde izleyin. \r\nİstediğiniz zaman iptal edin.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(901, 774);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(940, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "İzlemeye hazır mısın? Şimdi hemen izlemeye başlamak için bilgilerini doldur ve ka" +
    "yıt ol.";
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.Black;
            this.geri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.geri.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geri.ForeColor = System.Drawing.Color.Gray;
            this.geri.Location = new System.Drawing.Point(1990, 0);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(56, 70);
            this.geri.TabIndex = 12;
            this.geri.Text = "<";
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.button1_Click);
            // 
            // uyari
            // 
            this.uyari.AutoSize = true;
            this.uyari.BackColor = System.Drawing.Color.Transparent;
            this.uyari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.uyari.Location = new System.Drawing.Point(184, 621);
            this.uyari.Name = "uyari";
            this.uyari.Size = new System.Drawing.Size(0, 32);
            this.uyari.TabIndex = 13;
            // 
            // kullanıcı_kayıt
            // 
            this.kullanıcı_kayıt.BackColor = System.Drawing.Color.Black;
            this.kullanıcı_kayıt.Controls.Add(this.uyari);
            this.kullanıcı_kayıt.Controls.Add(this.geri);
            this.kullanıcı_kayıt.Controls.Add(this.label3);
            this.kullanıcı_kayıt.Controls.Add(this.label2);
            this.kullanıcı_kayıt.Controls.Add(this.kaydet);
            this.kullanıcı_kayıt.Controls.Add(this.password);
            this.kullanıcı_kayıt.Controls.Add(this.label);
            this.kullanıcı_kayıt.Controls.Add(this.yıl);
            this.kullanıcı_kayıt.Controls.Add(this.ay);
            this.kullanıcı_kayıt.Controls.Add(this.gun);
            this.kullanıcı_kayıt.Controls.Add(this.birthdate);
            this.kullanıcı_kayıt.Controls.Add(this.user_name);
            this.kullanıcı_kayıt.Controls.Add(this.kal);
            this.kullanıcı_kayıt.Controls.Add(this.panel3);
            this.kullanıcı_kayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcı_kayıt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kullanıcı_kayıt.Location = new System.Drawing.Point(-1, 0);
            this.kullanıcı_kayıt.Name = "kullanıcı_kayıt";
            this.kullanıcı_kayıt.Size = new System.Drawing.Size(2050, 1080);
            this.kullanıcı_kayıt.TabIndex = 7;
            this.kullanıcı_kayıt.Visible = false;
            this.kullanıcı_kayıt.Paint += new System.Windows.Forms.PaintEventHandler(this.kullanıcı_kayıt_Paint);
            // 
            // giris_ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 860);
            this.Controls.Add(this.kullanıcı_kayıt);
            this.Controls.Add(this.kayıt_ol);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "giris_ekrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.kullanıcı_kayıt.ResumeLayout(false);
            this.kullanıcı_kayıt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button kayıt_ol;
        private System.Windows.Forms.Button oturum_ac;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label kal;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.Label birthdate;
        private System.Windows.Forms.ComboBox gun;
        private System.Windows.Forms.ComboBox ay;
        private System.Windows.Forms.ComboBox yıl;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Label uyari;
        public System.Windows.Forms.Panel kullanıcı_kayıt;
    }
}

