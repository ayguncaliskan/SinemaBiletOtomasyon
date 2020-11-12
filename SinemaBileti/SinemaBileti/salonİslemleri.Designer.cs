namespace SinemaBileti
{
    partial class salonİslemleri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salon_sil = new System.Windows.Forms.Button();
            this.salonaditxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.salon_güncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(686, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(446, 467);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // salon_sil
            // 
            this.salon_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.salon_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salon_sil.ForeColor = System.Drawing.SystemColors.Control;
            this.salon_sil.Location = new System.Drawing.Point(101, 370);
            this.salon_sil.Name = "salon_sil";
            this.salon_sil.Size = new System.Drawing.Size(210, 66);
            this.salon_sil.TabIndex = 2;
            this.salon_sil.Text = "Salon Sil";
            this.salon_sil.UseVisualStyleBackColor = false;
            this.salon_sil.Click += new System.EventHandler(this.salon_sil_Click);
            // 
            // salonaditxt
            // 
            this.salonaditxt.BackColor = System.Drawing.Color.Black;
            this.salonaditxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salonaditxt.ForeColor = System.Drawing.Color.White;
            this.salonaditxt.Location = new System.Drawing.Point(328, 225);
            this.salonaditxt.Name = "salonaditxt";
            this.salonaditxt.Size = new System.Drawing.Size(297, 38);
            this.salonaditxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Salon Adı";
            // 
            // salon_güncelle
            // 
            this.salon_güncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.salon_güncelle.FlatAppearance.BorderSize = 0;
            this.salon_güncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salon_güncelle.ForeColor = System.Drawing.Color.White;
            this.salon_güncelle.Location = new System.Drawing.Point(415, 370);
            this.salon_güncelle.Name = "salon_güncelle";
            this.salon_güncelle.Size = new System.Drawing.Size(210, 66);
            this.salon_güncelle.TabIndex = 6;
            this.salon_güncelle.Text = "Salon Güncelle";
            this.salon_güncelle.UseVisualStyleBackColor = false;
            this.salon_güncelle.Click += new System.EventHandler(this.salon_güncelle_Click);
            // 
            // salonİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SinemaBileti.Properties.Resources.ref_astor_grand_cinema_galerie_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.salon_güncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salonaditxt);
            this.Controls.Add(this.salon_sil);
            this.Controls.Add(this.dataGridView1);
            this.Name = "salonİslemleri";
            this.Size = new System.Drawing.Size(1207, 709);
            this.Load += new System.EventHandler(this.salonİslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button salon_sil;
        private System.Windows.Forms.TextBox salonaditxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button salon_güncelle;
    }
}
