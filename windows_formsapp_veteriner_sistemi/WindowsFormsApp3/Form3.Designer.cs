namespace WindowsFormsApp3
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.maskedtctxt = new System.Windows.Forms.MaskedTextBox();
            this.sifrelbl = new System.Windows.Forms.Label();
            this.sifretxtbox = new System.Windows.Forms.TextBox();
            this.kullaniciisimtxt = new System.Windows.Forms.TextBox();
            this.isimlbl = new System.Windows.Forms.Label();
            this.tclbl = new System.Windows.Forms.Label();
            this.girisbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedtctxt
            // 
            this.maskedtctxt.Location = new System.Drawing.Point(392, 122);
            this.maskedtctxt.Mask = "00000000000";
            this.maskedtctxt.Name = "maskedtctxt";
            this.maskedtctxt.Size = new System.Drawing.Size(100, 20);
            this.maskedtctxt.TabIndex = 14;
            this.maskedtctxt.ValidatingType = typeof(int);
            // 
            // sifrelbl
            // 
            this.sifrelbl.AutoSize = true;
            this.sifrelbl.BackColor = System.Drawing.Color.Transparent;
            this.sifrelbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifrelbl.ForeColor = System.Drawing.Color.White;
            this.sifrelbl.Location = new System.Drawing.Point(346, 201);
            this.sifrelbl.Name = "sifrelbl";
            this.sifrelbl.Size = new System.Drawing.Size(43, 20);
            this.sifrelbl.TabIndex = 13;
            this.sifrelbl.Text = "Şifre:";
            // 
            // sifretxtbox
            // 
            this.sifretxtbox.Location = new System.Drawing.Point(392, 202);
            this.sifretxtbox.Name = "sifretxtbox";
            this.sifretxtbox.PasswordChar = '*';
            this.sifretxtbox.Size = new System.Drawing.Size(100, 20);
            this.sifretxtbox.TabIndex = 12;
            this.sifretxtbox.UseSystemPasswordChar = true;
            // 
            // kullaniciisimtxt
            // 
            this.kullaniciisimtxt.Location = new System.Drawing.Point(392, 161);
            this.kullaniciisimtxt.Name = "kullaniciisimtxt";
            this.kullaniciisimtxt.Size = new System.Drawing.Size(100, 20);
            this.kullaniciisimtxt.TabIndex = 11;
            // 
            // isimlbl
            // 
            this.isimlbl.AutoSize = true;
            this.isimlbl.BackColor = System.Drawing.Color.Transparent;
            this.isimlbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isimlbl.ForeColor = System.Drawing.Color.White;
            this.isimlbl.Location = new System.Drawing.Point(295, 160);
            this.isimlbl.Name = "isimlbl";
            this.isimlbl.Size = new System.Drawing.Size(94, 20);
            this.isimlbl.TabIndex = 10;
            this.isimlbl.Text = "İsim-Soyisim:";
            // 
            // tclbl
            // 
            this.tclbl.AutoSize = true;
            this.tclbl.BackColor = System.Drawing.Color.Transparent;
            this.tclbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tclbl.ForeColor = System.Drawing.Color.White;
            this.tclbl.Location = new System.Drawing.Point(311, 122);
            this.tclbl.Name = "tclbl";
            this.tclbl.Size = new System.Drawing.Size(78, 20);
            this.tclbl.TabIndex = 9;
            this.tclbl.Text = "T.C Kimlik:";
            // 
            // girisbutton
            // 
            this.girisbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(59)))), ((int)(((byte)(166)))));
            this.girisbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisbutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisbutton.ForeColor = System.Drawing.Color.White;
            this.girisbutton.Location = new System.Drawing.Point(371, 279);
            this.girisbutton.Name = "girisbutton";
            this.girisbutton.Size = new System.Drawing.Size(104, 50);
            this.girisbutton.TabIndex = 8;
            this.girisbutton.Text = "KAYIT OL";
            this.girisbutton.UseVisualStyleBackColor = false;
            this.girisbutton.Click += new System.EventHandler(this.girisbutton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedtctxt);
            this.Controls.Add(this.sifrelbl);
            this.Controls.Add(this.sifretxtbox);
            this.Controls.Add(this.kullaniciisimtxt);
            this.Controls.Add(this.isimlbl);
            this.Controls.Add(this.tclbl);
            this.Controls.Add(this.girisbutton);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedtctxt;
        private System.Windows.Forms.Label sifrelbl;
        private System.Windows.Forms.TextBox sifretxtbox;
        private System.Windows.Forms.TextBox kullaniciisimtxt;
        private System.Windows.Forms.Label isimlbl;
        private System.Windows.Forms.Label tclbl;
        private System.Windows.Forms.Button girisbutton;
    }
}