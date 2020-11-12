using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SinemaBileti.sinemaTableAdapters;

namespace SinemaBileti
{
    public partial class ekleme : UserControl
    {
        public ekleme()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!FrmAnasayfa.Instance.PnlContainer.Controls.ContainsKey("filmEkle"))
            {
                filmEkle a1 = new filmEkle();
                a1.Dock = DockStyle.Fill;
                FrmAnasayfa.Instance.PnlContainer.Controls.Add(a1);
            }
            FrmAnasayfa.Instance.PnlContainer.Controls["filmEkle"].BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!FrmAnasayfa.Instance.PnlContainer.Controls.ContainsKey("salonEkle"))
            {
                salonEkle a1 = new salonEkle();
                a1.Dock = DockStyle.Fill;
                FrmAnasayfa.Instance.PnlContainer.Controls.Add(a1);
            }
            FrmAnasayfa.Instance.PnlContainer.Controls["salonEkle"].BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!FrmAnasayfa.Instance.PnlContainer.Controls.ContainsKey("seansEkle"))
            {
                seansEkle a1 = new seansEkle();
                a1.Dock = DockStyle.Fill;
                FrmAnasayfa.Instance.PnlContainer.Controls.Add(a1);
            }
            FrmAnasayfa.Instance.PnlContainer.Controls["seansEkle"].BringToFront();
        }

        private void ekleme_Load(object sender, EventArgs e)
        {

        }
    }
}
