using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nesneTabanli_Okul
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        DataSet2TableAdapters.DataTable1TableAdapter ds = new DataSet2TableAdapters.DataTable1TableAdapter();
        private void button5_Click(object sender, EventArgs e)
        {
            data.DataSource = ds.OgrenciGetir(txtAra.Text);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            data.DataSource = ds.OgrenciListesi();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = cbKulüp.SelectedValue.ToString();
        }

        string cins = "";
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cins = "Kadın";
            }
            if (radioButton2.Checked)
            {
                cins = "Erkek";
            }

            ds.OgrenciEkle(txtAd.Text, txtSoyad.Text, byte.Parse(cbKulüp.SelectedValue.ToString()), cins);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(txtID.Text));
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.OgrenciGuncelle(txtAd.Text, txtSoyad.Text, byte.Parse(cbKulüp.SelectedValue.ToString()), cins, int.Parse(txtID.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cins = "Kız";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                cins = "Erkek";
            }
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = data.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtAd.Text = data.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSoyad.Text = data.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbKulüp.Text = data.Rows[e.RowIndex].Cells[3].Value.ToString();

                string cinsiyet = data.Rows[e.RowIndex].Cells["ogr_cinsiyet"].Value.ToString().Trim();

                if (cinsiyet == "Kız")
                {
                    radioButton1.Checked = true;
                    cins = "Kız";
                }
                else if (cinsiyet == "Erkek")
                {
                    radioButton2.Checked = true;
                    cins = "Erkek";
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
