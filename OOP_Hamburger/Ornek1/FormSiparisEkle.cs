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
    public partial class FormSiparisEkle : Form
    {
        public static List<Siparis> tumSiparisler = new List<Siparis>();
        public static List<Siparis> mevcutSiparisler = new List<Siparis>();

        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu() { Ad = "Bing King", Fiyat=21.90M},
            new Menu() { Ad = "Whopper", Fiyat=18.60M},
            new Menu() { Ad = "Whopper Jr.", Fiyat=16.90M},
            new Menu() { Ad = "King Chicken", Fiyat=24.90M},
            new Menu() { Ad = "Köfte Burger", Fiyat=24.90M},
            new Menu() { Ad = "Steakhouse", Fiyat=24.90M}

        };

        public static List<Malzeme> malzemeler = new List<Malzeme>()
        {
            new Malzeme() { Ad = "Ketçap", Fiyat=1.00M},
            new Malzeme() { Ad = "Mayonez", Fiyat=1.00M},
            new Malzeme() { Ad = "Hardal", Fiyat=1.00M},
            new Malzeme() { Ad = "BBQ", Fiyat=1.50M},
            new Malzeme() { Ad = "Ranch", Fiyat=1.50M},
            new Malzeme() { Ad = "Buffalo", Fiyat=1.00M},
            new Malzeme() { Ad = "Soğan", Fiyat=1.00M}
        };


        public FormSiparisEkle()
        {
            InitializeComponent();
        }



        private void FormSiparisEkle_Load(object sender, EventArgs e)
        {
            foreach (Menu item in menuler)
            {
                cmbMenu.Items.Add(item.Ad + " Menü");
            }

            foreach (Malzeme item in malzemeler)
            {
                flpMalzeme.Controls.Add(new CheckBox() { Text = item.Ad, Tag = item });

                //CheckBox checkBox = new CheckBox();
                //checkBox.Name = FromTurkishToEnglish(item.Ad);
                //checkBox.Text = item.Ad;
                //flpMalzeme.Controls.Add(checkBox);
            }

            foreach (Siparis item in mevcutSiparisler)
            {
                lbxSiparisler.Items.Add(item); // Form açıldığında mevcut yani tamamlanmyan siparisleri listeleyecektir.
            }

            TutarHesapla();

            rbtnKucuk.Checked = true;
            cmbMenu.SelectedIndex = 0; // Default olarak -1'dir. Ancak -1 olursa herhangi bir eleman gelmez.

        }

        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lbxSiparisler.Items.Count; i++)
            {
                Siparis gelenSiparis = (Siparis)lbxSiparisler.Items[i];
                toplamTutar += gelenSiparis.ToplamTutar;
            }
            lblToplamTutar.Text = toplamTutar.ToString("C2");
            return toplamTutar;
        }

        //private string FromTurkishToEnglish(string text)
        //{
        //    char[] turkishChars = { 'ı', 'ğ', 'İ', 'Ğ', 'ç', 'Ç', 'ş', 'Ş', 'ö', 'Ö', 'ü', 'Ü' };
        //    char[] englishChars = { 'i', 'g', 'I', 'G', 'c', 'C', 's', 'S', 'o', 'O', 'u', 'U' };

        //    for (int i = 0; i < turkishChars.Length; i++)
        //    {
        //        text = text.Replace(turkishChars[i], englishChars[i]);
        //    }

        //    return text;
        //}

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            //Menu menu = (Menu)cmbMenu.SelectedItem; // Ben cmb'ye nesneyi değil sadece adı gönderdiğimden cast işlemi yapamıyor.
            Menu menu = menuler[cmbMenu.SelectedIndex];
            siparis.Menu = menu;

            if (rbtnKucuk.Checked)
                siparis.Boyut = Boyut.Kucuk;
            else if (rbtnOrta.Checked)
                siparis.Boyut = Boyut.Orta;
            else
                siparis.Boyut = Boyut.Buyuk;

            //foreach (Control item in grpBoyut.Controls)
            //{
            //    if (item is RadioButton)
            //    {
            //        RadioButton radioButton = item as RadioButton;
            //        string secilenBoyut = radioButton.Checked ? radioButton.Text : "";


            //    }
            //}

            foreach (CheckBox kontrol in flpMalzeme.Controls)
            {
                if (kontrol.Checked)
                    siparis.Malzemeler.Add((Malzeme)kontrol.Tag);
            }

            //foreach (var item in flpMalzeme.Controls)
            //{
            //    if (item is CheckBox)
            //    {
            //        CheckBox checkBox = item as CheckBox;
            //        if (checkBox.Checked)
            //        {
            //            string secilenMalzemeAd = checkBox.Text;
            //            foreach (Malzeme malzeme in malzemeler)
            //            {
            //                if (malzeme.Ad == secilenMalzemeAd)
            //                {
            //                    siparis.Malzemeler.Add(malzeme);
            //                }
            //            }
            //        }
            //    }
            //}

            siparis.Adet = Convert.ToInt32(nudAdet.Value);
            siparis.Hesapla();

            mevcutSiparisler.Add(siparis);
            lbxSiparisler.Items.Add(siparis);
            TutarHesapla(); // Toplam tutarı label de göstermek için.
            tumSiparisler.Add(siparis);

            // TODO: Fonksiyon class'ından Temizle metotu gelecek

        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Siparis Tutarı: " + TutarHesapla().ToString("C2")+"\nSatın Alma İşlemini Onaylıyor musunuz?","Sipariş Bilgisi",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                lbxSiparisler.Items.Clear();
                mevcutSiparisler.Clear();
                TutarHesapla(); // Label deki değeri temizlecek. Lbx de elemanlar temizleğinden
                MessageBox.Show("Siparişiniz Tamamlandı");
            }
            else
            {
                MessageBox.Show("İşleminiz iptal edildi");
            }
        }
    }
}
