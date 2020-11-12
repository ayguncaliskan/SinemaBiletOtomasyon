using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SinemaBileti
{
    public partial class filmİslemleri : UserControl
    {
        
        SqlCommand komut;
        SqlDataAdapter da;
        public filmİslemleri()
        {
            InitializeComponent();
        }

        private void Film_Listele()
        {

            baglantı yeniBaglantı = new baglantı();
            yeniBaglantı.a1();
            da = new SqlDataAdapter("SELECT *FROM Film_Bilgileri", baglantı.conn);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantı.conn.Close();

        }

        private void film_sil_Click(object sender, EventArgs e)
        {
            baglantı yeniBaglantı = new baglantı();
            yeniBaglantı.a1();
            string sorgu = "DELETE FROM Film_Bilgileri WHERE FilmAdi=@FilmAdi";
            komut = new SqlCommand(sorgu, baglantı.conn);
            komut.Parameters.AddWithValue("@FilmAdi", filmaditxt.Text);
            komut.ExecuteNonQuery();
            baglantı.conn.Close();
            Film_Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            filmaditxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            yonetmentxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            filmturutxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            filmsuresitxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            yapimyılıtxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            resimtxt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void afissec_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            pictureBox1.ImageLocation = file.FileName;
            resimtxt.Text = file.FileName;
        }

        private void film_güncelle_Click(object sender, EventArgs e)
        {
            baglantı yeniBaglantı = new baglantı();
            yeniBaglantı.a1();
            string sorgu = "UPDATE Film_Bilgileri SET FilmAdi=@FilmAdi,Yonetmen=@Yonetmen,FilmTuru=@FilmTuru,FilmSuresi=@FilmSuresi,tarih=@tarih,YapimYili=@YapimYili,Resim=@Resim where FilmAdi=@FilmAdi";
            komut = new SqlCommand(sorgu, baglantı.conn);
            try
            {
                komut.Parameters.AddWithValue("@FilmAdi", filmaditxt.Text);
                komut.Parameters.AddWithValue("@Yonetmen", yonetmentxt.Text);
                komut.Parameters.AddWithValue("@FilmTuru", filmturutxt.Text);
                komut.Parameters.AddWithValue("@FilmSuresi", filmsuresitxt.Text);
                komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@YapimYili", yapimyılıtxt.Text);
                komut.Parameters.AddWithValue("@Resim", resimtxt.Text);
                MessageBox.Show("Film Başarıyla Güncellendi");
            }
            catch (Exception hata)
            {

                MessageBox.Show("Kayıt Eklenemedi" + hata.Message, "Uyarı");
            }
            komut.ExecuteNonQuery();
            baglantı.conn.Close();
            Film_Listele();
        }

        private void filmİslemleri_Load(object sender, EventArgs e)
        {
            Film_Listele();
        }
    }
}