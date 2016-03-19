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
    public partial class RandevuFormu : Form
    {

        public RandevuFormu()
        {
            InitializeComponent();
            dataGridView1.DataSource = dao.RandevuDao.getAll("randevu");


        }
        // randevu nesnesi olusturma
        model.Randevu randevu = model.Randevu.getInstance();

        private void randevuEkle_Click(object sender, EventArgs e)
        {
            // randevu nesnesının degıskenlerını doldurma
            randevu.ID = Convert.ToInt32(txtId.Text);
            randevu.hastaTC = txtTC.Text;
            randevu.hastaAdi = txtHastaAdi.Text;
            randevu.hastane = txtHastane.Text;
            randevu.doktor = txtDoctor.Text;
            randevu.hastaTel = txtTel.Text;
            randevu.bolum = txtBolum.Text;
            randevu.tarih = dtpTarih.Value;
             clearControl();
            dataGridView1.DataSource = dao.RandevuDao.insert(randevu);
             
        }

        private void RandevuFormu_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void clearControl()
        {
            txtId.Text = "";
            txtTC.Text = "";
            txtTel.Text = "";
            txtHastaAdi.Text = "";
            txtBolum.Text = "";
            txtDoctor.Text = "";
            txtHastane.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            MessageBox.Show("Test : "+row.Cells[0].Value);
        }

    }
}

