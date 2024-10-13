using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230826_Inheritance
{
    internal class Personel:Kisi
    {
        public int calismaSaati, saatlikUcret;

        public double maas
        {
            get { return (double)calismaSaati*saatlikUcret;}
        }

        public void Yazdir()
        {
            Console.WriteLine("Personel Bilgileri");
            Console.WriteLine("-------------------");
            Console.WriteLine("Personelin adı ve soyadı : "+tamAd);
            Console.WriteLine("Çalışma Saati : "+calismaSaati);
            Console.WriteLine("Saatlik Ücret : "+saatlikUcret);
            Console.WriteLine("Maaş : "+maas);
        }

    }
}
