
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{   // ВИД_4 (View_4)
    //  Вид — это тот слой триады MVC, который отображает графическое или текстовое представление
    //  модели. Вид получает всю информацию о состоянии модели от самой модели.
    //  Единственной связью между моделью и пользовательским интерфейсом является связь
    //  через службу уведомления об изменении состояния системы.
    //  Если вид или контроллер заинтересованы в уведомлении об изменении состояния системы, 
    //  они регистрируются в модели через службу регистрации.
    //  Для формирования составного вида используется паттерн компоновщик  

    public partial class Form1 : Form, IObserver
    {

        //              MVC
        delegate void Change(RadioButton rb1, RadioButton rb2, RadioButton rb3);
        private Form1Controller controller;
        private TrafficLightModel model;
        private bool flag;
        private uint timeElapsed;

        public Form1(TrafficLightModel model)
        {
            InitializeComponent();
            this.model = model;
            flag = false;
            //  наблюдатели (view) регистрируют свою заинтересованность в модели
            this.model.Register(this);
            AttachController(MakeController());
        }
        //    Обновление вида
        //    Все наблюдатели (view), которые хотят зарегистрироваться у наблюдаемого объекта,
        //    должны реализовать интерфейс Observer

        

        public void UpdateState()
        {
            if (model.SwitchedOn)
            {

                //  Получение информации от о состоянии модели от самой модели
                switch (model.State)
                {
                    case TrafficLightState.Red:
                        if (radioButton1.InvokeRequired)
                        {
                            Change ch = ChangeRadioButton;
                            this.Invoke(ch, radioButton1, radioButton2, radioButton3);
                        }
                        else ChangeRadioButton(radioButton1, radioButton2, radioButton3);
                        break;
                    case TrafficLightState.Yellow:
                        if (radioButton2.InvokeRequired)
                        {
                            Change ch = ChangeRadioButton;
                            this.Invoke(ch, radioButton2, radioButton1, radioButton3);
                        }
                        else ChangeRadioButton(radioButton2, radioButton1, radioButton3);
                        break;
                    case TrafficLightState.Green:
                        if (radioButton3.InvokeRequired)
                        {
                            Change ch = ChangeRadioButton;
                            this.Invoke(ch, radioButton3, radioButton2, radioButton1);
                        }
                        else ChangeRadioButton(radioButton3, radioButton2, radioButton1);
                        break;
                }
                if (flag)
                {
                    timeElapsed = 0;
                    timer1.Start();
                    toolStripStatusLabel2.Text = "Работает";

                    timer1.Interval = 1000;

                }
                else
                {
                    timeElapsed = 0;
                    timer1.Stop();

                    toolStripStatusLabel2.Text = "Выключен";
                }
            }
        }

        //          Подключение контроллера к виду

        //  Этот метод связывает данный контроллер с видом

        public void AttachController(Form1Controller controller)
        {
            this.controller = controller;
        }

        protected Form1Controller MakeController()
        {
            //          Передача контроллеру ссылок на вид и модель

            return new Form1Controller(this, model);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double red = 0, yellow = 0, green = 0;
            try
            {
                red = double.Parse(numericUpDown1.Text)*1000;
                yellow = double.Parse(numericUpDown2.Text) *1000;
                green = double.Parse(numericUpDown3.Text) *1000;
            }
            catch { MessageBox.Show("Задайте корректные интервалы!"); }
            try
            {
                controller.SetIntervals(red, yellow, green);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = true;
            try
            {
                controller.SwithOn();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flag = false;
            textBox1.Text = "";
            controller.SwitchOff();
        }

        static void ChangeRadioButton(RadioButton rb1, RadioButton rb2, RadioButton rb3)
        {
            rb2.Checked = false;
            rb3.Checked = false;
            rb1.Checked = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed += 1000;
            DateTime dt = DateTime.Now;
            textBox1.Text = dt.Hour + ":" + dt.Minute + ":" + dt.Second;
        }
    }
}

