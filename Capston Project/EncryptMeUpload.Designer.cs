
namespace Capston_Project
{
    partial class EncryptMeUpload
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
            this.UpLoadTitleEncryptMe = new System.Windows.Forms.Label();
            this.UploadButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // UpLoadTitleEncryptMe
            // 
            this.UpLoadTitleEncryptMe.AutoSize = true;
            this.UpLoadTitleEncryptMe.Location = new System.Drawing.Point(343, 25);
            this.UpLoadTitleEncryptMe.Name = "UpLoadTitleEncryptMe";
            this.UpLoadTitleEncryptMe.Size = new System.Drawing.Size(61, 13);
            this.UpLoadTitleEncryptMe.TabIndex = 0;
            this.UpLoadTitleEncryptMe.Text = "Encrypt Me";
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(604, 398);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(75, 23);
            this.UploadButton.TabIndex = 1;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(685, 398);
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
            this.listView1.Location = new System.Drawing.Point(12, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(748, 351);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // EncryptMeUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.UpLoadTitleEncryptMe);
            this.Name = "EncryptMeUpload";
            this.Text = "EncryptMeUpload";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpLoadTitleEncryptMe;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ListView listView1;
    }
}