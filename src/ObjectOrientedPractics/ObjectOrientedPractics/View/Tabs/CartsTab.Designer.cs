namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            panel3 = new Panel();
            listBoxCartItems = new ListBox();
            panel2 = new Panel();
            buttonAddToCart = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            textBoxTotalPrice = new TextBox();
            textBoxDiscountAmount = new TextBox();
            label7 = new Label();
            checkedListBoxDiscounts = new CheckedListBox();
            label6 = new Label();
            label5 = new Label();
            panel5 = new Panel();
            label2 = new Label();
            comboBoxCustomerInCart = new ComboBox();
            listBoxCartOrder = new ListBox();
            label3 = new Label();
            label4 = new Label();
            textBoxAmount = new TextBox();
            panel4 = new Panel();
            buttonCreateOrder = new Button();
            buttonRemoveItem = new Button();
            buttonClearCart = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel6);
            splitContainer1.Panel2.Controls.Add(panel5);
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Size = new Size(1104, 724);
            splitContainer1.SplitterDistance = 490;
            splitContainer1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(listBoxCartItems);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(490, 604);
            panel3.TabIndex = 4;
            // 
            // listBoxCartItems
            // 
            listBoxCartItems.Dock = DockStyle.Fill;
            listBoxCartItems.FormattingEnabled = true;
            listBoxCartItems.Location = new Point(0, 0);
            listBoxCartItems.Name = "listBoxCartItems";
            listBoxCartItems.Size = new Size(490, 604);
            listBoxCartItems.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonAddToCart);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 646);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 78);
            panel2.TabIndex = 3;
            // 
            // buttonAddToCart
            // 
            buttonAddToCart.Location = new Point(14, 6);
            buttonAddToCart.Name = "buttonAddToCart";
            buttonAddToCart.Size = new Size(134, 57);
            buttonAddToCart.TabIndex = 0;
            buttonAddToCart.Text = "Add To Cart";
            buttonAddToCart.UseVisualStyleBackColor = true;
            buttonAddToCart.Click += buttonAddToCartClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 42);
            panel1.TabIndex = 2;
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
            // panel6
            // 
            panel6.Controls.Add(textBoxTotalPrice);
            panel6.Controls.Add(textBoxDiscountAmount);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(checkedListBoxDiscounts);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label5);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 404);
            panel6.Name = "panel6";
            panel6.Size = new Size(610, 320);
            panel6.TabIndex = 20;
            // 
            // textBoxTotalPrice
            // 
            textBoxTotalPrice.BorderStyle = BorderStyle.None;
            textBoxTotalPrice.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            textBoxTotalPrice.ForeColor = SystemColors.WindowText;
            textBoxTotalPrice.Location = new Point(443, 289);
            textBoxTotalPrice.Name = "textBoxTotalPrice";
            textBoxTotalPrice.ReadOnly = true;
            textBoxTotalPrice.Size = new Size(125, 23);
            textBoxTotalPrice.TabIndex = 17;
            textBoxTotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxDiscountAmount
            // 
            textBoxDiscountAmount.BorderStyle = BorderStyle.None;
            textBoxDiscountAmount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            textBoxDiscountAmount.ForeColor = SystemColors.WindowText;
            textBoxDiscountAmount.Location = new Point(443, 46);
            textBoxDiscountAmount.Name = "textBoxDiscountAmount";
            textBoxDiscountAmount.ReadOnly = true;
            textBoxDiscountAmount.Size = new Size(125, 23);
            textBoxDiscountAmount.TabIndex = 16;
            textBoxDiscountAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label7.Location = new Point(505, 260);
            label7.Name = "label7";
            label7.Size = new Size(63, 28);
            label7.TabIndex = 15;
            label7.Text = "Total:";
            // 
            // checkedListBoxDiscounts
            // 
            checkedListBoxDiscounts.BackColor = SystemColors.Control;
            checkedListBoxDiscounts.BorderStyle = BorderStyle.None;
            checkedListBoxDiscounts.FormattingEnabled = true;
            checkedListBoxDiscounts.Location = new Point(8, 46);
            checkedListBoxDiscounts.Name = "checkedListBoxDiscounts";
            checkedListBoxDiscounts.Size = new Size(312, 242);
            checkedListBoxDiscounts.TabIndex = 14;
            checkedListBoxDiscounts.ItemCheck += checkedListBoxDiscountsItemCheck;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label6.Location = new Point(393, 15);
            label6.Name = "label6";
            label6.Size = new Size(175, 28);
            label6.TabIndex = 13;
            label6.Text = "Discount Amount:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.Location = new Point(8, 15);
            label5.Name = "label5";
            label5.Size = new Size(105, 28);
            label5.TabIndex = 12;
            label5.Text = "Discounts:";
            // 
            // panel5
            // 
            panel5.Controls.Add(label2);
            panel5.Controls.Add(comboBoxCustomerInCart);
            panel5.Controls.Add(listBoxCartOrder);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(textBoxAmount);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(610, 350);
            panel5.TabIndex = 19;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 4);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 0;
            label2.Text = "Customer:";
            // 
            // comboBoxCustomerInCart
            // 
            comboBoxCustomerInCart.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCustomerInCart.FormattingEnabled = true;
            comboBoxCustomerInCart.Location = new Point(132, 3);
            comboBoxCustomerInCart.Name = "comboBoxCustomerInCart";
            comboBoxCustomerInCart.Size = new Size(464, 28);
            comboBoxCustomerInCart.TabIndex = 1;
            comboBoxCustomerInCart.SelectedIndexChanged += comboBoxCustomerInCartSelectedIndexChanged;
            // 
            // listBoxCartOrder
            // 
            listBoxCartOrder.FormattingEnabled = true;
            listBoxCartOrder.Location = new Point(11, 64);
            listBoxCartOrder.Name = "listBoxCartOrder";
            listBoxCartOrder.Size = new Size(560, 224);
            listBoxCartOrder.TabIndex = 10;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(11, 33);
            label3.Name = "label3";
            label3.Size = new Size(48, 28);
            label3.TabIndex = 2;
            label3.Text = "Cart:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(496, 294);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 4;
            label4.Text = "Amount:";
            // 
            // textBoxAmount
            // 
            textBoxAmount.BorderStyle = BorderStyle.None;
            textBoxAmount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            textBoxAmount.Location = new Point(446, 320);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.ReadOnly = true;
            textBoxAmount.Size = new Size(125, 23);
            textBoxAmount.TabIndex = 11;
            textBoxAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // panel4
            // 
            panel4.Controls.Add(buttonCreateOrder);
            panel4.Controls.Add(buttonRemoveItem);
            panel4.Controls.Add(buttonClearCart);
            panel4.Location = new Point(0, 349);
            panel4.Name = "panel4";
            panel4.Size = new Size(610, 56);
            panel4.TabIndex = 18;
            // 
            // buttonCreateOrder
            // 
            buttonCreateOrder.Location = new Point(0, 0);
            buttonCreateOrder.Name = "buttonCreateOrder";
            buttonCreateOrder.Size = new Size(129, 55);
            buttonCreateOrder.TabIndex = 8;
            buttonCreateOrder.Text = "Create Order";
            buttonCreateOrder.UseVisualStyleBackColor = true;
            buttonCreateOrder.Click += buttonCreateOrderClick;
            // 
            // buttonRemoveItem
            // 
            buttonRemoveItem.Location = new Point(277, 0);
            buttonRemoveItem.Name = "buttonRemoveItem";
            buttonRemoveItem.Size = new Size(129, 55);
            buttonRemoveItem.TabIndex = 7;
            buttonRemoveItem.Text = "Remove Item";
            buttonRemoveItem.UseVisualStyleBackColor = true;
            buttonRemoveItem.Click += buttonRemoveItemClick;
            // 
            // buttonClearCart
            // 
            buttonClearCart.Location = new Point(431, 0);
            buttonClearCart.Name = "buttonClearCart";
            buttonClearCart.Size = new Size(129, 55);
            buttonClearCart.TabIndex = 9;
            buttonClearCart.Text = "Clear Cart";
            buttonClearCart.UseVisualStyleBackColor = true;
            buttonClearCart.MouseClick += buttonClearCartMouseClick;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "CartsTab";
            Size = new Size(1104, 724);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private ListBox listBoxCartItems;
        private Panel panel2;
        private Button buttonAddToCart;
        private Label label2;
        private Label label4;
        private Label label3;
        private ComboBox comboBoxCustomerInCart;
        private Button buttonCreateOrder;
        private Button buttonRemoveItem;
        private Button buttonClearCart;
        private ListBox listBoxCartOrder;
        private TextBox textBoxAmount;
        private TextBox textBoxDiscountAmount;
        private Label label7;
        private CheckedListBox checkedListBoxDiscounts;
        private Label label6;
        private Label label5;
        private TextBox textBoxTotalPrice;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
    }
}
