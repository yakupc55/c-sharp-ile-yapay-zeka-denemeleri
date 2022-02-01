using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yapayzekadenemeleri1
{
    public partial class basitAgYapilandirmaFormu : Form
    {
        public basitAgYapilandirmaFormu()
        {
            InitializeComponent();
        }

        private void btnSnapsisDegerDegistir_Click(object sender, EventArgs e)
        {
            sbs.basitAgRastgeleSnapsisMin = Convert.ToDouble(tbSnapsisMinDeger.Text);
            sbs.basitAgRastgeleSnapsisMax = Convert.ToDouble(tbSnapsisMaxDeger.Text);
        }// fonksiyon sonu

        private void basitAgYapilandirmaFormu_Load(object sender, EventArgs e)
        {
            tbSnapsisMinDeger.Text = sbs.basitAgRastgeleSnapsisMin.ToString();
            tbSnapsisMaxDeger.Text = sbs.basitAgRastgeleSnapsisMax.ToString();
        }// fonksiyon sonu
    }// sınıf sonu
}// isimlendirme sonu
