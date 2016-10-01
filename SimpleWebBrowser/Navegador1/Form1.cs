using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador1
{
    public partial class FalloutDrox : Form
    {
        public FalloutDrox()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.br");
        }
    }
}
