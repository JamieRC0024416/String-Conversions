using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int i = 3;
            richTextBox1.AppendText(i.ToString() + "\n");
            richTextBox1.AppendText("" + i);
            double pi = 3.14159265;
            richTextBox1.AppendText(pi.ToString());
            richTextBox1.AppendText(3.ToString());
            double d1 = 5e6;
            richTextBox1.AppendText(d1.ToString() +  "\n");
            richTextBox1.AppendText(d1.ToString("N") + "\n");
            richTextBox1.AppendText(d1.ToString("N3") + "\n");
            richTextBox1.AppendText(d1.ToString("N0") + "\n");
            richTextBox1.AppendText(d1.ToString("0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.0E0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.00E00") + "\n");

            richTextBox1.AppendText("\nTask 1\n======\n");
            pi = 3.141592653589793;
            double c = 299792458;
            //3DP
            richTextBox1.AppendText(pi.ToString() + "\n");
            //5DP
            richTextBox1.AppendText(pi.ToString() + "\n");
            //15DP
            richTextBox1.AppendText(pi.ToString() + "\n");
            //0DP
            richTextBox1.AppendText(c.ToString() + "\n");
            //commas as separators
            richTextBox1.AppendText(c.ToString() + "\n");
            //16SF in standard form
            richTextBox1.AppendText(c.ToString() + "\n");
            //3SF in standard form
            richTextBox1.AppendText(c.ToString() + "\n");

        }
    }
}
