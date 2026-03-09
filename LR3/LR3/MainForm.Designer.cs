namespace LR3
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CategoriesListBox = new System.Windows.Forms.ListBox();
            this.DrugsComboBox = new System.Windows.Forms.ComboBox();
            this.DrugPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.ProviderLabel = new System.Windows.Forms.Label();
            this.OrderButton = new System.Windows.Forms.Button();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DrugPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriesListBox
            // 
            this.CategoriesListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.CategoriesListBox.FormattingEnabled = true;
            this.CategoriesListBox.Location = new System.Drawing.Point(0, 0);
            this.CategoriesListBox.Name = "CategoriesListBox";
            this.CategoriesListBox.Size = new System.Drawing.Size(213, 450);
            this.CategoriesListBox.TabIndex = 0;
            this.CategoriesListBox.SelectedIndexChanged += new System.EventHandler(this.CategoriesListBox_SelectedIndexChanged);
            // 
            // DrugsComboBox
            // 
            this.DrugsComboBox.FormattingEnabled = true;
            this.DrugsComboBox.Location = new System.Drawing.Point(219, 12);
            this.DrugsComboBox.Name = "DrugsComboBox";
            this.DrugsComboBox.Size = new System.Drawing.Size(192, 21);
            this.DrugsComboBox.TabIndex = 1;
            this.DrugsComboBox.SelectedIndexChanged += new System.EventHandler(this.DrugsComboBox_SelectedIndexChanged);
            // 
            // DrugPictureBox
            // 
            this.DrugPictureBox.Location = new System.Drawing.Point(219, 53);
            this.DrugPictureBox.Name = "DrugPictureBox";
            this.DrugPictureBox.Size = new System.Drawing.Size(569, 220);
            this.DrugPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DrugPictureBox.TabIndex = 2;
            this.DrugPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Цена за штуку";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Изготовитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Годен до";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Поставщик";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(348, 280);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(57, 13);
            this.PriceLabel.TabIndex = 7;
            this.PriceLabel.Text = "PriceLabel";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(348, 306);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(96, 13);
            this.ManufacturerLabel.TabIndex = 8;
            this.ManufacturerLabel.Text = "ManufacturerLabel";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(348, 334);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(56, 13);
            this.DateLabel.TabIndex = 9;
            this.DateLabel.Text = "DateLabel";
            // 
            // ProviderLabel
            // 
            this.ProviderLabel.AutoSize = true;
            this.ProviderLabel.Location = new System.Drawing.Point(348, 360);
            this.ProviderLabel.Name = "ProviderLabel";
            this.ProviderLabel.Size = new System.Drawing.Size(72, 13);
            this.ProviderLabel.TabIndex = 10;
            this.ProviderLabel.Text = "ProviderLabel";
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(583, 379);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(205, 59);
            this.OrderButton.TabIndex = 11;
            this.OrderButton.Text = "Заказать";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(583, 344);
            this.QuantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(205, 20);
            this.QuantityNumericUpDown.TabIndex = 12;
            this.QuantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuantityNumericUpDown);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.ProviderLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ManufacturerLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrugPictureBox);
            this.Controls.Add(this.DrugsComboBox);
            this.Controls.Add(this.CategoriesListBox);
            this.Name = "MainForm";
            this.Text = "Кувалдаев_вариант4";

            ((System.ComponentModel.ISupportInitialize)(this.DrugPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CategoriesListBox;
        private System.Windows.Forms.ComboBox DrugsComboBox;
        private System.Windows.Forms.PictureBox DrugPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label ProviderLabel;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
    }
}

