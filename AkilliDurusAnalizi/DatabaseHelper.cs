using System;
using System.Data.SQLite;
using System.IO;

namespace AkilliDurusAnalizi
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Data Source=akilli_durus.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public static void InitializeDatabase()
        {
            // Veritabanı dosyası yoksa otomatik oluşturur
            if (!File.Exists("akilli_durus.db"))
            {
                SQLiteConnection.CreateFile("akilli_durus.db");
            }

            using (var conn = GetConnection())
            {
                conn.Open();

                // 1. KULLANICILAR Tablosu
                string sqlKullanicilar = @"
                    CREATE TABLE IF NOT EXISTS KULLANICILAR (
                        kullanici_id INTEGER PRIMARY KEY AUTOINCREMENT,
                        ad_soyad TEXT NOT NULL,
                        eposta TEXT,
                        sifre_hash TEXT,
                        kayit_tarihi TEXT
                    );";

                // 2. KULLANICI_AYARLARI Tablosu
                string sqlAyar = @"
                    CREATE TABLE IF NOT EXISTS KULLANICI_AYARLARI (
                        ayar_id INTEGER PRIMARY KEY AUTOINCREMENT,
                        kullanici_id INTEGER,
                        sesli_uyari INTEGER,
                        hassasiyet TEXT,
                        FOREIGN KEY(kullanici_id) REFERENCES KULLANICILAR(kullanici_id)
                    );";

                // 3. DURUS_ANALIZI Tablosu
                string sqlDurus = @"
                    CREATE TABLE IF NOT EXISTS DURUS_ANALIZI (
                        analiz_id INTEGER PRIMARY KEY AUTOINCREMENT,
                        kullanici_id INTEGER,
                        tarih TEXT,
                        puan REAL,
                        durum TEXT,
                        FOREIGN KEY(kullanici_id) REFERENCES KULLANICILAR(kullanici_id)
                    );";

                // 4. UYARI_KAYITLARI Tablosu
                string sqlUyarilar = @"
                    CREATE TABLE IF NOT EXISTS UYARI_KAYITLARI (
                        uyari_id INTEGER PRIMARY KEY AUTOINCREMENT,
                        analiz_id INTEGER,
                        uyari_turu TEXT,
                        zaman_damgasi TEXT,
                        FOREIGN KEY(analiz_id) REFERENCES DURUS_ANALIZI(analiz_id)
                    );";

                using (var cmd = new SQLiteCommand(sqlKullanicilar, conn)) { cmd.ExecuteNonQuery(); }
                using (var cmd = new SQLiteCommand(sqlAyar, conn)) { cmd.ExecuteNonQuery(); }
                using (var cmd = new SQLiteCommand(sqlDurus, conn)) { cmd.ExecuteNonQuery(); }
                using (var cmd = new SQLiteCommand(sqlUyarilar, conn)) { cmd.ExecuteNonQuery(); }
            }
        }
    }
}