using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıfOzellikleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisiler ek = new Kisiler();
            Console.WriteLine(ek.AD + " " + ek.SOYAD + " " + ek.MEMLEKET + " " + ek.CINSIYET + " " + ek.YAS);
            Console.ReadLine();
        }
    }
}
