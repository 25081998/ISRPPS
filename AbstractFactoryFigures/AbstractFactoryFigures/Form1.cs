using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactoryFigures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            AbstractFactory abstractFactory = new FactoryCircle();
            Client client = new Client(abstractFactory);
            client.Run();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AbstractFactory abstractFactory = new FactorySquare();
            Client client = new Client(abstractFactory);
            client.Run();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            AbstractFactory abstractFactory = new FactoryTriangle();
            Client client = new Client(abstractFactory);
            client.Run();
        }
    }
}
