namespace Q2
{
    public partial class Form1 : Form
    {
        const double BANANA = 115;
        const double APPLE = 80;
        const double ORANGE = 90;
        const double PEAR = 120;

        Boolean bananaClicked = false;
        Boolean appleClicked = false;
        Boolean orangeClicked = false;
        Boolean pearClicked = false;

        private double total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            total += BANANA;
            total_label.Text = total.ToString("c");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            total += APPLE;
            total_label.Text = total.ToString("c");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            total += ORANGE;
            total_label.Text = total.ToString("c");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            total += PEAR;
            total_label.Text = total.ToString("c");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            total_label.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            total += BANANA;
            total_label.Text = total.ToString("c");
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            total += APPLE;
            total_label.Text = total.ToString("c");
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            total += ORANGE;
            total_label.Text = total.ToString("c");
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            total += PEAR;
            total_label.Text = total.ToString("c");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            total_label.Text = "0";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

    
