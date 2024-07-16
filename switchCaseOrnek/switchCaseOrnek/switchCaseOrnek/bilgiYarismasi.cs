using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switchCaseOrnek
{
    public partial class bilgiYarismasi : Form
    {
        public bilgiYarismasi()
        {
            InitializeComponent();
        }
        int soruno = 0, dogruno = 0, yanlisno = 0;
        public void nona()
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
        }
        public void key(string gonder)
        {
            verilencvp.Text = gonder;
            if (verilencvp.Text == dogru.Text)
            {
                dogruno++;
                LblDogruno.Text = dogruno.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;

            }
            else
            {
                yanlisno++;
                LblYanlisno.Text = yanlisno.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            BtnSonraki.Enabled = true;
        }
        private void BtnB_Click(object sender, EventArgs e)
        {

            key(BtnB.Text);
            nona();
        }
        private void BtnC_Click(object sender, EventArgs e)
        {
            key(BtnC.Text);
            nona();
        }
        private void BtnD_Click(object sender, EventArgs e)
        {
            key(BtnD.Text);
            nona();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            key(BtnA.Text);
            nona();
        }
        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;
            ++soruno;
            LblSoruno.Text = soruno.ToString();
            pictureBox1.Visible = false;
            switch(soruno)
            {
                case 1:
                richTextBox1.Text = "Cumhuriyet Kaç Yılında İlan Edilmiştir";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                dogru.Text = "1923";
                break;
                case 2:
                    richTextBox1.Text = "Koşul Biligou nedir";
                    BtnA.Text = "if";
                    BtnB.Text = "button";
                    BtnC.Text = "this";
                    BtnD.Text = "sql";
                    dogru.Text = "if";
                    break;
                case 3:richTextBox1.Text = "matrix kaç yılında yayınlanmıştır";
                    BtnA.Text = "2000";
                    BtnB.Text = "1999";
                    BtnC.Text = "3000";
                    BtnD.Text = "2023";
                    dogru.Text = "1999";
                    break;
                    default : richTextBox1.Text = "Sorular Tamamlandı";
                    BtnA.Enabled = false;
                    BtnB.Enabled = false;
                    BtnC.Enabled = false;
                    BtnD.Enabled = false;
                    BtnSonraki.Enabled = false;
                    break;    
            }
            

        }
    }
}
