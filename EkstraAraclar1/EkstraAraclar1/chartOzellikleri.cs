using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkstraAraclar1
{
    public partial class chartOzellikleri : Form
    {
        public chartOzellikleri()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void chartOzellikleri_Load(object sender, EventArgs e)
        {
            chart1.Series["Kitab"].Points.AddXY("Akdeniz", 5);
            chart1.Series["Kitab"].Points.AddXY("Ege", 3);
        }
    }
}
