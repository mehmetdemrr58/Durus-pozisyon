using System;
using System.Data.SQLite; // 1. Eksik olan using eklendi
using System.Windows.Forms;

namespace AkilliDurusAnalizi
{
    public partial class GirisFormu : Form
    {
        // 2. Değişken burada tanımlandı (Hata 3 bu yüzden çözülecek)
        public string GirisYapanKullaniciAdi { get; set; }

        public GirisFormu()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string adSoyad = txtAdSoyad.Text.Trim();
            string secilenTarih = dateTimePickerTarih.Value.ToString("yyyy-MM-dd HH:mm:ss");

            if (string.IsNullOrEmpty(adSoyad))
            {
                MessageBox.Show("Lütfen ad ve soyad girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanına kullanıcıyı ve seçilen tarihi kaydedelim
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO KULLANICILAR (ad_soyad, eposta, sifre_hash, kayit_tarihi) VALUES (@ad, 'ogrenci@gop.edu.tr', 'sifresiz', @tarih);";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ad", adSoyad);
                    cmd.Parameters.AddWithValue("@tarih", secilenTarih);
                    cmd.ExecuteNonQuery();
                }
            }

            // Kullanıcı adını ana forma aktarmak için tutuyoruz
            GirisYapanKullaniciAdi = adSoyad;

            // Formu onaylayıp kapatıyoruz
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}