using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutubhaneBroje
{
    public partial class kitapUyeKayit : Form
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
        public kitapUyeKayit()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            menuGetir(1);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.Close();
            menuGetir(2);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.Close();
            menuGetir(3);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.Close();
            menuGetir(4);
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
