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
    public partial class FigureForm : Form
    {
        private AbstractFactory abstractFactory;
        private AbstractProduct abstractProduct;

        public FigureForm(AbstractProduct abstractProduct)
        {
            InitializeComponent();
            this.abstractProduct = abstractProduct;
        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abstractFactory = new CreateRed(abstractProduct);
            abstractFactory.CreateColor();
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abstractFactory = new CreateBlue(abstractProduct);
            abstractFactory.CreateColor();
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abstractFactory = new CreateGreen(abstractProduct);
            abstractFactory.CreateColor();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
