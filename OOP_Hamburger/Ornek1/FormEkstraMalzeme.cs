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
    public partial class FormEkstraMalzeme : Form
    {
        public FormEkstraMalzeme()
        {
            InitializeComponent();
        }

        private void btnMenuyuKaydet_Click(object sender, EventArgs e)
        {
            FormSiparisEkle.malzemeler.Add(new Malzeme() { Ad = txtMalzemeAdi.Text, Fiyat = nudFiyati.Value });

            //TODO: Ekledikten sonra temizle metotu çağırılsın.
            MessageBox.Show("Malzeme Başarılı Bir Şekilde Eklendi");
        }
    }
}
