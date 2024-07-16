using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listCombobox
{
    public partial class digerElementler_2 : Form
    {

        public digerElementler_2()
        {
            InitializeComponent();
            
        }
        public void hesab()
        {
            if (maskedTextBox1 != null && maskedTextBox2 != null)
            {

            
            double vize = Convert.ToInt16(maskedTextBox1.Text);
            double final = Convert.ToInt16(maskedTextBox2.Text);
            double but = 0;
            double hesa = (vize * 0.4) + (final * 0.6);
            if (hesa <= 100 && hesa >= 0)
            {
                if(hesa <= 49)
                {
                    
                    if (maskedTextBox3.Text == "")
                    {
                        label4.Visible = true;
                        maskedTextBox3.Visible = true;
                        MessageBox.Show("Bütünlemeye kaldınız");
                    }
                    else
                    {
                        but = Convert.ToInt16(maskedTextBox3.Text);
                        if (but >= 50)
                        {
                            label7.Text = maskedTextBox3.Text;
                        }
                        else
                        {
                            MessageBox.Show("Komble kaldınız");
                        }
                    }
                }
                else
                {
                    label7.Text = hesa.ToString();
                }
            }
            } // if
        }
        private void digerElementler_2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hesab();
        }
    }
}
