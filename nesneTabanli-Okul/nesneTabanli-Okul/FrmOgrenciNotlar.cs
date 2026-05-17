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
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=ORCUN\SQLEXPRESS;Initial Catalog=okul-NesneTabanli;Integrated Security=SSPI");

        public string numara;

        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutAdSoyad = new SqlCommand("Select ogr_ad, ogr_soyad FROM ogrenciler WHERE ogr_id = @p1", baglanti);
            komutAdSoyad.Parameters.AddWithValue("@p1", Convert.ToInt32(numara));
            SqlDataReader dr = komutAdSoyad.ExecuteReader();

            while (dr.Read())
            {
                this.Text = dr[0] + " " + dr[1];
            }
            baglanti.Close();


            SqlCommand komut = new SqlCommand(@"Select ders_ad,sinav1,sinav2,sinav3,proje,ortalama,durum from notlar
                                                inner join dersler on dersler.ders_id = notlar.dersid where ogrid = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", Convert.ToInt32(numara));

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
