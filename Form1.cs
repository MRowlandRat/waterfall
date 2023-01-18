using System;
using System.Drawing;
using System.Windows.Forms;



namespace waterfallPro
{
    public partial class Form1 : Form
    {

        string message;

        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Value = DateTime.Today;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            message = textBox1.Text;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime iDate;
            iDate = dateTimePicker1.Value;
            MessageBox.Show("Selected date is " + iDate + " " + message);
        }
    }
}