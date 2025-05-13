using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using vtysOdev5.Models;

namespace vtysOdev5
{
    public partial class FakulteEkle : Form
    {
        public FakulteEkle()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FakulteListele();
            
        }

        // 🟡 Fakülte listele
        private void FakulteListele()
        {
            using (var db = new OgrenciContext())
            {
                var liste = db.Fakulteler
                              .Select(f => new { f.FakulteID, f.FakulteAd })
                              .ToList();
                DataGridView1.DataSource = liste;
            }
        }

        // 🟢 Fakülte ekle
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = FakulteTextBox.Text.Trim();

                if (string.IsNullOrEmpty(ad))
                {
                    MessageBox.Show("Fakülte adı boş olamaz!");
                    return;
                }

                using (var db = new OgrenciContext())
                {
                    var yeniFakulte = new Fakulte { FakulteAd = ad };
                    db.Fakulteler.Add(yeniFakulte);
                    db.SaveChanges();
                }

                MessageBox.Show("Fakülte başarıyla eklendi.");
                FakulteTextBox.Clear();
                FakulteListele();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA OLUŞTU: " + ex.Message);
            }
        }


        // ❓ Boş event handlerlar
        private void label1_Click(object sender, EventArgs e) { }
        private void TextBox1_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
    }
}
