using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursGeneticAlgorithm
{
    public partial class AlgorithmInformation : Form
    {
        //ссылка на продукт
        private Algorithm algorithm;
        //конструктор
        public AlgorithmInformation(AbstractProduct algorithm)
        {
            InitializeComponent();
            this.algorithm = (Algorithm)algorithm;
            richTextBox1.Text = algorithm.Information();
        }
    }
}
