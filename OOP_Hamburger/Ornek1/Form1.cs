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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChildForm(Form childForm)
        {

            this.Width = childForm.Width + 25;
            this.Height = childForm.Height + 70;

            bool durum = false;

            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == childForm.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }


            if (durum == false)
            {
                childForm.MdiParent = this;
                childForm.Show();
            }


            //this.ClientSize = childForm.Size;
            //childForm.Dock = DockStyle.Fill;
            //this.MinimumSize = childForm.Size;
            //childForm.MdiParent = this;
            //childForm.Show();
        }

        private void tsmSiparisOlustur_Click(object sender, EventArgs e)
        {
            ChildForm(new FormSiparisEkle());
        }

        private void tsmSiparisBilgileri_Click(object sender, EventArgs e)
        {
            ChildForm(new FormSiparisBilgileri());
        }

        private void tsmMenuEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new FormMenuBilgileri());
        }

        private void tsmEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new FormEkstraMalzeme());
        }
    }
}
