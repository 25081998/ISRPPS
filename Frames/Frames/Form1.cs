using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frames
{
    public partial class Form1 : Form
    {
        private double sum;
        private List<Expense> expenses;
        private List<TreeNode> checkedNodes = new List<TreeNode>();

        public Form1()
        {
            InitializeComponent();
            sum = 0;
            treeView1.CheckBoxes = true;
            expenses = new List<Expense>();
            MakeRecursive(treeView1);
            textBox3.Visible = false;
            button3.Visible = false;
            textBox4.Visible = false;
            button4.Visible = false;
            listView1.Items.Clear();
        }

        //построение узлов дерева
        private void MakeTree(TreeNode treeNode) 
        {
            expenses.Add(new Expense(treeNode));
            foreach (TreeNode tn in treeNode.Nodes)
            {
                MakeTree(tn);
            }
        }

        //построение дерева
        private void MakeRecursive(TreeView treeView) 
        {
            TreeNodeCollection nodes = treeView.Nodes;
            foreach (TreeNode n in nodes)
            {
                MakeTree(n);
            }
        }

        //удаление узлов дерева
        private void DeleteNodes(List<TreeNode> checkedNodes) 
        {
            foreach (TreeNode tn in checkedNodes)
            {
                TreeNodeCollection nodes = tn.Nodes;
                foreach (TreeNode t in nodes)
                {
                    sum -= FindExpense(t).Value();
                    expenses.Remove(FindExpense(t));
                }
                treeView1.Nodes.Remove(tn);
                //checkedNodes.Remove(tn);
            }
            
        }

        //составление списка удаляемых узлов
        private void DeleteRecursive(TreeNodeCollection nodes) 
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Checked) checkedNodes.Add(node);
                else DeleteRecursive(node.Nodes);
            }
        }

        //нахождение расходов
        private Expense FindExpense(TreeNode treeNode) 
        {
            Expense ex = null;
            foreach (Expense exp in expenses) if (exp.Name() == treeNode.Text)  ex = exp;
            return ex;
        }

        //добавление расходов в узел
        private void AddExpense(TreeNode treeNode) 
        {
            if (treeNode.Checked)
            {
                sum += Convert.ToDouble(textBox2.Text);
                FindExpense(treeNode).Add(Convert.ToDouble(textBox2.Text));
                textBox2.Text = "";
            }
            foreach (TreeNode tn in treeNode.Nodes)
            {
                AddExpense(tn);
            }
        }

        //добавление разходов в дерево
        private void AddRecursive(TreeView treeView) 
        {
            TreeNodeCollection nodes = treeView.Nodes;
            foreach (TreeNode n in nodes)
            {
                AddExpense(n);
            }
        }

        //добавить расходы
        private void button2_Click(object sender, EventArgs e)  
        {
            try
            {
                AddRecursive(treeView1);
            }
            catch (FormatException)
            {
                if (textBox2.Text == "") MessageBox.Show("Введите данные");
                else
                {
                    DialogResult result = MessageBox.Show("Ошибка ввода.\n" + "Неверный формат данных.\n" + "Повторить?",
                                "Ошибка", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            break;
                        case DialogResult.No:
                            this.Close();
                            break;
                    }
                }
            }
        }

        //показать дерево
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) 
        {
            TreeNode selectedNode = e.Node;
            listView1.Items.Clear();

            TreeNodeCollection nodes = selectedNode.Nodes;
            
            foreach (TreeNode tn in nodes)
            {
                ListViewItem lvi = new ListViewItem(FindExpense(tn).Name());
                lvi.SubItems.Add(FindExpense(tn).Value().ToString());
                string str = String.Format("{0:#.##} %", (FindExpense(tn).Value() / sum) * 100);
                if (sum == 0 || (FindExpense(tn).Value() / sum) * 100 == 0) lvi.SubItems.Add("0 %"); 
                else lvi.SubItems.Add(str);

                listView1.Items.Add(lvi);
            }
        }

        //информация о программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("Примитивная программа учета расходов.\n\nРазработчик: Бабичева Анна М8О-202Б-17\nМАИ 2018");
        }

        //сумма расходов
        private void button1_Click(object sender, EventArgs e) 
        {
            textBox1.Text = Convert.ToString(sum);
        }

        //очистить дерево от значений
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            MakeRecursive(treeView1);
            listView1.Items.Clear();
            sum = 0;
        }

        //добавить узел
        private void добавитьКатегориюToolStripMenuItem1_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("Введите название категории в поле для ввода");
            textBox3.Visible = true;
            button3.Visible = true;
        }

        //добавление узла
        private void button3_Click(object sender, EventArgs e) 
        {
            if (textBox3.Text == "") MessageBox.Show("Введите данные");
            else
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Text = textBox3.Text;
                treeView1.Nodes.Add(treeNode);
                expenses.Add(new Expense(treeNode));
                textBox3.Text = "";
                textBox3.Visible = false;
                button3.Visible = false;
            }
        }

        //удаление узлов
        private void удалитьКатегориюToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            listView1.Items.Clear();
            DeleteRecursive(treeView1.Nodes);
            DeleteNodes(checkedNodes);
        }

        //добавить потомка
        private void добавитьРасходToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("Введите название конкретного расхода в поле для ввода");
            textBox4.Visible = true;
            button4.Visible = true;
        }

        //удаление узлов
        private void удалитьРасходToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            listView1.Items.Clear();
            DeleteRecursive(treeView1.Nodes);
            DeleteNodes(checkedNodes);
        }

        //добавление потомка
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "") MessageBox.Show("Введите данные");
            else
            {
                TreeNode treeNode = new TreeNode();
                TreeNodeCollection nodes = treeView1.Nodes;
                treeNode.Text = textBox4.Text;
                foreach(TreeNode tn in nodes)
                {
                    if (tn.Checked) tn.Nodes.Add(treeNode);
                }
                expenses.Add(new Expense(treeNode));
                textBox4.Text = "";
                textBox4.Visible = false;
                button4.Visible = false;
            }
        }
    }
}
