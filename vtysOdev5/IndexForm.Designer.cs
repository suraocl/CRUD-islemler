namespace vtysOdev5
{
    partial class IndexForm
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
            this.BtnFakulte = new System.Windows.Forms.Button();
            this.BolumEkle = new System.Windows.Forms.Button();
            this.OgrenciEkle = new System.Windows.Forms.Button();
            this.OgrenciSorgula = new System.Windows.Forms.Button();
            this.OgrenciSorgulaWeb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFakulte
            // 
            this.BtnFakulte.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnFakulte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFakulte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFakulte.Location = new System.Drawing.Point(218, 46);
            this.BtnFakulte.Name = "BtnFakulte";
            this.BtnFakulte.Size = new System.Drawing.Size(177, 53);
            this.BtnFakulte.TabIndex = 0;
            this.BtnFakulte.Text = "Fakülte Ekle";
            this.BtnFakulte.UseVisualStyleBackColor = false;
            this.BtnFakulte.Click += new System.EventHandler(this.BtnFakulte_Click);
            // 
            // BolumEkle
            // 
            this.BolumEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BolumEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BolumEkle.Location = new System.Drawing.Point(218, 127);
            this.BolumEkle.Name = "BolumEkle";
            this.BolumEkle.Size = new System.Drawing.Size(177, 53);
            this.BolumEkle.TabIndex = 1;
            this.BolumEkle.Text = "Bölüm Ekle";
            this.BolumEkle.UseVisualStyleBackColor = true;
            this.BolumEkle.Click += new System.EventHandler(this.BolumEkle_Click);
            // 
            // OgrenciEkle
            // 
            this.OgrenciEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OgrenciEkle.Location = new System.Drawing.Point(218, 207);
            this.OgrenciEkle.Name = "OgrenciEkle";
            this.OgrenciEkle.Size = new System.Drawing.Size(177, 53);
            this.OgrenciEkle.TabIndex = 2;
            this.OgrenciEkle.Text = "Öğrenci Ekle";
            this.OgrenciEkle.UseVisualStyleBackColor = true;
            this.OgrenciEkle.Click += new System.EventHandler(this.OgrenciEkle_Click);
            // 
            // OgrenciSorgula
            // 
            this.OgrenciSorgula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OgrenciSorgula.Location = new System.Drawing.Point(218, 290);
            this.OgrenciSorgula.Name = "OgrenciSorgula";
            this.OgrenciSorgula.Size = new System.Drawing.Size(177, 53);
            this.OgrenciSorgula.TabIndex = 3;
            this.OgrenciSorgula.Text = "Öğrenci Sorgula";
            this.OgrenciSorgula.UseVisualStyleBackColor = true;
            this.OgrenciSorgula.Click += new System.EventHandler(this.OgrenciSorgula_Click);
            // 
            // OgrenciSorgulaWeb
            // 
            this.OgrenciSorgulaWeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OgrenciSorgulaWeb.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.OgrenciSorgulaWeb.Location = new System.Drawing.Point(218, 366);
            this.OgrenciSorgulaWeb.Name = "OgrenciSorgulaWeb";
            this.OgrenciSorgulaWeb.Size = new System.Drawing.Size(177, 53);
            this.OgrenciSorgulaWeb.TabIndex = 4;
            this.OgrenciSorgulaWeb.Text = "Öğrenci Sorgula (Web Servisi İle)";
            this.OgrenciSorgulaWeb.UseVisualStyleBackColor = true;
            this.OgrenciSorgulaWeb.Click += new System.EventHandler(this.OgrenciSorgulaWeb_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnFakulte);
            this.Controls.Add(this.OgrenciSorgulaWeb);
            this.Controls.Add(this.OgrenciSorgula);
            this.Controls.Add(this.OgrenciEkle);
            this.Controls.Add(this.BolumEkle);
            this.Name = "IndexForm";
            this.Text = "IndexForm";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFakulte;
        private System.Windows.Forms.Button BolumEkle;
        private System.Windows.Forms.Button OgrenciEkle;
        private System.Windows.Forms.Button OgrenciSorgula;
        private System.Windows.Forms.Button OgrenciSorgulaWeb;
    }
}