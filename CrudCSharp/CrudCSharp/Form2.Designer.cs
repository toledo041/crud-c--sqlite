namespace CrudCSharp
{
    partial class LoginForm
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
            userTxt = new TextBox();
            passTxt = new TextBox();
            label2 = new Label();
            loginBtn = new Button();
            registerBtn = new Button();
            forgotLink = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "User";
            // 
            // userTxt
            // 
            userTxt.Location = new Point(12, 27);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(189, 23);
            userTxt.TabIndex = 1;
            // 
            // passTxt
            // 
            passTxt.Location = new Point(12, 81);
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(189, 23);
            passTxt.TabIndex = 2;
            passTxt.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(12, 120);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(126, 120);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(75, 23);
            registerBtn.TabIndex = 5;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // forgotLink
            // 
            forgotLink.AutoSize = true;
            forgotLink.Location = new Point(42, 158);
            forgotLink.Name = "forgotLink";
            forgotLink.Size = new Size(122, 15);
            forgotLink.TabIndex = 6;
            forgotLink.TabStop = true;
            forgotLink.Text = "Forgot your password";
            forgotLink.LinkClicked += forgotLink_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 206);
            Controls.Add(forgotLink);
            Controls.Add(registerBtn);
            Controls.Add(loginBtn);
            Controls.Add(label2);
            Controls.Add(passTxt);
            Controls.Add(userTxt);
            Controls.Add(label1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += LoginForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userTxt;
        private TextBox passTxt;
        private Label label2;
        private Button loginBtn;
        private Button registerBtn;
        private LinkLabel forgotLink;
    }
}