namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            label6 = new Label();
            comboBoxTimePriority = new ComboBox();
            comboBoxStatusPriority = new ComboBox();
            textBoxIdPriority = new TextBox();
            textBoxCreatedPriority = new TextBox();
            label7 = new Label();
            listBoxItemsInPriority = new ListBox();
            label8 = new Label();
            textBoxAmountPriority = new TextBox();
            buttonClearOrderPriority = new Button();
            buttonRemoveItemPriority = new Button();
            buttonAddItemPriority = new Button();
            addressControlInPriority = new Controls.AddressControl();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(4, 34);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 0;
            label1.Text = "Selected Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 63);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 93);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Created:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 123);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 3;
            label4.Text = "Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(430, 34);
            label5.Name = "label5";
            label5.Size = new Size(141, 20);
            label5.TabIndex = 4;
            label5.Text = "Priority Options";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(430, 63);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 5;
            label6.Text = "Delivery Time:";
            // 
            // comboBoxTimePriority
            // 
            comboBoxTimePriority.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTimePriority.FormattingEnabled = true;
            comboBoxTimePriority.Location = new Point(539, 60);
            comboBoxTimePriority.Name = "comboBoxTimePriority";
            comboBoxTimePriority.Size = new Size(121, 28);
            comboBoxTimePriority.TabIndex = 6;
            comboBoxTimePriority.SelectedIndexChanged += ComboBoxTimePrioritySelectedIndexChanged;
            // 
            // comboBoxStatusPriority
            // 
            comboBoxStatusPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatusPriority.FormattingEnabled = true;
            comboBoxStatusPriority.Location = new Point(74, 120);
            comboBoxStatusPriority.Name = "comboBoxStatusPriority";
            comboBoxStatusPriority.Size = new Size(121, 28);
            comboBoxStatusPriority.TabIndex = 7;
            comboBoxStatusPriority.SelectedIndexChanged += ComboBoxStatusPrioritySelectedIndexChanged;
            // 
            // textBoxIdPriority
            // 
            textBoxIdPriority.Location = new Point(74, 60);
            textBoxIdPriority.Name = "textBoxIdPriority";
            textBoxIdPriority.ReadOnly = true;
            textBoxIdPriority.Size = new Size(121, 27);
            textBoxIdPriority.TabIndex = 8;
            // 
            // textBoxCreatedPriority
            // 
            textBoxCreatedPriority.Location = new Point(74, 90);
            textBoxCreatedPriority.Name = "textBoxCreatedPriority";
            textBoxCreatedPriority.ReadOnly = true;
            textBoxCreatedPriority.Size = new Size(121, 27);
            textBoxCreatedPriority.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(4, 365);
            label7.Name = "label7";
            label7.Size = new Size(97, 18);
            label7.TabIndex = 11;
            label7.Text = "Order Items";
            // 
            // listBoxItemsInPriority
            // 
            listBoxItemsInPriority.FormattingEnabled = true;
            listBoxItemsInPriority.Location = new Point(4, 386);
            listBoxItemsInPriority.Name = "listBoxItemsInPriority";
            listBoxItemsInPriority.Size = new Size(699, 184);
            listBoxItemsInPriority.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(617, 583);
            label8.Name = "label8";
            label8.Size = new Size(86, 25);
            label8.TabIndex = 13;
            label8.Text = "Amount";
            // 
            // textBoxAmountPriority
            // 
            textBoxAmountPriority.Location = new Point(603, 611);
            textBoxAmountPriority.Name = "textBoxAmountPriority";
            textBoxAmountPriority.ReadOnly = true;
            textBoxAmountPriority.Size = new Size(100, 27);
            textBoxAmountPriority.TabIndex = 14;
            // 
            // buttonClearOrderPriority
            // 
            buttonClearOrderPriority.Location = new Point(603, 641);
            buttonClearOrderPriority.Name = "buttonClearOrderPriority";
            buttonClearOrderPriority.Size = new Size(100, 54);
            buttonClearOrderPriority.TabIndex = 15;
            buttonClearOrderPriority.Text = "Clear Order";
            buttonClearOrderPriority.UseVisualStyleBackColor = true;
            buttonClearOrderPriority.Click += ButtonClearOrderPriorityClick;
            // 
            // buttonRemoveItemPriority
            // 
            buttonRemoveItemPriority.Location = new Point(104, 641);
            buttonRemoveItemPriority.Name = "buttonRemoveItemPriority";
            buttonRemoveItemPriority.Size = new Size(101, 54);
            buttonRemoveItemPriority.TabIndex = 16;
            buttonRemoveItemPriority.Text = "Remove Item";
            buttonRemoveItemPriority.UseVisualStyleBackColor = true;
            buttonRemoveItemPriority.Click += ButtonRemoveItemPriorityClick;
            // 
            // buttonAddItemPriority
            // 
            buttonAddItemPriority.Location = new Point(4, 641);
            buttonAddItemPriority.Name = "buttonAddItemPriority";
            buttonAddItemPriority.Size = new Size(94, 54);
            buttonAddItemPriority.TabIndex = 17;
            buttonAddItemPriority.Text = "Add Item";
            buttonAddItemPriority.UseVisualStyleBackColor = true;
            buttonAddItemPriority.Click += ButtonAddItemPriorityClick;
            // 
            // addressControlInPriority
            // 
            addressControlInPriority.Apartament = "";
            addressControlInPriority.Building = "";
            addressControlInPriority.City = "";
            addressControlInPriority.Country = "";
            addressControlInPriority.Location = new Point(4, 154);
            addressControlInPriority.Name = "addressControlInPriority";
            addressControlInPriority.PostIndex = "";
            addressControlInPriority.Size = new Size(699, 208);
            addressControlInPriority.Street = "";
            addressControlInPriority.TabIndex = 10;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonAddItemPriority);
            Controls.Add(buttonRemoveItemPriority);
            Controls.Add(buttonClearOrderPriority);
            Controls.Add(textBoxAmountPriority);
            Controls.Add(label8);
            Controls.Add(listBoxItemsInPriority);
            Controls.Add(label7);
            Controls.Add(addressControlInPriority);
            Controls.Add(textBoxCreatedPriority);
            Controls.Add(textBoxIdPriority);
            Controls.Add(comboBoxStatusPriority);
            Controls.Add(comboBoxTimePriority);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PriorityOrdersTab";
            Size = new Size(710, 735);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTimePriority;
        private System.Windows.Forms.ComboBox comboBoxStatusPriority;
        private System.Windows.Forms.TextBox textBoxIdPriority;
        private System.Windows.Forms.TextBox textBoxCreatedPriority;
        private ObjectOrientedPractics.View.Controls.AddressControl addressControlInPriority;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxItemsInPriority;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAmountPriority;
        private System.Windows.Forms.Button buttonClearOrderPriority;
        private System.Windows.Forms.Button buttonRemoveItemPriority;
        private System.Windows.Forms.Button buttonAddItemPriority;
    }
}
