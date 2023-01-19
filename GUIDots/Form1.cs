/*
 * GUI Dots
 * 1/18/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program and see what it does. Be prepared to discuss
 * the following questions...
 * 1. How was a loop used in this program?
 * 2. What is the point of the variable dots?
 * 3. This program uses a common technique called building a 
 *    string. What do you think that means?
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIDots
{
    public partial class GUIDotsForm : Form
    {
        public GUIDotsForm()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            int numberDots;
            string dots = "";
            numberDots = Convert.ToInt32(numberDotsTextBox.Text);
            for(int i = 0; i < numberDots; i++)
            {
                dots += "*";
            }
            dotsLabel.Text = dots;
        }
    }
}
