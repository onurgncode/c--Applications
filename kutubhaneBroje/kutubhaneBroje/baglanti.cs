using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace kutubhaneBroje
{
    public class baglanti
    {
        public SqlConnection sqlBaglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=ONURENTER\\ADMIN;Initial Catalog=DBkutuphane;Integrated Security=True;");
            baglan.Open();
            return baglan;
        }
        
        
        
    }
}
