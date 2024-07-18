using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekstraYapılar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ikinciSayfa ek = new ikinciSayfa();
        private void button1_Click(object sender, EventArgs e)
        {
            ek.Show();
            this.Hide();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point locab = new Point(20, 20);
            Button buton = new Button();
            buton.Location = locab;
            buton.Name = "buton1";
            buton.Text = "Tıklama";
            buton.BackColor = Color.Red;
            this.Controls.Add( buton ); // Kodla Oluşturmak için bunu eklemek gerekiyor
        }
    }
}
