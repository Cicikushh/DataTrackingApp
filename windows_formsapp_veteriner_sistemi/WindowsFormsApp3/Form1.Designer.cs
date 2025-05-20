namespace WindowsFormsApp3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.girisbutton = new System.Windows.Forms.Button();
            this.tclbl = new System.Windows.Forms.Label();
            this.isimlbl = new System.Windows.Forms.Label();
            this.kullaniciisimtxt = new System.Windows.Forms.TextBox();
            this.sifretxtbox = new System.Windows.Forms.TextBox();
            this.sifrelbl = new System.Windows.Forms.Label();
            this.maskedtctxt = new System.Windows.Forms.MaskedTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // girisbutton
            // 
            this.girisbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(59)))), ((int)(((byte)(166)))));
            this.girisbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisbutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisbutton.ForeColor = System.Drawing.Color.White;
            this.girisbutton.Location = new System.Drawing.Point(336, 266);
            this.girisbutton.Name = "girisbutton";
            this.girisbutton.Size = new System.Drawing.Size(104, 50);
            this.girisbutton.TabIndex = 0;
            this.girisbutton.Text = "GİRİŞ";
            this.girisbutton.UseVisualStyleBackColor = false;
            this.girisbutton.Click += new System.EventHandler(this.girisbutton_Click);
            // 
            // tclbl
            // 
            this.tclbl.AutoSize = true;
            this.tclbl.BackColor = System.Drawing.Color.Transparent;
            this.tclbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tclbl.ForeColor = System.Drawing.Color.White;
            this.tclbl.Location = new System.Drawing.Point(276, 109);
            this.tclbl.Name = "tclbl";
            this.tclbl.Size = new System.Drawing.Size(78, 20);
            this.tclbl.TabIndex = 1;
            this.tclbl.Text = "T.C Kimlik:";
            // 
            // isimlbl
            // 
            this.isimlbl.AutoSize = true;
            this.isimlbl.BackColor = System.Drawing.Color.Transparent;
            this.isimlbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isimlbl.ForeColor = System.Drawing.Color.White;
            this.isimlbl.Location = new System.Drawing.Point(260, 147);
            this.isimlbl.Name = "isimlbl";
            this.isimlbl.Size = new System.Drawing.Size(94, 20);
            this.isimlbl.TabIndex = 2;
            this.isimlbl.Text = "İsim-Soyisim:";
            // 
            // kullaniciisimtxt
            // 
            this.kullaniciisimtxt.Location = new System.Drawing.Point(357, 148);
            this.kullaniciisimtxt.Name = "kullaniciisimtxt";
            this.kullaniciisimtxt.Size = new System.Drawing.Size(100, 20);
            this.kullaniciisimtxt.TabIndex = 4;
            // 
            // sifretxtbox
            // 
            this.sifretxtbox.Location = new System.Drawing.Point(357, 189);
            this.sifretxtbox.Name = "sifretxtbox";
            this.sifretxtbox.PasswordChar = '*';
            this.sifretxtbox.Size = new System.Drawing.Size(100, 20);
            this.sifretxtbox.TabIndex = 5;
            this.sifretxtbox.UseSystemPasswordChar = true;
            // 
            // sifrelbl
            // 
            this.sifrelbl.AutoSize = true;
            this.sifrelbl.BackColor = System.Drawing.Color.Transparent;
            this.sifrelbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifrelbl.ForeColor = System.Drawing.Color.White;
            this.sifrelbl.Location = new System.Drawing.Point(311, 188);
            this.sifrelbl.Name = "sifrelbl";
            this.sifrelbl.Size = new System.Drawing.Size(43, 20);
            this.sifrelbl.TabIndex = 6;
            this.sifrelbl.Text = "Şifre:";
            // 
            // maskedtctxt
            // 
            this.maskedtctxt.Location = new System.Drawing.Point(357, 109);
            this.maskedtctxt.Mask = "00000000000";
            this.maskedtctxt.Name = "maskedtctxt";
            this.maskedtctxt.Size = new System.Drawing.Size(100, 20);
            this.maskedtctxt.TabIndex = 7;
            this.maskedtctxt.ValidatingType = typeof(int);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(457, 300);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 16);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kayıt Ol";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AcceptButton = this.girisbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.maskedtctxt);
            this.Controls.Add(this.sifrelbl);
            this.Controls.Add(this.sifretxtbox);
            this.Controls.Add(this.kullaniciisimtxt);
            this.Controls.Add(this.isimlbl);
            this.Controls.Add(this.tclbl);
            this.Controls.Add(this.girisbutton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button girisbutton;
        private System.Windows.Forms.Label tclbl;
        private System.Windows.Forms.Label isimlbl;
        private System.Windows.Forms.TextBox kullaniciisimtxt;
        private System.Windows.Forms.TextBox sifretxtbox;
        private System.Windows.Forms.Label sifrelbl;
        private System.Windows.Forms.MaskedTextBox maskedtctxt;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

