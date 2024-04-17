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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PicturesControl.Pictures = new Picture();
        }

        private void BttnAddEquil_Click(object sender, EventArgs e)
        {
            Form addEq = new AddEquil();
            addEq.Show();
        }

        private void BttnAddRight_Click(object sender, EventArgs e)
        {
            Form addRight = new AddRight();
            addRight.Show();
        }

        private void BttnAddIsos_Click(object sender, EventArgs e)
        {
            Form addIsos = new AddIsos();
            addIsos.Show();
        }

        private void BttnAboutTr_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string triangleCharacteristics = PicturesControl.Pictures.PrintTriangleCharacteristics();

            // Разделяем строку на подстроки по символу новой строки
            string[] characteristicsArray = triangleCharacteristics.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            // Добавляем каждую подстроку в ListBox как отдельный элемент
            foreach (string characteristic in characteristicsArray)
            {
                listBox1.Items.Add(characteristic);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            listBox1.Items.Add($"Общая площадь: {PicturesControl.Pictures.CalculateTotalArea()}");
        }
    }
}
