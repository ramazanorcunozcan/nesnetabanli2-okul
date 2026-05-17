using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nesneTabanli_Okul
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.derslerTableAdapter ds = new DataSet1TableAdapters.derslerTableAdapter();
        private void FrmDersler_Load(object sender, EventArgs e)
        {
            data.DataSource = ds.DersListesi();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(txtDersAdi.Text);
            MessageBox.Show("Ders ekleme işlemi yapıldı.");

            data.DataSource = ds.DersListesi();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            data.DataSource = ds.DersListesi();
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDersID.Text = data.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDersAdi.Text = data.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.DersGuncelle(txtDersAdi.Text, Convert.ToByte(txtDersID.Text));
            MessageBox.Show("Güncelleme başarılı.");

            data.DataSource = ds.DersListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.DersSil(Convert.ToByte(txtDersID.Text));
            MessageBox.Show("Ders silme işlemi başarılı.");

            data.DataSource = ds.DersListesi();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
