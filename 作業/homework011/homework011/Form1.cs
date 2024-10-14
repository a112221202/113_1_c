namespace homework011
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "Three of spades";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "four of diamonds";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "six of spades";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "diamonds one";
        }
    }
}
