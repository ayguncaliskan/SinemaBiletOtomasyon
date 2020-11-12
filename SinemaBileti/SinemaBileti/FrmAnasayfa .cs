using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBileti
{
    //user control https://csharpui.com/dynamic-usercontrols/
    public partial class FrmAnasayfa : Form
    {
        static FrmAnasayfa _obj;

        public static FrmAnasayfa Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FrmAnasayfa();
                }
                return _obj;
            }
        }
        public FrmAnasayfa()
        {
            InitializeComponent();
        }
        
        
 
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Seanslar_Click(object sender, EventArgs e)
        {
            if (!FrmAnasayfa.Instance.PnlContainer.Controls.ContainsKey("seansListele"))
            {
                seansListele a1 = new seansListele();
                a1.Dock = DockStyle.Fill;
                FrmAnasayfa.Instance.PnlContainer.Controls.Add(a1);
            }
            FrmAnasayfa.Instance.PnlContainer.Controls["seansListele"].BringToFront();
        }

        private void anaSayfa_Click(object sender, EventArgs e)
        {
            if (!FrmAnasayfa.Instance.PnlContainer.Controls.ContainsKey("anasayfa"))
            {
                anasayfa a1 = new anasayfa();
                a1.Dock = DockStyle.Fill;
                FrmAnasayfa.Instance.PnlContainer.Controls.Add(a1);
            }
            FrmAnasayfa.Instance.PnlContainer.Controls["anasayfa"].BringToFront();
        }

        private void biletSatısı_Click(object sender, EventArgs e)
        {
            if (!FrmAnasayfa.Instance.PnlContainer.Controls.ContainsKey("bilet"))
            {
                bilet un = new bilet();
                un.Dock = DockStyle.Fill;
                FrmAnasayfa.Instance.PnlContainer.Controls.Add(un);
            }
            FrmAnasayfa.Instance.PnlContainer.Controls["bilet"].BringToFront();
        }

        private void gecmis_Click(object sender, EventArgs e)
        {
            if (!FrmAnasayfa.Instance.PnlContainer.Controls.ContainsKey("satisListeleme"))
            {
                satisListeleme a1 = new satisListeleme();
                a1.Dock = DockStyle.Fill;
                FrmAnasayfa.Instance.PnlContainer.Controls.Add(a1);
            }
            FrmAnasayfa.Instance.PnlContainer.Controls["satisListeleme"].BringToFront();
        }

        private void ekleme_Click(object sender, EventArgs e)
        {
            if (!FrmAnasayfa.Instance.PnlContainer.Controls.ContainsKey("ekleme"))
            {
                ekleme a1 = new ekleme();
                a1.Dock = DockStyle.Fill;
                FrmAnasayfa.Instance.PnlContainer.Controls.Add(a1);
            }
            FrmAnasayfa.Instance.PnlContainer.Controls["ekleme"].BringToFront();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            _obj = this;

            anasayfa uc = new anasayfa();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
