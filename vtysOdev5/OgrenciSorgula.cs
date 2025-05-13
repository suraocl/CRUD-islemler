using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using vtysOdev5.Models;

namespace vtysOdev5
{
    public partial class OgrenciSorgula : Form
    {
        public OgrenciSorgula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ogrenciId;

            // ID geçerli bir sayı mı kontrol et
            if (!int.TryParse(textBox1.Text.Trim(), out ogrenciId))
            {
                MessageBox.Show("Lütfen geçerli bir öğrenci numarası giriniz!");
                return;
            }

            using (var db = new OgrenciContext())
            {
                // Öğrenciyi çek
                var ogr = db.Ogrenciler
                            .Where(o => o.OgrenciID == ogrenciId)
                            .Select(o => new
                            {
                                o.Ad,
                                o.Soyad,
                                BolumAd = o.Bolum.BolumAd,
                                FakulteAd = o.Bolum.Fakulte.FakulteAd
                            })
                            .FirstOrDefault();

                if (ogr == null)
                {
                    MessageBox.Show("Öğrenci bulunamadı!");
                    return;
                }

                // Bilgileri ekrana yaz
                label2.Text = "Öğrenci adı: " + ogr.Ad;
                label3.Text = "Öğrenci soyadı: " + ogr.Soyad;
                label4.Text = "Bölüm adı: " + ogr.BolumAd;
                label5.Text = "Fakülte: " + ogr.FakulteAd;

                // Ders listesini çek
                var dersler = db.OgrenciDersler
                                .Where(d => d.OgrenciID == ogrenciId)
                                .Select(d => new
                                {
                                    DersAdi = d.Ders.DersAd,
                                    d.Yil,
                                    d.Yariyil,
                                    Not = (d.Vize + d.Final) / 2
                                })
                                .ToList();

                // DataGrid'e yükle
                SorgulamaDatagrid.DataSource = dersler;
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void OgrenciSorgula_Load_1(object sender, EventArgs e)
        {

        }
    }
}
