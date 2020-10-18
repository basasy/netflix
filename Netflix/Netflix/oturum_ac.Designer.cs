namespace Netflix
{
    partial class oturum_ac
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
            this.o_email = new System.Windows.Forms.TextBox();
            this.o_sifre = new System.Windows.Forms.TextBox();
            this.oturum = new System.Windows.Forms.Button();
            this.o_geri = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // o_email
            // 
            this.o_email.BackColor = System.Drawing.Color.Gray;
            this.o_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.o_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.o_email.ForeColor = System.Drawing.Color.White;
            this.o_email.Location = new System.Drawing.Point(59, 231);
            this.o_email.Name = "o_email";
            this.o_email.Size = new System.Drawing.Size(340, 34);
            this.o_email.TabIndex = 1;
            this.o_email.TextChanged += new System.EventHandler(this.o_email_TextChanged);
            // 
            // o_sifre
            // 
            this.o_sifre.BackColor = System.Drawing.Color.Gray;
            this.o_sifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.o_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.o_sifre.ForeColor = System.Drawing.Color.White;
            this.o_sifre.Location = new System.Drawing.Point(59, 319);
            this.o_sifre.Name = "o_sifre";
            this.o_sifre.PasswordChar = '*';
            this.o_sifre.Size = new System.Drawing.Size(340, 34);
            this.o_sifre.TabIndex = 3;
            // 
            // oturum
            // 
            this.oturum.BackColor = System.Drawing.Color.Red;
            this.oturum.FlatAppearance.BorderSize = 0;
            this.oturum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.oturum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.oturum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oturum.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oturum.ForeColor = System.Drawing.Color.White;
            this.oturum.Location = new System.Drawing.Point(59, 404);
            this.oturum.Name = "oturum";
            this.oturum.Size = new System.Drawing.Size(340, 73);
            this.oturum.TabIndex = 4;
            this.oturum.Text = "Oturum Aç";
            this.oturum.UseVisualStyleBackColor = false;
            this.oturum.Click += new System.EventHandler(this.oturum_Click_1);
            // 
            // o_geri
            // 
            this.o_geri.BackColor = System.Drawing.Color.Transparent;
            this.o_geri.FlatAppearance.BorderSize = 0;
            this.o_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.o_geri.Font = new System.Drawing.Font("Agency FB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o_geri.ForeColor = System.Drawing.Color.DimGray;
            this.o_geri.Location = new System.Drawing.Point(420, -1);
            this.o_geri.Name = "o_geri";
            this.o_geri.Size = new System.Drawing.Size(56, 60);
            this.o_geri.TabIndex = 6;
            this.o_geri.Text = "<";
            this.o_geri.UseVisualStyleBackColor = false;
            this.o_geri.Click += new System.EventHandler(this.o_geri_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 55);
            this.label3.TabIndex = 7;
            this.label3.Text = "Oturum Aç";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "E-posta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre";
            // 
            // oturum_ac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(488, 631);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.o_geri);
            this.Controls.Add(this.oturum);
            this.Controls.Add(this.o_sifre);
            this.Controls.Add(this.o_email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "oturum_ac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oturum AÇ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox o_email;
        private System.Windows.Forms.TextBox o_sifre;
        private System.Windows.Forms.Button o_geri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button oturum;
    }
}