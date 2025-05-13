namespace vtysOdev5
{
    partial class BolumEkle
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
            this.BolumComboBox = new System.Windows.Forms.ComboBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BolumTextBox = new System.Windows.Forms.TextBox();
            this.BolumAdi = new System.Windows.Forms.Label();
            this.FakSec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BolumComboBox
            // 
            this.BolumComboBox.FormattingEnabled = true;
            this.BolumComboBox.Location = new System.Drawing.Point(188, 142);
            this.BolumComboBox.Name = "BolumComboBox";
            this.BolumComboBox.Size = new System.Drawing.Size(120, 21);
            this.BolumComboBox.TabIndex = 0;
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnEkle.Location = new System.Drawing.Point(253, 239);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(55, 23);
            this.BtnEkle.TabIndex = 5;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);

            // 
            // BolumTextBox
            // 
            this.BolumTextBox.Location = new System.Drawing.Point(188, 178);
            this.BolumTextBox.Name = "BolumTextBox";
            this.BolumTextBox.Size = new System.Drawing.Size(120, 20);
            this.BolumTextBox.TabIndex = 4;
            // 
            // BolumAdi
            // 
            this.BolumAdi.AutoSize = true;
            this.BolumAdi.Location = new System.Drawing.Point(82, 178);
            this.BolumAdi.Name = "BolumAdi";
            this.BolumAdi.Size = new System.Drawing.Size(57, 13);
            this.BolumAdi.TabIndex = 3;
            this.BolumAdi.Text = "Bölüm Adı:";
            // 
            // FakSec
            // 
            this.FakSec.AutoSize = true;
            this.FakSec.Location = new System.Drawing.Point(82, 142);
            this.FakSec.Name = "FakSec";
            this.FakSec.Size = new System.Drawing.Size(82, 13);
            this.FakSec.TabIndex = 6;
            this.FakSec.Text = "Fakülte Seçiniz:";
            this.FakSec.Click += new System.EventHandler(this.label2_Click);
            // 
            // BolumEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FakSec);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BolumTextBox);
            this.Controls.Add(this.BolumAdi);
            this.Controls.Add(this.BolumComboBox);
            this.Name = "BolumEkle";
            this.Text = "BolumEkle";
            this.Load += new System.EventHandler(this.BolumEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BolumComboBox;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox BolumTextBox;
        private System.Windows.Forms.Label BolumAdi;
        private System.Windows.Forms.Label FakSec;
    }
}