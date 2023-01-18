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

            string scramble = word_box.Text.ToUpper();

            switch (checkedListBox1.Text)
            {
                case "Uppercase":
                    word_box.Text = checkedListBox1.Text;
                    break;

                case "Lowercase":
                    
                    break;
                
                case "Reverse":
                    
                    break;
                
                case "Camelcase":
                    
                    break;
            }
        }
    }
}
