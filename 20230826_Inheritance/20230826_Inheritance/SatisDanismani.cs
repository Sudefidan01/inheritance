using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace _20230826_Inheritance
{
    internal class SatisDanismani:Personel
    {
        public double prim;
        public double toplamMaas { get { return prim + maas; } }
        //Miras alınan classlar içerisinde aynı isimde bir metod varsa .Classlara özgü bir metod olmasını istiyorsak bu metod içerisinde new ifadesini belirtmemiz gerekmektedir
        public new void Yazdir()
        {
            Console.WriteLine("Personel Bilgileri");
            Console.WriteLine("-------------------");
            Console.WriteLine("Personelin adı ve soyadı : " + tamAd);
            Console.WriteLine("Çalışma Saati : " + calismaSaati);
            Console.WriteLine("Saatlik Ücret : " + saatlikUcret);
            Console.WriteLine("Maaş : " + maas);
            Console.WriteLine("Prim : "+prim);
            Console.WriteLine("Toplam Alacağı Maaş : "+toplamMaas);
        }
    }

   
}
