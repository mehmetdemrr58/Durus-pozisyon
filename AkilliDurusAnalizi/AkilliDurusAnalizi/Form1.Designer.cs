namespace AkilliDurusAnalizi
{
    partial class Form1
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
            this.picRehberVideo = new System.Windows.Forms.PictureBox();
            this.picKullaniciKamera = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDurusUyari = new System.Windows.Forms.Label();
            this.btnKalibrasyon = new System.Windows.Forms.Button();
            this.btnTestBaslat = new System.Windows.Forms.Button();
            this.dgvGecmisSkorlar = new System.Windows.Forms.DataGridView();
            this.AD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAktifKullanici = new System.Windows.Forms.Label();
            this.lblSayac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRehberVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKullaniciKamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecmisSkorlar)).BeginInit();
            this.SuspendLayout();
            // 
            // picRehberVideo
            // 
            this.picRehberVideo.Location = new System.Drawing.Point(215, 12);
            this.picRehberVideo.Name = "picRehberVideo";
            this.picRehberVideo.Size = new System.Drawing.Size(784, 453);
            this.picRehberVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRehberVideo.TabIndex = 0;
            this.picRehberVideo.TabStop = false;
            this.picRehberVideo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picKullaniciKamera
            // 
            this.picKullaniciKamera.Location = new System.Drawing.Point(12, 35);
            this.picKullaniciKamera.Name = "picKullaniciKamera";
            this.picKullaniciKamera.Size = new System.Drawing.Size(190, 200);
            this.picKullaniciKamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picKullaniciKamera.TabIndex = 1;
            this.picKullaniciKamera.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // lblDurusUyari
            // 
            this.lblDurusUyari.AutoSize = true;
            this.lblDurusUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurusUyari.Location = new System.Drawing.Point(568, 492);
            this.lblDurusUyari.Name = "lblDurusUyari";
            this.lblDurusUyari.Size = new System.Drawing.Size(219, 31);
            this.lblDurusUyari.TabIndex = 3;
            this.lblDurusUyari.Text = "UYARI EKRANI";
            // 
            // btnKalibrasyon
            // 
            this.btnKalibrasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKalibrasyon.Location = new System.Drawing.Point(25, 295);
            this.btnKalibrasyon.Name = "btnKalibrasyon";
            this.btnKalibrasyon.Size = new System.Drawing.Size(156, 27);
            this.btnKalibrasyon.TabIndex = 6;
            this.btnKalibrasyon.Text = "Kalibrasyon Yap";
            this.btnKalibrasyon.UseVisualStyleBackColor = true;
            // 
            // btnTestBaslat
            // 
            this.btnTestBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTestBaslat.Location = new System.Drawing.Point(25, 358);
            this.btnTestBaslat.Name = "btnTestBaslat";
            this.btnTestBaslat.Size = new System.Drawing.Size(156, 27);
            this.btnTestBaslat.TabIndex = 7;
            this.btnTestBaslat.Text = "Testi Başlat";
            this.btnTestBaslat.UseVisualStyleBackColor = true;
            // 
            // dgvGecmisSkorlar
            // 
            this.dgvGecmisSkorlar.AllowUserToResizeColumns = false;
            this.dgvGecmisSkorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGecmisSkorlar.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvGecmisSkorlar.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvGecmisSkorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGecmisSkorlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AD,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvGecmisSkorlar.Location = new System.Drawing.Point(1018, 9);
            this.dgvGecmisSkorlar.Name = "dgvGecmisSkorlar";
            this.dgvGecmisSkorlar.Size = new System.Drawing.Size(443, 427);
            this.dgvGecmisSkorlar.TabIndex = 8;
            // 
            // AD
            // 
            this.AD.HeaderText = "Ad Soyad";
            this.AD.Name = "AD";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tarih";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Puan";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Durum";
            this.Column3.Name = "Column3";
            // 
            // lblAktifKullanici
            // 
            this.lblAktifKullanici.AutoSize = true;
            this.lblAktifKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAktifKullanici.Location = new System.Drawing.Point(20, 498);
            this.lblAktifKullanici.Name = "lblAktifKullanici";
            this.lblAktifKullanici.Size = new System.Drawing.Size(153, 25);
            this.lblAktifKullanici.TabIndex = 9;
            this.lblAktifKullanici.Text = "Aktif Kullanıcı: ";
            this.lblAktifKullanici.Click += new System.EventHandler(this.lblAktifKullanici_Click);
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayac.Location = new System.Drawing.Point(834, 498);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(183, 25);
            this.lblSayac.TabIndex = 10;
            this.lblSayac.Text = "Kalan Süre: 20 sn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1472, 588);
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.lblAktifKullanici);
            this.Controls.Add(this.dgvGecmisSkorlar);
            this.Controls.Add(this.btnTestBaslat);
            this.Controls.Add(this.btnKalibrasyon);
            this.Controls.Add(this.lblDurusUyari);
            this.Controls.Add(this.picKullaniciKamera);
            this.Controls.Add(this.picRehberVideo);
            this.Name = "Form1";
            this.Text = "Akıllı Duruş Analizi ve Postür Takip Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.picRehberVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKullaniciKamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecmisSkorlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRehberVideo;
        private System.Windows.Forms.PictureBox picKullaniciKamera;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDurusUyari;
        private System.Windows.Forms.Button btnKalibrasyon;
        private System.Windows.Forms.Button btnTestBaslat;
        private System.Windows.Forms.DataGridView dgvGecmisSkorlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn AD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lblAktifKullanici;
        private System.Windows.Forms.Label lblSayac;
    }
}

