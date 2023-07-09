namespace POS
{
    partial class Login
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
            AdminUserNametxt = new TextBox();
            AdminPasswordtxt = new TextBox();
            loginBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 138);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 195);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // AdminUserNametxt
            // 
            AdminUserNametxt.Location = new Point(327, 138);
            AdminUserNametxt.Name = "AdminUserNametxt";
            AdminUserNametxt.Size = new Size(172, 23);
            AdminUserNametxt.TabIndex = 2;
            // 
            // AdminPasswordtxt
            // 
            AdminPasswordtxt.Location = new Point(327, 187);
            AdminPasswordtxt.Name = "AdminPasswordtxt";
            AdminPasswordtxt.Size = new Size(172, 23);
            AdminPasswordtxt.TabIndex = 3;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(325, 279);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginBtn);
            Controls.Add(AdminPasswordtxt);
            Controls.Add(AdminUserNametxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox AdminUserNametxt;
        private TextBox AdminPasswordtxt;
        private Button loginBtn;
    }
}