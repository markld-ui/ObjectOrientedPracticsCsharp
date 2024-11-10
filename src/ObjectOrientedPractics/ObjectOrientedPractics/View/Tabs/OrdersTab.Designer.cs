namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxIdOrder = new TextBox();
            textBoxCreatedOrder = new TextBox();
            comboBoxStatusOrder = new ComboBox();
            label6 = new Label();
            listBoxItemsInOrder = new ListBox();
            label7 = new Label();
            textBoxAmountInOrder = new TextBox();
            dataGridViewOrder = new DataGridView();
            addressControlInOrder = new Controls.AddressControl();
            dataPanelOrder = new Panel();
            comboBoxTimeOrder = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            textBoxTotalOrder = new TextBox();
            label10 = new Label();
            Id = new DataGridViewTextBoxColumn();
            Created = new DataGridViewTextBoxColumn();
            OrderStatus = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).BeginInit();
            dataPanelOrder.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Orders";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 1;
            label2.Text = "Selected Order:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 32);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 2;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 58);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 3;
            label4.Text = "Created:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 91);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 4;
            label5.Text = "Status:";
            // 
            // textBoxIdOrder
            // 
            textBoxIdOrder.Location = new Point(74, 25);
            textBoxIdOrder.Name = "textBoxIdOrder";
            textBoxIdOrder.ReadOnly = true;
            textBoxIdOrder.Size = new Size(121, 27);
            textBoxIdOrder.TabIndex = 5;
            // 
            // textBoxCreatedOrder
            // 
            textBoxCreatedOrder.Location = new Point(74, 55);
            textBoxCreatedOrder.Name = "textBoxCreatedOrder";
            textBoxCreatedOrder.ReadOnly = true;
            textBoxCreatedOrder.Size = new Size(121, 27);
            textBoxCreatedOrder.TabIndex = 6;
            // 
            // comboBoxStatusOrder
            // 
            comboBoxStatusOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatusOrder.FormattingEnabled = true;
            comboBoxStatusOrder.Location = new Point(74, 88);
            comboBoxStatusOrder.Name = "comboBoxStatusOrder";
            comboBoxStatusOrder.Size = new Size(121, 28);
            comboBoxStatusOrder.TabIndex = 7;
            comboBoxStatusOrder.SelectedIndexChanged += comboBoxStatusOrderSelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(4, 351);
            label6.Name = "label6";
            label6.Size = new Size(119, 24);
            label6.TabIndex = 9;
            label6.Text = "Order Items";
            // 
            // listBoxItemsInOrder
            // 
            listBoxItemsInOrder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBoxItemsInOrder.FormattingEnabled = true;
            listBoxItemsInOrder.Location = new Point(0, 378);
            listBoxItemsInOrder.Name = "listBoxItemsInOrder";
            listBoxItemsInOrder.Size = new Size(556, 184);
            listBoxItemsInOrder.TabIndex = 10;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(478, 568);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 11;
            label7.Text = "Amount:";
            // 
            // textBoxAmountInOrder
            // 
            textBoxAmountInOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxAmountInOrder.Location = new Point(456, 591);
            textBoxAmountInOrder.Name = "textBoxAmountInOrder";
            textBoxAmountInOrder.ReadOnly = true;
            textBoxAmountInOrder.Size = new Size(100, 27);
            textBoxAmountInOrder.TabIndex = 12;
            // 
            // dataGridViewOrder
            // 
            dataGridViewOrder.AllowUserToAddRows = false;
            dataGridViewOrder.AllowUserToResizeRows = false;
            dataGridViewOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrder.Columns.AddRange(new DataGridViewColumn[] { Id, Created, OrderStatus, Customer, Address, Price, Total });
            dataGridViewOrder.Location = new Point(0, 24);
            dataGridViewOrder.MultiSelect = false;
            dataGridViewOrder.Name = "dataGridViewOrder";
            dataGridViewOrder.RowHeadersVisible = false;
            dataGridViewOrder.RowHeadersWidth = 51;
            dataGridViewOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrder.Size = new Size(535, 538);
            dataGridViewOrder.TabIndex = 13;
            dataGridViewOrder.CellClick += dataGridViewOrderCellClick;
            // 
            // addressControlInOrder
            // 
            addressControlInOrder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressControlInOrder.Apartament = "";
            addressControlInOrder.Building = "";
            addressControlInOrder.City = "";
            addressControlInOrder.Country = "";
            addressControlInOrder.Location = new Point(4, 122);
            addressControlInOrder.Name = "addressControlInOrder";
            addressControlInOrder.PostIndex = "";
            addressControlInOrder.Size = new Size(552, 210);
            addressControlInOrder.Street = "";
            addressControlInOrder.TabIndex = 8;
            // 
            // dataPanelOrder
            // 
            dataPanelOrder.Controls.Add(comboBoxTimeOrder);
            dataPanelOrder.Controls.Add(label8);
            dataPanelOrder.Controls.Add(label9);
            dataPanelOrder.Location = new Point(215, 3);
            dataPanelOrder.Name = "dataPanelOrder";
            dataPanelOrder.Size = new Size(233, 100);
            dataPanelOrder.TabIndex = 14;
            // 
            // comboBoxTimeOrder
            // 
            comboBoxTimeOrder.FormattingEnabled = true;
            comboBoxTimeOrder.Location = new Point(112, 26);
            comboBoxTimeOrder.Name = "comboBoxTimeOrder";
            comboBoxTimeOrder.Size = new Size(121, 28);
            comboBoxTimeOrder.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 29);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 8;
            label8.Text = "Delivery Time:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(141, 20);
            label9.TabIndex = 7;
            label9.Text = "Priority Options";
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1104, 682);
            panel1.TabIndex = 15;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(dataGridViewOrder);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(textBoxTotalOrder);
            splitContainer1.Panel2.Controls.Add(label10);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(textBoxAmountInOrder);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(dataPanelOrder);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(listBoxItemsInOrder);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(addressControlInOrder);
            splitContainer1.Panel2.Controls.Add(textBoxIdOrder);
            splitContainer1.Panel2.Controls.Add(textBoxCreatedOrder);
            splitContainer1.Panel2.Controls.Add(comboBoxStatusOrder);
            splitContainer1.Size = new Size(1104, 682);
            splitContainer1.SplitterDistance = 537;
            splitContainer1.TabIndex = 0;
            // 
            // textBoxTotalOrder
            // 
            textBoxTotalOrder.Location = new Point(314, 591);
            textBoxTotalOrder.Name = "textBoxTotalOrder";
            textBoxTotalOrder.ReadOnly = true;
            textBoxTotalOrder.Size = new Size(100, 27);
            textBoxTotalOrder.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(357, 568);
            label10.Name = "label10";
            label10.Size = new Size(57, 20);
            label10.TabIndex = 15;
            label10.Text = "Total:";
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.SortMode = DataGridViewColumnSortMode.NotSortable;
            Id.Width = 125;
            // 
            // Created
            // 
            Created.HeaderText = "Created";
            Created.MinimumWidth = 6;
            Created.Name = "Created";
            Created.ReadOnly = true;
            Created.SortMode = DataGridViewColumnSortMode.NotSortable;
            Created.Width = 125;
            // 
            // OrderStatus
            // 
            OrderStatus.HeaderText = "Order Status";
            OrderStatus.MinimumWidth = 6;
            OrderStatus.Name = "OrderStatus";
            OrderStatus.ReadOnly = true;
            OrderStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            OrderStatus.Width = 125;
            // 
            // Customer
            // 
            Customer.HeaderText = "Customer Fullname";
            Customer.MinimumWidth = 6;
            Customer.Name = "Customer";
            Customer.ReadOnly = true;
            Customer.SortMode = DataGridViewColumnSortMode.NotSortable;
            Customer.Width = 125;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.SortMode = DataGridViewColumnSortMode.NotSortable;
            Address.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.SortMode = DataGridViewColumnSortMode.NotSortable;
            Price.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.SortMode = DataGridViewColumnSortMode.NotSortable;
            Total.Width = 125;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "OrdersTab";
            Size = new Size(1104, 682);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).EndInit();
            dataPanelOrder.ResumeLayout(false);
            dataPanelOrder.PerformLayout();
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIdOrder;
        private System.Windows.Forms.TextBox textBoxCreatedOrder;
        private System.Windows.Forms.ComboBox comboBoxStatusOrder;
        private ObjectOrientedPractics.View.Controls.AddressControl addressControlInOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxItemsInOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAmountInOrder;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Panel dataPanelOrder;
        private System.Windows.Forms.ComboBox comboBoxTimeOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxTotalOrder;
        private System.Windows.Forms.Label label10;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Created;
        private DataGridViewTextBoxColumn OrderStatus;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Total;
    }
}
