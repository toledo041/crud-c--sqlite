namespace CrudCSharp
{
    partial class RegisterLogin
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
            registerBtn = new Button();
            label2 = new Label();
            passTxt = new TextBox();
            userTxt = new TextBox();
            label1 = new Label();
            label3 = new Label();
            emailTxt = new TextBox();
            label4 = new Label();
            pass2Txt = new TextBox();
            SuspendLayout();
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(68, 233);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(75, 23);
            registerBtn.TabIndex = 11;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 119);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // passTxt
            // 
            passTxt.Location = new Point(12, 137);
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(189, 23);
            passTxt.TabIndex = 9;
            passTxt.UseSystemPasswordChar = true;
            // 
            // userTxt
            // 
            userTxt.Location = new Point(12, 26);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(189, 23);
            userTxt.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 6;
            label1.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 62);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 12;
            label3.Text = "Email";
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(12, 80);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(189, 23);
            emailTxt.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 170);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 15;
            label4.Text = "Confirm your password";
            // 
            // pass2Txt
            // 
            pass2Txt.Location = new Point(12, 188);
            pass2Txt.Name = "pass2Txt";
            pass2Txt.Size = new Size(189, 23);
            pass2Txt.TabIndex = 10;
            pass2Txt.UseSystemPasswordChar = true;
            // 
            // RegisterLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(216, 268);
            Controls.Add(label4);
            Controls.Add(pass2Txt);
            Controls.Add(emailTxt);
            Controls.Add(label3);
            Controls.Add(registerBtn);
            Controls.Add(label2);
            Controls.Add(passTxt);
            Controls.Add(userTxt);
            Controls.Add(label1);
            Name = "RegisterLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            FormClosing += RegisterLogin_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerBtn;
        private Label label2;
        private TextBox passTxt;
        private TextBox userTxt;
        private Label label1;
        private Label label3;
        private TextBox emailTxt;
        private Label label4;
        private TextBox pass2Txt;
    }
}