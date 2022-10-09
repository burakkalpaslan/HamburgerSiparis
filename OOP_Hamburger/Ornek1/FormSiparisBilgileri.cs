using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek1
{
    public partial class FormSiparisBilgileri : Form
    {
        public FormSiparisBilgileri()
        {
            InitializeComponent();
        }

        private void FormSiparisBilgileri_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal malzemeGeliri = 0;
            int satisAdedi = 0;

            foreach (Siparis siparis in FormSiparisEkle.tumSiparisler)
            {
                ciro += siparis.ToplamTutar;
                foreach (Malzeme malzeme in siparis.Malzemeler)
                {
                    malzemeGeliri += malzeme.Fiyat;
                }

                satisAdedi += siparis.Adet;

                lbxTumSiparisler.Items.Add(siparis);
            }

            lblCiro.Text = ciro.ToString("C2");
            lblEkstraMalzemeGeliri.Text = malzemeGeliri.ToString("C2");
            lblSiparisSayisi.Text = lbxTumSiparisler.Items.Count.ToString();
            lblSatılanÜrünAdedi.Text = satisAdedi.ToString();
        }
    }
}
