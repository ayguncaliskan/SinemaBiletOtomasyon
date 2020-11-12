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
    public partial class salonEkle : UserControl
    {
        public salonEkle()
        {
            InitializeComponent();
        }


        sinemaTableAdapters.Salon_BilgileriTableAdapter salon = new sinemaTableAdapters.Salon_BilgileriTableAdapter();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                salon.SalonEkleme(txtsalonekle.Text);
                MessageBox.Show("Salon Eklendi", "Kayıt");
            }
            catch (Exception)
            {

                MessageBox.Show("Aynı salonu daha önce eklediniz!!", "Uyarı");
            }
            txtsalonekle.Text = "";
        }

        private void salon_işlemleri_Click(object sender, EventArgs e)
        {
            if (!FrmAnasayfa.Instance.PnlContainer.Controls.ContainsKey("salonİslemleri"))
            {
                salonİslemleri un = new salonİslemleri();
                un.Dock = DockStyle.Fill;
                FrmAnasayfa.Instance.PnlContainer.Controls.Add(un);
            }
            FrmAnasayfa.Instance.PnlContainer.Controls["salonİslemleri"].BringToFront();
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            try
            {
                salon.SalonEkleme(txtsalonekle.Text);
                MessageBox.Show("Salon Eklendi", "Kayıt");
            }
            catch (Exception)
            {

                MessageBox.Show("Aynı salonu daha önce eklediniz!!", "Uyarı");
            }
            txtsalonekle.Text = "";
        }

        private void salonEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
