using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;


namespace DataAccessLayer
{
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut1 = new SqlCommand("Select  * from TBLbilgi", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }

            SqlDataReader dr = komut1.ExecuteReader();
            while(dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Ad = dr["AD"].ToString();
                ent.Soyad = dr["SOYAD"].ToString();
                ent.Sehir = dr["SEHIR"].ToString();
                ent.Gorev = dr["GOREV"].ToString();
                ent.Maas = short.Parse(dr["MAAS"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBLbilgi(AD,SOYAD,GOREV,SEHIR,MAAS) VALUES (@P1,@P2,@P3,@P4,@P5)", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {

            komut2.Connection.Open(); 
            }
            komut2.Parameters.AddWithValue("@P1", p.Ad);
            komut2.Parameters.AddWithValue("@P2", p.Soyad);
            komut2.Parameters.AddWithValue("@P3", p.Gorev);
            komut2.Parameters.AddWithValue("@P4", p.Sehir);
            komut2.Parameters.AddWithValue("@P5", p.Maas);
            return komut2.ExecuteNonQuery();

        }
        public static int PersonelGuncelle(EntityPersonel p)
        {
            SqlCommand komut3 = new SqlCommand("Update TBLbilgi set AD=@P1,SOYAD=@P2,GOREV=@P3,SEHIR=@P4,MAAS=@P5 where TBLbilgi.ID = @P0", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {

                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P0", p.Id);
            komut3.Parameters.AddWithValue("@P1", p.Ad);
            komut3.Parameters.AddWithValue("@P2", p.Soyad);
            komut3.Parameters.AddWithValue("@P3", p.Gorev);
            komut3.Parameters.AddWithValue("@P4", p.Sehir);
            komut3.Parameters.AddWithValue("@P5", p.Maas);
            return komut3.ExecuteNonQuery();
        }
        public static int PersonelSil(EntityPersonel p)
        {
            SqlCommand komut4 = new SqlCommand("DELETE FROM TBLbilgi where TBLbilgi.ID = @P0", Baglanti.bgl);
            if (komut4.Connection.State != ConnectionState.Open)
            {

                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P0", p.Id);
            return komut4.ExecuteNonQuery();
        }

    }
}
