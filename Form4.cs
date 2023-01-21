using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
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

        int num;
        int add;
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





        /* private void Form4_KeyDown(object sender, KeyEventArgs e)
         {
             if (e.KeyCode == Keys.G)
             {
                 e.Handled = true;
                 MessageBox.Show("It works");
             }
             *//*if (e.Handled == Keys.G)
             {
                 //int counter = 0;
                 //label3.Text = counter.ToString;
                 *//* for (int counter = 0; counter < 0; counter++)
                  {
                      Console.WriteLine(label3.Text);
                  }*/
        /*while (counter <= 0)
        {
            label3.Text = counter.ToString();
            counter++;
        }*/

        /*if (counter == 0)
        {
            MessageBox.Show("Press button");
        }
        else
        {
            MessageBox.Show("Keep going!");
        }

        Console.WriteLine(label3.Text);*//*
        //label3.Text = "works!";*//*

    }*/

        private void label3_Keydown(object sender, KeyEventArgs e)
        {
            label3.Text = "kill";
        }

        private void label3_Click(object sender, EventArgs e)
        {

            bool less = false;

            do
            {
                label3.Text = num.ToString();

                if (num < 60)
                {
                    num++;

                    break;
                }
                else { less = true; }

            } while (!less);


        }
    }
}



        


        
        
        
    

