﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iteration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //if (comboBox1.Text == "SteJ") 
          //{
          //    MessageBox.Show("You picked SteJ");
          //    comboBox1.Text = ""; // clears comboBox if selected
          //} 
          //  // 2. 'if' statement curly braces removed, one line of code to be executed
          //  if (comboBox1.Text == "Steph") 
          //      MessageBox.Show("You picked Steph"); // one line of code after ‘if’
            
            
            
            if (comboBox1.Text != "Ste") // if not equal to Ste false go to else  
           { 
               if (comboBox1.Text == "SteJ")
               {
                   MessageBox.Show("You picked SteJ."); // SteJ is selected
               } 
               else
               { 
                   MessageBox.Show("I'm not sure who you picked."); // Stevo or Steph selected
               }
               
           } else { MessageBox.Show("You picked Ste"); } // end else
        }
    }
}
