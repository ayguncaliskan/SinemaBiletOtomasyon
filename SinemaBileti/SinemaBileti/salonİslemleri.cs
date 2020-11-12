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
    public partial class salonİslemleri : UserControl
    {
        SqlCommand komut;
        SqlDataAdapter da;
        public salonİslemleri()
        {
            InitializeComponent();
        }
        private void Salon_Listele()
        {
            baglantı yeniBaglantı = new baglantı();
            yeniBaglantı.a1();
            da = new SqlDataAdapter("SELECT *FROM Salon_Bilgileri", baglantı.conn);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantı.conn.Close();

        }
        private void salonİslemleri_Load(object sender, EventArgs e)
        {
            Salon_Listele();
        }

        private void salon_sil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Salon_Bilgileri WHERE SalonAdi=@SalonAdi";
            komut = new SqlCommand(sorgu, baglantı.conn);
            komut.Parameters.AddWithValue("@SalonAdi", salonaditxt.Text);
            baglantı yeniBaglantı = new baglantı();
            yeniBaglantı.a1();
            komut.ExecuteNonQuery();
            baglantı.conn.Close();
            Salon_Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            salonaditxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void salon_güncelle_Click(object sender, EventArgs e)
        {
            string salonAdiEski = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            SqlCommand komut = new SqlCommand("UPDATE Salon_Bilgileri SET SalonAdi=@SalonAdi where SalonAdi=@SalonAdiEski", baglantı.conn);
            try
            {
                komut.Parameters.AddWithValue("@SalonAdi", salonaditxt.Text);
                komut.Parameters.AddWithValue("@SalonAdiEski", salonAdiEski);
            }
            catch (Exception hata)
            {

                MessageBox.Show("Uyarı" + hata.Message);
            }

            baglantı yeniBaglantı = new baglantı();
            yeniBaglantı.a1();

            komut.ExecuteNonQuery();
            baglantı.conn.Close();
            MessageBox.Show("Salon Bilgileri Güncellendi");
            Salon_Listele();
        }
    }
}
