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
    public partial class Form1 : Form
    {
        private int h, c_h, f, c, fi, c_f, c_c, c_fi, ingredients, cost_ingredients, cost_cake;      

        private Cake cake = null;
        private string str;

        public Form1()
        {
            InitializeComponent();
            button1.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                h = Convert.ToInt32(textBox1.Text);
                c_h = Convert.ToInt32(textBox2.Text);
                f = Convert.ToInt32(textBox3.Text);
                c = Convert.ToInt32(textBox4.Text);
                fi = Convert.ToInt32(textBox5.Text);
                c_f = Convert.ToInt32(textBox6.Text);
                c_c = Convert.ToInt32(textBox7.Text);
                c_fi = Convert.ToInt32(textBox8.Text);
                cake = new Cake(h, c_h, f, c, fi, c_f, c_c, c_fi);
                ingredients = cake.Ingredients(); //вес ингредиентов
                cost_ingredients = cake.CostOfIngredients(); //стоимость ингредиентов
                cost_cake = cake.CostOfCake(); //стоимость торта
                str = cake.Infomation(ingredients, cost_ingredients, cost_cake);
                button1.Visible = true;
                button2.Visible = true;
                button4.Visible = true;
            }
            catch (FormatException)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
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

        private void button1_Click(object sender, EventArgs e)
        {
            WinFormInf inf = new WinFormInf(cake, str);
            inf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WinFormContinue con = new WinFormContinue(cake);
            con.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            button1.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
        }
    }
}
