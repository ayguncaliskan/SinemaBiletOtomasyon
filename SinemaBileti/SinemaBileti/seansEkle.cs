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
    public partial class seansEkle : UserControl
    {
        public seansEkle()
        {
            InitializeComponent();
        }
        sinemaTableAdapters.Seans_BilgileriTableAdapter filmseansi = new sinemaTableAdapters.Seans_BilgileriTableAdapter();


        private void FilmVeSalonGoster(ComboBox combo, string sql, string sql2)
        {
            baglantı yeniBaglantı = new baglantı();
            yeniBaglantı.a1();
            SqlCommand komut = new SqlCommand(sql, baglantı.conn);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read() == true)
            {
                combo.Items.Add(read[sql2].ToString());
            }
            baglantı.conn.Close();
        }
        string seans = "";
        private void Radiobutonseciliyse()
        {
            if (radioButton1.Checked == true) seans = radioButton1.Text;
            else if (radioButton2.Checked == true) seans = radioButton2.Text;
            else if (radioButton3.Checked == true) seans = radioButton3.Text;
            else if (radioButton4.Checked == true) seans = radioButton4.Text;
            else if (radioButton5.Checked == true) seans = radioButton5.Text;
            else if (radioButton6.Checked == true) seans = radioButton6.Text;
            else if (radioButton7.Checked == true) seans = radioButton7.Text;
            else if (radioButton8.Checked == true) seans = radioButton8.Text;
            else if (radioButton9.Checked == true) seans = radioButton9.Text;
            else if (radioButton10.Checked == true) seans = radioButton10.Text;
            else if (radioButton11.Checked == true) seans = radioButton11.Text;
            else if (radioButton12.Checked == true) seans = radioButton12.Text;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Radiobutonseciliyse();
            if (seans != "")
            {

                filmseansi.SeansEkleme(comboFilm.Text, comboSalon.Text, dateTimePicker1.Text, seans);
                MessageBox.Show("Seans Ekleme işlemi yapılıdı", "Kayıt");

            }
            else if (seans == "")
            {
                MessageBox.Show("Seans Seçimi Yapmadınız!!", "Uyarı");
            }
            comboSalon.Text = "";
            comboFilm.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        }

        private void comboSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control item3 in groupBox2.Controls)
            {
                item3.Enabled = true;
            }
            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime yeni = DateTime.Parse(dateTimePicker1.Text);
            if (yeni == bugün)
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (DateTime.Parse(DateTime.Now.ToShortTimeString()) > DateTime.Parse(item.Text))
                    {
                        item.Enabled = false;
                    }
                }
                Tarihi_karsilastir();
            }
            else if (yeni > bugün)
            {
                Tarihi_karsilastir();
            }
            else if (yeni < bugün)
            {
                MessageBox.Show("Geriye dönük işlem yapılamaz", "Uyarı");
                dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            }
        }
        private void Tarihi_karsilastir()
        {
            baglantı yeniBaglantı = new baglantı();
            yeniBaglantı.a1();
            SqlCommand komut = new SqlCommand("select * from Seans_bilgileri where SalonAdi='" + comboSalon.Text + "'and Tarih='" + dateTimePicker1.Text + "'", baglantı.conn);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read() == true)
            {
                foreach (Control item2 in groupBox2.Controls)
                {
                    if (read["Seans"].ToString() == item2.Text)
                    {
                        item2.Enabled = false;
                    }
                }
            }
            baglantı.conn.Close();
        }

        private void seansEkle_Load(object sender, EventArgs e)
        {
            FilmVeSalonGoster(comboFilm, "select *from Film_bilgileri", "FilmAdi");
            FilmVeSalonGoster(comboSalon, "select *from Salon_bilgileri", "Salonadi");
        }
    }
}
