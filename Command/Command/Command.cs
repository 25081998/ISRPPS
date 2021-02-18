using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public abstract class Command
    {
        protected Complex result;
        protected Complex c1;
        protected Complex c2;

        public Complex Result { get { return result; } }

        public abstract Complex Execute();
        public abstract Complex UnExecute();
    }
    //конкретная команда 1
    public class SumCommand : Command
    {
        //конструктор 
        public SumCommand(Complex c1, Complex c2)
        {
            this.c1 = c1;
            this.c2 = c2;
        }

        public override Complex Execute()
        {
            result = Complex.Sum(c1, c2);
            return this.Result;
        }
        public override Complex UnExecute()
        {
            result = Complex.Subtraction(c1, c2);
            return this.Result;
        }
    }
    //конкретная команда 2
    public class SubtractionCommand : Command
    {
        //конструктор
        public SubtractionCommand(Complex c1, Complex c2)
        {
            this.c1 = c1;
            this.c2 = c2;
        }

        public override Complex Execute()
        {
            result = Complex.Subtraction(c1, c2);
            return this.Result;
        }
        public override Complex UnExecute()
        {
            result = Complex.Sum(c1, c2);
            return this.Result;
        }
    }
    //конкретная команда 3
    public class MultiplicationCommand : Command
    {
        //конструктор
        public MultiplicationCommand(Complex c1, Complex c2)
        {
            this.c1 = c1;
            this.c2 = c2;
        }

        public override Complex Execute()
        {
            result = Complex.Multiplication(c1, c2);
            return this.Result;
        }
        public override Complex UnExecute()
        {
            result = Complex.Segmentation(c1, c2);
            return this.Result;
        }
    }
    //конкретная команда 4
    public class SegmentationCommand : Command
    {
        //конструктор
        public SegmentationCommand(Complex c1, Complex c2)
        {
            this.c1 = c1;
            this.c2 = c2;
        }

        public override Complex Execute()
        {
            result = Complex.Segmentation(c1, c2);
            return this.Result;
        }
        public override Complex UnExecute()
        {
            result = Complex.Multiplication(c1, c2);
            return this.Result;
        }
    }
}
