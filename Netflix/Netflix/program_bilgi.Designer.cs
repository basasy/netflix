namespace Netflix
{
    partial class program_bilgi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(program_bilgi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.puanla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.adi = new System.Windows.Forms.Label();
            this.tipi = new System.Windows.Forms.Label();
            this.tur = new System.Windows.Forms.Label();
            this.puan = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.sure = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bolum = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kal_bolum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(38, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 227);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(429, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Program Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(429, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Program Türü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(429, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Program Tipi:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // puanla
            // 
            this.puanla.BackColor = System.Drawing.Color.Black;
            this.puanla.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.puanla.FlatAppearance.BorderSize = 2;
            this.puanla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.puanla.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanla.ForeColor = System.Drawing.Color.White;
            this.puanla.Location = new System.Drawing.Point(78, 436);
            this.puanla.Name = "puanla";
            this.puanla.Size = new System.Drawing.Size(125, 39);
            this.puanla.TabIndex = 4;
            this.puanla.Text = "Puanla";
            this.puanla.UseVisualStyleBackColor = false;
            this.puanla.Click += new System.EventHandler(this.puanla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(429, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Program Puanı:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(874, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 51);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adi
            // 
            this.adi.AutoSize = true;
            this.adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adi.ForeColor = System.Drawing.Color.White;
            this.adi.Location = new System.Drawing.Point(573, 81);
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(138, 25);
            this.adi.TabIndex = 9;
            this.adi.Text = "Program Adı:";
            this.adi.TextChanged += new System.EventHandler(this.adi_Click);
            // 
            // tipi
            // 
            this.tipi.AutoSize = true;
            this.tipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tipi.ForeColor = System.Drawing.Color.White;
            this.tipi.Location = new System.Drawing.Point(573, 121);
            this.tipi.Name = "tipi";
            this.tipi.Size = new System.Drawing.Size(138, 25);
            this.tipi.TabIndex = 10;
            this.tipi.Text = "Program Adı:";
            // 
            // tur
            // 
            this.tur.AutoSize = true;
            this.tur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tur.ForeColor = System.Drawing.Color.White;
            this.tur.Location = new System.Drawing.Point(586, 161);
            this.tur.Name = "tur";
            this.tur.Size = new System.Drawing.Size(138, 25);
            this.tur.TabIndex = 11;
            this.tur.Text = "Program Adı:";
            // 
            // puan
            // 
            this.puan.AutoSize = true;
            this.puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puan.ForeColor = System.Drawing.Color.White;
            this.puan.Location = new System.Drawing.Point(586, 197);
            this.puan.Name = "puan";
            this.puan.Size = new System.Drawing.Size(138, 25);
            this.puan.TabIndex = 12;
            this.puan.Text = "Program Adı:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(733, 409);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(65, 25);
            this.label.TabIndex = 13;
            this.label.Text = "Süre:";
            // 
            // sure
            // 
            this.sure.AutoSize = true;
            this.sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sure.ForeColor = System.Drawing.Color.White;
            this.sure.Location = new System.Drawing.Point(804, 409);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(48, 25);
            this.sure.TabIndex = 14;
            this.sure.Text = "123";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(650, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(343, 36);
            this.label6.TabIndex = 15;
            this.label6.Text = "Hemen İzlemeye Başla.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(806, 523);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "İzlenen Tarih:";
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih.ForeColor = System.Drawing.Color.DimGray;
            this.tarih.Location = new System.Drawing.Point(935, 523);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(90, 17);
            this.tarih.TabIndex = 17;
            this.tarih.Text = "01.01.2020";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(1083, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bolum
            // 
            this.bolum.BackColor = System.Drawing.Color.Red;
            this.bolum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolum.ForeColor = System.Drawing.Color.White;
            this.bolum.FormattingEnabled = true;
            this.bolum.Location = new System.Drawing.Point(738, 346);
            this.bolum.Name = "bolum";
            this.bolum.Size = new System.Drawing.Size(130, 30);
            this.bolum.TabIndex = 19;
            this.bolum.Text = "Bölüm Seç";
            this.bolum.Visible = false;
            this.bolum.SelectedIndexChanged += new System.EventHandler(this.bolum_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(103, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 53);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(103, 381);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 53);
            this.button4.TabIndex = 21;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(938, 335);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 51);
            this.button5.TabIndex = 22;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(111, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 51);
            this.label5.TabIndex = 23;
            this.label5.Text = "0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kal_bolum
            // 
            this.kal_bolum.AutoSize = true;
            this.kal_bolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kal_bolum.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.kal_bolum.Location = new System.Drawing.Point(1012, 354);
            this.kal_bolum.Name = "kal_bolum";
            this.kal_bolum.Size = new System.Drawing.Size(0, 20);
            this.kal_bolum.TabIndex = 24;
            // 
            // program_bilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1145, 562);
            this.Controls.Add(this.kal_bolum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bolum);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.label);
            this.Controls.Add(this.puan);
            this.Controls.Add(this.tur);
            this.Controls.Add(this.tipi);
            this.Controls.Add(this.adi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.puanla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "program_bilgi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "program_bilgi";
            this.Load += new System.EventHandler(this.program_bilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label adi;
        public System.Windows.Forms.Label tipi;
        public System.Windows.Forms.Label tur;
        public System.Windows.Forms.Label puan;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button puanla;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label sure;
        public System.Windows.Forms.ComboBox bolum;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label kal_bolum;
    }
}