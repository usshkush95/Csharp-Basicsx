using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switches
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                switch (listBox1.SelectedItems[i].ToString())
                {
                    case "Liverpool":
                        MessageBox.Show("THE POOL GERUP!");
                        break;

                    case "ManU":
                        MessageBox.Show("Why pick these? pfft.");
                        break;

                    case "Chelsea":
                        MessageBox.Show("You have selected Chelsea");
                        break;

                    case "Arsenal":
                        MessageBox.Show("You have selected Arsenal");
                        break;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
