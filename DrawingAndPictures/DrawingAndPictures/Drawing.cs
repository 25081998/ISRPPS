using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DrawingAndPictures
{
    public class Drawing
    {
        private float width;    //ширина кисти
        private float height;   //длина кисти
        private Brush brush;    //кисть

        private Graphics g;     //графика
        private Pen p;          //перо
        //доступ к полям
        public float Width { set { width = value; } get { return width; } }
        public float Height { set { height = value; } get { return height; } }
        public Brush Brush { set { brush = value; } get { return brush; } }
        //Singleton
        private static Drawing instance = new Drawing();
        public static Drawing Instance { get { return instance; } }
        //конструктор
        protected Drawing()
        {
            width = 1;
            height = 1;
            brush = new SolidBrush(Color.Black);
        }
        //прорисовка кривых
        public void Draw(PictureBox pic, float x, float y)
        {
            g = Graphics.FromHwnd(pic.Handle);
            g.FillRectangle(brush, x, y, width, height);
            g.Dispose();
        }
        //прорисовка линий
        public void DrawLine(PictureBox pic, Point p1, Point p2)
        {
            g = Graphics.FromHwnd(pic.Handle);
            p = new Pen(brush, width);
            g.DrawLine(p, p1, p2);
            g.Dispose();
        }
        //прорислвка эллипса
        public void DrawEllipse(PictureBox pic, int x, int y, int w, int h)
        {
            g = Graphics.FromHwnd(pic.Handle);
            p = new Pen(brush, width);
            g.DrawEllipse(p, x, y, w, h);
            g.Dispose();
        }
        //прорисовка текста
        public void DrawText(PictureBox pic, string str, float x, float y)
        {
            g = Graphics.FromHwnd(pic.Handle);
            g.DrawString(str, new Font(new FontFamily("Helvetica"), width, FontStyle.Regular, GraphicsUnit.Point), brush, x, y);
            g.Dispose();
        }
    }
}
