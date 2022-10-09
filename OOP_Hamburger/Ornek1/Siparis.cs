using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ornek1
{
    public class Siparis
    {
        public Menu Menu { get; set; }
        public List<Malzeme> Malzemeler { get; set; }
        public int Adet { get; set; }
        public Boyut Boyut { get; set; }

        public decimal ToplamTutar { get; set; }
        public Siparis()
        {
            Malzemeler = new List<Malzeme>();
        }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += Menu.Fiyat;
            switch (Boyut)
            {
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.10M;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += ToplamTutar * 0.25M;
                    break;
                default:
                    break;
            }

            foreach (Malzeme malzeme in Malzemeler)
            {
                ToplamTutar += malzeme.Fiyat;
            }

            ToplamTutar *= Adet;
        }

        public override string ToString()
        {
            if (Malzemeler.Count < 1)
            {
                return string.Format("{0} Menü x {1} Adet, {2} Boy, Toplam: {3}", Menu.Ad, Adet, Boyut.ToString(), ToplamTutar.ToString("C2"));
            }
            else
            {
                string ekstraMalzemeler = null;
                foreach (Malzeme malzeme in Malzemeler)
                {
                    ekstraMalzemeler += malzeme.Ad + ",";
                }
                ekstraMalzemeler = ekstraMalzemeler.Trim(',');

                return string.Format("{0} Menü x {1} Adet, {2} Boy, ({3}) Toplam: {4}", Menu.Ad, Adet, Boyut.ToString(), ekstraMalzemeler, ToplamTutar.ToString("C2"));
            }
        }
    }
}
