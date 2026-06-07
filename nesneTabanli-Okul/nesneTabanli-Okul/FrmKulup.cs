using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace nesneTabanli_Okul
{
    public partial class FrmKulup : Form
    {
        public FrmKulup()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=ORCUN\SQLEXPRESS;Initial Catalog=okul-NesneTabanli;Integrated Security=SSPI");

        void liste()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from kulupler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            data.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void FrmKulup_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kulupler(kulup_ad) values(@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKulupAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulup listeye eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKulupID.Text = data.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtKulupAd.Text = data.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Maroon;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from kulupler where kulup_id = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKulupID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşlem başarılı.");
            liste();
            txtKulupAd.Text = "";
            txtKulupID.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update kulupler set kulup_ad = @p1 where kulup_id = @p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKulupAd.Text);
            komut.Parameters.AddWithValue("@p2", txtKulupID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşlem başarılı.");
            liste();
        }
    }
}
