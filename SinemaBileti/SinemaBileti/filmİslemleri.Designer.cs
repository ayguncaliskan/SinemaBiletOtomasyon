namespace SinemaBileti
{
    partial class filmİslemleri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filmIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yonetmenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmSuresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yapimYiliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinema = new SinemaBileti.sinema();
            this.film_BilgileriTableAdapter = new SinemaBileti.sinemaTableAdapters.Film_BilgileriTableAdapter();
            this.film_sil = new System.Windows.Forms.Button();
            this.film_güncelle = new System.Windows.Forms.Button();
            this.filmaditxt = new System.Windows.Forms.TextBox();
            this.yonetmentxt = new System.Windows.Forms.TextBox();
            this.filmturutxt = new System.Windows.Forms.TextBox();
            this.filmsuresitxt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.yapimyılıtxt = new System.Windows.Forms.TextBox();
            this.resimtxt = new System.Windows.Forms.TextBox();
            this.afissec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label99 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmIdDataGridViewTextBoxColumn,
            this.filmAdiDataGridViewTextBoxColumn,
            this.yonetmenDataGridViewTextBoxColumn,
            this.filmTuruDataGridViewTextBoxColumn,
            this.filmSuresiDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.yapimYiliDataGridViewTextBoxColumn,
            this.resimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.filmBilgileriBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(82, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 197);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // filmIdDataGridViewTextBoxColumn
            // 
            this.filmIdDataGridViewTextBoxColumn.DataPropertyName = "FilmId";
            this.filmIdDataGridViewTextBoxColumn.HeaderText = "FilmId";
            this.filmIdDataGridViewTextBoxColumn.Name = "filmIdDataGridViewTextBoxColumn";
            this.filmIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmAdiDataGridViewTextBoxColumn
            // 
            this.filmAdiDataGridViewTextBoxColumn.DataPropertyName = "FilmAdi";
            this.filmAdiDataGridViewTextBoxColumn.HeaderText = "FilmAdi";
            this.filmAdiDataGridViewTextBoxColumn.Name = "filmAdiDataGridViewTextBoxColumn";
            this.filmAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yonetmenDataGridViewTextBoxColumn
            // 
            this.yonetmenDataGridViewTextBoxColumn.DataPropertyName = "Yonetmen";
            this.yonetmenDataGridViewTextBoxColumn.HeaderText = "Yonetmen";
            this.yonetmenDataGridViewTextBoxColumn.Name = "yonetmenDataGridViewTextBoxColumn";
            this.yonetmenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmTuruDataGridViewTextBoxColumn
            // 
            this.filmTuruDataGridViewTextBoxColumn.DataPropertyName = "FilmTuru";
            this.filmTuruDataGridViewTextBoxColumn.HeaderText = "FilmTuru";
            this.filmTuruDataGridViewTextBoxColumn.Name = "filmTuruDataGridViewTextBoxColumn";
            this.filmTuruDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmSuresiDataGridViewTextBoxColumn
            // 
            this.filmSuresiDataGridViewTextBoxColumn.DataPropertyName = "FilmSuresi";
            this.filmSuresiDataGridViewTextBoxColumn.HeaderText = "FilmSuresi";
            this.filmSuresiDataGridViewTextBoxColumn.Name = "filmSuresiDataGridViewTextBoxColumn";
            this.filmSuresiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yapimYiliDataGridViewTextBoxColumn
            // 
            this.yapimYiliDataGridViewTextBoxColumn.DataPropertyName = "YapimYili";
            this.yapimYiliDataGridViewTextBoxColumn.HeaderText = "YapimYili";
            this.yapimYiliDataGridViewTextBoxColumn.Name = "yapimYiliDataGridViewTextBoxColumn";
            this.yapimYiliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resimDataGridViewTextBoxColumn
            // 
            this.resimDataGridViewTextBoxColumn.DataPropertyName = "Resim";
            this.resimDataGridViewTextBoxColumn.HeaderText = "Resim";
            this.resimDataGridViewTextBoxColumn.Name = "resimDataGridViewTextBoxColumn";
            this.resimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmBilgileriBindingSource
            // 
            this.filmBilgileriBindingSource.DataMember = "Film_Bilgileri";
            this.filmBilgileriBindingSource.DataSource = this.sinema;
            // 
            // sinema
            // 
            this.sinema.DataSetName = "sinema";
            this.sinema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // film_BilgileriTableAdapter
            // 
            this.film_BilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // film_sil
            // 
            this.film_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.film_sil.FlatAppearance.BorderSize = 0;
            this.film_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.film_sil.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.film_sil.Location = new System.Drawing.Point(230, 589);
            this.film_sil.Name = "film_sil";
            this.film_sil.Size = new System.Drawing.Size(193, 62);
            this.film_sil.TabIndex = 1;
            this.film_sil.Text = "Filmi Sil";
            this.film_sil.UseVisualStyleBackColor = false;
            this.film_sil.Click += new System.EventHandler(this.film_sil_Click);
            // 
            // film_güncelle
            // 
            this.film_güncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.film_güncelle.FlatAppearance.BorderSize = 0;
            this.film_güncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.film_güncelle.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.film_güncelle.Location = new System.Drawing.Point(704, 589);
            this.film_güncelle.Name = "film_güncelle";
            this.film_güncelle.Size = new System.Drawing.Size(193, 62);
            this.film_güncelle.TabIndex = 2;
            this.film_güncelle.Text = "Filmi Güncelle";
            this.film_güncelle.UseVisualStyleBackColor = false;
            this.film_güncelle.Click += new System.EventHandler(this.film_güncelle_Click);
            // 
            // filmaditxt
            // 
            this.filmaditxt.BackColor = System.Drawing.Color.Black;
            this.filmaditxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmaditxt.ForeColor = System.Drawing.Color.White;
            this.filmaditxt.Location = new System.Drawing.Point(350, 80);
            this.filmaditxt.Name = "filmaditxt";
            this.filmaditxt.Size = new System.Drawing.Size(321, 38);
            this.filmaditxt.TabIndex = 3;
            // 
            // yonetmentxt
            // 
            this.yonetmentxt.BackColor = System.Drawing.Color.Black;
            this.yonetmentxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yonetmentxt.ForeColor = System.Drawing.Color.White;
            this.yonetmentxt.Location = new System.Drawing.Point(350, 124);
            this.yonetmentxt.Name = "yonetmentxt";
            this.yonetmentxt.Size = new System.Drawing.Size(321, 38);
            this.yonetmentxt.TabIndex = 4;
            // 
            // filmturutxt
            // 
            this.filmturutxt.BackColor = System.Drawing.Color.Black;
            this.filmturutxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmturutxt.ForeColor = System.Drawing.Color.White;
            this.filmturutxt.Location = new System.Drawing.Point(350, 164);
            this.filmturutxt.Name = "filmturutxt";
            this.filmturutxt.Size = new System.Drawing.Size(321, 38);
            this.filmturutxt.TabIndex = 5;
            // 
            // filmsuresitxt
            // 
            this.filmsuresitxt.BackColor = System.Drawing.Color.Black;
            this.filmsuresitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmsuresitxt.ForeColor = System.Drawing.Color.White;
            this.filmsuresitxt.Location = new System.Drawing.Point(350, 208);
            this.filmsuresitxt.Name = "filmsuresitxt";
            this.filmsuresitxt.Size = new System.Drawing.Size(321, 38);
            this.filmsuresitxt.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(350, 306);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(321, 38);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // yapimyılıtxt
            // 
            this.yapimyılıtxt.BackColor = System.Drawing.Color.Black;
            this.yapimyılıtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yapimyılıtxt.ForeColor = System.Drawing.Color.White;
            this.yapimyılıtxt.Location = new System.Drawing.Point(350, 256);
            this.yapimyılıtxt.Name = "yapimyılıtxt";
            this.yapimyılıtxt.Size = new System.Drawing.Size(321, 38);
            this.yapimyılıtxt.TabIndex = 8;
            // 
            // resimtxt
            // 
            this.resimtxt.BackColor = System.Drawing.Color.White;
            this.resimtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resimtxt.ForeColor = System.Drawing.Color.Black;
            this.resimtxt.Location = new System.Drawing.Point(886, 310);
            this.resimtxt.Name = "resimtxt";
            this.resimtxt.Size = new System.Drawing.Size(100, 38);
            this.resimtxt.TabIndex = 9;
            // 
            // afissec
            // 
            this.afissec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.afissec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afissec.ForeColor = System.Drawing.Color.White;
            this.afissec.Location = new System.Drawing.Point(1005, 317);
            this.afissec.Name = "afissec";
            this.afissec.Size = new System.Drawing.Size(50, 23);
            this.afissec.TabIndex = 10;
            this.afissec.Text = "SEÇ";
            this.afissec.UseVisualStyleBackColor = false;
            this.afissec.Click += new System.EventHandler(this.afissec_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(799, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.BackColor = System.Drawing.Color.Transparent;
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.ForeColor = System.Drawing.Color.White;
            this.label99.Location = new System.Drawing.Point(76, 83);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(111, 31);
            this.label99.TabIndex = 12;
            this.label99.Text = "Film Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Yönetmen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(76, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "Film Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(76, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "Film Süresi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(76, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tarih";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(76, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "Yapım Yılı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(802, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Afiş";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // filmİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SinemaBileti.Properties.Resources.ref_astor_grand_cinema_galerie_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label99);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.afissec);
            this.Controls.Add(this.resimtxt);
            this.Controls.Add(this.yapimyılıtxt);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.filmsuresitxt);
            this.Controls.Add(this.filmturutxt);
            this.Controls.Add(this.yonetmentxt);
            this.Controls.Add(this.filmaditxt);
            this.Controls.Add(this.film_güncelle);
            this.Controls.Add(this.film_sil);
            this.Controls.Add(this.dataGridView1);
            this.Name = "filmİslemleri";
            this.Size = new System.Drawing.Size(1207, 709);
            this.Load += new System.EventHandler(this.filmİslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private sinema sinema;
        private System.Windows.Forms.BindingSource filmBilgileriBindingSource;
        private sinemaTableAdapters.Film_BilgileriTableAdapter film_BilgileriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yonetmenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmSuresiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yapimYiliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button film_sil;
        private System.Windows.Forms.Button film_güncelle;
        private System.Windows.Forms.TextBox filmaditxt;
        private System.Windows.Forms.TextBox yonetmentxt;
        private System.Windows.Forms.TextBox filmturutxt;
        private System.Windows.Forms.TextBox filmsuresitxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox yapimyılıtxt;
        private System.Windows.Forms.TextBox resimtxt;
        private System.Windows.Forms.Button afissec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
