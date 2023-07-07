namespace POS
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ProductNameTxt = new TextBox();
            ProductPriceTxt = new TextBox();
            ProductVatTxt = new TextBox();
            ProductDiscountTxt = new TextBox();
            ProductCreatedByTxt = new TextBox();
            ProductUpdatedByTxt = new TextBox();
            button7 = new Button();
            AddProductBtn = new Button();
            ProductCreatedDateTxt = new DateTimePicker();
            ProductUpdatedDateTxt = new DateTimePicker();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Location = new Point(12, 250);
            button6.Name = "button6";
            button6.Size = new Size(125, 29);
            button6.TabIndex = 23;
            button6.Text = "Sales Details";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(12, 206);
            button5.Name = "button5";
            button5.Size = new Size(125, 35);
            button5.TabIndex = 22;
            button5.Text = "Sales Summary";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 171);
            button4.Name = "button4";
            button4.Size = new Size(125, 29);
            button4.TabIndex = 21;
            button4.Text = "Category";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 131);
            button3.Name = "button3";
            button3.Size = new Size(125, 29);
            button3.TabIndex = 20;
            button3.Text = "Stock";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 90);
            button2.Name = "button2";
            button2.Size = new Size(125, 29);
            button2.TabIndex = 19;
            button2.Text = "Customer";
            button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(197, 36);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 24;
            label6.Text = "Product table";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(504, 94);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 25;
            label1.Text = "Name  :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(508, 127);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 26;
            label2.Text = "Price   :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(503, 160);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 27;
            label3.Text = "Vat %   :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(472, 193);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 28;
            label4.Text = "Discount ?   :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(476, 229);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 29;
            label5.Text = "Created By :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(460, 262);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 30;
            label7.Text = "Created Date :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(466, 292);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 31;
            label8.Text = "Updated By  :";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(450, 325);
            label9.Name = "label9";
            label9.Size = new Size(114, 20);
            label9.TabIndex = 32;
            label9.Text = "Updated Date  :";
            // 
            // ProductNameTxt
            // 
            ProductNameTxt.Location = new Point(570, 91);
            ProductNameTxt.Name = "ProductNameTxt";
            ProductNameTxt.Size = new Size(224, 27);
            ProductNameTxt.TabIndex = 33;
            // 
            // ProductPriceTxt
            // 
            ProductPriceTxt.Location = new Point(571, 124);
            ProductPriceTxt.Name = "ProductPriceTxt";
            ProductPriceTxt.Size = new Size(224, 27);
            ProductPriceTxt.TabIndex = 34;
            // 
            // ProductVatTxt
            // 
            ProductVatTxt.Location = new Point(570, 157);
            ProductVatTxt.Name = "ProductVatTxt";
            ProductVatTxt.Size = new Size(224, 27);
            ProductVatTxt.TabIndex = 35;
            ProductVatTxt.Visible = false;
            // 
            // ProductDiscountTxt
            // 
            ProductDiscountTxt.Location = new Point(570, 193);
            ProductDiscountTxt.Name = "ProductDiscountTxt";
            ProductDiscountTxt.Size = new Size(224, 27);
            ProductDiscountTxt.TabIndex = 36;
            // 
            // ProductCreatedByTxt
            // 
            ProductCreatedByTxt.Location = new Point(570, 226);
            ProductCreatedByTxt.Name = "ProductCreatedByTxt";
            ProductCreatedByTxt.Size = new Size(224, 27);
            ProductCreatedByTxt.TabIndex = 37;
            // 
            // ProductUpdatedByTxt
            // 
            ProductUpdatedByTxt.Location = new Point(570, 292);
            ProductUpdatedByTxt.Name = "ProductUpdatedByTxt";
            ProductUpdatedByTxt.Size = new Size(224, 27);
            ProductUpdatedByTxt.TabIndex = 39;
            // 
            // button7
            // 
            button7.Location = new Point(133, 378);
            button7.Name = "button7";
            button7.Size = new Size(125, 29);
            button7.TabIndex = 42;
            button7.Text = "Refresh";
            button7.UseVisualStyleBackColor = true;
            // 
            // AddProductBtn
            // 
            AddProductBtn.Location = new Point(609, 399);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(125, 29);
            AddProductBtn.TabIndex = 43;
            AddProductBtn.Text = "Add product";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // ProductCreatedDateTxt
            // 
            ProductCreatedDateTxt.Location = new Point(570, 259);
            ProductCreatedDateTxt.Name = "ProductCreatedDateTxt";
            ProductCreatedDateTxt.Size = new Size(250, 27);
            ProductCreatedDateTxt.TabIndex = 44;
            // 
            // ProductUpdatedDateTxt
            // 
            ProductUpdatedDateTxt.Location = new Point(571, 325);
            ProductUpdatedDateTxt.Name = "ProductUpdatedDateTxt";
            ProductUpdatedDateTxt.Size = new Size(250, 27);
            ProductUpdatedDateTxt.TabIndex = 45;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 450);
            Controls.Add(ProductUpdatedDateTxt);
            Controls.Add(ProductCreatedDateTxt);
            Controls.Add(AddProductBtn);
            Controls.Add(button7);
            Controls.Add(ProductUpdatedByTxt);
            Controls.Add(ProductCreatedByTxt);
            Controls.Add(ProductDiscountTxt);
            Controls.Add(ProductVatTxt);
            Controls.Add(ProductPriceTxt);
            Controls.Add(ProductNameTxt);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "ProductForm";
            Text = "ProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox ProductNameTxt;
        private TextBox ProductPriceTxt;
        private TextBox ProductVatTxt;
        private TextBox ProductDiscountTxt;
        private TextBox ProductCreatedByTxt;
        private TextBox ProductUpdatedByTxt;
        private Button button7;
        private Button AddProductBtn;
        private DateTimePicker ProductCreatedDateTxt;
        private DateTimePicker ProductUpdatedDateTxt;
    }
}