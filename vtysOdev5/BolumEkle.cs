using System;
using System.Linq;
using System.Windows.Forms;
using vtysOdev5.Models;

namespace vtysOdev5
{
    public partial class BolumEkle : Form
    {
        public BolumEkle()
        {
            InitializeComponent();
        }

        private void BolumEkle_Load(object sender, EventArgs e)
        {
            // Fakülteleri ComboBox'a getir
            using (var db = new OgrenciContext())
            {
                BolumComboBox.DataSource = db.Fakulteler.ToList();
                BolumComboBox.DisplayMember = "FakulteAd";
                BolumComboBox.ValueMember = "FakulteID";
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            string bolumAd = BolumTextBox.Text.Trim();

            if (string.IsNullOrEmpty(bolumAd))
            {
                MessageBox.Show("Bölüm adı boş olamaz!");
                return;
            }

            if (BolumComboBox.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir fakülte seçiniz!");
                return;
            }

            int fakulteId = (int)BolumComboBox.SelectedValue;

            using (var db = new OgrenciContext())
            {
                var yeniBolum = new Bolum
                {
                    BolumAd = bolumAd,
                    FakulteID = fakulteId
                };

                db.Bolumler.Add(yeniBolum);
                db.SaveChanges();
            }

            MessageBox.Show("Bölüm başarıyla eklendi.");
            BolumTextBox.Clear();
        }

        // Kullanılmayan eventler
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
    }
}
