using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = textBox1;
            textBox1.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text.Substring(0, 5).ToUpper();
            string navigare = "https://spo.aptiv.com/sites/0404-103/Spec/ASpecs/" + textBox1.Text + "A.pdf";
            webBrowser1.Navigate(navigare);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
             button1_Click(sender,e);
            }
        }

     
    }
}
