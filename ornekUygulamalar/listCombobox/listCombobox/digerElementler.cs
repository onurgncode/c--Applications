using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listCombobox
{
    public partial class digerElementler : Form
    {
        public digerElementler()
        {
            InitializeComponent();
        }
        public void dondur()
        {
            string al = txtgit.Text;
            txtgit.Text = txtvar.Text;
            txtvar.Text = al;
        }
        private void digerElementler_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rotanız : " + txtgit.Text + " - " + txtvar.Text +  " "+"Bilgileriniz : " + txtTc.Text + " " + txtTel.Text);
            MessageBox.Show("Bilgiler Kaydedildi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dondur();
        }
        digerElementler_2 ek = new digerElementler_2();
        private void button3_Click(object sender, EventArgs e)
        {
            ek.Show();
        }
    }
}
