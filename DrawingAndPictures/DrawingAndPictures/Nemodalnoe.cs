using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingAndPictures
{
    public partial class Nemodalnoe : Form
    {
        //событие немодального окна
        public event EventHandler ApplyHandler;
        //конструктор
        public Nemodalnoe()
        {
            InitializeComponent();
        }
        //строка для прорисовки
        public string TextToDraw { get { return textBox1.Text; } set { textBox1.Text = value; } }
        //обмен данными
        private void button1_Click(object sender, EventArgs e)
        {
            if (ApplyHandler != null)
                // Генерируем событие, обработчик для которого зарегистрирован в главном окне
                ApplyHandler(this, new EventArgs());
        }
    }
}
