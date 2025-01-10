using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Nesne_Programi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                customer cus = new customer(12, "falan", "12", "sadsadasd");
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                DatabaseLog loged = new DatabaseLog(ex.Message.ToString());
            }
        }
    }
}
