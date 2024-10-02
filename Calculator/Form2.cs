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

namespace Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            

        }

        public void ChangeColor1(Color newColor)
        {
            
            this.BackColor = newColor;

        }

        public void ChangeColor2(Color newColor)
        {
            this.BackColor = newColor;

        }

        public void SetText(string text)
        {
            textBox1.Text = text; // Устанавливаем текст в TextBox
        }

        public void UpdateTextBox(string text) // Метод для обновления textBox
        {
            textBox1.Text = text;
        }
    }
}
