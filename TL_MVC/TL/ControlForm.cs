using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
//ВИД_3 (View_3)
{
    public partial class ControlForm : Form, IObserver
    {
        private ControlFormController controller;
        private TrafficLightModel model;
        private bool flag = false;

        private int timeElapsed;

        public ControlForm(TrafficLightModel model)
        {
            InitializeComponent();
            this.model = model;
            //  наблюдатели (view) регистрируют свою заинтересованность в модели
            this.model.Register(this);
            attachController(makeController());
        }
       
        private void drawLight(Brush a)
        {
            Bitmap bmp=new Bitmap(106,106);
            Graphics g = Graphics.FromImage(bmp);
            g.FillEllipse(a, new Rectangle(3, 3, 100, 100));
            pictureBox1.Image = bmp;
        }

        public void UpdateState
            ()
        {
            switch(model.State){
                case TrafficLightState.Red: drawLight(Brushes.Red); break;
                case TrafficLightState.Yellow: drawLight(Brushes.Yellow); break;
                case TrafficLightState.Green: drawLight(Brushes.Green); break;
                default: drawLight(Brushes.Yellow); break;
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
        public void attachController(ControlFormController controller) // контроллер
        {
            this.controller = controller;
        }
        protected ControlFormController makeController()
        {
            return new ControlFormController(this, model);
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
        
            timeElapsed += 1000;
            DateTime dt = DateTime.Now;
            tbt.Text = dt.Hour + ":" + dt.Minute + ":" + dt.Second;          //String.Format("{0}",timeElapsed/1000);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            double red = 0, yellow = 0, green = 0;
            try
            {
                red = double.Parse(tb1.Text)*1000;
                yellow = double.Parse(tb3.Text)*1000;
                green = double.Parse(tb2.Text)*1000;
            }
            catch { MessageBox.Show("Задайте корректные интервалы!"); }
            try
            {
                controller.SetIntervals(red, yellow, green);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
          /*  try
            {
                controller.specifyDuration((ushort)(ushort.Parse(textBox1.Text) * 1000), (ushort)(ushort.Parse(textBox2.Text) * 1000), (ushort)(ushort.Parse(textBox3.Text) * 1000));          
            }
            catch
            {
                MessageBox.Show("Error");
            }  */
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            flag = true;
            try
            {
                controller.SwithOn();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = false;

         controller.SwitchOff();
        }
        
    }
}