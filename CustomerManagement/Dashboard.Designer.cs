
namespace CustomerManagement
{
    partial class Dashboard
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
            this.manageUserOrdersButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.manageUserRoleButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // manageUserOrdersButton
            // 
            this.manageUserOrdersButton.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.manageUserOrdersButton, 2);
            this.manageUserOrdersButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageUserOrdersButton.Image = global::CustomerManagement.Properties.Resources.contacts_line;
            this.manageUserOrdersButton.Location = new System.Drawing.Point(3, 228);
            this.manageUserOrdersButton.Name = "manageUserOrdersButton";
            this.manageUserOrdersButton.Size = new System.Drawing.Size(794, 219);
            this.manageUserOrdersButton.TabIndex = 0;
            this.manageUserOrdersButton.Text = "Kunden und Bestellungen verwalten";
            this.manageUserOrdersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.manageUserOrdersButton.UseVisualStyleBackColor = true;
            this.manageUserOrdersButton.Click += new System.EventHandler(this.ManageUserOrdersButtonClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.manageUserRoleButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.loginButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.manageUserOrdersButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // manageUserRoleButton
            // 
            this.manageUserRoleButton.AutoSize = true;
            this.manageUserRoleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.manageUserRoleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageUserRoleButton.Image = global::CustomerManagement.Properties.Resources.admin_line;
            this.manageUserRoleButton.Location = new System.Drawing.Point(403, 3);
            this.manageUserRoleButton.Name = "manageUserRoleButton";
            this.manageUserRoleButton.Size = new System.Drawing.Size(394, 219);
            this.manageUserRoleButton.TabIndex = 2;
            this.manageUserRoleButton.Text = "Benutzer-Rollen verwalten";
            this.manageUserRoleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.manageUserRoleButton.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginButton.Image = global::CustomerManagement.Properties.Resources.login_box_line__1_;
            this.loginButton.Location = new System.Drawing.Point(3, 3);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(394, 219);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Benutzer-Anmeldung";
            this.loginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButtonClicked);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageUserOrdersButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button manageUserRoleButton;
        private System.Windows.Forms.Button loginButton;
    }
}