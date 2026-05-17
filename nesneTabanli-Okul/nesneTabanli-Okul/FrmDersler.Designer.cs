namespace nesneTabanli_Okul
{
    partial class FrmDersler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDersler));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            data = new DataGridView();
            txtDersID = new TextBox();
            txtDersAdi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnListele = new Button();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(46, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(29, 227);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(347, 266);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(29, 490);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(215, 224);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(827, 161);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(214, 213);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(598, 490);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(194, 144);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(1060, 34);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 50);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // data
            // 
            data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data.Location = new Point(524, 213);
            data.Name = "data";
            data.Size = new Size(240, 150);
            data.TabIndex = 6;
            data.CellClick += data_CellClick;
            // 
            // txtDersID
            // 
            txtDersID.Enabled = false;
            txtDersID.Location = new Point(613, 369);
            txtDersID.Name = "txtDersID";
            txtDersID.Size = new Size(151, 23);
            txtDersID.TabIndex = 7;
            // 
            // txtDersAdi
            // 
            txtDersAdi.Location = new Point(613, 398);
            txtDersAdi.Name = "txtDersAdi";
            txtDersAdi.Size = new Size(151, 23);
            txtDersAdi.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(586, 367);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 9;
            label1.Text = "Ders ID:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(578, 396);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 10;
            label2.Text = "Ders Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(170, 48);
            label3.Name = "label3";
            label3.Size = new Size(206, 28);
            label3.TabIndex = 11;
            label3.Text = "Ders İşlemleri Paneli";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(984, 48);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 12;
            label4.Text = "Çıkış -->";
            // 
            // btnListele
            // 
            btnListele.FlatStyle = FlatStyle.Flat;
            btnListele.Font = new Font("Segoe UI", 12F);
            btnListele.Location = new Point(228, 391);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(137, 53);
            btnListele.TabIndex = 13;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // btnEkle
            // 
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 12F);
            btnEkle.Location = new Point(250, 582);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(137, 53);
            btnEkle.TabIndex = 14;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Segoe UI", 12F);
            btnGuncelle.Location = new Point(827, 380);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(137, 52);
            btnGuncelle.TabIndex = 15;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 12F);
            btnSil.Location = new Point(455, 582);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(137, 52);
            btnSil.TabIndex = 16;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // FrmDersler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1239, 726);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(btnListele);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDersAdi);
            Controls.Add(txtDersID);
            Controls.Add(data);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDersler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDersler";
            Load += FrmDersler_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private DataGridView data;
        private TextBox txtDersID;
        private TextBox txtDersAdi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnListele;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
    }
}