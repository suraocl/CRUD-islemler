namespace vtysOdev5
{
    partial class FakulteEkle
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.Label1 = new System.Windows.Forms.Label();
            this.FakulteTextBox = new System.Windows.Forms.TextBox();
            this.BtnFakulteEkle = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(43, 65);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(63, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Fakülte Adı:";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FakulteTextBox
            // 
            this.FakulteTextBox.Location = new System.Drawing.Point(112, 58);
            this.FakulteTextBox.Name = "FakulteTextBox";
            this.FakulteTextBox.Size = new System.Drawing.Size(230, 20);
            this.FakulteTextBox.TabIndex = 1;
            this.FakulteTextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // BtnFakulteEkle
            // 
            this.BtnFakulteEkle.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnFakulteEkle.Location = new System.Drawing.Point(417, 60);
            this.BtnFakulteEkle.Name = "BtnFakulteEkle";
            this.BtnFakulteEkle.Size = new System.Drawing.Size(55, 23);
            this.BtnFakulteEkle.TabIndex = 2;
            this.BtnFakulteEkle.Text = "Ekle";
            this.BtnFakulteEkle.UseVisualStyleBackColor = false;
            this.BtnFakulteEkle.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(44, 93);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(428, 222);
            this.DataGridView1.TabIndex = 3;
            // 
            // FakulteEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.BtnFakulteEkle);
            this.Controls.Add(this.FakulteTextBox);
            this.Controls.Add(this.Label1);
            this.Name = "FakulteEkle";
            this.Text = "FakulteEkle";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox FakulteTextBox;
        private System.Windows.Forms.Button BtnFakulteEkle;
        private System.Windows.Forms.DataGridView DataGridView1;
    }
}
