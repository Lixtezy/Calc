using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class QuadraticForm : Form
    {
        public QuadraticForm()
        {
            InitializeComponent();
        }      
        private void textBoxs1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                double d = b * b - 4 * a * c;

                if (d < 0)
                {
                    textBox4.Text = "Корней нет.";
                }                               
                else
                {
                    double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                    double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                    textBox4.Text = "Дискриминант равен " + Math.Round(d, 2) + ". x1 = " + Math.Round(x1, 2) + "; x2 = " + Math.Round(x2, 2) + ".";
                }
            }
            catch
            {
                textBox4.Text = "Ошибка! Введите цифры.";
            }
        }
    }
}
