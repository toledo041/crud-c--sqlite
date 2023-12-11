namespace CrudCSharp
{
    partial class ForgotForm
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
            loginBtn = new Button();
            label2 = new Label();
            passTxt = new TextBox();
            userTxt = new TextBox();
            label1 = new Label();
            label4 = new Label();
            pass2Txt = new TextBox();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(59, 173);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 10;
            loginBtn.Text = "Update";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // passTxt
            // 
            passTxt.Location = new Point(12, 78);
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(189, 23);
            passTxt.TabIndex = 8;
            passTxt.UseSystemPasswordChar = true;
            // 
            // userTxt
            // 
            userTxt.Location = new Point(12, 24);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(189, 23);
            userTxt.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 6;
            label1.Text = "User";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 117);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 17;
            label4.Text = "Confirm your password";
            // 
            // pass2Txt
            // 
            pass2Txt.Location = new Point(12, 135);
            pass2Txt.Name = "pass2Txt";
            pass2Txt.Size = new Size(189, 23);
            pass2Txt.TabIndex = 9;
            pass2Txt.UseSystemPasswordChar = true;
            // 
            // ForgotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(213, 211);
            Controls.Add(label4);
            Controls.Add(pass2Txt);
            Controls.Add(loginBtn);
            Controls.Add(label2);
            Controls.Add(passTxt);
            Controls.Add(userTxt);
            Controls.Add(label1);
            Name = "ForgotForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginBtn;
        private Label label2;
        private TextBox passTxt;
        private TextBox userTxt;
        private Label label1;
        private Label label4;
        private TextBox pass2Txt;
    }
}