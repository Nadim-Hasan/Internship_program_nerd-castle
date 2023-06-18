namespace WinFormsTask
{
    partial class Form1
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
            btnSave = new Button();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSearch = new Button();
            textSearch = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(300, 238);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(276, 184);
            txtContact.Margin = new Padding(3, 2, 3, 2);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(162, 23);
            txtContact.TabIndex = 1;
            txtContact.TextChanged += txtContact_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(276, 146);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(162, 23);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(276, 104);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(162, 23);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 110);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 4;
            label1.Text = "Name  :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 148);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 5;
            label2.Text = "Email   :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 189);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "Contact :";
            label3.Click += label3_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(530, 238);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(119, 22);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search Email";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(497, 210);
            textSearch.Margin = new Padding(3, 2, 3, 2);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(178, 23);
            textSearch.TabIndex = 8;
            textSearch.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(497, 189);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 9;
            label4.Text = "Input Your Email Here";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label4);
            Controls.Add(textSearch);
            Controls.Add(btnSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtContact);
            Controls.Add(btnSave);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Workerform";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtContact;
        private TextBox txtEmail;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSearch;
        private TextBox textSearch;
        private Label label4;
    }
}