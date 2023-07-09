namespace POS
{
    partial class CategoryForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            AddCategoryBtn = new Button();
            label6 = new Label();
            CatNameTxt = new TextBox();
            CatCreatedByTxt = new TextBox();
            CatUpdatedByTxt = new TextBox();
            CatCreatedDate = new DateTimePicker();
            CatUpdatedDate = new DateTimePicker();
            CategoryDatatbl = new DataGridView();
            IsDeletedchek = new CheckBox();
            CatDescriptionTxt = new TextBox();
            label7 = new Label();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)CategoryDatatbl).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(476, 93);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(467, 175);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Created By";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(466, 199);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "Created Date";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(463, 223);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 3;
            label4.Text = "Updated By";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(462, 247);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 4;
            label5.Text = "Updated Date";
            // 
            // button1
            // 
            button1.Location = new Point(379, 41);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(78, 22);
            button1.TabIndex = 5;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(10, 82);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(109, 22);
            button2.TabIndex = 6;
            button2.Text = "Product";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(10, 112);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(109, 22);
            button3.TabIndex = 7;
            button3.Text = "Stock";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(10, 142);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(109, 22);
            button4.TabIndex = 8;
            button4.Text = "Customer";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(10, 169);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(109, 26);
            button5.TabIndex = 9;
            button5.Text = "Sales Summary";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(10, 202);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(109, 22);
            button6.TabIndex = 10;
            button6.Text = "Sales Details";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // AddCategoryBtn
            // 
            AddCategoryBtn.Location = new Point(546, 321);
            AddCategoryBtn.Margin = new Padding(3, 2, 3, 2);
            AddCategoryBtn.Name = "AddCategoryBtn";
            AddCategoryBtn.Size = new Size(131, 22);
            AddCategoryBtn.TabIndex = 11;
            AddCategoryBtn.Text = "Add Category";
            AddCategoryBtn.UseVisualStyleBackColor = true;
            AddCategoryBtn.Click += button7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(143, 41);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 12;
            label6.Text = "Category table";
            label6.Click += label6_Click;
            // 
            // CatNameTxt
            // 
            CatNameTxt.Location = new Point(567, 85);
            CatNameTxt.Margin = new Padding(3, 2, 3, 2);
            CatNameTxt.Name = "CatNameTxt";
            CatNameTxt.Size = new Size(128, 23);
            CatNameTxt.TabIndex = 13;
            // 
            // CatCreatedByTxt
            // 
            CatCreatedByTxt.Location = new Point(567, 166);
            CatCreatedByTxt.Margin = new Padding(3, 2, 3, 2);
            CatCreatedByTxt.Name = "CatCreatedByTxt";
            CatCreatedByTxt.Size = new Size(128, 23);
            CatCreatedByTxt.TabIndex = 14;
            // 
            // CatUpdatedByTxt
            // 
            CatUpdatedByTxt.Location = new Point(567, 220);
            CatUpdatedByTxt.Margin = new Padding(3, 2, 3, 2);
            CatUpdatedByTxt.Name = "CatUpdatedByTxt";
            CatUpdatedByTxt.Size = new Size(128, 23);
            CatUpdatedByTxt.TabIndex = 16;
            // 
            // CatCreatedDate
            // 
            CatCreatedDate.Location = new Point(567, 193);
            CatCreatedDate.Margin = new Padding(3, 2, 3, 2);
            CatCreatedDate.Name = "CatCreatedDate";
            CatCreatedDate.Size = new Size(214, 23);
            CatCreatedDate.TabIndex = 18;
            // 
            // CatUpdatedDate
            // 
            CatUpdatedDate.Location = new Point(567, 247);
            CatUpdatedDate.Margin = new Padding(3, 2, 3, 2);
            CatUpdatedDate.Name = "CatUpdatedDate";
            CatUpdatedDate.Size = new Size(214, 23);
            CatUpdatedDate.TabIndex = 19;
            // 
            // CategoryDatatbl
            // 
            CategoryDatatbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryDatatbl.Location = new Point(125, 66);
            CategoryDatatbl.Margin = new Padding(3, 2, 3, 2);
            CategoryDatatbl.Name = "CategoryDatatbl";
            CategoryDatatbl.RowHeadersWidth = 51;
            CategoryDatatbl.RowTemplate.Height = 29;
            CategoryDatatbl.Size = new Size(332, 277);
            CategoryDatatbl.TabIndex = 20;
            // 
            // IsDeletedchek
            // 
            IsDeletedchek.AutoSize = true;
            IsDeletedchek.Location = new Point(567, 287);
            IsDeletedchek.Name = "IsDeletedchek";
            IsDeletedchek.Size = new Size(74, 19);
            IsDeletedchek.TabIndex = 21;
            IsDeletedchek.Text = "IsDeleted";
            IsDeletedchek.UseVisualStyleBackColor = true;
            // 
            // CatDescriptionTxt
            // 
            CatDescriptionTxt.Location = new Point(567, 126);
            CatDescriptionTxt.Margin = new Padding(3, 2, 3, 2);
            CatDescriptionTxt.Name = "CatDescriptionTxt";
            CatDescriptionTxt.Size = new Size(128, 23);
            CatDescriptionTxt.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(466, 134);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 23;
            label7.Text = "Description";
            // 
            // button8
            // 
            button8.Location = new Point(255, 40);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(104, 22);
            button8.TabIndex = 24;
            button8.Text = "Show Category";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 397);
            Controls.Add(button8);
            Controls.Add(label7);
            Controls.Add(CatDescriptionTxt);
            Controls.Add(IsDeletedchek);
            Controls.Add(CategoryDatatbl);
            Controls.Add(CatUpdatedDate);
            Controls.Add(CatCreatedDate);
            Controls.Add(CatUpdatedByTxt);
            Controls.Add(CatCreatedByTxt);
            Controls.Add(CatNameTxt);
            Controls.Add(label6);
            Controls.Add(AddCategoryBtn);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CategoryForm";
            Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)CategoryDatatbl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button AddCategoryBtn;
        private Label label6;
        private TextBox CatNameTxt;
        private TextBox CatCreatedByTxt;
        private TextBox textBox3;
        private TextBox CatUpdatedByTxt;
        private DateTimePicker CatCreatedDate;
        private DateTimePicker CatUpdatedDate;
        private DataGridView CategoryDatatbl;
        private CheckBox IsDeletedchek;
        private TextBox CatDescriptionTxt;
        private Label label7;
        private Button button8;
    }
}