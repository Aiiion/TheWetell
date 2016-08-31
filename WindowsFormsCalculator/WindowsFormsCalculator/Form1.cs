﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculator
{
    public partial class Form1 : Form
    {
        string ope = "";

        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();
            ButtonAdd.Text = "+";
            ButtonMinus.Text = "-";
            ButtonTimes.Text = "x";
            ButtonSplit.Text = "/";
            ButtonCalc.Text = "Calculate";
            listBox1.Text = "";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            ope = "+";
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            ope = "-";
        }

        private void ButtonTimes_Click(object sender, EventArgs e)
        {   
            ope = "x";
        }

        private void ButtonSplit_Click(object sender, EventArgs e)
        {   
            ope = "/";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(textBox1.Text);
            int number2 = int.Parse(textBox2.Text);
            int answer;

            switch (ope)
            {
                case "+":
                    answer = number1 + number2;
                    listBox1.Items.Add(answer);
                    break;
                case "-":
                    answer = number1 - number2;
                    listBox1.Items.Add(answer);
                    break;

                case "x":
                    answer = number1 * number2;
                    listBox1.Items.Add(answer);
                    break;
                case "/":
                    answer = number1 / number2;
                    listBox1.Items.Add(answer);
                    break;

                default:
                    break;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
