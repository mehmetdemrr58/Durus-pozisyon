using System;
using System.Windows.Forms;

namespace AkilliDurusAnalizi
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Veritabanını ve tabloları otomatik oluşturur
            DatabaseHelper.InitializeDatabase();

            // Önce Giriş Formunu açıyoruz
            GirisFormu giris = new GirisFormu();
            if (giris.ShowDialog() == DialogResult.OK)
            {
                // Giriş başarılı olursa ana ekranı (Form1) başlatıyoruz
                Application.Run(new Form1());
            }
        }
    }
}