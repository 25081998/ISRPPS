using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_1
{
    public partial class WinFormContinue : Form
    {
        private int h;
        private Cake cake = null;

        public WinFormContinue()
        {
            InitializeComponent();
        }

        public WinFormContinue(Cake cake)
        {
            InitializeComponent();
            this.cake = cake;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                h = Convert.ToInt32(textBox1.Text);
                cake.Time(h, this);
            }
            catch (FormatException)
            {
                if (textBox1.Text == "")
                    MessageBox.Show("Введите данные");
                else
                {
                    DialogResult result = MessageBox.Show("Ошибка ввода.\n" + "Неверный формат данных.\n" + "Повторить?",
                                "Ошибка", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            break;
                        case DialogResult.No:
                            this.Close();
                            break;
                    }
                }
            }
        }
    }
}
