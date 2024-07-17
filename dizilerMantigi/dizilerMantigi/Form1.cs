using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dizilerMantigi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] isimler = { "Ahmet", "mehmet", "Ayşe" };
            //for (int i = 0; i < isimler.Length;i++ )
            //{
            //    listBox1.Items.Add( isimler[i]);
            //}

            // 10 dan büyük çift sayıları listelet
            //int[] obcift = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12,13,14,15,16 };
            //for(int i = 0; i < obcift.Length; i++)
            //{
            //    if (obcift[i] > 10 && obcift[i] % 2 == 0)
            //        listBox1.Items.Add(obcift[i]);
            //}

            int[] sayiler = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
            foreach(int i in sayiler)
                listBox1.Items.Add(i);
        }
    }
}
