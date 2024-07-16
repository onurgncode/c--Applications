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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listVeri.Items.Add(txtAd.Text + " " + txtSoy.Text + " " + txtTel.Text + " " + dateSec.Text);
            txtAd.Text = "";
            txtSoy.Text = "";
            txtTel.Text = "";
            txtAd.Focus();
            
        }
        digerElementler  ek = new digerElementler();
        private void button2_Click(object sender, EventArgs e)
        {
            ek.Show();
        }
    }
}
