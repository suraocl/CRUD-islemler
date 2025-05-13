using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtysOdev5
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BtnFakulte_Click(object sender, EventArgs e)
        {
            FakulteEkle frm = new FakulteEkle();
            frm.ShowDialog();

        }

        private void BolumEkle_Click(object sender, EventArgs e)
        {
            BolumEkle frm = new BolumEkle();
            frm.ShowDialog();
        }

        private void OgrenciEkle_Click(object sender, EventArgs e)
        {

            OgrenciEkle frm = new OgrenciEkle();
            frm.ShowDialog();
        }

        private void OgrenciSorgula_Click(object sender, EventArgs e)
        {
            OgrenciSorgula frm = new OgrenciSorgula();
            frm.ShowDialog();
        }

        private void OgrenciSorgulaWeb_Click(object sender, EventArgs e)
        {
         
        }
    }
}
