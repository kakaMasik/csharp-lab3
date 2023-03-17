using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Початкове значення X
            textBox1.Text = "3,4";
            // Початкове значення Y
            textBox2.Text = "0,74";
            // Початкове значення Z
            textBox3.Text = "19,43";

        }
        double u,x,y,z;



        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox4.Clear();
            string v = (textBox5.Text);
            textBox4.Text += v;
            // Зчитування значення X
             x = double.Parse(textBox1.Text);
            // Виведення значення X у вікно
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            // Зчитування значення Y
             y = double.Parse(textBox2.Text);
            // Виведення значення Y у вікно
            textBox4.Text += Environment.NewLine + "Y=" + y.ToString();
            // Зчитування значення Z
             z = double.Parse(textBox3.Text);
            // Виведення значення Z у вікно
            textBox4.Text += Environment.NewLine + "Z=" + z.ToString();
            // Обчислюємо арифметичний вираз
            
            if (radioButton1.Checked)
                u = y * Math.Sin(x) * Math.Sin(x) + z;
            else if (radioButton2.Checked)
                u = y * Math.Exp(Math.Sin(x)) - z;
            else if (radioButton3.Checked)
                u = y * Math.Sin(Math.Sin(x)) + z;

            // Виведення результату
            textBox4.Text += Environment.NewLine;
            textBox4.Text += "U = " + u.ToString();
        
    }
    }
}

