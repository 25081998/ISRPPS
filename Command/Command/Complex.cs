using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //получатель
    public class Complex
    {
        private double a;
        private double b;
        //конструктор
        public Complex(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        //доступ к полям a и b
        public double A
        {
            set { a = value; }
            get { return a; }
        }
        public double B
        {
            set { b = value; }
            get { return b; }
        }
        //печать числа
        public string Print()
        {
            string str = "";
            if (a == 0 && b == 0) str = "0";
            else
            {
                switch (a)
                {
                    case 0:
                        break;
                    default:
                        str = Convert.ToString(a);
                        break;
                }
                switch (b)
                {
                    case 0:
                        break;
                    case 1:
                        if (a != 0) str = str + "+i";
                        else str = str + "i";
                        break;
                    case -1:
                        str = str + "-i";
                        break;
                    default:
                        if (a != 0 && b > 0) str = str + '+' + b + "i";
                        else str = str + b + "i";
                        break;
                }
            }
            return str;
        }
        //вычислительные функции
        static public Complex Sum(Complex c1, Complex c2)
        {
            double a, b;
            a = c1.A + c2.A;
            b = c1.B + c2.B;
            Complex c = new Complex(a, b);
            return c;
        }
        static public Complex Subtraction(Complex c1, Complex c2)
        {
            double a, b;
            a = c1.A - c2.A;
            b = c1.B - c2.B;
            Complex c = new Complex(a, b);
            return c;
        }
        static public Complex Multiplication(Complex c1, Complex c2)
        {
            double a, b;
            a = c1.A * c2.A - c1.B * c2.B;
            b = c1.A * c2.B + c2.A * c1.B;
            Complex c = new Complex(a, b);
            return c;
        }
        static public Complex Segmentation(Complex c1, Complex c2)
        {
            double a, b;
            a = (c1.A * c2.A + c1.B * c2.B) / (c2.A * c2.A + c2.B * c2.B);
            b = (c2.A * c1.B - c1.A * c2.B) / (c2.A * c2.A + c2.B * c2.B);
            Complex c = new Complex(a, b);
            return c;
        }
    }
}
