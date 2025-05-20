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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=Yuki\\SQLEXPRESS;Initial Catalog=\"kayit ekle\";Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kayit_ekleDataSet5.Kayit_Ekleme_Tb' table. You can move, or remove it, as needed.
            this.kayit_Ekleme_TbTableAdapter3.Fill(this.kayit_ekleDataSet5.Kayit_Ekleme_Tb);
           

        }

        private void hayvaneklebutton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into [Kayit Ekleme_Tb] values(@p1, @p2, @p3, @p4, @p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", hayvanisimtxt.Text);
            komut.Parameters.AddWithValue("@p2", hayvancinsicombobox.Text);
            komut.Parameters.AddWithValue("@p3", hayvanyastxt.Text);
            komut.Parameters.AddWithValue("@p4", asilartxt.Text);
            komut.Parameters.AddWithValue("@p5", hayvancinsiyetcombobox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.kayit_Ekleme_TbTableAdapter3.Fill(this.kayit_ekleDataSet5.Kayit_Ekleme_Tb);

        }

        private void hayvansilbutton_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from [Kayit Ekleme_Tb] where ID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", Convert.ToInt32(label2.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.kayit_Ekleme_TbTableAdapter3.Fill(this.kayit_ekleDataSet5.Kayit_Ekleme_Tb);

        }

        private void hayvanguncellebutton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update [Kayit Ekleme_Tb] set [Hayvan İsmi]=@p1, [Hayvan Cinsi]=@p2, [Hayvan Yaşı]=@p3, Aşılar=@p4,[Hayvan Cinsiyeti]=@p5 where  ID=@p6", baglanti);
            komut.Parameters.AddWithValue("@p1", hayvanisimtxt.Text);
            komut.Parameters.AddWithValue("@p2", hayvancinsicombobox.Text);
            komut.Parameters.AddWithValue("@p3", hayvanyastxt.Text);
            komut.Parameters.AddWithValue("@p4", asilartxt.Text);
            komut.Parameters.AddWithValue("@p5", hayvancinsiyetcombobox.Text);
            komut.Parameters.AddWithValue("@p6", label2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.kayit_Ekleme_TbTableAdapter3.Fill(this.kayit_ekleDataSet5.Kayit_Ekleme_Tb);

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            hayvanisimtxt.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            hayvancinsicombobox.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            hayvanyastxt.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            asilartxt.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            hayvancinsiyetcombobox.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            label2.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
        }
    }
}
