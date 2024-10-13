using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230826_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inheritance(Kalıtım)
            //c# programlama dili içerisinde aynı proje içerisinde birden fazla class yazabilir , bu classlar içerisinde bazı propertylerin özellikleri aynı olabilir.
            //Bir class'ı başka bir class'a miras alabilir , miras aldığınız class içerisinde diğer class'ın tüm özelliklerini kullanabiliriz
            //Bir class ' a sadece bir tane class miras edebilirsiniz
            //BU miras alma işlemleri class yapıları içerisinde zincirleme olabilir

            Personel p = new Personel();
            p.ad = "Ahmet";
            p.soyad = "Kaçar";
            p.calismaSaati = 200;
            p.saatlikUcret = 180;
            p.Yazdir();
            Console.WriteLine("-------------------------");
            SatisDanismani sd = new SatisDanismani();
            sd.ad = "Ayşe";
            sd.soyad = "Yumlu";
            sd.calismaSaati = 220;
            sd.saatlikUcret = 180;
            sd.prim = 6000;
            sd.Yazdir();



            Console.ReadKey();
        }
    }
}
