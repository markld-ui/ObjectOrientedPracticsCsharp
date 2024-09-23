namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            splitter1 = new Splitter();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            panel4 = new Panel();
            listBox_items = new ListBox();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            remove_btn_items = new Button();
            add_btn_items = new Button();
            panel5 = new Panel();
            label_category = new Label();
            comboBox_category_items = new ComboBox();
            textBox_descr_items = new TextBox();
            label6 = new Label();
            textBox_name_items = new TextBox();
            textBox_cost_items = new TextBox();
            textBox_id_items = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 682);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(4, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel5);
            splitContainer1.Size = new Size(1100, 682);
            splitContainer1.SplitterDistance = 481;
            splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 682);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(listBox_items);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 42);
            panel4.Name = "panel4";
            panel4.Size = new Size(481, 566);
            panel4.TabIndex = 4;
            // 
            // listBox_items
            // 
            listBox_items.Dock = DockStyle.Fill;
            listBox_items.FormattingEnabled = true;
            listBox_items.Location = new Point(0, 0);
            listBox_items.Name = "listBox_items";
            listBox_items.Size = new Size(481, 566);
            listBox_items.TabIndex = 0;
            listBox_items.MouseClick += listBox_items_MouseClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(481, 42);
            panel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 38);
            label1.TabIndex = 0;
            label1.Text = "Items";
            // 
            // panel2
            // 
            panel2.Controls.Add(remove_btn_items);
            panel2.Controls.Add(add_btn_items);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 608);
            panel2.Name = "panel2";
            panel2.Size = new Size(481, 74);
            panel2.TabIndex = 2;
            // 
            // remove_btn_items
            // 
            remove_btn_items.Dock = DockStyle.Left;
            remove_btn_items.Location = new Point(130, 0);
            remove_btn_items.Name = "remove_btn_items";
            remove_btn_items.Size = new Size(130, 74);
            remove_btn_items.TabIndex = 1;
            remove_btn_items.Text = "Remove";
            remove_btn_items.UseVisualStyleBackColor = true;
            remove_btn_items.MouseClick += remove_btn_items_MouseClick;
            // 
            // add_btn_items
            // 
            add_btn_items.Dock = DockStyle.Left;
            add_btn_items.Location = new Point(0, 0);
            add_btn_items.Name = "add_btn_items";
            add_btn_items.Size = new Size(130, 74);
            add_btn_items.TabIndex = 0;
            add_btn_items.Text = "Add";
            add_btn_items.UseVisualStyleBackColor = true;
            add_btn_items.MouseClick += add_btn_items_MouseClick;
            // 
            // panel5
            // 
            panel5.Controls.Add(label_category);
            panel5.Controls.Add(comboBox_category_items);
            panel5.Controls.Add(textBox_descr_items);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(textBox_name_items);
            panel5.Controls.Add(textBox_cost_items);
            panel5.Controls.Add(textBox_id_items);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(615, 682);
            panel5.TabIndex = 0;
            // 
            // label_category
            // 
            label_category.Font = new Font("Segoe UI", 10F);
            label_category.Location = new Point(3, 144);
            label_category.Name = "label_category";
            label_category.Size = new Size(94, 28);
            label_category.TabIndex = 10;
            label_category.Text = "Category:";
            // 
            // comboBox_category_items
            // 
            comboBox_category_items.FormattingEnabled = true;
            comboBox_category_items.Location = new Point(118, 144);
            comboBox_category_items.Name = "comboBox_category_items";
            comboBox_category_items.Size = new Size(153, 28);
            comboBox_category_items.TabIndex = 9;
            comboBox_category_items.SelectedIndexChanged += comboBox_category_items_SelectedIndexChanged;
            // 
            // textBox_descr_items
            // 
            textBox_descr_items.Location = new Point(15, 466);
            textBox_descr_items.Multiline = true;
            textBox_descr_items.Name = "textBox_descr_items";
            textBox_descr_items.Size = new Size(582, 167);
            textBox_descr_items.TabIndex = 8;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(6, 419);
            label6.Name = "label6";
            label6.Size = new Size(106, 27);
            label6.TabIndex = 7;
            label6.Text = "Description:";
            // 
            // textBox_name_items
            // 
            textBox_name_items.Location = new Point(15, 236);
            textBox_name_items.Multiline = true;
            textBox_name_items.Name = "textBox_name_items";
            textBox_name_items.Size = new Size(582, 180);
            textBox_name_items.TabIndex = 6;
            // 
            // textBox_cost_items
            // 
            textBox_cost_items.Location = new Point(118, 93);
            textBox_cost_items.Name = "textBox_cost_items";
            textBox_cost_items.Size = new Size(153, 27);
            textBox_cost_items.TabIndex = 5;
            // 
            // textBox_id_items
            // 
            textBox_id_items.Location = new Point(118, 53);
            textBox_id_items.Name = "textBox_id_items";
            textBox_id_items.Size = new Size(153, 27);
            textBox_id_items.TabIndex = 4;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(6, 206);
            label5.Name = "label5";
            label5.Size = new Size(62, 27);
            label5.TabIndex = 3;
            label5.Text = "Name:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(3, 93);
            label4.Name = "label4";
            label4.Size = new Size(50, 27);
            label4.TabIndex = 2;
            label4.Text = "Cost:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(3, 53);
            label3.Name = "label3";
            label3.Size = new Size(34, 27);
            label3.TabIndex = 1;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(185, 38);
            label2.TabIndex = 0;
            label2.Text = "Selected Item";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(splitter1);
            Name = "ItemsTab";
            Size = new Size(1104, 682);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Splitter splitter1;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Button remove_btn_items;
        private Button add_btn_items;
        private Panel panel4;
        private ListBox listBox_items;
        private Panel panel5;
        private TextBox textBox_descr_items;
        private Label label6;
        private TextBox textBox_name_items;
        private TextBox textBox_cost_items;
        private TextBox textBox_id_items;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label_category;
        private ComboBox comboBox_category_items;
    }
}
