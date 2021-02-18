using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Frames
{
    class Expense
    {
        private string name;
        private double value;
        private TreeNode treeNode;

        public Expense(TreeNode treeNode)
        {
            this.treeNode = treeNode;
            this.name = treeNode.Text;
            value = 0;
        }

        public void Add(double value) { this.value += value; }
        public double Value() { return value; }
        public string Name() { return name; }
    }
}
