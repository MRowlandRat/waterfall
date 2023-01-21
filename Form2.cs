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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string scramble = word_box.Text;

            string input = checkedListBox1.Text;

            switch (input)
            {
                
                case "Uppercase":
                    word_box.Text = scramble.ToUpper();
                    break;

                case "Lowercase":
                    word_box.Text = scramble.ToLower();
                    break;

                case "Reverse":
                    char[] scrambleArray = scramble.ToCharArray();
                    Array.Reverse(scrambleArray);
                    word_box.Text = new string(scrambleArray); 
                    break;

                case "Duplicate":

                    scramble = scramble + scramble;

                    word_box.Text = scramble;
                    break;
            }
        }
    }
}
