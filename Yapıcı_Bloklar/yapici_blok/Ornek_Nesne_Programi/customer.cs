using System;
using System.Data.SqlClient;

namespace Ornek_Nesne_Programi
{
    internal class customer : Person
    {
        private int _id;
        private string _name;
        private string _Age;
        private string _Descripton;
        public customer(int id, string name, string age, string descripton)
        {
            _id = id;
            _name = name;
            _Age = age;
            _Descripton = descripton;
            SaveCustomer();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Descripton { get; set; }

        private void SaveCustomer()
        {
            try
            {
                Console.WriteLine("Adınız= {0}\n Yaşınız= {1}", _name, _Age + "\n" + Database.Open());
            } 
            catch ( SqlException ex)
            {
                FileLog log = new FileLog(Database.Open()+ ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("Database Kontrol ediliyor");
                if (Database.Open() != "off")
                    Console.WriteLine("Bağlantı Sağlandı Devam Edin");
                else
                    Console.WriteLine("Bağlantı sağlanılamadı Kayıt Ekranına Geçiyorsunuz");
            }
        }
    }
}
