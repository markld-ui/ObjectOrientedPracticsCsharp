namespace ObjectOrientedPractices.View.Tabs
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
            listBoxItems = new ListBox();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            removeBtnItems = new Button();
            addBtnItems = new Button();
            panel5 = new Panel();
            label_category = new Label();
            comboBoxCategoryItems = new ComboBox();
            textBoxDescrItems = new TextBox();
            label6 = new Label();
            textBoxNameItems = new TextBox();
            textBoxCostItems = new TextBox();
            textBoxIdItems = new TextBox();
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
            panel4.Controls.Add(listBoxItems);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 42);
            panel4.Name = "panel4";
            panel4.Size = new Size(481, 566);
            panel4.TabIndex = 4;
            // 
            // listBoxItems
            // 
            listBoxItems.Dock = DockStyle.Fill;
            listBoxItems.FormattingEnabled = true;
            listBoxItems.Location = new Point(0, 0);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(481, 566);
            listBoxItems.TabIndex = 0;
            listBoxItems.MouseClick += listBoxItemsMouseClick;
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
            panel2.Controls.Add(removeBtnItems);
            panel2.Controls.Add(addBtnItems);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 608);
            panel2.Name = "panel2";
            panel2.Size = new Size(481, 74);
            panel2.TabIndex = 2;
            // 
            // removeBtnItems
            // 
            removeBtnItems.Dock = DockStyle.Left;
            removeBtnItems.Location = new Point(130, 0);
            removeBtnItems.Name = "removeBtnItems";
            removeBtnItems.Size = new Size(130, 74);
            removeBtnItems.TabIndex = 1;
            removeBtnItems.Text = "Remove";
            removeBtnItems.UseVisualStyleBackColor = true;
            removeBtnItems.MouseClick += removeBtnItemsMouseClick;
            // 
            // addBtnItems
            // 
            addBtnItems.Dock = DockStyle.Left;
            addBtnItems.Location = new Point(0, 0);
            addBtnItems.Name = "addBtnItems";
            addBtnItems.Size = new Size(130, 74);
            addBtnItems.TabIndex = 0;
            addBtnItems.Text = "Add";
            addBtnItems.UseVisualStyleBackColor = true;
            addBtnItems.MouseClick += addBtnItemsMouseClick;
            // 
            // panel5
            // 
            panel5.Controls.Add(label_category);
            panel5.Controls.Add(comboBoxCategoryItems);
            panel5.Controls.Add(textBoxDescrItems);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(textBoxNameItems);
            panel5.Controls.Add(textBoxCostItems);
            panel5.Controls.Add(textBoxIdItems);
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
            // comboBoxCategoryItems
            // 
            comboBoxCategoryItems.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoryItems.FormattingEnabled = true;
            comboBoxCategoryItems.Location = new Point(118, 144);
            comboBoxCategoryItems.Name = "comboBoxCategoryItems";
            comboBoxCategoryItems.Size = new Size(153, 28);
            comboBoxCategoryItems.TabIndex = 9;
            comboBoxCategoryItems.SelectedIndexChanged += comboBoxCategoryItemsSelectedIndexChanged;
            // 
            // textBoxDescrItems
            // 
            textBoxDescrItems.Location = new Point(15, 466);
            textBoxDescrItems.MaxLength = 1000;
            textBoxDescrItems.Multiline = true;
            textBoxDescrItems.Name = "textBoxDescrItems";
            textBoxDescrItems.Size = new Size(582, 167);
            textBoxDescrItems.TabIndex = 8;
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
            // textBoxNameItems
            // 
            textBoxNameItems.Location = new Point(15, 236);
            textBoxNameItems.MaxLength = 200;
            textBoxNameItems.Multiline = true;
            textBoxNameItems.Name = "textBoxNameItems";
            textBoxNameItems.Size = new Size(582, 180);
            textBoxNameItems.TabIndex = 6;
            // 
            // textBoxCostItems
            // 
            textBoxCostItems.Location = new Point(118, 93);
            textBoxCostItems.Name = "textBoxCostItems";
            textBoxCostItems.Size = new Size(153, 27);
            textBoxCostItems.TabIndex = 5;
            // 
            // textBoxIdItems
            // 
            textBoxIdItems.Location = new Point(118, 53);
            textBoxIdItems.Name = "textBoxIdItems";
            textBoxIdItems.ReadOnly = true;
            textBoxIdItems.Size = new Size(153, 27);
            textBoxIdItems.TabIndex = 4;
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
        private Button removeBtnItems;
        private Button addBtnItems;
        private Panel panel4;
        private ListBox listBoxItems;
        private Panel panel5;
        private TextBox textBoxDescrItems;
        private Label label6;
        private TextBox textBoxNameItems;
        private TextBox textBoxCostItems;
        private TextBox textBoxIdItems;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label_category;
        private ComboBox comboBoxCategoryItems;
    }
}
