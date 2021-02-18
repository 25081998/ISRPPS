using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractFactoryFigures
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProductRed CreateRedProduct();
        public abstract AbstractProductBlue CreateBlueProduct();
        public abstract AbstractProductGreen CreateGreenProduct();

        public abstract Form CreateForm(AbstractProductRed aPR, AbstractProductBlue aPB, AbstractProductGreen aPG);

    }

    public class FactoryCircle : AbstractFactory
    {
        public FactoryCircle() { }
        public override AbstractProductRed CreateRedProduct() { return new RedCircle(); }
        public override AbstractProductBlue CreateBlueProduct() { return new BlueCircle(); }
        public override AbstractProductGreen CreateGreenProduct() { return new GreenCircle(); }
        public override Form CreateForm(AbstractProductRed aPR, AbstractProductBlue aPB, AbstractProductGreen aPG) { return new Circle(aPR, aPB, aPG); }
    }

    public class FactorySquare : AbstractFactory
    {
        public FactorySquare() { }
        public override AbstractProductRed CreateRedProduct() { return new RedSquare(); }
        public override AbstractProductBlue CreateBlueProduct() { return new BlueSquare(); }
        public override AbstractProductGreen CreateGreenProduct() { return new GreenSquare(); }
        public override Form CreateForm(AbstractProductRed aPR, AbstractProductBlue aPB, AbstractProductGreen aPG) { return new Square(aPR, aPB, aPG); }
    }

    public class FactoryTriangle : AbstractFactory
    {
        public FactoryTriangle() { }
        public override AbstractProductRed CreateRedProduct() { return new RedTriangle(); }
        public override AbstractProductBlue CreateBlueProduct() { return new BlueTriangle(); }
        public override AbstractProductGreen CreateGreenProduct() { return new GreenTriangle(); }
        public override Form CreateForm(AbstractProductRed aPR, AbstractProductBlue aPB, AbstractProductGreen aPG) { return new Triangle(aPR, aPB, aPG); }
    }

    public class Client
    {
        private AbstractFactory abstractFactory;
        private AbstractProductRed abstractProductRed;
        private AbstractProductBlue abstractProductBlue;
        private AbstractProductGreen abstractProductGreen;

        public Client(AbstractFactory abstractFactory)
        {
            this.abstractFactory = abstractFactory;
            this.abstractProductRed = abstractFactory.CreateRedProduct();
            this.abstractProductBlue = abstractFactory.CreateBlueProduct();
            this.abstractProductGreen = abstractFactory.CreateGreenProduct();
        }

        public void Run() { this.abstractFactory.CreateForm(this.abstractProductRed, this.abstractProductBlue, this.abstractProductGreen).ShowDialog(); }
    }
}
