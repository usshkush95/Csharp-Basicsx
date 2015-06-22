using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string hello;
            //hello = "hello world";
            //MessageBox.Show(hello);
            //MessageBox.Show("hello world");
            int firstTextBox = 0;
            int secondTextBox = 0;
            int result = 0;
            
            firstTextBox = int.Parse(textBox1.Text);
            secondTextBox = int.Parse(textBox2.Text); 
            
            result = firstTextBox + secondTextBox; 
            label3.Text = result.ToString();

        }
    }
}
