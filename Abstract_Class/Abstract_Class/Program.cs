using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ornek Ornek = new calisma();
            Ornek.X();
            ornek2 ornek2 = new ornek2();
            ornek2.Z();
            Console.ReadKey();
        }
    }
    // Abstract Class
    abstract class Myclass
    {
        public abstract void X();
        public abstract int MyProperty { get; set; }

    }

    abstract class ornek
    {
        abstract public void X();
        public abstract int Y { get; set; }
    }
    class calisma : ornek
    {
        public override int Y { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public override void X()
        {
            Console.WriteLine("X Yazıldı");
        }
    }
    // Virtual Method kullanımı

    class MyClass2
    {
        public virtual void Z() {
            Console.WriteLine("Base Duran Yazı");
        
        }
    }
    class ornek2 : MyClass2
    {
        public override void Z()
        {
            Console.WriteLine("Ezilmiş yazı");
            base.Z();
        }
    }

}
