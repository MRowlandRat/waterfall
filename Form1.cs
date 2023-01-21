namespace waterfallPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load_1(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if((ch == 46 && textBox1.Text.IndexOf(".")!= -1 ) ||
               (ch == 45 && textBox1.Text.IndexOf("-")!= -1 )||
                (ch == 45 && textBox1.Text.IndexOf(".") != -1) ||
               (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 45))
               {
                e.Handled = true;
                return;
            } 

        }
    }
}