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
namespace kutubhaneBroje
{
    public partial class Form1 : Form
    {
        baglanti bgl = new baglanti();
        kitapUyeKayit ek;
        uyeKayit ek1;
        Form1 ek2;
        kütüphaneEkle ek3;
        girisSayfasi ek4;
        public void sil()
        {
            txtbarkod.Text = "";
            txtad.Text = "";
            txtsayfa.Text = "";
            txttur.Text = "";
            txtyazar.Text = "";
            combokut.Text = "Seçiniz";
        }
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
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            SqlCommand komutekle = new SqlCommand("select Adi from TBLKutuphane",bgl.sqlBaglanti());
            SqlDataReader dr2 = komutekle.ExecuteReader();
            while (dr2.Read())
            {
                combokut.Items.Add(dr2[0].ToString());
            }
            bgl.sqlBaglanti().Close();
        }
        int Move;
        int Mouse_X;
        int Mouse_Y;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlDataAdapter komut2 = new SqlDataAdapter("select TBLKitap.ID,TBLKitap.Adi,TBLKitap.Yazari,TBLKitap.Sayfa,TBLKitap.Tur,TBLKutuphane.Adi" +
                " from TBLKitap inner join TBLKutuphane on TBLKitap.KUTUPID = TBLKutuphane.ID ",bgl.sqlBaglanti());
            DataTable table = new DataTable();
            komut2.Fill(table);
            dataGridView1.DataSource = table;
            bgl.sqlBaglanti().Close();
            
        }

        private void kitaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void seçeneklerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            menuGetir(3);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
            menuGetir(1);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
            menuGetir(2);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
           menuGetir(4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlCommand ekle = new SqlCommand("insert into TBLKitap(Adi,Yazari,Sayfa,Tur,KUTUPID) values (@P1,@P2,@P3,@P4,@P6)" , bgl.sqlBaglanti());
           
            SqlCommand oku = new SqlCommand("select ID from TBLKutuphane where Adi = @P8", bgl.sqlBaglanti());
            oku.Parameters.AddWithValue("@P8", combokut.Text);
            SqlDataReader dr = oku.ExecuteReader();
            while (dr.Read())
            {
                ekle.Parameters.AddWithValue("@P6", dr[0]);
            }
            
            ekle.Parameters.AddWithValue("@P1", txtad.Text);
            ekle.Parameters.AddWithValue("@P2", txtyazar.Text);
            ekle.Parameters.AddWithValue("@P3", txtsayfa.Text);
            ekle.Parameters.AddWithValue("@P4", txttur.Text);
            ekle.ExecuteNonQuery();
            bgl.sqlBaglanti().Close();
            MessageBox.Show("Başarıyla Kaydedilmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sil();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtbarkod.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsayfa.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txttur.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtyazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            combokut.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }
    }
}
