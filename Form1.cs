namespace waterfallPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //temerature convertor
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 newMDI = new Form5();
            newMDI.Show();
        }

        //button game
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form4 newMDI = new Form4();
            newMDI.Show();
        }

        //date notetaker
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form3 newMDI = new Form3();
            newMDI.Show();
        }

        //word scrambler
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form2 newMDI = new Form2();
            newMDI.Show();
        }
    }
}