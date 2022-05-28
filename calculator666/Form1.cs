using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator666
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point LastPoint2;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint2 = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint2.X;
                this.Top += e.Y - LastPoint2.Y;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
        double a = 0, b = 0, c = 0;
        char znac = '+';

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                if (textBox1.Text[0] == '-')
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                else textBox1.Text = '-' + textBox1.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double dn=0, res=0;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dn);
            textBox1.Text = res.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double dn = 0, res = 0;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(dn,2);
            textBox1.Text = res.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double dn = 0, res = 0;
            dn = Convert.ToDouble(textBox1.Text);
            res = 1 / dn;
            textBox1.Text = res.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text += ",";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double dn = 0, res = 0;
            dn = Convert.ToDouble(textBox1.Text);
            res =  dn / 100*dn;
            textBox1.Text = res.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            switch (znac)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case 'x':c = a * b;
                    break;
                case '/':c = a / b;
                    break;
            }
            textBox1.Text = c.ToString();

        }
     
        private void button11_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            znac = (sender as Button).Text[0];
            textBox1.Clear();
        }
    }
}
