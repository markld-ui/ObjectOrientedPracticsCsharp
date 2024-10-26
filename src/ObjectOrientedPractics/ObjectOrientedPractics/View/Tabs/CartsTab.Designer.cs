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
            buttonClearCart = new Button();
            buttonCreateOrder = new Button();
            buttonRemoveItem = new Button();
            labelAmount = new Label();
            label4 = new Label();
            textBoxCart = new TextBox();
            label3 = new Label();
            comboBoxCustomerInCart = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            splitContainer1.Panel2.Controls.Add(buttonClearCart);
            splitContainer1.Panel2.Controls.Add(buttonCreateOrder);
            splitContainer1.Panel2.Controls.Add(buttonRemoveItem);
            splitContainer1.Panel2.Controls.Add(labelAmount);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(textBoxCart);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(comboBoxCustomerInCart);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(1104, 682);
            splitContainer1.SplitterDistance = 490;
            splitContainer1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(listBoxCartItems);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(490, 562);
            panel3.TabIndex = 4;
            // 
            // listBoxCartItems
            // 
            listBoxCartItems.Dock = DockStyle.Fill;
            listBoxCartItems.FormattingEnabled = true;
            listBoxCartItems.Location = new Point(0, 0);
            listBoxCartItems.Name = "listBoxCartItems";
            listBoxCartItems.Size = new Size(490, 562);
            listBoxCartItems.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonAddToCart);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 604);
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
            // buttonClearCart
            // 
            buttonClearCart.Location = new Point(445, 445);
            buttonClearCart.Name = "buttonClearCart";
            buttonClearCart.Size = new Size(129, 55);
            buttonClearCart.TabIndex = 9;
            buttonClearCart.Text = "Clear Cart";
            buttonClearCart.UseVisualStyleBackColor = true;
            buttonClearCart.MouseClick += buttonClearCartMouseClick;
            // 
            // buttonCreateOrder
            // 
            buttonCreateOrder.Location = new Point(14, 445);
            buttonCreateOrder.Name = "buttonCreateOrder";
            buttonCreateOrder.Size = new Size(129, 55);
            buttonCreateOrder.TabIndex = 8;
            buttonCreateOrder.Text = "Create Order";
            buttonCreateOrder.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveItem
            // 
            buttonRemoveItem.Location = new Point(291, 445);
            buttonRemoveItem.Name = "buttonRemoveItem";
            buttonRemoveItem.Size = new Size(129, 55);
            buttonRemoveItem.TabIndex = 7;
            buttonRemoveItem.Text = "Remove Item";
            buttonRemoveItem.UseVisualStyleBackColor = true;
            // 
            // labelAmount
            // 
            labelAmount.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            labelAmount.Location = new Point(416, 403);
            labelAmount.Name = "labelAmount";
            labelAmount.RightToLeft = RightToLeft.Yes;
            labelAmount.Size = new Size(158, 39);
            labelAmount.TabIndex = 5;
            labelAmount.Text = "0.0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(499, 370);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 4;
            label4.Text = "Amount:";
            // 
            // textBoxCart
            // 
            textBoxCart.Location = new Point(14, 140);
            textBoxCart.Multiline = true;
            textBoxCart.Name = "textBoxCart";
            textBoxCart.Size = new Size(560, 214);
            textBoxCart.TabIndex = 3;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(14, 109);
            label3.Name = "label3";
            label3.Size = new Size(48, 28);
            label3.TabIndex = 2;
            label3.Text = "Cart:";
            // 
            // comboBoxCustomerInCart
            // 
            comboBoxCustomerInCart.FormattingEnabled = true;
            comboBoxCustomerInCart.Location = new Point(110, 42);
            comboBoxCustomerInCart.Name = "comboBoxCustomerInCart";
            comboBoxCustomerInCart.Size = new Size(464, 28);
            comboBoxCustomerInCart.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(14, 42);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 0;
            label2.Text = "Customer:";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "CartsTab";
            Size = new Size(1104, 682);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label labelAmount;
        private Label label4;
        private TextBox textBoxCart;
        private Label label3;
        private ComboBox comboBoxCustomerInCart;
        private Button buttonCreateOrder;
        private Button buttonRemoveItem;
        private Button buttonClearCart;
    }
}
