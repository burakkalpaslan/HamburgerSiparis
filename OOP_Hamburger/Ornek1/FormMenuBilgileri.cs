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
    public partial class FormMenuBilgileri : Form
    {
        public FormMenuBilgileri()
        {
            InitializeComponent();
        }

        private void btnMenuyuKaydet_Click(object sender, EventArgs e)
        {
            FormSiparisEkle.menuler.Add(new Menu() { Ad = txtMenuAdi.Text, Fiyat = nudFiyati.Value });

            //TODO: Ekledikten sonra temizle metotu çağırılsın.
            MessageBox.Show("Menü Başarılı Bir Şekilde Eklendi");
        }
    }
}
