namespace Frames
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode309 = new System.Windows.Forms.TreeNode("Зерномучные");
            System.Windows.Forms.TreeNode treeNode310 = new System.Windows.Forms.TreeNode("Фрукты, овощи");
            System.Windows.Forms.TreeNode treeNode311 = new System.Windows.Forms.TreeNode("Кондитерские изделия");
            System.Windows.Forms.TreeNode treeNode312 = new System.Windows.Forms.TreeNode("Мясо и мясные");
            System.Windows.Forms.TreeNode treeNode313 = new System.Windows.Forms.TreeNode("Рыбная продукция");
            System.Windows.Forms.TreeNode treeNode314 = new System.Windows.Forms.TreeNode("Молочные продукты");
            System.Windows.Forms.TreeNode treeNode315 = new System.Windows.Forms.TreeNode("Напитки");
            System.Windows.Forms.TreeNode treeNode316 = new System.Windows.Forms.TreeNode("Продукты", new System.Windows.Forms.TreeNode[] {
            treeNode309,
            treeNode310,
            treeNode311,
            treeNode312,
            treeNode313,
            treeNode314,
            treeNode315});
            System.Windows.Forms.TreeNode treeNode317 = new System.Windows.Forms.TreeNode("Водоснабжение");
            System.Windows.Forms.TreeNode treeNode318 = new System.Windows.Forms.TreeNode("Газоснабжение");
            System.Windows.Forms.TreeNode treeNode319 = new System.Windows.Forms.TreeNode("Электричество");
            System.Windows.Forms.TreeNode treeNode320 = new System.Windows.Forms.TreeNode("Телефон");
            System.Windows.Forms.TreeNode treeNode321 = new System.Windows.Forms.TreeNode("ЖКХ", new System.Windows.Forms.TreeNode[] {
            treeNode317,
            treeNode318,
            treeNode319,
            treeNode320});
            System.Windows.Forms.TreeNode treeNode322 = new System.Windows.Forms.TreeNode("Аренда");
            System.Windows.Forms.TreeNode treeNode323 = new System.Windows.Forms.TreeNode("Кредиты");
            System.Windows.Forms.TreeNode treeNode324 = new System.Windows.Forms.TreeNode("Налоги");
            System.Windows.Forms.TreeNode treeNode325 = new System.Windows.Forms.TreeNode("Постоянные затраты", new System.Windows.Forms.TreeNode[] {
            treeNode322,
            treeNode323,
            treeNode324});
            System.Windows.Forms.TreeNode treeNode326 = new System.Windows.Forms.TreeNode("Бензин");
            System.Windows.Forms.TreeNode treeNode327 = new System.Windows.Forms.TreeNode("Автомобиль", new System.Windows.Forms.TreeNode[] {
            treeNode326});
            System.Windows.Forms.TreeNode treeNode328 = new System.Windows.Forms.TreeNode("Общественный транспорт");
            System.Windows.Forms.TreeNode treeNode329 = new System.Windows.Forms.TreeNode("Транспорт", new System.Windows.Forms.TreeNode[] {
            treeNode327,
            treeNode328});
            System.Windows.Forms.TreeNode treeNode330 = new System.Windows.Forms.TreeNode("Незапланированные затраты");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.деревоРасходовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКатегориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКатегориюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКатегориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.конкретныеРасходыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьРасходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьРасходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 31);
            this.treeView1.Name = "treeView1";
            treeNode309.Name = "Узел1";
            treeNode309.Text = "Зерномучные";
            treeNode310.Name = "Узел2";
            treeNode310.Text = "Фрукты, овощи";
            treeNode311.Name = "Узел4";
            treeNode311.Text = "Кондитерские изделия";
            treeNode312.Name = "Узел5";
            treeNode312.Text = "Мясо и мясные";
            treeNode313.Name = "Узел6";
            treeNode313.Text = "Рыбная продукция";
            treeNode314.Name = "Узел7";
            treeNode314.Text = "Молочные продукты";
            treeNode315.Name = "Узел8";
            treeNode315.Text = "Напитки";
            treeNode316.Name = "Узел0";
            treeNode316.Text = "Продукты";
            treeNode317.Name = "Узел10";
            treeNode317.Text = "Водоснабжение";
            treeNode318.Name = "Узел11";
            treeNode318.Text = "Газоснабжение";
            treeNode319.Name = "Узел12";
            treeNode319.Text = "Электричество";
            treeNode320.Name = "Узел13";
            treeNode320.Text = "Телефон";
            treeNode321.Name = "Узел9";
            treeNode321.Text = "ЖКХ";
            treeNode322.Name = "Узел15";
            treeNode322.Text = "Аренда";
            treeNode323.Name = "Узел16";
            treeNode323.Text = "Кредиты";
            treeNode324.Name = "Узел17";
            treeNode324.Text = "Налоги";
            treeNode325.Name = "Узел14";
            treeNode325.Text = "Постоянные затраты";
            treeNode326.Name = "Узел21";
            treeNode326.Text = "Бензин";
            treeNode327.Name = "Узел20";
            treeNode327.Text = "Автомобиль";
            treeNode328.Name = "Узел22";
            treeNode328.Text = "Общественный транспорт";
            treeNode329.Name = "Узел19";
            treeNode329.Text = "Транспорт";
            treeNode330.Name = "Узел23";
            treeNode330.Text = "Незапланированные затраты";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode316,
            treeNode321,
            treeNode325,
            treeNode329,
            treeNode330});
            this.treeView1.Size = new System.Drawing.Size(304, 407);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.деревоРасходовToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // деревоРасходовToolStripMenuItem
            // 
            this.деревоРасходовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКатегориюToolStripMenuItem,
            this.конкретныеРасходыToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.деревоРасходовToolStripMenuItem.Name = "деревоРасходовToolStripMenuItem";
            this.деревоРасходовToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.деревоРасходовToolStripMenuItem.Text = "Дерево расходов";
            // 
            // добавитьКатегориюToolStripMenuItem
            // 
            this.добавитьКатегориюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКатегориюToolStripMenuItem1,
            this.удалитьКатегориюToolStripMenuItem});
            this.добавитьКатегориюToolStripMenuItem.Name = "добавитьКатегориюToolStripMenuItem";
            this.добавитьКатегориюToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.добавитьКатегориюToolStripMenuItem.Text = "Категория расходов";
            // 
            // добавитьКатегориюToolStripMenuItem1
            // 
            this.добавитьКатегориюToolStripMenuItem1.Name = "добавитьКатегориюToolStripMenuItem1";
            this.добавитьКатегориюToolStripMenuItem1.Size = new System.Drawing.Size(229, 26);
            this.добавитьКатегориюToolStripMenuItem1.Text = "Добавить категорию";
            this.добавитьКатегориюToolStripMenuItem1.Click += new System.EventHandler(this.добавитьКатегориюToolStripMenuItem1_Click);
            // 
            // удалитьКатегориюToolStripMenuItem
            // 
            this.удалитьКатегориюToolStripMenuItem.Name = "удалитьКатегориюToolStripMenuItem";
            this.удалитьКатегориюToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.удалитьКатегориюToolStripMenuItem.Text = "Удалить категорию";
            this.удалитьКатегориюToolStripMenuItem.Click += new System.EventHandler(this.удалитьКатегориюToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(322, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(561, 347);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 111;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Сумма расхода";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Процент от всех расходов";
            this.columnHeader3.Width = 185;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(322, 415);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Итог";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(322, 384);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(428, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(565, 384);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 22);
            this.textBox3.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(714, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Добавить категорию";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // конкретныеРасходыToolStripMenuItem
            // 
            this.конкретныеРасходыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьРасходToolStripMenuItem,
            this.удалитьРасходToolStripMenuItem});
            this.конкретныеРасходыToolStripMenuItem.Name = "конкретныеРасходыToolStripMenuItem";
            this.конкретныеРасходыToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.конкретныеРасходыToolStripMenuItem.Text = "Конкретные расходы";
            // 
            // добавитьРасходToolStripMenuItem
            // 
            this.добавитьРасходToolStripMenuItem.Name = "добавитьРасходToolStripMenuItem";
            this.добавитьРасходToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.добавитьРасходToolStripMenuItem.Text = "Добавить расход";
            this.добавитьРасходToolStripMenuItem.Click += new System.EventHandler(this.добавитьРасходToolStripMenuItem_Click);
            // 
            // удалитьРасходToolStripMenuItem
            // 
            this.удалитьРасходToolStripMenuItem.Name = "удалитьРасходToolStripMenuItem";
            this.удалитьРасходToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.удалитьРасходToolStripMenuItem.Text = "Удалить расход";
            this.удалитьРасходToolStripMenuItem.Click += new System.EventHandler(this.удалитьРасходToolStripMenuItem_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(565, 415);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(143, 22);
            this.textBox4.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(714, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Добавить расход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Планер расходов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem деревоРасходовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКатегориюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКатегориюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьКатегориюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem конкретныеРасходыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьРасходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьРасходToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
    }
}

