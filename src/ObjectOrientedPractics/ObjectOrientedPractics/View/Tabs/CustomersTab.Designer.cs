namespace ObjectOrientedPractices.View.Tabs
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
            listBoxCustomers = new ListBox();
            panel3 = new Panel();
            removeBtnCustomers = new Button();
            addBtnCustomers = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            addressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            textBoxFullNameCustomers = new TextBox();
            textBoxIdCustomers = new TextBox();
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
            panel4.Controls.Add(listBoxCustomers);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 45);
            panel4.Name = "panel4";
            panel4.Size = new Size(381, 563);
            panel4.TabIndex = 2;
            // 
            // listBoxCustomers
            // 
            listBoxCustomers.Dock = DockStyle.Fill;
            listBoxCustomers.FormattingEnabled = true;
            listBoxCustomers.Location = new Point(0, 0);
            listBoxCustomers.Name = "listBoxCustomers";
            listBoxCustomers.Size = new Size(381, 563);
            listBoxCustomers.TabIndex = 0;
            listBoxCustomers.MouseClick += listBoxCustomersMouseClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(removeBtnCustomers);
            panel3.Controls.Add(addBtnCustomers);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 608);
            panel3.Name = "panel3";
            panel3.Size = new Size(381, 74);
            panel3.TabIndex = 1;
            // 
            // removeBtnCustomers
            // 
            removeBtnCustomers.Dock = DockStyle.Left;
            removeBtnCustomers.Location = new Point(130, 0);
            removeBtnCustomers.Name = "removeBtnCustomers";
            removeBtnCustomers.Size = new Size(130, 74);
            removeBtnCustomers.TabIndex = 1;
            removeBtnCustomers.Text = "Remove";
            removeBtnCustomers.UseVisualStyleBackColor = true;
            removeBtnCustomers.MouseClick += removeBtnCustomersMouseClick;
            // 
            // addBtnCustomers
            // 
            addBtnCustomers.Dock = DockStyle.Left;
            addBtnCustomers.Location = new Point(0, 0);
            addBtnCustomers.Name = "addBtnCustomers";
            addBtnCustomers.Size = new Size(130, 74);
            addBtnCustomers.TabIndex = 0;
            addBtnCustomers.Text = "Add";
            addBtnCustomers.UseVisualStyleBackColor = true;
            addBtnCustomers.MouseClick += addBtnCustomersMouseClick;
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
            panel2.Controls.Add(addressControl);
            panel2.Controls.Add(textBoxFullNameCustomers);
            panel2.Controls.Add(textBoxIdCustomers);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(719, 682);
            panel2.TabIndex = 2;
            // 
            // addressControl
            // 
            addressControl.Apartament = "";
            addressControl.Building = "";
            addressControl.City = "";
            addressControl.Country = "";
            addressControl.Location = new Point(3, 163);
            addressControl.Name = "addressControl";
            addressControl.PostIndex = "";
            addressControl.Size = new Size(712, 204);
            addressControl.Street = "";
            addressControl.TabIndex = 6;
            // 
            // textBoxFullNameCustomers
            // 
            textBoxFullNameCustomers.Location = new Point(132, 130);
            textBoxFullNameCustomers.Name = "textBoxFullNameCustomers";
            textBoxFullNameCustomers.Size = new Size(583, 27);
            textBoxFullNameCustomers.TabIndex = 5;
            // 
            // textBoxIdCustomers
            // 
            textBoxIdCustomers.Location = new Point(132, 82);
            textBoxIdCustomers.Name = "textBoxIdCustomers";
            textBoxIdCustomers.ReadOnly = true;
            textBoxIdCustomers.Size = new Size(237, 27);
            textBoxIdCustomers.TabIndex = 4;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(20, 130);
            label4.Name = "label4";
            label4.Size = new Size(93, 27);
            label4.TabIndex = 2;
            label4.Text = "Full Name:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(20, 82);
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
        private ListBox listBoxCustomers;
        private Button removeBtnCustomers;
        private Button addBtnCustomers;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxIdCustomers;
        private TextBox textBoxFullNameCustomers;
        private ObjectOrientedPractics.View.Controls.AddressControl addressControl;
    }
}
