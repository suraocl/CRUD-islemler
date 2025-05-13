namespace vtysOdev5
{
    partial class OgrenciEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BolumTextBox = new System.Windows.Forms.TextBox();
            this.OgrSoyAd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OgrAd = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.OgrBolum = new System.Windows.Forms.Label();
            this.OgrDataGrid = new System.Windows.Forms.DataGridView();
            this.OgrBilgiler = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OgrDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnEkle.Location = new System.Drawing.Point(279, 284);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(55, 23);
            this.BtnEkle.TabIndex = 8;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BolumTextBox
            // 
            this.BolumTextBox.Location = new System.Drawing.Point(214, 169);
            this.BolumTextBox.Name = "BolumTextBox";
            this.BolumTextBox.Size = new System.Drawing.Size(120, 20);
            this.BolumTextBox.TabIndex = 7;
            // 
            // OgrSoyAd
            // 
            this.OgrSoyAd.AutoSize = true;
            this.OgrSoyAd.Location = new System.Drawing.Point(108, 176);
            this.OgrSoyAd.Name = "OgrSoyAd";
            this.OgrSoyAd.Size = new System.Drawing.Size(96, 13);
            this.OgrSoyAd.TabIndex = 6;
            this.OgrSoyAd.Text = "Öğrencinin Soyadı:";
            this.OgrSoyAd.Click += new System.EventHandler(this.BolumAdi_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 10;
            // 
            // OgrAd
            // 
            this.OgrAd.AutoSize = true;
            this.OgrAd.Location = new System.Drawing.Point(108, 128);
            this.OgrAd.Name = "OgrAd";
            this.OgrAd.Size = new System.Drawing.Size(79, 13);
            this.OgrAd.TabIndex = 9;
            this.OgrAd.Text = "Öğrencinin Adı:";
            this.OgrAd.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(214, 216);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // OgrBolum
            // 
            this.OgrBolum.AutoSize = true;
            this.OgrBolum.Location = new System.Drawing.Point(108, 219);
            this.OgrBolum.Name = "OgrBolum";
            this.OgrBolum.Size = new System.Drawing.Size(99, 13);
            this.OgrBolum.TabIndex = 12;
            this.OgrBolum.Text = "Öğrencinin Bölümü:";
            // 
            // OgrDataGrid
            // 
            this.OgrDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OgrDataGrid.Location = new System.Drawing.Point(358, 114);
            this.OgrDataGrid.Name = "OgrDataGrid";
            this.OgrDataGrid.Size = new System.Drawing.Size(430, 193);
            this.OgrDataGrid.TabIndex = 14;
            // 
            // OgrBilgiler
            // 
            this.OgrBilgiler.AutoSize = true;
            this.OgrBilgiler.Location = new System.Drawing.Point(373, 98);
            this.OgrBilgiler.Name = "OgrBilgiler";
            this.OgrBilgiler.Size = new System.Drawing.Size(96, 13);
            this.OgrBilgiler.TabIndex = 15;
            this.OgrBilgiler.Text = "Öğrencinin Bilgileri:";
            // 
            // OgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OgrBilgiler);
            this.Controls.Add(this.OgrDataGrid);
            this.Controls.Add(this.OgrBolum);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OgrAd);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BolumTextBox);
            this.Controls.Add(this.OgrSoyAd);
            this.Name = "OgrenciEkle";
            this.Text = "ÖğrenciEkle";
            this.Load += new System.EventHandler(this.OgrenciEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OgrDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox BolumTextBox;
        private System.Windows.Forms.Label OgrSoyAd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label OgrAd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label OgrBolum;
        private System.Windows.Forms.DataGridView OgrDataGrid;
        private System.Windows.Forms.Label OgrBilgiler;
    }
}

