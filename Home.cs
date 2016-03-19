using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneOto.view;

namespace HastaneOto
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRandevuIslemleri_Click(object sender, EventArgs e)
        {
            RandevuFormu frmRandevu = new RandevuFormu();
            frmRandevu.Show();
        }

        private void btnHastaIslemleri_Click(object sender, EventArgs e)
        {
            HastaFormu frmHasta = new HastaFormu();
            frmHasta.Show();
        }

    }
}
