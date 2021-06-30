
namespace CustomerManagement
{
    partial class UserLoginForm
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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.AcceptsReturn = true;
            this.usernameTextBox.Location = new System.Drawing.Point(3, 28);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(215, 31);
            this.usernameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Benutzername";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Passwort";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AcceptsReturn = true;
            this.passwordTextBox.Location = new System.Drawing.Point(3, 90);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(215, 31);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(3, 127);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(112, 34);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Anmelden";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButtonClicked);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.usernameTextBox);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.passwordTextBox);
            this.flowLayoutPanel1.Controls.Add(this.loginButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(367, 214);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(367, 214);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UserLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benutzer-Anmeldung";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}