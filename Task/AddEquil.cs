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
    public partial class AddEquil : Form
    {
        public AddEquil()
        {
            InitializeComponent();
        }

        private void BttnAddSide_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double value) && value > 0)
            {
                if (PicturesControl.Pictures != null)
                {
                    PicturesControl.Pictures.AddTriangle(new EquilateralTriangle(value));
                    MessageBox.Show($"Равносторонний треугольник был создан с стороной {value}", "Результат");
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
                MessageBox.Show($"Неверно введено число. Повторите попытку.\nТекущий результат: {textBox1.Text}\nВвод вещественного числа осуществляется с помощью \",\"", "Ошибка");
            }
        }
    }
}
