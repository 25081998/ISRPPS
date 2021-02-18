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
    public partial class Circle : Form
    {
        public Circle(AbstractProductRed aPR, AbstractProductBlue aPB, AbstractProductGreen aPG)
        {
            InitializeComponent();
            pictureBox1.BackgroundImage = aPR.FRedBitmap();
            pictureBox2.BackgroundImage = aPB.FBlueBitmap();
            pictureBox3.BackgroundImage = aPG.FGreenBitmap();
        }
    }
}
