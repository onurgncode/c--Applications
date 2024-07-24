using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace kutubhaneBroje
{
    
    public partial class kütüphaneEkle : Form
    {
        kitapUyeKayit ek;
        uyeKayit ek1;
        Form1 ek2;
        kütüphaneEkle ek3;
        girisSayfasi ek4;
        public void menuGetir(int x)
        {

            switch (x)
            {
                case 1:
                    if (ek == null || IsDisposed)
                    {
                        ek = new kitapUyeKayit();
                        ek.Show();
                        break;
                    }
                    else
                    {
                        ek = null;
                        ek = new kitapUyeKayit();
                        ek.Show();
                        break;
                    }

                case 2:
                    if (ek1 == null || IsDisposed)
                    {
                        ek1 = new uyeKayit();
                        ek1.Show();
                        break;
                    }
                    else
                    {
                        ek1 = null;
                        ek1 = new uyeKayit();
                        ek1.Show();
                        break;
                    }
                case 3:
                    if (ek2 == null || IsDisposed)
                    {
                        ek2 = new Form1();
                        ek2.Show();
                        break;
                    }
                    else
                    {
                        ek2 = null;
                        ek2 = new Form1();
                        ek2.Show();
                        break;
                    }
                case 4:
                    if (ek3 == null || IsDisposed)
                    {
                        ek3 = new kütüphaneEkle();
                        ek3.Show();
                        break;
                    }
                    else
                    {
                        ek3 = null;
                        ek3 = new kütüphaneEkle();
                        ek3.Show();
                        break;
                    }
                case 5:
                    if (ek4 == null || IsDisposed)
                    {
                        ek4 = new girisSayfasi();
                        ek4.Show();
                        break;
                    }
                    else
                    {
                        ek4 = null;
                        ek4 = new girisSayfasi();
                        ek4.Show();
                        break;
                    }

            }
        }
        public kütüphaneEkle()
        {
            InitializeComponent();

        }
        int Move;
        int Mouse_X;
        int Mouse_Y;
        baglanti bgl = new baglanti();
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
            menuGetir(1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBLKutuphane (Adi, Adresi) values (@p1,@p2)", bgl.sqlBaglanti());
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtAdres.Text);
            komut.ExecuteNonQuery();
            bgl.sqlBaglanti().Close();
            MessageBox.Show("Kütüphane Eklenmiştir", "Bilgi");
            txtAd.Text = "";
            txtAdres.Text = "";
            silmek();
            Guncelle();
        }
        public void silmek()
        {
            comboBox1.Items.Clear();
            // Silmek için 
            SqlCommand komut1 = new SqlCommand("select Adi from TBLKutuphane", bgl.sqlBaglanti());
            SqlDataReader dr2 = komut1.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2[0]);
            }
            bgl.sqlBaglanti().Close();
            comboBox1.Text = "Seçiniz";
            comboBox2.Text = "Seçiniz";
        }

        public void Guncelle()
        {
            comboBox2.Items.Clear();
            // Güncellemek için
            SqlCommand komut2 = new SqlCommand("select Adi from TBLKutuphane", bgl.sqlBaglanti());
            SqlDataReader dr3 = komut2.ExecuteReader();
            while (dr3.Read())
            {
                comboBox2.Items.Add(dr3[0]);
            }
            bgl.sqlBaglanti().Close();
            comboBox1.Text = "Seçiniz";
            comboBox2.Text = "Seçiniz";
            txtguncelad.Text = "";
            txtgunceladres.Text = "";
        }
        private void kütüphaneEkle_Load(object sender, EventArgs e)
        {
            silmek();
            Guncelle();
            comboBox1.Text = "Seçiniz";
            comboBox2.Text = "Seçiniz";

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dinle1 = MessageBox.Show("Silmek İstedigine Eminmisin", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            
            if(dinle1 == DialogResult.OK)
            {
                SqlCommand komutSil = new SqlCommand("DELETE from TBLKutuphane where TBLKutuphane.Adi =@P1", bgl.sqlBaglanti());
                komutSil.Parameters.Add("@P1", comboBox1.Text);
                komutSil.ExecuteNonQuery();
                bgl.sqlBaglanti().Close();
                
                MessageBox.Show("Başarıyla Silinmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            silmek();
            Guncelle();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
            menuGetir(2);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            menuGetir(3);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("UPDATE TBLKutuphane SET Adi = @P1, Adresi = @P2 WHERE Adi = @P3", bgl.sqlBaglanti());
            komut2.Parameters.AddWithValue("@P1", txtguncelad.Text);
            komut2.Parameters.AddWithValue("@P3", comboBox2.Text);
            komut2.Parameters.AddWithValue("@P2", txtgunceladres.Text);
            komut2.ExecuteNonQuery();
            bgl.sqlBaglanti().Close();
            MessageBox.Show("Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            silmek();
            Guncelle();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("select * from TBLKutuphane where Adi = @P1", bgl.sqlBaglanti());
            komut2.Parameters.AddWithValue("@P1", comboBox2.Text);
            SqlDataReader dr4 = komut2.ExecuteReader();
            while (dr4.Read())
            {
                txtguncelad.Text = dr4[1].ToString();
                txtgunceladres.Text = dr4[2].ToString();
            }
            bgl.sqlBaglanti().Close();
            
        }
    }
}
