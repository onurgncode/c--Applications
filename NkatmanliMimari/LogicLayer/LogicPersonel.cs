using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelListesi()
        {
            return DALPersonel.PersonelListesi();
        }
        public static int  LLPersonelEkle(EntityPersonel p)
        {
            if (p.Ad != "")
            {
                return DALPersonel.PersonelEkle(p);
            }
            else
            {
                return -1;
            }
        }
        public static int LLPersonelGuncelle(EntityPersonel p)
        {
            return DALPersonel.PersonelGuncelle(p);
        }
        public static int LLPersonelSil(EntityPersonel p)
        {
            return DALPersonel.PersonelSil(p);
        }
    }
}
