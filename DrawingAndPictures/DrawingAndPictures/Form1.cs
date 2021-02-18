using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingAndPictures
{
    public partial class Form1 : Form
    {
        private Image image;                            //фото
        private string s;                               //строка для прорисовки
        private Point p1, p2;                           //точки для прорисовки линии
        private int a, x, y, w, h;                      //всевозможные параметры        
        private bool doDraw, doLine, doEllipse, doText; //показатели, что прорисовка началась
        //углы поворота
        private int ang1 = -90;                         
        private int ang2 = 90;

        //конструктор
        public Form1()
        {
            InitializeComponent();
            doDraw = false;
            doLine = false;
            doEllipse = false;
            doText = false;
            pictureBox1.BackColor = Color.White;
            a = 1;
        }
        //работа с немодальным окном
        private void Nemodalnoe_Apply(object sender, System.EventArgs e)
        {
            Nemodalnoe dialog = (Nemodalnoe)sender;
            // Отображение адресов почтовых серверов, 
            // введенных в дочернее немодальное окно, в главном окне
            this.textBox1.Text = dialog.TextToDraw;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Создание немодального окна и родительских отношений
            // между главным окном и дочерним немодальным окном
            Nemodalnoe dialog = new Nemodalnoe();
            dialog.Owner = this;
            // Копирование текста из полей ввода главного окна 
            // в свойства немодального диалогового окна 
            dialog.TextToDraw = this.textBox1.Text;
            // Добавление обработчика события, 
            // создаваемого дочерним немодальным окном, в список события
            dialog.ApplyHandler += new EventHandler(Nemodalnoe_Apply);
            // отображение немодального окна
            dialog.Show();
        }
        //мышь опущена
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (a)
            {
                //прорисовка кривых
                case 1:
                    doDraw = true;
                    break;
                //прорисовка линий
                case 2:
                    doLine = true;
                    p1 = new Point(e.X, e.Y);
                    break;
                //прорисовка эллипсов
                case 3:
                    doEllipse = true;
                    x = e.X;
                    y = e.Y;
                    break;
                //прорисовка текста
                case 4:
                    doText = true;
                    x = e.X;
                    y = e.Y;
                    break;
            }
        }
        //рисовать
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (doDraw) Drawing.Instance.Draw(pictureBox1, e.X, e.Y);
        }
        //мышь поднята
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //прорисовка линий
            if (doLine)
            {
                p2 = new Point(e.X, e.Y);
                Drawing.Instance.DrawLine(pictureBox1, p1, p2);
            }
            //прорисовка эллипсов
            if (doEllipse)
            {
                w = Math.Abs(e.X - x);
                h = Math.Abs(y - e.Y);
                x = Math.Min(e.X, x);
                y = Math.Min(e.Y, y);
                Drawing.Instance.DrawEllipse(pictureBox1, x, y, w, h);
            }
            //прорисовка текста
            if (doText)
            {
                s = textBox1.Text;
                x = Math.Min(e.X, x);
                y = Math.Min(e.Y, y);
                Drawing.Instance.DrawText(pictureBox1, s, x, y);
            }
            //прорисовка закончена
            doDraw = false;
            doLine = false;
            doEllipse = false;
            doText = false;
        }
        //открыть фотографию
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)// ответ в диалоговом окне "Ок" 
            {
                try
                {
                    this.pictureBox1.Load(this.openFileDialog1.FileName);
                }
                catch (InvalidOperationException exc)
                {
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//вывод ошибки 

                }
                catch (System.IO.FileNotFoundException exc)
                {
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//вывод ошибки
                }
                catch (ArgumentException exc)
                {
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//вывод ошибки
                }
            }
        }
        //закрыть фото
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Dispose();
        }
        //сменить цвет кисти
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            switch (Drawing.Instance.Brush.GetType().Name)
            {
                case "SolidBrush":
                    Drawing.Instance.Brush = Brushes.Red;
                    break;
                case "HatchBrush":
                    Drawing.Instance.Brush = new HatchBrush(HatchStyle.OutlinedDiamond,
                            Color.Aquamarine, Color.Red);
                    break;
                case "LinearGradientBrush":
                    Drawing.Instance.Brush = new LinearGradientBrush(new Rectangle(0, 0, 200, 200),
                            Color.Red, Color.LightPink, 45, false);
                    break;
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            switch (Drawing.Instance.Brush.GetType().Name)
            {
                case "SolidBrush":
                    Drawing.Instance.Brush = Brushes.Blue;
                    break;
                case "HatchBrush":
                    Drawing.Instance.Brush = new HatchBrush(HatchStyle.OutlinedDiamond,
                            Color.Aquamarine, Color.Blue);
                    break;
                case "LinearGradientBrush":
                    Drawing.Instance.Brush = new LinearGradientBrush(new Rectangle(0, 0, 200, 200),
                            Color.Blue, Color.LightBlue, 45, false);
                    break;
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            switch (Drawing.Instance.Brush.GetType().Name)
            {
                case "SolidBrush":
                    Drawing.Instance.Brush = Brushes.Green;
                    break;
                case "HatchBrush":
                    Drawing.Instance.Brush = new HatchBrush(HatchStyle.OutlinedDiamond,
                            Color.Aquamarine, Color.Green);
                    break;
                case "LinearGradientBrush":
                    Drawing.Instance.Brush = new LinearGradientBrush(new Rectangle(0, 0, 200, 200),
                            Color.Green, Color.LightGreen, 45, false);
                    break;
            }
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            switch (Drawing.Instance.Brush.GetType().Name)
            {
                case "SolidBrush":
                    Drawing.Instance.Brush = Brushes.Yellow;
                    break;
                case "HatchBrush":
                    Drawing.Instance.Brush = new HatchBrush(HatchStyle.OutlinedDiamond,
                            Color.Aquamarine, Color.Yellow);
                    break;
                case "LinearGradientBrush":
                    Drawing.Instance.Brush = new LinearGradientBrush(new Rectangle(0, 0, 200, 200),
                            Color.Yellow, Color.LightYellow, 45, false);
                    break;
            }
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            switch (Drawing.Instance.Brush.GetType().Name)
            {
                case "SolidBrush":
                    Drawing.Instance.Brush = Brushes.Black;
                    break;
                case "HatchBrush":
                    Drawing.Instance.Brush = new HatchBrush(HatchStyle.OutlinedDiamond,
                            Color.Aquamarine, Color.Black);
                    break;
                case "LinearGradientBrush":
                    Drawing.Instance.Brush = new LinearGradientBrush(new Rectangle(0, 0, 200, 200),
                            Color.Black, Color.LightGray, 45, false);
                    break;
            }
        }
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            switch (Drawing.Instance.Brush.GetType().Name)
            {
                case "SolidBrush":
                    Drawing.Instance.Brush = Brushes.White;
                    break;
                case "HatchBrush":
                    Drawing.Instance.Brush = new HatchBrush(HatchStyle.OutlinedDiamond,
                            Color.Aquamarine, Color.White);
                    break;
                case "LinearGradientBrush":
                    Drawing.Instance.Brush = new LinearGradientBrush(new Rectangle(0, 0, 200, 200),
                            Color.Gray, Color.White, 45, false);
                    break;
            }
        }
        //сменить кисть
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Drawing.Instance.Brush = new SolidBrush(Color.Black);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Drawing.Instance.Brush = new HatchBrush(HatchStyle.OutlinedDiamond,
            Color.Aquamarine, Color.Black);
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Drawing.Instance.Brush = new LinearGradientBrush(new Rectangle(0, 0, 200, 200),
                Color.Black, Color.LightGray, 45, false);
        }
        //сменить ширину и длину кисти
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Drawing.Instance.Height = trackBar1.Value;
            Drawing.Instance.Width = trackBar1.Value;
        }
        //поворот влево на 90 градусов
        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            pictureBox1.Paint += RotateImage.Rotate.pictureBox1_Paint;
            RotateImage.Rotate.type = RotateType.OZ;
            RotateImage.Rotate.Angle = ang1;
            if (ang1 == -360) ang1 = -90;
            else ang1 -= 90;
            pictureBox1.Refresh();
        }
        //поворот вправо на 90 градусов
        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            pictureBox1.Paint += RotateImage.Rotate.pictureBox1_Paint;
            RotateImage.Rotate.type = RotateType.OZ;
            RotateImage.Rotate.Angle = ang2;
            if (ang2 == 360) ang2 = 90;
            else ang2 += 90;
            pictureBox1.Refresh();
        }
        //отражение на 180 градусов
        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            pictureBox1.Paint += RotateImage.Rotate.pictureBox1_Paint;
            RotateImage.Rotate.type = RotateType.OY;
            RotateImage.Rotate.Angle = 180;
            pictureBox1.Refresh();
        }
        //очистить от рисунка
        private void очиститьToolStripMenuItem1_Click(object sender, EventArgs e) { pictureBox1.Refresh(); }
        //перерисовка при изменении размера
        private void pictureBox1_Resize(object sender, EventArgs e) { Invalidate(); }
        //прорисовка фотографии
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (image != null)     //если загружено изображение для рисования
            {
                // определение границы прямоугольной области, занимаемой
                // клиентской областью окна приложения
                RectangleF winRect = new RectangleF(0, 0,
                    e.Graphics.VisibleClipBounds.Width,
                    e.Graphics.VisibleClipBounds.Height);
                // получение размеров изображения в пикселах,а не в дюймах
                // HorizontalResolution, VerticalResolution - количество пикселов 
                // в пересчете на 1 дюйм изображения по горизонтали и вертикал
                SizeF size = new SizeF(image.Width / image.HorizontalResolution,
                    image.Height / image.VerticalResolution);
                // вычисление масштаба, необходимого, чтобы изображение 
                // полностью поместилось в окне 
                float scale = Math.Min(winRect.Width / size.Width,
                    winRect.Height / size.Height);
                // вычисление новых размеров изображения
                size.Width *= scale;
                size.Height *= scale;
                // Рисование
                e.Graphics.DrawImage(image,
                    winRect.X + (winRect.Width - size.Width) / 2,   // координаты верхнего левого угла
                    winRect.Y + (winRect.Height - size.Height) / 2, // прямоугольной области для рисования     
                    size.Width, size.Height);   // размеры области
            }
        }
        //событие DragDrop
        private void Form1_DragOver(object sender, DragEventArgs e) { e.Effect = DragDropEffects.Copy; }
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            // массив полных путей файлов
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            // загрузка изображения в память (для любого из перечисленных форматов)
            image = Image.FromFile(files[0]);
            // Перерисовка окна
            pictureBox1.Invalidate();
        }
        //рисуем кривые
        private void toolStripButton7_Click(object sender, EventArgs e) { a = 1; }
        //рисуем прямые
        private void toolStripButton8_Click(object sender, EventArgs e) { a = 2; }
        //рисуем эллипсы
        private void toolStripButton9_Click(object sender, EventArgs e) { a = 3; }
        //рисуем текст
        private void toolStripButton10_Click(object sender, EventArgs e) { a = 4; }
    }
}
