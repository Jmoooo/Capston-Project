
namespace Capston_Project
{
    partial class EncrypMeDownLoad
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
            this.EncryptMeTitle = new System.Windows.Forms.Label();
            this.DownLoadButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // EncryptMeTitle
            // 
            this.EncryptMeTitle.AutoSize = true;
            this.EncryptMeTitle.Location = new System.Drawing.Point(358, 30);
            this.EncryptMeTitle.Name = "EncryptMeTitle";
            this.EncryptMeTitle.Size = new System.Drawing.Size(61, 13);
            this.EncryptMeTitle.TabIndex = 0;
            this.EncryptMeTitle.Text = "Encrypt Me";
            // 
            // DownLoadButton
            // 
            this.DownLoadButton.Location = new System.Drawing.Point(632, 415);
            this.DownLoadButton.Name = "DownLoadButton";
            this.DownLoadButton.Size = new System.Drawing.Size(75, 23);
            this.DownLoadButton.TabIndex = 1;
            this.DownLoadButton.Text = "DownLoad";
            this.DownLoadButton.UseVisualStyleBackColor = true;
            this.DownLoadButton.Click += new System.EventHandler(this.DownLoadButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(713, 415);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 363);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // EncrypMeDownLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DownLoadButton);
            this.Controls.Add(this.EncryptMeTitle);
            this.Name = "EncrypMeDownLoad";
            this.Text = "EncrypMeDownLoad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EncryptMeTitle;
        private System.Windows.Forms.Button DownLoadButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ListView listView1;
    }
}