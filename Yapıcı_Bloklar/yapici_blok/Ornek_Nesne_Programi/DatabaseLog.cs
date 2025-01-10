using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Nesne_Programi
{
    internal class DatabaseLog : ILOGGER
    {
        private string _message;
        public DatabaseLog(string message)
        {
            _message = message;
            Log();
        }
        

        public void Log()
        {
            Console.WriteLine("{0}\n Hatasını Aldınız Database Kayıt Başarılı",_message + Database.Open());
        }

        public string message { get; set; }
    }
}
