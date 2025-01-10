using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Nesne_Programi
{
    internal class FileLog : ILOGGER
    {
        private string _message;
        public FileLog(string message)
        {
            _message = message;
            Log();
        }
        public void Log()
        {
            Console.WriteLine("Dosya Şeklinde log landı");
        }
        public string message { get; set; }
        

        
    }
}
