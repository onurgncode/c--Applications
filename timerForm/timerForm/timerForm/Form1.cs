using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            sayac++;
            label1.Text = sayac.ToString();
            if(sayac < 6)
            {
            switch (label1.Text)
            {
                case "1":
                
                this.BackColor = Color.Green;
                    break;
                case "2":
                    
                    this.BackColor = Color.Aqua;
                    break;
                case "3":
                    
                    this.BackColor = Color.Blue;
                    break;
                case "4":
                    
                    this.BackColor = Color.Bisque;
                    break;
                case "5":
                    
                    this.BackColor = Color.Green;
                    break;
            }// swtich
                timer1.Stop();
            }// if
            else
            {
                this.Close();
            }
        }
        djitalSaat ek = new djitalSaat();
        private void button2_Click(object sender, EventArgs e)
        {
            ek.Show();
        }
    }
}
