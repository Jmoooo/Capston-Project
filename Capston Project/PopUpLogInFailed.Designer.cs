
namespace Capston_Project
{
    partial class PopUpLogInFailed
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
            this.LogInFailedLable = new System.Windows.Forms.Label();
            this.FailedLogInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogInFailedLable
            // 
            this.LogInFailedLable.AutoSize = true;
            this.LogInFailedLable.Location = new System.Drawing.Point(34, 50);
            this.LogInFailedLable.Name = "LogInFailedLable";
            this.LogInFailedLable.Size = new System.Drawing.Size(236, 13);
            this.LogInFailedLable.TabIndex = 0;
            this.LogInFailedLable.Text = "The User Name or Password entered is incorrect";
            // 
            // FailedLogInButton
            // 
            this.FailedLogInButton.Location = new System.Drawing.Point(113, 66);
            this.FailedLogInButton.Name = "FailedLogInButton";
            this.FailedLogInButton.Size = new System.Drawing.Size(75, 23);
            this.FailedLogInButton.TabIndex = 1;
            this.FailedLogInButton.Text = "Okay";
            this.FailedLogInButton.UseVisualStyleBackColor = true;
            this.FailedLogInButton.Click += new System.EventHandler(this.FailedLogInButton_Click);
            // 
            // PopUpLogInFailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 119);
            this.Controls.Add(this.FailedLogInButton);
            this.Controls.Add(this.LogInFailedLable);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "PopUpLogInFailed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopUpLogInFailed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogInFailedLable;
        private System.Windows.Forms.Button FailedLogInButton;
    }
}