﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorWindows
{
    public partial class Form1 : Form
    {
        int firstNumber = 0;
        int secondNumber = 0;
        int result = 0;
        string equasionOperator;
        bool secondOperation = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (secondOperation)
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "1";
            } else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (secondOperation)
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (secondOperation)
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (secondOperation)
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (secondOperation)
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (secondOperation)
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (secondOperation)
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (secondOperation)
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (secondOperation)
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (secondOperation)
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (firstNumber == 0)
            {
                secondOperation = false;
                equasionOperator = button4.Text;
                int.TryParse(textBox1.Text, out firstNumber);
                textBox1.Clear();
            } else
            {
                secondOperation = true;
                Calculate();
                equasionOperator = button4.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (firstNumber == 0)
            {
                secondOperation = false;
                equasionOperator = button8.Text;
                int.TryParse(textBox1.Text, out firstNumber);
                textBox1.Clear();
            }
            else
            {
                secondOperation = true;
                Calculate();
                equasionOperator = button8.Text;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (firstNumber == 0)
            {
                secondOperation = false;
                equasionOperator = button12.Text;
                int.TryParse(textBox1.Text, out firstNumber);
                textBox1.Clear();
            }
            else
            {
                secondOperation = true;
                Calculate();
                equasionOperator = button12.Text;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (firstNumber == 0)
            {
                secondOperation = false;
                equasionOperator = button14.Text;
                int.TryParse(textBox1.Text, out firstNumber);
                textBox1.Clear();
            }
            else
            {
                secondOperation = true;
                Calculate();
                equasionOperator = button14.Text;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            firstNumber = 0;
            secondNumber = 0;
            secondOperation = false;
        }

        private void Calculate()
        {
            int.TryParse(textBox1.Text, out secondNumber);

            switch (equasionOperator)
            {
                case "+":
                    textBox1.Text = (firstNumber + secondNumber).ToString();
                    firstNumber = firstNumber + secondNumber;
                    break;
                case "-":
                    textBox1.Text = (firstNumber - secondNumber).ToString();
                    firstNumber = firstNumber - secondNumber;
                    break;
                case "*":
                    textBox1.Text = (firstNumber * secondNumber).ToString();
                    firstNumber = firstNumber * secondNumber;
                    break;
                case "/":
                    textBox1.Text = (firstNumber / secondNumber).ToString();
                    firstNumber = firstNumber / secondNumber;
                    break;
            }
        }
    }
}
