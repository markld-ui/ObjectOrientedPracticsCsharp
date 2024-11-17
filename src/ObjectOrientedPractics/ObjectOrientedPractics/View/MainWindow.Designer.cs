using ObjectOrientedPractices.View.Tabs;

namespace ObjectOrientedPractices
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            Model.Orders.PriorityOrder priorityOrder1 = new Model.Orders.PriorityOrder();
            Model.Orders.PriorityOrder priorityOrder2 = new Model.Orders.PriorityOrder();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            itemsTab1 = new ItemsTab();
            tabPage2 = new TabPage();
            customersTab1 = new CustomersTab();
            tabPage3 = new TabPage();
            cartsTab1 = new ObjectOrientedPractics.View.Tabs.CartsTab();
            tabPage4 = new TabPage();
            ordersTab1 = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            tabPage5 = new TabPage();
            priorityOrdersTab1 = new ObjectOrientedPractics.View.Tabs.PriorityOrdersTab();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1074, 791);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(itemsTab1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1066, 758);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Items";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(1060, 752);
            itemsTab1.TabIndex = 0;
            itemsTab1.Load += itemsTab1Load;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(customersTab1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1066, 758);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customers";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.newDiscount = null;
            customersTab1.Size = new Size(1060, 752);
            customersTab1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(cartsTab1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1066, 758);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cart";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.Customers = null;
            cartsTab1.Dock = DockStyle.Fill;
            cartsTab1.Items = null;
            cartsTab1.Location = new Point(3, 3);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(1060, 752);
            cartsTab1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(ordersTab1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1066, 758);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Orders";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            ordersTab1.Dock = DockStyle.Fill;
            ordersTab1.Location = new Point(3, 3);
            ordersTab1.Name = "ordersTab1";
            priorityOrder1.DiscountAmount = 0D;
            priorityOrder1.PriorityOrderDate = new DateTime(0L);
            priorityOrder1.PriorityOrderTime = null;
            priorityOrder1.Status = Model.Enums.OrderStatus.New;
            ordersTab1.PriorityOrder = priorityOrder1;
            ordersTab1.Size = new Size(1060, 752);
            ordersTab1.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(priorityOrdersTab1);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1066, 758);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Priority Orders";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // priorityOrdersTab1
            // 
            priorityOrdersTab1.Dock = DockStyle.Fill;
            priorityOrdersTab1.Location = new Point(3, 3);
            priorityOrdersTab1.Name = "priorityOrdersTab1";
            priorityOrder2.DiscountAmount = 0D;
            priorityOrder2.PriorityOrderDate = new DateTime(0L);
            priorityOrder2.PriorityOrderTime = null;
            priorityOrder2.Status = Model.Enums.OrderStatus.New;
            priorityOrdersTab1.PriorityOrder = priorityOrder2;
            priorityOrdersTab1.Size = new Size(1060, 752);
            priorityOrdersTab1.TabIndex = 0;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 803);
            Controls.Add(tabControl1);
            Name = "MainWindow";
            Text = "Object Oriented Practics";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ItemsTab itemsTab1;
        private CustomersTab customersTab1;
        private TabPage tabPage3;
        private ObjectOrientedPractics.View.Tabs.CartsTab cartsTab1;
        private TabPage tabPage4;
        private ObjectOrientedPractics.View.Tabs.OrdersTab ordersTab1;
        private TabPage tabPage5;
        private ObjectOrientedPractics.View.Tabs.PriorityOrdersTab priorityOrdersTab1;
    }
}
