using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Font = new Font(this.Font.FontFamily, 12);

            
            // Установка зеленого цвета для формы
            this.BackColor = Color.Chocolate;
            
            // Установка зеленого цвета для кнопок
            button1.BackColor = Color.LightBlue;
            button2.BackColor = Color.Green;
            button4.BackColor = Color.Yellow;
            button3.BackColor = Color.Red;

            // Установка  цвета для текстовых полей
            textBox1.BackColor = Color.Orange;
            textBox2.BackColor = Color.Orange;
            textBox3.BackColor = Color.Orange;

            // Установка  цвета для текста в текстовых полях
            textBox1.ForeColor = Color.DarkGreen;
            textBox2.ForeColor = Color.DarkGreen;
            textBox3.ForeColor = Color.DarkGreen;

            // Установка  цвета для поля данных и вывода результата
           // label3.BackColor = Color.Green;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            // Получение чисел из текстовых полей
            if (!double.TryParse(textBox1.Text, out double number1) || !double.TryParse(textBox2.Text, out double number2))
            {
                MessageBox.Show("Введите корректные числа.");
                return;
            }

            // Выполнение операции сложения
            double result = number1 + number2;

            // Отображение результата в поле вывода
            textBox3.Text = result.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Получение чисел из текстовых полей
            if (!double.TryParse(textBox1.Text, out double number1) || !double.TryParse(textBox2.Text, out double number2))
            {
                MessageBox.Show("Введите корректные числа.");
                return;
            }

            // Выполнение операции сложения
            double result = number1 - number2;

            // Отображение результата в поле вывода
            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Получение чисел из текстовых полей
            if (!double.TryParse(textBox1.Text, out double number1) || !double.TryParse(textBox2.Text, out double number2))
            {
                MessageBox.Show("Введите корректные числа.");
                return;
            }
            try
            {
                if (number2 == 0)
                {
                    throw new DivideByZeroException("Деление на ноль недопустимо");
                }
                // Выполнение операции деления
                double result = number1 / number2;

                // Отображение результата в поле вывода
                textBox3.Text = result.ToString();

            }
            catch (DivideByZeroException ex)
            {
                //Обработка исключени деления на ноль
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Получение чисел из текстовых полей
            if (!double.TryParse(textBox1.Text, out double number1) || !double.TryParse(textBox2.Text, out double number2))
            {
                MessageBox.Show("Введите корректные числа.");
                return;
            }

            // Выполнение операции сложения
            double result = number1 * number2;

            // Отображение результата в поле вывода
            textBox3.Text = result.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

