using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursGeneticAlgorithm
{
    //абстрактная фабрика
    public abstract class AbstractFactory
    {
        public abstract AbstractProduct CreateInformation();
        public abstract Form CreateForm(AbstractProduct abstractProduct);
    }
    //конкретная фабрика
    public class AlgorithmFactory : AbstractFactory
    {
        public override Form CreateForm(AbstractProduct abstractProduct)
        {
            return new AlgorithmInformation(abstractProduct);
        }
        public override AbstractProduct CreateInformation()
        {
            return new Algorithm();
        }
    }
    //конкретная фабрика
    public class EnglishFactory : AbstractFactory
    {
        public override Form CreateForm(AbstractProduct abstractProduct)
        {
            return new EnglishInformation(abstractProduct);
        }
        public override AbstractProduct CreateInformation()
        {
            return new English();
        }
    }
    //клиент-синглтон
    public class Client
    {
        private static Form form;
        private static AbstractProduct product;
        private static Client instance = new Client();

        public static Client Instance { get { return instance; } }

        protected Client() { }
     
        public static void Take(AbstractFactory factory)
        {
            product = factory.CreateInformation();
            form = factory.CreateForm(product);
        }

        public void Run() { form.Show(); }
    }
}
