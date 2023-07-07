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
            button7 = new Button();
            label6 = new Label();
            CatNameTxt = new TextBox();
            CatCreatedByTxt = new TextBox();
            CatUpdatedByTxt = new TextBox();
            CatCreatedDate = new DateTimePicker();
            CatUpdatedDate = new DateTimePicker();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(528, 113);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(528, 154);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "Created By";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(528, 199);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Created Date";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(528, 236);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 3;
            label4.Text = "Updated By";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(528, 278);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 4;
            label5.Text = "Updated Date";
            // 
            // button1
            // 
            button1.Location = new Point(433, 55);
            button1.Name = "button1";
            button1.Size = new Size(76, 29);
            button1.TabIndex = 5;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 109);
            button2.Name = "button2";
            button2.Size = new Size(125, 29);
            button2.TabIndex = 6;
            button2.Text = "Product";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 150);
            button3.Name = "button3";
            button3.Size = new Size(125, 29);
            button3.TabIndex = 7;
            button3.Text = "Stock";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 190);
            button4.Name = "button4";
            button4.Size = new Size(125, 29);
            button4.TabIndex = 8;
            button4.Text = "Customer";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(12, 225);
            button5.Name = "button5";
            button5.Size = new Size(125, 35);
            button5.TabIndex = 9;
            button5.Text = "Sales Summary";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(12, 269);
            button6.Name = "button6";
            button6.Size = new Size(125, 29);
            button6.TabIndex = 10;
            button6.Text = "Sales Details";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(609, 363);
            button7.Name = "button7";
            button7.Size = new Size(150, 29);
            button7.TabIndex = 11;
            button7.Text = "Add Category";
            button7.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(163, 55);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 12;
            label6.Text = "Category table";
            label6.Click += label6_Click;
            // 
            // CatNameTxt
            // 
            CatNameTxt.Location = new Point(648, 109);
            CatNameTxt.Name = "CatNameTxt";
            CatNameTxt.Size = new Size(146, 27);
            CatNameTxt.TabIndex = 13;
            // 
            // CatCreatedByTxt
            // 
            CatCreatedByTxt.Location = new Point(648, 154);
            CatCreatedByTxt.Name = "CatCreatedByTxt";
            CatCreatedByTxt.Size = new Size(146, 27);
            CatCreatedByTxt.TabIndex = 14;
            // 
            // CatUpdatedByTxt
            // 
            CatUpdatedByTxt.Location = new Point(648, 236);
            CatUpdatedByTxt.Name = "CatUpdatedByTxt";
            CatUpdatedByTxt.Size = new Size(146, 27);
            CatUpdatedByTxt.TabIndex = 16;
            // 
            // CatCreatedDate
            // 
            CatCreatedDate.Location = new Point(648, 199);
            CatCreatedDate.Name = "CatCreatedDate";
            CatCreatedDate.Size = new Size(244, 27);
            CatCreatedDate.TabIndex = 18;
            // 
            // CatUpdatedDate
            // 
            CatUpdatedDate.Location = new Point(648, 278);
            CatUpdatedDate.Name = "CatUpdatedDate";
            CatUpdatedDate.Size = new Size(244, 27);
            CatUpdatedDate.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(163, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(346, 292);
            dataGridView1.TabIndex = 20;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 450);
            Controls.Add(dataGridView1);
            Controls.Add(CatUpdatedDate);
            Controls.Add(CatCreatedDate);
            Controls.Add(CatUpdatedByTxt);
            Controls.Add(CatCreatedByTxt);
            Controls.Add(CatNameTxt);
            Controls.Add(label6);
            Controls.Add(button7);
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
            Name = "CategoryForm";
            Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button button7;
        private Label label6;
        private TextBox CatNameTxt;
        private TextBox CatCreatedByTxt;
        private TextBox textBox3;
        private TextBox CatUpdatedByTxt;
        private DateTimePicker CatCreatedDate;
        private DateTimePicker CatUpdatedDate;
        private DataGridView dataGridView1;
    }
}