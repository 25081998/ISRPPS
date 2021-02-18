using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace App_1
{
    public class Cake
    {
        private int hours, // кол-во часов на изготовление
                    cost_hour, //стоимость часа работы
                               //ingredients, //кол-во ингредиентов в кг
                               //cost_ingredients, //стоимость ингредиентов
                    flour, //мука
                    cream, //крем
                    filling, //начинка
                    cost_flour, //стоимость муки
                    cost_cream, //стоимость крема
                    cost_filling; //стоимость начинки
        public Cake(int h, int c_h, int f, int c, int fi, int c_f, int c_c, int c_fi) //конструктор
        {
            hours = h;
            cost_hour = c_h;
            flour = f;
            cream = c;
            filling = fi;
            cost_flour = c_f;
            cost_cream = c_c;
            cost_filling = c_fi;
        }
        public int Ingredients() //вес ингредиентов в кг
        {
            return flour + cream + filling;
        }
        public int CostOfIngredients() //стоимость ингредиентов
        {
            return flour * cost_flour + cream * cost_cream + filling * cost_filling;
        }
        public int CostOfCake() //Стоимость торта
        {
            int s;
            s = CostOfIngredients();
            return hours * cost_hour + s;
        }
        public void Time(int h, Form form) //Успеют ли приготовить торт
        {
            if (h >= hours) MessageBox.Show("Достаточно времени на изготовление торта");
            else
            {
                DialogResult result = MessageBox.Show("Не достаточно времени на изготовление торта.\n Повторить ввод данных?", "Продолжить", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                switch (result)
                {
                    case DialogResult.Yes:
                        break;
                    case DialogResult.No:
                        form.Close();
                        break;
                }
            }
        }
        public string Infomation(int ingredients, int cost_ingredients, int cost_cake) //информация о торте
        {
            return "Время на изготовление: " + hours + "\nСтоимость часа работы: " + cost_hour + "\nКол-во ингредиентов: " + ingredients + "\nСтоимость ингредиентов: " + cost_ingredients + "\nСтоимость торта: " + cost_cake;
        }
    }
}
