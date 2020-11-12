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

namespace SinemaBileti
{
    public partial class bilet : UserControl
    {
        public bilet()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int sayac = 0;
        private void FilmveSalonGetir(ComboBox combo, string sql1, string sql2)
        {
            baglantı yeniBaglantı = new baglantı();
            yeniBaglantı.a1();
            SqlCommand komut = new SqlCommand(sql1, baglantı.conn);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read[sql2].ToString());

            }
            baglantı.conn.Close();
        }
        private void FilmAfişiGoster()
        {
            baglantı yeniBaglantı = new baglantı();
            yeniBaglantı.a1();
            SqlCommand komut = new SqlCommand("Select *from film_bilgileri where FilmAdi='" + comboFilmAdi.SelectedItem + "'", baglantı.conn);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                pictureBox1.ImageLocation = read["Resim"].ToString();
            }
            baglantı.conn.Close();
        }
        private void Combo_Dolu_Koltuklar()
        {
            comboKoltukİptal.Items.Clear();
            comboKoltukİptal.Text = "";
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor == Color.Red)
                    {
                        comboKoltukİptal.Items.Add(item.Text);
                    }
                }
            }
        }
        private void YenidenRenklendir()
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }
        private void Veritabanı_Dolu_Koltuklar()
        {
            baglantı yeniBaglantı = new baglantı();
            yeniBaglantı.a1();

            SqlCommand komut = new SqlCommand("select *from Satis_Bilgileri where FilmAdi='" + comboFilmAdi.SelectedItem + "' and SalonAdi='" + comboSalonAdi.SelectedItem + "' and Tarih='" + comboFilmTarihi.SelectedItem + "' and Saat='" + comboFilmSeansı.SelectedItem + " '", baglantı.conn);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item is Button)
                    {
                        if (read["KoltukNO"].ToString() == item.Text)
                        {
                            item.BackColor = Color.Red;
                        }

                    }
                }
            }
            baglantı.conn.Close();
        }
        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            Boş_Koltuklar();
            FilmveSalonGetir(comboFilmAdi, "select *from film_bilgileri", "FilmAdi");
            FilmveSalonGetir(comboSalonAdi, "select *from salon_bilgileri", "SalonAdi");
            combokasiyer.Text = GirisEkranı.user;
        }

        private void Boş_Koltuklar()
        {
            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.BackColor = Color.White;
                    btn.Location = new Point(j * 29 + 20, i * 25 + 30);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (j == 4)
                    {
                        continue;
                    }
                    sayac++;
                    this.panel1.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor == Color.White)
            {
                txtKoltukNo.Text = b.Text;
            }
        }
        private void comboFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboFilmSeansı.Items.Clear();
            comboFilmTarihi.Items.Clear();
            comboFilmSeansı.Text = "";
            comboFilmTarihi.Text = "";
            comboSalonAdi.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";

            FilmAfişiGoster();
            YenidenRenklendir();
            Combo_Dolu_Koltuklar();
        }
        sinemaTableAdapters.Satis_BilgileriTableAdapter satis = new sinemaTableAdapters.Satis_BilgileriTableAdapter();
        private void btnBiletSat_Click(object sender, EventArgs e)
        {

            if (txtKoltukNo.Text != "")
            {
                try
                {
                    satis.Satış_Yap(txtKoltukNo.Text, comboSalonAdi.Text, comboFilmAdi.Text, comboFilmTarihi.Text, comboFilmSeansı.Text, txtAd.Text, txtSoyad.Text, comboUcret.Text, DateTime.Now.ToString(), combokasiyer.Text);
                    foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                    YenidenRenklendir();
                    Veritabanı_Dolu_Koltuklar();
                    Combo_Dolu_Koltuklar();

                }
                catch (Exception hata)
                {

                    MessageBox.Show("Hata Oluştu!!" + hata.Message, "Uyarı");
                }
            }
            else
            {
                MessageBox.Show("Koltuk Seçimi Yapmadınız!!", "Uyarı");
            }
        }
        private void Film_Tarihi_Getir()
        {
            comboFilmTarihi.Text = "";
            comboFilmSeansı.Text = "";
            comboFilmTarihi.Items.Clear();
            comboFilmSeansı.Items.Clear();
            baglantı yeniBaglantı = new baglantı();
            yeniBaglantı.a1();
            SqlCommand komut = new SqlCommand("select *from seans_bilgileri where FilmAdi='" + comboFilmAdi.SelectedItem + "' and SalonAdi='" + comboSalonAdi.SelectedItem + "'", baglantı.conn);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Parse(read["Tarih"].ToString()) >= DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (!comboFilmTarihi.Items.Contains(read["Tarih"].ToString()))
                    {
                        comboFilmTarihi.Items.Add(read["Tarih"].ToString());
                    }

                }

            }
            baglantı.conn.Close();
        }
        private void comboSalonAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film_Tarihi_Getir();
        }

        private void Film_Seansı_Getir()
        {
            comboFilmSeansı.Text = "";
            comboFilmSeansı.Items.Clear();


            baglantı yeniBaglantı = new baglantı();
            yeniBaglantı.a1();

            SqlCommand komut = new SqlCommand("select *from seans_bilgileri where FilmAdi='" + comboFilmAdi.SelectedItem + "' and SalonAdi='" + comboSalonAdi.SelectedItem + "' and Tarih='" + comboFilmTarihi.SelectedItem + "'", baglantı.conn);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Parse(read["Tarih"].ToString()) == DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (DateTime.Parse(read["Seans"].ToString()) > DateTime.Parse(DateTime.Now.ToShortTimeString()))
                    {
                        comboFilmSeansı.Items.Add(read["Seans"].ToString());
                    }



                }
                else if (DateTime.Parse(read["Tarih"].ToString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))
                {

                    comboFilmSeansı.Items.Add(read["Seans"].ToString());


                }
            }
            baglantı.conn.Close();
        }
        private void comboFilmTarihi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film_Seansı_Getir();
        }

        private void comboFilmSeansı_SelectedIndexChanged(object sender, EventArgs e)
        {
            YenidenRenklendir();
            Veritabanı_Dolu_Koltuklar();
            Combo_Dolu_Koltuklar();
        }

        private void btnBiletiptal_Click(object sender, EventArgs e)
        {
            if (comboKoltukİptal.Text != "")
            {
                try
                {
                    satis.Satış_İptal(comboFilmAdi.Text, comboSalonAdi.Text, comboFilmTarihi.Text, comboFilmSeansı.Text, comboKoltukİptal.Text);
                    YenidenRenklendir();
                    Veritabanı_Dolu_Koltuklar();
                    Combo_Dolu_Koltuklar();
                }
                catch (Exception hata)
                {

                    MessageBox.Show("Hata oluştu!!" + hata.Message, "Uyarı");
                }

            }
            else
            {
                MessageBox.Show("Koltuk Seçimi Yapmadınız", "Uyarı");
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
