namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDate.Text = "";
            txtMounth.Text = "";
            txtWeeek.Text = "";
            txtYear.Text = "";
        }

        private void btnShowDate_Click(object sender, EventArgs e)
        {
            string output;

            output = "民國" + txtYear.Text + "年" + txtMounth.Text + "月" + txtDate.Text + "日" + "星期" + txtWeeek.Text;
            lblShow.Text = output;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
