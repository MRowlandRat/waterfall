using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace waterfallPro
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void KeyBoardForm_Load(object sender, EventArgs e)
        {

        }

        private void fontDialog2_Apply(object sender, EventArgs e)
        {

        }


        private void label1_VisibleChanged(object sender, EventArgs e)
        {
            label1.Text = "Button Game!";
        }

        private void label2_VisibledChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.G)
            {
                MessageBox.Show("Enter key pressed");
            }
            if (e.KeyChar == 13)
            {
                MessageBox.Show("Enter key pressed");
            }
        }

        private void label2_VisibleChanged(object sender, EventArgs e)
        {
            label2.Text = "Press and hold the G key to play!";
        }

        

        private void label3_KeyPress(object sender, KeyEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (e.KeyCode == Keys.G)
            {
                int counter = 0;

                while (counter <= 0)
                {
                    label3.Text = counter;
                    counter++;
                }

                Console.WriteLine();
            }
        }
        }
    }



        


        
        
        
    

