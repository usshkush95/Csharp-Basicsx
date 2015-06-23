using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forloop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] myArray = { "Hey", "Hoooo", "boom", "boommm", "pow" };
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    MessageBox.Show(i.ToString());
            //}
            if (myArray[0] == "Hey")
            {
                MessageBox.Show("Found Hey!");
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //    int i = 0;
            //    while (i < int.Parse(textBox1.Text))
            //    {
            //        i++;
            //    }
            //    MessageBox.Show("The final value was:" = i.ToString());
            //}
        }
    }
}

