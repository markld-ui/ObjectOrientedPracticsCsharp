namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            panel1 = new Panel();
            labelDeliveryTitle = new Label();
            labelPostIndex = new Label();
            labelCountry = new Label();
            labelStreet = new Label();
            labelBuilding = new Label();
            labelCity = new Label();
            labelApartament = new Label();
            textBoxPostIndex = new TextBox();
            textBoxCountry = new TextBox();
            textBoxStreet = new TextBox();
            textBoxBuilding = new TextBox();
            textBoxCity = new TextBox();
            textBoxApartament = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxApartament);
            panel1.Controls.Add(textBoxCity);
            panel1.Controls.Add(textBoxBuilding);
            panel1.Controls.Add(textBoxStreet);
            panel1.Controls.Add(textBoxCountry);
            panel1.Controls.Add(textBoxPostIndex);
            panel1.Controls.Add(labelApartament);
            panel1.Controls.Add(labelCity);
            panel1.Controls.Add(labelBuilding);
            panel1.Controls.Add(labelStreet);
            panel1.Controls.Add(labelCountry);
            panel1.Controls.Add(labelPostIndex);
            panel1.Controls.Add(labelDeliveryTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(710, 217);
            panel1.TabIndex = 0;
            // 
            // labelDeliveryTitle
            // 
            labelDeliveryTitle.AutoSize = true;
            labelDeliveryTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            labelDeliveryTitle.Location = new Point(12, 10);
            labelDeliveryTitle.Name = "labelDeliveryTitle";
            labelDeliveryTitle.Size = new Size(148, 23);
            labelDeliveryTitle.TabIndex = 0;
            labelDeliveryTitle.Text = "Delivery Address:";
            // 
            // labelPostIndex
            // 
            labelPostIndex.Font = new Font("Segoe UI", 10F);
            labelPostIndex.Location = new Point(12, 50);
            labelPostIndex.Name = "labelPostIndex";
            labelPostIndex.Size = new Size(94, 27);
            labelPostIndex.TabIndex = 1;
            labelPostIndex.Text = "Post Index:";
            // 
            // labelCountry
            // 
            labelCountry.Font = new Font("Segoe UI", 10F);
            labelCountry.Location = new Point(13, 91);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(93, 27);
            labelCountry.TabIndex = 2;
            labelCountry.Text = "Country:";
            // 
            // labelStreet
            // 
            labelStreet.Font = new Font("Segoe UI", 10F);
            labelStreet.Location = new Point(12, 130);
            labelStreet.Name = "labelStreet";
            labelStreet.Size = new Size(94, 27);
            labelStreet.TabIndex = 3;
            labelStreet.Text = "Street:";
            // 
            // labelBuilding
            // 
            labelBuilding.Font = new Font("Segoe UI", 10F);
            labelBuilding.Location = new Point(12, 173);
            labelBuilding.Name = "labelBuilding";
            labelBuilding.Size = new Size(94, 27);
            labelBuilding.TabIndex = 4;
            labelBuilding.Text = "Building:";
            // 
            // labelCity
            // 
            labelCity.Font = new Font("Segoe UI", 10F);
            labelCity.Location = new Point(408, 91);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(49, 27);
            labelCity.TabIndex = 5;
            labelCity.Text = "City:";
            // 
            // labelApartament
            // 
            labelApartament.Font = new Font("Segoe UI", 10F);
            labelApartament.Location = new Point(288, 173);
            labelApartament.Name = "labelApartament";
            labelApartament.Size = new Size(105, 27);
            labelApartament.TabIndex = 6;
            labelApartament.Text = "Apartament:";
            // 
            // textBoxPostIndex
            // 
            textBoxPostIndex.Location = new Point(131, 50);
            textBoxPostIndex.Name = "textBoxPostIndex";
            textBoxPostIndex.Size = new Size(177, 27);
            textBoxPostIndex.TabIndex = 7;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(131, 91);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(262, 27);
            textBoxCountry.TabIndex = 8;
            // 
            // textBoxStreet
            // 
            textBoxStreet.Location = new Point(131, 130);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(562, 27);
            textBoxStreet.TabIndex = 9;
            // 
            // textBoxBuilding
            // 
            textBoxBuilding.Location = new Point(131, 173);
            textBoxBuilding.Name = "textBoxBuilding";
            textBoxBuilding.Size = new Size(99, 27);
            textBoxBuilding.TabIndex = 10;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(463, 91);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(230, 27);
            textBoxCity.TabIndex = 11;
            // 
            // textBoxApartament
            // 
            textBoxApartament.Location = new Point(408, 172);
            textBoxApartament.Name = "textBoxApartament";
            textBoxApartament.Size = new Size(107, 27);
            textBoxApartament.TabIndex = 12;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AddressControl";
            Size = new Size(710, 217);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelPostIndex;
        private Label labelDeliveryTitle;
        private TextBox textBoxStreet;
        private TextBox textBoxCountry;
        private TextBox textBoxPostIndex;
        private Label labelApartament;
        private Label labelCity;
        private Label labelBuilding;
        private Label labelStreet;
        private Label labelCountry;
        private TextBox textBoxApartament;
        private TextBox textBoxCity;
        private TextBox textBoxBuilding;
    }
}
