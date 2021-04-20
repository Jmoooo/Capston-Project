
namespace Capston_Project
{
    partial class SignUp
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
            this.SignUpTitle = new System.Windows.Forms.Label();
            this.CreateUserNameTxt = new System.Windows.Forms.TextBox();
            this.CreatePasswordFirst = new System.Windows.Forms.TextBox();
            this.CreatePasswordSecond = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CreateUserNameLabel = new System.Windows.Forms.Label();
            this.CreatePasswordlabel = new System.Windows.Forms.Label();
            this.ConformPasswordLable = new System.Windows.Forms.Label();
            this.CreatUserIdsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignUpTitle
            // 
            this.SignUpTitle.AutoSize = true;
            this.SignUpTitle.Location = new System.Drawing.Point(225, 42);
            this.SignUpTitle.Name = "SignUpTitle";
            this.SignUpTitle.Size = new System.Drawing.Size(45, 13);
            this.SignUpTitle.TabIndex = 0;
            this.SignUpTitle.Text = "Sign Up";
            // 
            // CreateUserNameTxt
            // 
            this.CreateUserNameTxt.Location = new System.Drawing.Point(228, 90);
            this.CreateUserNameTxt.Name = "CreateUserNameTxt";
            this.CreateUserNameTxt.Size = new System.Drawing.Size(100, 20);
            this.CreateUserNameTxt.TabIndex = 1;
            // 
            // CreatePasswordFirst
            // 
            this.CreatePasswordFirst.Location = new System.Drawing.Point(228, 117);
            this.CreatePasswordFirst.Name = "CreatePasswordFirst";
            this.CreatePasswordFirst.Size = new System.Drawing.Size(100, 20);
            this.CreatePasswordFirst.TabIndex = 2;
            // 
            // CreatePasswordSecond
            // 
            this.CreatePasswordSecond.Location = new System.Drawing.Point(228, 144);
            this.CreatePasswordSecond.Name = "CreatePasswordSecond";
            this.CreatePasswordSecond.Size = new System.Drawing.Size(100, 20);
            this.CreatePasswordSecond.TabIndex = 3;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(371, 285);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CreateUserNameLabel
            // 
            this.CreateUserNameLabel.AutoSize = true;
            this.CreateUserNameLabel.Location = new System.Drawing.Point(131, 93);
            this.CreateUserNameLabel.Name = "CreateUserNameLabel";
            this.CreateUserNameLabel.Size = new System.Drawing.Size(91, 13);
            this.CreateUserNameLabel.TabIndex = 5;
            this.CreateUserNameLabel.Text = "Create UserName";
            // 
            // CreatePasswordlabel
            // 
            this.CreatePasswordlabel.AutoSize = true;
            this.CreatePasswordlabel.Location = new System.Drawing.Point(135, 120);
            this.CreatePasswordlabel.Name = "CreatePasswordlabel";
            this.CreatePasswordlabel.Size = new System.Drawing.Size(87, 13);
            this.CreatePasswordlabel.TabIndex = 6;
            this.CreatePasswordlabel.Text = "Create Password";
            // 
            // ConformPasswordLable
            // 
            this.ConformPasswordLable.AutoSize = true;
            this.ConformPasswordLable.Location = new System.Drawing.Point(127, 147);
            this.ConformPasswordLable.Name = "ConformPasswordLable";
            this.ConformPasswordLable.Size = new System.Drawing.Size(95, 13);
            this.ConformPasswordLable.TabIndex = 7;
            this.ConformPasswordLable.Text = "Conform Password";
            // 
            // CreatUserIdsButton
            // 
            this.CreatUserIdsButton.Location = new System.Drawing.Point(228, 170);
            this.CreatUserIdsButton.Name = "CreatUserIdsButton";
            this.CreatUserIdsButton.Size = new System.Drawing.Size(100, 23);
            this.CreatUserIdsButton.TabIndex = 8;
            this.CreatUserIdsButton.Text = "Create User";
            this.CreatUserIdsButton.UseVisualStyleBackColor = true;
            this.CreatUserIdsButton.Click += new System.EventHandler(this.CreatUserIdsButton_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 320);
            this.Controls.Add(this.CreatUserIdsButton);
            this.Controls.Add(this.ConformPasswordLable);
            this.Controls.Add(this.CreatePasswordlabel);
            this.Controls.Add(this.CreateUserNameLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CreatePasswordSecond);
            this.Controls.Add(this.CreatePasswordFirst);
            this.Controls.Add(this.CreateUserNameTxt);
            this.Controls.Add(this.SignUpTitle);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignUpTitle;
        private System.Windows.Forms.TextBox CreateUserNameTxt;
        private System.Windows.Forms.TextBox CreatePasswordFirst;
        private System.Windows.Forms.TextBox CreatePasswordSecond;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label CreateUserNameLabel;
        private System.Windows.Forms.Label CreatePasswordlabel;
        private System.Windows.Forms.Label ConformPasswordLable;
        private System.Windows.Forms.Button CreatUserIdsButton;
    }
}