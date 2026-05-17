namespace nesneTabanli_Okul
{
    partial class FrmKulup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKulup));
            data = new DataGridView();
            txtKulupID = new TextBox();
            txtKulupAd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnListele = new Button();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label3 = new Label();
            pictureBox6 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)data).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // data
            // 
            data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data.Location = new Point(492, 436);
            data.Name = "data";
            data.ReadOnly = true;
            data.Size = new Size(240, 150);
            data.TabIndex = 0;
            data.CellClick += data_CellClick;
            // 
            // txtKulupID
            // 
            txtKulupID.Enabled = false;
            txtKulupID.Location = new Point(574, 587);
            txtKulupID.Name = "txtKulupID";
            txtKulupID.Size = new Size(158, 23);
            txtKulupID.TabIndex = 1;
            // 
            // txtKulupAd
            // 
            txtKulupAd.Location = new Point(574, 616);
            txtKulupAd.Name = "txtKulupAd";
            txtKulupAd.Size = new Size(158, 23);
            txtKulupAd.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(496, 589);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 3;
            label1.Text = "Kulüp ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(488, 616);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 4;
            label2.Text = "Kulüp Adı:";
            label2.Click += label2_Click;
            // 
            // btnListele
            // 
            btnListele.FlatStyle = FlatStyle.Flat;
            btnListele.Font = new Font("Segoe UI", 12F);
            btnListele.Location = new Point(248, 321);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(101, 43);
            btnListele.TabIndex = 5;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += button1_Click;
            // 
            // btnEkle
            // 
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 12F);
            btnEkle.Location = new Point(248, 529);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(101, 43);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Segoe UI", 12F);
            btnGuncelle.Location = new Point(877, 321);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(101, 43);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 12F);
            btnSil.Location = new Point(877, 529);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(101, 43);
            btnSil.TabIndex = 8;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 286);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 447);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(201, 192);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1012, 250);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(199, 191);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1012, 447);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(199, 192);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(406, 43);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(370, 189);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 17F);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(474, 9);
            label3.Name = "label3";
            label3.Size = new Size(232, 31);
            label3.TabIndex = 14;
            label3.Text = "Kulüp İşlemleri Paneli";
            // 
            // pictureBox6
            // 
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(1167, 9);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(44, 54);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            pictureBox6.MouseLeave += pictureBox6_MouseLeave;
            pictureBox6.MouseHover += pictureBox6_MouseHover;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(309, 131);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 16;
            label4.Text = "Ayarlar  -->";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(1087, 30);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 17;
            label5.Text = "Çıkış  -->";
            // 
            // FrmKulup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1223, 651);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox6);
            Controls.Add(label3);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(btnListele);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtKulupAd);
            Controls.Add(txtKulupID);
            Controls.Add(data);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmKulup";
            Text = "FrmKulup";
            Load += FrmKulup_Load;
            ((System.ComponentModel.ISupportInitialize)data).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView data;
        private TextBox txtKulupID;
        private TextBox txtKulupAd;
        private Label label1;
        private Label label2;
        private Button btnListele;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label3;
        private PictureBox pictureBox6;
        private Label label4;
        private Label label5;
    }
}