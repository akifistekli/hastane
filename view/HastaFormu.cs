using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneOto.model;
using HastaneOto.dao;

namespace HastaneOto.view
{
    public partial class HastaFormu : Form
    {
        public HastaFormu()
        {
            InitializeComponent();
          dataGridView1.DataSource = dao.HastaDao.getAll("hasta");
        }

    model. Hasta hasta =model.Hasta.getInstance();

        private void hastaEkle_Click(object sender, EventArgs e)
        {
            hasta.TCKN = txtTckn.Text;
            hasta.adi = txtAdi.Text;
            hasta.soyadi = txtSoyadi.Text;
            hasta.cinsiyet = txtCinsiyet.Text;
            hasta.dogumYeri = txtDYeri.Text;
            hasta.dogumTarihi = dtpTarih.Value;
            hasta.telefon = txtTel.Text;
            hasta.eposta = txteposta.Text;
            hasta.parola = textParola.Text;
             clearControl();
           dataGridView1.DataSource = dao.HastaDao.insert(hasta);
          
        }

        private void HastaFormu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void clearControl()
        {
            txtTckn.Text = "";
            txtAdi.Text = "";
            txtTel.Text = "";
            txtSoyadi.Text = "";
            txtCinsiyet.Text = "";
            txtDYeri.Text = "";
            txteposta.Text = "";
            textParola.Text = "";
        }
    }
}
