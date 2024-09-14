namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            splitContainer1 = new SplitContainer();
            panel4 = new Panel();
            listBox_customers = new ListBox();
            panel3 = new Panel();
            remove_btn_customers = new Button();
            add_btn_customers = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            textBox_adrs_customers = new TextBox();
            textBox_fn_customers = new TextBox();
            textBox_id_customers = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel4);
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(1104, 682);
            splitContainer1.SplitterDistance = 381;
            splitContainer1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(listBox_customers);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 45);
            panel4.Name = "panel4";
            panel4.Size = new Size(381, 563);
            panel4.TabIndex = 2;
            // 
            // listBox_customers
            // 
            listBox_customers.Dock = DockStyle.Fill;
            listBox_customers.FormattingEnabled = true;
            listBox_customers.Location = new Point(0, 0);
            listBox_customers.Name = "listBox_customers";
            listBox_customers.Size = new Size(381, 563);
            listBox_customers.TabIndex = 0;
            listBox_customers.MouseClick += listBox_customers_MouseClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(remove_btn_customers);
            panel3.Controls.Add(add_btn_customers);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 608);
            panel3.Name = "panel3";
            panel3.Size = new Size(381, 74);
            panel3.TabIndex = 1;
            // 
            // remove_btn_customers
            // 
            remove_btn_customers.Dock = DockStyle.Left;
            remove_btn_customers.Location = new Point(130, 0);
            remove_btn_customers.Name = "remove_btn_customers";
            remove_btn_customers.Size = new Size(130, 74);
            remove_btn_customers.TabIndex = 1;
            remove_btn_customers.Text = "Remove";
            remove_btn_customers.UseVisualStyleBackColor = true;
            remove_btn_customers.MouseClick += remove_btn_customers_MouseClick;
            // 
            // add_btn_customers
            // 
            add_btn_customers.Dock = DockStyle.Left;
            add_btn_customers.Location = new Point(0, 0);
            add_btn_customers.Name = "add_btn_customers";
            add_btn_customers.Size = new Size(130, 74);
            add_btn_customers.TabIndex = 0;
            add_btn_customers.Text = "Add";
            add_btn_customers.UseVisualStyleBackColor = true;
            add_btn_customers.MouseClick += add_btn_customers_MouseClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(381, 45);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 37);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox_adrs_customers);
            panel2.Controls.Add(textBox_fn_customers);
            panel2.Controls.Add(textBox_id_customers);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(719, 682);
            panel2.TabIndex = 2;
            // 
            // textBox_adrs_customers
            // 
            textBox_adrs_customers.BackColor = SystemColors.Window;
            textBox_adrs_customers.Location = new Point(115, 176);
            textBox_adrs_customers.Multiline = true;
            textBox_adrs_customers.Name = "textBox_adrs_customers";
            textBox_adrs_customers.Size = new Size(601, 174);
            textBox_adrs_customers.TabIndex = 6;
            // 
            // textBox_fn_customers
            // 
            textBox_fn_customers.Location = new Point(115, 121);
            textBox_fn_customers.Name = "textBox_fn_customers";
            textBox_fn_customers.Size = new Size(601, 27);
            textBox_fn_customers.TabIndex = 5;
            // 
            // textBox_id_customers
            // 
            textBox_id_customers.Location = new Point(115, 73);
            textBox_id_customers.Name = "textBox_id_customers";
            textBox_id_customers.Size = new Size(237, 27);
            textBox_id_customers.TabIndex = 4;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(8, 177);
            label5.Name = "label5";
            label5.Size = new Size(88, 27);
            label5.TabIndex = 3;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(3, 121);
            label4.Name = "label4";
            label4.Size = new Size(93, 27);
            label4.TabIndex = 2;
            label4.Text = "Full Name:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(3, 73);
            label3.Name = "label3";
            label3.Size = new Size(31, 27);
            label3.TabIndex = 1;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(250, 38);
            label2.TabIndex = 0;
            label2.Text = "Selected Customer";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "CustomersTab";
            Size = new Size(1104, 682);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Label label1;
        private Panel panel4;
        private Panel panel3;
        private ListBox listBox_customers;
        private Button remove_btn_customers;
        private Button add_btn_customers;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox_id_customers;
        private TextBox textBox_adrs_customers;
        private TextBox textBox_fn_customers;
    }
}
