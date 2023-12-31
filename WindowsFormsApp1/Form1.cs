﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        Double result = 0;
        string operation = "";
        bool isOperationPerformed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void c_Click(object sender, EventArgs e)
        {
            label_result.Text = "0";
            label.Text = "0";
            result = 0;
        }


        private void res_click(object sender, EventArgs e)
        {
            label_result.Text = "999 updated";

        }

        private void operation_click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (result != 0)
            {
                buttonEqual.PerformClick();
                operation = button.Text;
                result = double.Parse(label_result.Text);
                label.Text = result + operation;
                isOperationPerformed = true;
            }else
            {
                operation = button.Text;
                result = double.Parse(label_result.Text);
                label.Text = result + operation;
                isOperationPerformed = true;
            }            
        }

        private void equal_click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    label_result.Text = (result + Double.Parse(label_result.Text)).ToString();
                    break;
                case "-":
                    label_result.Text = (result - Double.Parse(label_result.Text)).ToString();
                    break;
                case "x":
                    label_result.Text = (result * Double.Parse(label_result.Text)).ToString();
                    break;
                case "/":
                    label_result.Text = (result / Double.Parse(label_result.Text)).ToString();
                    break;
                default:
                    break;

            }
            result = double.Parse(label_result.Text);
            label.Text = "";
        }

        private void button_click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            
            if (label_result.Text == "0" || (isOperationPerformed))
            {
                label_result.Clear();
            }
            isOperationPerformed = false;

            if (button.Text == ".")
            {
                if (!label_result.Text.Contains("."))
                {
                    label_result.Text += button.Text;
                }
            }else
            {
                label_result.Text += button.Text; 
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
            
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_result_TextChanged(object sender, EventArgs e)
        {

        }


        //    private void Button1_Click_1(object sender, EventArgs e)
        //    {
        //        if (double.TryParse(textBox1.Text, out double number1) && double.TryParse(textBox2.Text, out double number2))
        //        {
        //            // Perform the addition.
        //            double result = number1 + number2;

        //            // Display the result in the label.
        //            label1.Text = "Result: " + result.ToString();
        //        }
        //        else
        //        {
        //            // Handle invalid input.
        //            label1.Text = "Invalid input. Please enter valid numbers.";
        //        }
        //    }
    }
}
