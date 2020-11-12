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
    public partial class satisListeleme : UserControl
    {
        public satisListeleme()
        {
            InitializeComponent();
        }


        SqlCommand komut = new SqlCommand();
        DataTable tablo = new DataTable();


        private void satislistesi1(string sql)
        {

            baglantı yeniBaglantı = new baglantı();
            yeniBaglantı.a1();

            SqlDataAdapter adtr = new SqlDataAdapter(sql, baglantı.conn);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantı.conn.Close();
        }

        private void satisListeleme_Load(object sender, EventArgs e)
        {
            tablo.Clear();
            satislistesi1("select *from Satis_bilgileri where Tarih like '" + dateTimePicker1.Value.ToShortDateString() + "'");
            ToplamUcretHesapla();
        }

        private void ToplamUcretHesapla()
        {
            int ucrettoplami = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ucrettoplami += Convert.ToInt16(dataGridView1.Rows[i].Cells["Ucret"].Value);
            }
            label1.Text = "Toplam Satış=" + ucrettoplami + "TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Clear();
            satislistesi1("select *from Satis_bilgileri");
            ToplamUcretHesapla();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            satislistesi1("select *from Satis_bilgileri where Tarih like '" + dateTimePicker1.Value.ToShortDateString() + "'");
            ToplamUcretHesapla();
        }
    }
}
