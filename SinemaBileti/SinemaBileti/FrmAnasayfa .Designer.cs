using System;
using System.Windows.Forms;

namespace SinemaBileti
{
    partial class FrmAnasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnasayfa));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.ekleme = new System.Windows.Forms.Button();
            this.gecmis = new System.Windows.Forms.Button();
            this.biletSatısı = new System.Windows.Forms.Button();
            this.anaSayfa = new System.Windows.Forms.Button();
            this.Seanslar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "indir.jpg");
            this.ımageList1.Images.SetKeyName(1, "Movies-icon.png");
            this.ımageList1.Images.SetKeyName(2, "video-camera-icon.png");
            this.ımageList1.Images.SetKeyName(3, "Video-File-icon.png");
            this.ımageList1.Images.SetKeyName(4, "Videos-icon.png");
            this.ımageList1.Images.SetKeyName(5, "Movie-icon.png");
            this.ımageList1.Images.SetKeyName(6, "para.jpg");
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.ekleme);
            this.panel3.Controls.Add(this.gecmis);
            this.panel3.Controls.Add(this.biletSatısı);
            this.panel3.Controls.Add(this.anaSayfa);
            this.panel3.Controls.Add(this.Seanslar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(146, 741);
            this.panel3.TabIndex = 12;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // ekleme
            // 
            this.ekleme.FlatAppearance.BorderSize = 0;
            this.ekleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekleme.ForeColor = System.Drawing.Color.White;
            this.ekleme.Image = global::SinemaBileti.Properties.Resources.settings;
            this.ekleme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ekleme.Location = new System.Drawing.Point(11, 449);
            this.ekleme.Name = "ekleme";
            this.ekleme.Size = new System.Drawing.Size(132, 78);
            this.ekleme.TabIndex = 27;
            this.ekleme.Text = "    Ekleme";
            this.ekleme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ekleme.UseVisualStyleBackColor = true;
            this.ekleme.Click += new System.EventHandler(this.ekleme_Click);
            // 
            // gecmis
            // 
            this.gecmis.FlatAppearance.BorderSize = 0;
            this.gecmis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gecmis.ForeColor = System.Drawing.Color.White;
            this.gecmis.Image = global::SinemaBileti.Properties.Resources.folder;
            this.gecmis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gecmis.Location = new System.Drawing.Point(11, 547);
            this.gecmis.Name = "gecmis";
            this.gecmis.Size = new System.Drawing.Size(132, 78);
            this.gecmis.TabIndex = 25;
            this.gecmis.Text = "    Geçmiş İşlemler";
            this.gecmis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gecmis.UseVisualStyleBackColor = true;
            this.gecmis.Click += new System.EventHandler(this.gecmis_Click);
            // 
            // biletSatısı
            // 
            this.biletSatısı.FlatAppearance.BorderSize = 0;
            this.biletSatısı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.biletSatısı.ForeColor = System.Drawing.Color.White;
            this.biletSatısı.Image = global::SinemaBileti.Properties.Resources.commerce_and_shopping;
            this.biletSatısı.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.biletSatısı.Location = new System.Drawing.Point(11, 351);
            this.biletSatısı.Name = "biletSatısı";
            this.biletSatısı.Size = new System.Drawing.Size(132, 68);
            this.biletSatısı.TabIndex = 24;
            this.biletSatısı.Text = "    Bilet Satışı";
            this.biletSatısı.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.biletSatısı.UseVisualStyleBackColor = true;
            this.biletSatısı.Click += new System.EventHandler(this.biletSatısı_Click);
            // 
            // anaSayfa
            // 
            this.anaSayfa.FlatAppearance.BorderSize = 0;
            this.anaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anaSayfa.ForeColor = System.Drawing.Color.White;
            this.anaSayfa.Image = global::SinemaBileti.Properties.Resources.house;
            this.anaSayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anaSayfa.Location = new System.Drawing.Point(11, 151);
            this.anaSayfa.Name = "anaSayfa";
            this.anaSayfa.Size = new System.Drawing.Size(132, 68);
            this.anaSayfa.TabIndex = 23;
            this.anaSayfa.Text = "    Ana Sayfa";
            this.anaSayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.anaSayfa.UseVisualStyleBackColor = true;
            this.anaSayfa.Click += new System.EventHandler(this.anaSayfa_Click);
            // 
            // Seanslar
            // 
            this.Seanslar.FlatAppearance.BorderSize = 0;
            this.Seanslar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seanslar.ForeColor = System.Drawing.Color.White;
            this.Seanslar.Image = global::SinemaBileti.Properties.Resources.time_and_date;
            this.Seanslar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Seanslar.Location = new System.Drawing.Point(11, 248);
            this.Seanslar.Name = "Seanslar";
            this.Seanslar.Size = new System.Drawing.Size(132, 68);
            this.Seanslar.TabIndex = 22;
            this.Seanslar.Text = "    Seanslar";
            this.Seanslar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Seanslar.UseVisualStyleBackColor = true;
            this.Seanslar.Click += new System.EventHandler(this.Seanslar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::SinemaBileti.Properties.Resources.ui1;
            this.button1.Location = new System.Drawing.Point(1177, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 31);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(146, 32);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1207, 709);
            this.panelContainer.TabIndex = 38;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(146, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 33);
            this.panel1.TabIndex = 31;
            // 
            // FrmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1353, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnasayfa";
            this.Load += new System.EventHandler(this.FrmAnasayfa_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        

        #endregion
        private ImageList ımageList1;
        private Panel panel3;
        private Button Seanslar;
        private Button anaSayfa;
        private Button biletSatısı;
        private Button gecmis;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panelContainer;
        private Button ekleme;
        private Panel panel1;
    }
}

