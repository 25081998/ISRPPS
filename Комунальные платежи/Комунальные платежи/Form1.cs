using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Коммунальные_платежи
{
    public partial class Form1 : Form
    {
        public Form1(double sum)
        {
            InitializeComponent();
            textBox1.Text = "" + sum;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) MessageBox.Show("Оплатите по адресу ул. Пушкина, д. Колотушкина");
            else MessageBox.Show("Оплачено");
            this.Close();
        }
    }
}
