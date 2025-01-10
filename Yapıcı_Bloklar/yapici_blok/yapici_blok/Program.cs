using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace yapici_blok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.List();

            Product product = new Product(2, "Falan"); //isterse böyle
            Product product2 = new Product();
            product2.id = 2;
            product2.Name = "falan";

            EmployeeManager emp = new EmployeeManager(new FileLogger()); // Construckter injection
            emp.add();
            

            PersonManager personManager = new PersonManager("Personel");
            personManager.Added();

            Console.ReadLine();
        }
        class CustomerManager
        {
            //ctor constracter oluşturmak için yazıp taba basılır
            private int _count = 15;
            public CustomerManager(int count)
            {
                _count = count;

            }
            //constracterların overloadingi aşırı yüklenmesi 
            public CustomerManager()
            {

            }
            public void List()
            {
                Console.WriteLine($"{_count} tane item Listelendi");
            }
            public void Add()
            {
                Console.WriteLine("Eklendi");
            }
        }// CM

        class Product
        {
            private int _id;
            private string _name;
            public Product(int id, string name)
            {
                _id = id;
                _name = name;
            }
            public Product()
            {

            }
            //prop+tab ile hızlıca oluşturulabilir
            public int id { get; set; }
            public string Name { get; set; }
        } // Product

        interface ILOGGER
        {
            void Log();
        }
        class DatebaseLogger : ILOGGER
        {
            public void Log()
            {
                Console.WriteLine("I log to database");
            }
        }

        class FileLogger : ILOGGER
        {
            public void Log()
            {
                
                Console.WriteLine("I log to File");
            }
        }
         class EmployeeManager
        {

            private ILOGGER _logger;
            public EmployeeManager(ILOGGER logger)
            {
                _logger = logger;
            }

            public void add()
            {
                _logger.Log();
                Console.WriteLine("ADDED!");
            }
        }

        class BaseClass
        {
            private string _entity;
            public BaseClass(string entity)
            {
                _entity = entity;
            }
            public void Message()
            {
                Console.WriteLine("{0} Message",_entity);
            }
        }


        class PersonManager : BaseClass
        {
            public PersonManager(string entity):base(entity)
            {
                
            }

            public void Added()
            {
                Console.WriteLine("Person Added!");
                Message();
            }
        }


        // Statik nesneler bellekte bir defa üretilir new lenemez 
        static class Teacher
        {
            // static classların proportileride static olmalıdır.
            // static nesneler ortak nesnelerdir herkes için aynı değer kullanılır her sayfa içinde aynı değer kullanılır
            public static int Number { get; set; }
        }
        class Manager {
            // new lemeden kullanılabilir
            public static void DoSomthing()
            {
                Console.WriteLine("Done");
            }
            // yada newleyerek 
            public void DoSomthing2()
            {
                Console.Write("Done 2");
            }
        }
    }
}
