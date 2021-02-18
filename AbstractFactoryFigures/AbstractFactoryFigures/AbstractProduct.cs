using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractFactoryFigures
{
    public abstract class AbstractProductRed
    {
        public abstract Bitmap FRedBitmap();
    }

    public abstract class AbstractProductBlue
    {
        public abstract Bitmap FBlueBitmap();
    }

    public abstract class AbstractProductGreen
    {
        public abstract Bitmap FGreenBitmap();
    }

    public class RedCircle : AbstractProductRed
    {
        public RedCircle() { }
        public override Bitmap FRedBitmap() { return new Bitmap(Properties.Resources.Красный_круг); }
    }

    public class BlueCircle : AbstractProductBlue
    {
        public BlueCircle() { }
        public override Bitmap FBlueBitmap() { return new Bitmap(Properties.Resources.Синий_круг); }
    }

    public class GreenCircle : AbstractProductGreen
    {
        public GreenCircle() { }
        public override Bitmap FGreenBitmap() { return new Bitmap(Properties.Resources.Зеленый_круг); }
    }

    public class RedSquare : AbstractProductRed
    {
        public RedSquare() { }
        public override Bitmap FRedBitmap() { return new Bitmap(Properties.Resources.Красный_квадрат); }
    }

    public class BlueSquare : AbstractProductBlue
    {
        public BlueSquare() { }
        public override Bitmap FBlueBitmap() { return new Bitmap(Properties.Resources.Синий_квадрат); }
    }

    public class GreenSquare : AbstractProductGreen
    {
        public GreenSquare() { }
        public override Bitmap FGreenBitmap() { return new Bitmap(Properties.Resources.Зеленый_квадрат); }
    }

    public class RedTriangle : AbstractProductRed
    {
        public RedTriangle() { }
        public override Bitmap FRedBitmap() { return new Bitmap(Properties.Resources.Красный_треугольник); }
    }

    public class BlueTriangle : AbstractProductBlue
    {
        public BlueTriangle() { }
        public override Bitmap FBlueBitmap() { return new Bitmap(Properties.Resources.Синий_треугольник); }
    }

    public class GreenTriangle : AbstractProductGreen
    {
        public GreenTriangle() { }
        public override Bitmap FGreenBitmap() { return new Bitmap(Properties.Resources.Зеленый_треугольник); }
    }
}
