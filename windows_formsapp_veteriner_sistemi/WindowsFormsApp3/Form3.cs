using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=Yuki\\SQLEXPRESS;Initial Catalog=\"kayit ekle\";Integrated Security=True");

        private void girisbutton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Giris_Tb values(@p1, @p2, @p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", kullaniciisimtxt.Text);
            komut.Parameters.AddWithValue("@p2", Convert.ToInt64(maskedtctxt.Text));
            komut.Parameters.AddWithValue("@p3", sifretxtbox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
