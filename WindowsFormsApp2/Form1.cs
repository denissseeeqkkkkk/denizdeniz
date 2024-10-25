using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hello world";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int size = int.Parse(textBox4.Text);
            int p = size + 4;
            label7.Text = p.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string day = textBox2.Text;
            string temperature = textBox3.Text;

            string result = $"On {day} the temperature is {temperature}";

            label6.Text = result;
        }
    }
}
