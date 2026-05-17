using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nesneTabanli_Okul
{
    public partial class FrmSinavNotlar : Form
    {
        public FrmSinavNotlar()
        {
            InitializeComponent();
        }

        DataSet2TableAdapters.notlarTableAdapter ds = new DataSet2TableAdapters.notlarTableAdapter(); 
        private void btnAra_Click(object sender, EventArgs e)
        {
            data.DataSource = ds.NotListesi(int.Parse(txtOgrenciID.Text));
        }
    }
}
