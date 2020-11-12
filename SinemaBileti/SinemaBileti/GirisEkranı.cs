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
    public partial class GirisEkranı : Form
    {
        
        SqlDataReader dr;
        public static string user, password;
        public GirisEkranı()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void GirisEkranı_Load(object sender, EventArgs e)
        {

        }

        private void giris_yap_Click(object sender, EventArgs e)
        {
            user = kullaniciaditxt.Text;
            password = sifretxt.Text;

            baglantı yeniBaglantı = new baglantı();
            yeniBaglantı.a1();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglantı.conn;
            
            cmd.CommandText = "SELECT * FROM Kasiyer_Bilgileri where KullaniciAdi='" + kullaniciaditxt.Text + "' AND Sifre='" + sifretxt.Text + "'";
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                FrmAnasayfa giris = new FrmAnasayfa();
                giris.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }
            baglantı.conn.Close();
        }



    }
}
