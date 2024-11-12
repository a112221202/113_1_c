using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program4_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double calory; //熱量(卡路里)
            double gram;   //克數(脂肪重量)
            double con;
            double vog;
            calory = double.Parse(textBox1.Text);
            gram = double.Parse(textBox2.Text);
            con = gram * 9 ;
            vog = (con / calory) * 100;
            label3.Text = con.ToString("\n");

            //以下作答，必須使用double.TryParse()方法
        }
    }
}
