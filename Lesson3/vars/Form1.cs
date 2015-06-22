using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string hello;
            //hello = "hello world";
            //MessageBox.Show(hello);
            //MessageBox.Show("hello world");

            string firstTextBox = textBox1.Text;
            string secondTextBox = textBox2.Text;

            label3.Text = firstTextBox + " " + secondTextBox;

        }
    }
}
