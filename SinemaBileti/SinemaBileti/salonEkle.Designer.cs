namespace SinemaBileti
{
    partial class salonEkle
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtsalonekle = new System.Windows.Forms.TextBox();
            this.salon_işlemleri = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtsalonekle
            // 
            this.txtsalonekle.BackColor = System.Drawing.Color.Black;
            this.txtsalonekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalonekle.ForeColor = System.Drawing.Color.White;
            this.txtsalonekle.Location = new System.Drawing.Point(654, 217);
            this.txtsalonekle.Name = "txtsalonekle";
            this.txtsalonekle.Size = new System.Drawing.Size(155, 38);
            this.txtsalonekle.TabIndex = 1;
            // 
            // salon_işlemleri
            // 
            this.salon_işlemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.salon_işlemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.salon_işlemleri.FlatAppearance.BorderSize = 0;
            this.salon_işlemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salon_işlemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salon_işlemleri.ForeColor = System.Drawing.Color.White;
            this.salon_işlemleri.ImageList = this.ımageList1;
            this.salon_işlemleri.Location = new System.Drawing.Point(690, 392);
            this.salon_işlemleri.Name = "salon_işlemleri";
            this.salon_işlemleri.Size = new System.Drawing.Size(209, 62);
            this.salon_işlemleri.TabIndex = 9;
            this.salon_işlemleri.Text = "Salon   \r\nİşlemleri";
            this.salon_işlemleri.UseVisualStyleBackColor = false;
            this.salon_işlemleri.Click += new System.EventHandler(this.salon_işlemleri_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(311, 392);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(210, 62);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(418, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Salon ekle";
            // 
            // salonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SinemaBileti.Properties.Resources.ref_astor_grand_cinema_galerie_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salon_işlemleri);
            this.Controls.Add(this.txtsalonekle);
            this.Controls.Add(this.btnEkle);
            this.Name = "salonEkle";
            this.Size = new System.Drawing.Size(1207, 709);
            this.Load += new System.EventHandler(this.salonEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox txtsalonekle;
        private System.Windows.Forms.Label salonekle;
        private System.Windows.Forms.Button salon_işlemleri;
        private System.Windows.Forms.Label label1;
    }
}
