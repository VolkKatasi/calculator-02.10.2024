using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(); // форм 2 
        }

        public void ChangeColor1(Color newColor)
        {
            this.BackColor = newColor;
        }
        public void ChangeColor2(Color newColor)
        {
            this.BackColor = newColor;
        }

        public double i;
        public double num1, num2, num3;
        public double memory = 0;
        
        private double Factorial(double n)
        {
            
            int res = 1;
            for (int j = 1; j <= n; j++)
            {
                res *= j;
            }
            return res;
        }

        //  нажатие цифр //
        private void zero_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "0";
                form2.SetText(textBox.Text); // Передаем значение в Form2
            }
            else
            {
                textBox.Text += "0";
                form2.SetText(textBox.Text); // Передаем значение в Form2
            }
            form2.Show(); 
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "1";
                form2.SetText(textBox.Text); // Передаем значение в Form2
            }
            else
            {
                textBox.Text += "1";
                form2.SetText(textBox.Text); // Передаем значение в Form2
            }
            form2.Show(); 
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "2";
                form2.SetText(textBox.Text); // Передаем значение в Form2
            }
            else
            {
                textBox.Text += "2";
                form2.SetText(textBox.Text); // Передаем значение в Form2
            }
            form2.Show(); 
        }
        private void three_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "3";
                form2.SetText(textBox.Text); // Передаем значение в Form2
            }
            else
            {
                textBox.Text += "3";
                form2.SetText(textBox.Text); // Передаем значение в Form2
            }
            form2.Show(); 
        }
        private void four_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "4";
                form2.SetText(textBox.Text); // Передаем значение в Form2
            }
            else
            {
                textBox.Text += "4";
                form2.SetText(textBox.Text); // Передаем значение в Form2
            }
            form2.Show(); 
        }
        
        private void five_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "5";
                form2.SetText(textBox.Text); // Передаем значение в Form2
            }
            else
            {
                textBox.Text += "5";
                form2.SetText(textBox.Text); // Передаем значение в Form2
            }
            form2.Show(); 
        }
        private void six_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "6";
                form2.SetText(textBox.Text); // Передаем значение в Form2
            }
            else
            {
                textBox.Text += "6";
                form2.SetText(textBox.Text); // Передаем значение в Form2
            }
            form2.Show(); 
        }
        private void seven_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "7";
                form2.SetText(textBox.Text); // Передаем значение в Form2
            }
            else
            {
                textBox.Text += "7";
                form2.SetText(textBox.Text); // Передаем значение в Form2
            }
            form2.Show(); 
        }
        private void eight_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "8";
                form2.SetText(textBox.Text); // Передаем значение в Form2
            }
            else
            {
                textBox.Text += "8";
                form2.SetText(textBox.Text); // Передаем значение в Form2
            }
            form2.Show(); 
        }
        private void nine_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "9";
                form2.SetText(textBox.Text); // Передаем значение в Form2
            }
            else
            {
                textBox.Text += "9";
                form2.SetText(textBox.Text); // Передаем значение в Form2
            }
            form2.Show(); 
        }
        private void point_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, что текст не пустой и последний символ не является запятой
                if (textBox.Text != "" && !textBox.Text.EndsWith(","))
                {

                    if (!char.IsDigit(textBox.Text[textBox.Text.Length - 1]))
                    {

                    }
                    if (textBox.Text == "0")
                        textBox.Text = "0,";
                    else
                        textBox.Text += ",";
                }
                form2.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("Не выбрано число. Пожалуйста, введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        // Арифметические операции //
        
        private void defect_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, что текст не пустой и последний символ не является запятой
                if (textBox.Text == "0" || textBox.Text == "")
                    textBox.Text = "0";
                else
                {
                    i = 4;
                    num1 = Convert.ToDouble(textBox.Text);
                    textBox.Text = "";
                    textBox.Focus();

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Не выбрано число. Пожалуйста, введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Others //
        private void delete_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            form2.SetText(textBox.Text);
        }
        private void rovno_Click(object sender, EventArgs e)
        {
            if (i == 4)
            {
                num2 = Double.Parse(textBox.Text);
                num3 = num1 - num2;
                textBox.Text = num3.ToString();
                form2.SetText(textBox.Text);
            }
            if (i == 5)
            {
                num2 = Double.Parse(textBox.Text);
                num3 = Math.Pow(num1,num2);
                form2.SetText(textBox.Text);
                textBox.Text = num3.ToString();
            }
            if (i == 6)
            {
                num2 = Double.Parse(textBox.Text);
                num3 = Math.Pow(num1, (double)1 / num2);
                textBox.Text = num3.ToString();
                form2.SetText(textBox.Text);
            }
        }
    }
}
