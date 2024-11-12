namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal Length;
            decimal Width;
            decimal mas;
            Length = decimal.Parse(text_Length.Text);
            Width = decimal.Parse(text_Width.Text);
            mas = Length * Width;
            label_mas.Text = mas.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal Length;
            decimal Width;
            decimal mas;
            Length = decimal.Parse(text_Length.Text);
            Width = decimal.Parse(text_Width.Text);
            mas = (Length + Width) * 2;
            label_mas.Text = mas.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal Length;
            decimal Width;
            decimal mas;
            decimal con;

            Length = decimal.Parse(text_Length.Text);
            Width = decimal.Parse(text_Width.Text);
            con = decimal.Parse(text_cost.Text);
            mas = con * 2 * (Width + Length);
            label_mas.Text = mas.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
