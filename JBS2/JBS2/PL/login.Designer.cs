namespace JBS2
{
    partial class login
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
            this.Login_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.tex_User_Name = new System.Windows.Forms.TextBox();
            this.tex_userpwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "كلمة المرور :";
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(198, 122);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(98, 28);
            this.Login_button.TabIndex = 2;
            this.Login_button.Text = "دخــــول";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            this.Login_button.Enter += new System.EventHandler(this.Login_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(321, 122);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(98, 28);
            this.Cancel_button.TabIndex = 3;
            this.Cancel_button.Text = "إلغــاء";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // tex_User_Name
            // 
            this.tex_User_Name.Location = new System.Drawing.Point(171, 43);
            this.tex_User_Name.Name = "tex_User_Name";
            this.tex_User_Name.Size = new System.Drawing.Size(248, 20);
            this.tex_User_Name.TabIndex = 4;
            // 
            // tex_userpwd
            // 
            this.tex_userpwd.Location = new System.Drawing.Point(171, 72);
            this.tex_userpwd.Name = "tex_userpwd";
            this.tex_userpwd.PasswordChar = '*';
            this.tex_userpwd.Size = new System.Drawing.Size(248, 20);
            this.tex_userpwd.TabIndex = 5;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 178);
            this.Controls.Add(this.tex_userpwd);
            this.Controls.Add(this.tex_User_Name);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تسجيل دخول";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.TextBox tex_User_Name;
        private System.Windows.Forms.TextBox tex_userpwd;

    }
}