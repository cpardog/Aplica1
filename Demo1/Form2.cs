using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 1;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            for (int i = 1; i<100; i++)
			        {
            progressBar1.PerformStep();
			        }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //progressBar1.RightToLeftLayout=true;
            //progressBar1.Minimum = 1;
            //progressBar1.Maximum = 100;
            //progressBar1.Step = -1;
            //for (int i = 1; i < 100; i++)
            //{
            //    progressBar1.PerformStep();
            //}
           
           
        }
    }
}
