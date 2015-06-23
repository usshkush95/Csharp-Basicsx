using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] myArray = new string[5];
            myArray[0] = "HEEEY";
            myArray[1] = "Hoooooo";
            myArray[2] = "Booom";
            myArray[3] = "Booooooom";
            myArray[4] = "pooow";

            MessageBox.Show(myArray[3]);

        }
    }
}
