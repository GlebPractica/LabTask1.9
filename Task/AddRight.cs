using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class AddRight : Form
    {
        public AddRight()
        {
            InitializeComponent();
        }

        private void BttnAddSide1Side2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double side1) && side1 > 0)
            {
                if (double.TryParse(textBox2.Text, out double side2) && side2 > 0)
                {
                    if (PicturesControl.Pictures != null)
                    {
                        PicturesControl.Pictures.AddTriangle(new RightTriangle(side1, side2));
                        MessageBox.Show($"Добавлен прямоугольный треугольник со сторонами {side1}, {side2}");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Не удалось добавить треугольник.");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show($"Неверно введена 2 сторона. Повторите попытку.\nТекущий результат: {textBox2.Text}\nВвод вещественного числа осуществляется с помощью \",\"", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show($"Неверно введена 1 сторона. Повторите попытку.\nТекущий результат: {textBox1.Text}\nВвод вещественного числа осуществляется с помощью \",\"", "Ошибка");
            }
        }
    }
}
