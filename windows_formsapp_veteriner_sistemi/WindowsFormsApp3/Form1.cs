using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=Yuki\\SQLEXPRESS;Initial Catalog=\"kayit ekle\";Integrated Security=True");

        private void girisbutton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Giris_Tb where [Veteriner İsim]=@username and Şifre=@password and [T.C.]=@tc", baglanti);
            komut.Parameters.AddWithValue("@username", kullaniciisimtxt.Text);
            komut.Parameters.AddWithValue("@password", sifretxtbox.Text);
            komut.Parameters.AddWithValue("@tc", Convert.ToInt64(maskedtctxt.Text));
            SqlDataReader rdr = komut.ExecuteReader();
            if (rdr.Read())
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı, şifre veya TC", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
           

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
    
}
