using System;
using System.Linq;
using System.Windows.Forms;
using vtysOdev5.Models;

namespace vtysOdev5
{
    public partial class OgrenciEkle : Form
    {
        public OgrenciEkle()
        {
            InitializeComponent();
        }

        private void OgrenciEkle_Load(object sender, EventArgs e)
        {
            // Bölüm bilgilerini ComboBox'a yükle
            using (var db = new OgrenciContext())
            {
                comboBox1.DataSource = db.Bolumler.ToList();
                comboBox1.DisplayMember = "BolumAd";
                comboBox1.ValueMember = "BolumID";
            }

            OgrenciListele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text.Trim();
            string soyad = BolumTextBox.Text.Trim();

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad))
            {
                MessageBox.Show("Ad ve soyad boş olamaz!");
                return;
            }

            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir bölüm seçiniz!");
                return;
            }

            int bolumId = (int)comboBox1.SelectedValue;

            using (var db = new OgrenciContext())
            {
                var yeniOgrenci = new Ogrenci
                {
                    Ad = ad,
                    Soyad = soyad,
                    BolumID = bolumId
                };

                db.Ogrenciler.Add(yeniOgrenci);
                db.SaveChanges();
            }

            MessageBox.Show("Öğrenci başarıyla eklendi.");
            textBox1.Clear();
            BolumTextBox.Clear();
            OgrenciListele();
        }

        private void OgrenciListele()
        {
            using (var db = new OgrenciContext())
            {
                var liste = db.Ogrenciler
                              .Select(o => new
                              {
                                  o.OgrenciID,
                                  o.Ad,
                                  o.Soyad,
                                  Bolum = o.Bolum.BolumAd
                              })
                              .ToList();

                OgrDataGrid.DataSource = liste;
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void BolumAdi_Click(object sender, EventArgs e) { }
    }
}
