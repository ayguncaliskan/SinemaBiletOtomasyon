using System;
using System.Windows.Forms;

namespace SinemaBileti
{
    public partial class filmEkle : UserControl
    {
        public filmEkle()
        {
            InitializeComponent();
        }

        sinemaTableAdapters.Film_BilgileriTableAdapter film = new sinemaTableAdapters.Film_BilgileriTableAdapter();

        private void btnfilmekle_Click(object sender, EventArgs e)
        {
            try
            {
                film.FilmEkleme(filmadi.Text, yonetmenadi.Text, filmturcombo.Text, filmsure.Text, dateTimePicker1.Text, filmyil.Text, pictureBox1.ImageLocation);
                MessageBox.Show("Film bilgileri Eklendi!!", "Kayıt");
            }
            catch (Exception hata)
            {

                MessageBox.Show("Bu film daha önce eklendi!!" + hata.Message, "Uyarı");
            }

            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            filmturcombo.Text = "";

        }

        private void afissec_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            pictureBox1.ImageLocation = file.FileName;
        }

        private void Film_İşlemleri_Click(object sender, EventArgs e)
        {
            if (!FrmAnasayfa.Instance.PnlContainer.Controls.ContainsKey("filmİslemleri"))
            {
                filmİslemleri un = new filmİslemleri();
                un.Dock = DockStyle.Fill;
                FrmAnasayfa.Instance.PnlContainer.Controls.Add(un);
            }
            FrmAnasayfa.Instance.PnlContainer.Controls["filmİslemleri"].BringToFront();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void filmEkle_Load(object sender, EventArgs e)
        {

        }
    }
}


