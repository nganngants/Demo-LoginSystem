namespace LoginSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_usrname = new System.Windows.Forms.TextBox();
            this.txt_usrpwd = new System.Windows.Forms.TextBox();
            this.but_Clear = new System.Windows.Forms.Button();
            this.but_Login = new System.Windows.Forms.Button();
            this.but_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AccessibleName = "";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "username";
            // 
            // label3
            // 
            this.label3.AccessibleName = "";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "password";
            // 
            // txt_usrname
            // 
            this.txt_usrname.AccessibleName = "txt_username";
            this.txt_usrname.Location = new System.Drawing.Point(228, 151);
            this.txt_usrname.Name = "txt_usrname";
            this.txt_usrname.Size = new System.Drawing.Size(199, 22);
            this.txt_usrname.TabIndex = 3;
            // 
            // txt_usrpwd
            // 
            this.txt_usrpwd.AccessibleName = "txt_userpwd";
            this.txt_usrpwd.UseSystemPasswordChar = true;
            this.txt_usrpwd.PasswordChar = '*';
            this.txt_usrpwd.Location = new System.Drawing.Point(228, 188);
            this.txt_usrpwd.Name = "txt_usrpwd";
            this.txt_usrpwd.Size = new System.Drawing.Size(199, 22);
            this.txt_usrpwd.TabIndex = 4;
            // 
            // but_Clear
            // 
            this.but_Clear.AccessibleName = "but_Clear";
            this.but_Clear.Location = new System.Drawing.Point(228, 236);
            this.but_Clear.Name = "but_Clear";
            this.but_Clear.Size = new System.Drawing.Size(75, 32);
            this.but_Clear.TabIndex = 5;
            this.but_Clear.Text = "Clear";
            this.but_Clear.UseVisualStyleBackColor = true;
            this.but_Clear.Click += new System.EventHandler(this.but_Clear_Click);
            // 
            // but_Login
            // 
            this.but_Login.AccessibleName = "but_login";
            this.but_Login.Location = new System.Drawing.Point(352, 236);
            this.but_Login.Name = "but_Login";
            this.but_Login.Size = new System.Drawing.Size(75, 32);
            this.but_Login.TabIndex = 6;
            this.but_Login.Text = "Login";
            this.but_Login.UseVisualStyleBackColor = true;
            this.but_Login.Click += new System.EventHandler(this.but_Login_Click);
            // 
            // but_Exit
            // 
            this.but_Exit.AccessibleName = "but_Exit";
            this.but_Exit.Location = new System.Drawing.Point(147, 236);
            this.but_Exit.Name = "but_Exit";
            this.but_Exit.Size = new System.Drawing.Size(75, 32);
            this.but_Exit.TabIndex = 7;
            this.but_Exit.Text = "Exit";
            this.but_Exit.UseVisualStyleBackColor = true;
            this.but_Exit.Click += new System.EventHandler(this.but_Exit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 383);
            this.Controls.Add(this.but_Exit);
            this.Controls.Add(this.but_Login);
            this.Controls.Add(this.but_Clear);
            this.Controls.Add(this.txt_usrpwd);
            this.Controls.Add(this.txt_usrname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_usrname;
        private System.Windows.Forms.TextBox txt_usrpwd;
        private System.Windows.Forms.Button but_Clear;
        private System.Windows.Forms.Button but_Login;
        private System.Windows.Forms.Button but_Exit;
    }
}

