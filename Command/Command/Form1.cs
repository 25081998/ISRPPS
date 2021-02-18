using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command
{
    //вызывающий
    public partial class Form1 : Form
    {
        private List<Command> commands = new List<Command>();
        private Complex result;
        private int current = 0;
        //конструктор
        public Form1()
        {
            InitializeComponent();
        }
        //справка
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Комплексное число — это выражение вида a + bi, где a, b — действительные числа, а i — так называемая мнимая единица, символ, квадрат которого равен –1, то есть i^2 = –1.\n\n" +
                            "Арифметические действия над комплексными числами те же, что и над действительными: их можно складывать, вычитать, умножать и делить друг на друга.\n\n" +
                            "Для использования калькулятора введите все данные (действительные и мнимые части интересующих чисел, не забывайте про знаки). Если какая-либо часть комплексного числа равна нулю, то введите 0. Не забывайте про существование коэффициента 1!!!\n\n" +
                            "Разработчик: Бабичева Анна М8О-202Б-17 2018г.");
        }
        //печать результата
        public void Print() { textBoxRes.Text = result.Print(); }
        //функция повторить
        public void Redo(int levels)
        {
            for (int i = 0; i < levels; i++)
                if (current < commands.Count)
                {
                    result = commands[current++].Execute();
                    Print();
                }
        }
        //функция отменить
        public void Undo(int levels)
        {
            for (int i = 0; i < levels; i++)
                if (current > 0)
                {
                    result = commands[--current].UnExecute();
                    Print();
                }
        }
        //функция подсчета
        public void Compute(Command command)
        {
            result = command.Execute();
            commands.Add(command);
            current++;
            Print();
        }

        private void сложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Command command = new SumCommand(new Complex(Convert.ToDouble(textBoxA1.Text), Convert.ToDouble(textBoxB1.Text)), 
                                             new Complex(Convert.ToDouble(textBoxA2.Text), Convert.ToDouble(textBoxB2.Text)));
            Compute(command);
        }

        private void вычитаниеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Command command = new SubtractionCommand(new Complex(Convert.ToDouble(textBoxA1.Text), Convert.ToDouble(textBoxB1.Text)),
                                             new Complex(Convert.ToDouble(textBoxA2.Text), Convert.ToDouble(textBoxB2.Text)));
            Compute(command);
        }

        private void умножениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Command command = new MultiplicationCommand(new Complex(Convert.ToDouble(textBoxA1.Text), Convert.ToDouble(textBoxB1.Text)),
                                             new Complex(Convert.ToDouble(textBoxA2.Text), Convert.ToDouble(textBoxB2.Text)));
            Compute(command);
        }

        private void делениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Command command = new SegmentationCommand(new Complex(Convert.ToDouble(textBoxA1.Text), Convert.ToDouble(textBoxB1.Text)),
                                             new Complex(Convert.ToDouble(textBoxA2.Text), Convert.ToDouble(textBoxB2.Text)));
            Compute(command);
        }

        private void Назад_Click(object sender, EventArgs e)
        {
            Undo(1);
        }

        private void Повторить_Click(object sender, EventArgs e)
        {
            Redo(1);
        }
    }
}
