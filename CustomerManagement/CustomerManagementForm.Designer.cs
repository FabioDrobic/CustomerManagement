
namespace CustomerManagement
{
    partial class CustomerManagementForm
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
            this.customerGrid = new System.Windows.Forms.DataGridView();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.manageOrdersButtons = new System.Windows.Forms.Button();
            this.orderGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerGrid
            // 
            this.customerGrid.AllowUserToAddRows = false;
            this.customerGrid.AllowUserToDeleteRows = false;
            this.customerGrid.BackgroundColor = System.Drawing.Color.White;
            this.customerGrid.ColumnHeadersHeight = 34;
            this.customerGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerGrid.Location = new System.Drawing.Point(3, 27);
            this.customerGrid.MultiSelect = false;
            this.customerGrid.Name = "customerGrid";
            this.customerGrid.RowHeadersWidth = 62;
            this.customerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerGrid.ShowEditingIcon = false;
            this.customerGrid.Size = new System.Drawing.Size(922, 284);
            this.customerGrid.TabIndex = 0;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.AutoSize = true;
            this.addCustomerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addCustomerButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addCustomerButton.Location = new System.Drawing.Point(3, 311);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(922, 35);
            this.addCustomerButton.TabIndex = 1;
            this.addCustomerButton.Text = "Kunde anlegen";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.OnAddCustomerButtonClicked);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // manageOrdersButtons
            // 
            this.manageOrdersButtons.AutoSize = true;
            this.manageOrdersButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.manageOrdersButtons.Location = new System.Drawing.Point(3, 311);
            this.manageOrdersButtons.Name = "manageOrdersButtons";
            this.manageOrdersButtons.Size = new System.Drawing.Size(922, 35);
            this.manageOrdersButtons.TabIndex = 2;
            this.manageOrdersButtons.Text = "Kundenbestellung anlegen";
            this.manageOrdersButtons.UseVisualStyleBackColor = true;
            this.manageOrdersButtons.Click += new System.EventHandler(this.ManageCustomerOrderButtonClicked);
            // 
            // orderGrid
            // 
            this.orderGrid.AllowUserToAddRows = false;
            this.orderGrid.AllowUserToDeleteRows = false;
            this.orderGrid.BackgroundColor = System.Drawing.Color.White;
            this.orderGrid.ColumnHeadersHeight = 34;
            this.orderGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderGrid.Location = new System.Drawing.Point(3, 27);
            this.orderGrid.MultiSelect = false;
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.ReadOnly = true;
            this.orderGrid.RowHeadersWidth = 62;
            this.orderGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.orderGrid.ShowEditingIcon = false;
            this.orderGrid.Size = new System.Drawing.Size(922, 284);
            this.orderGrid.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.customerGrid);
            this.groupBox1.Controls.Add(this.addCustomerButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 349);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kunden";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.orderGrid);
            this.groupBox2.Controls.Add(this.manageOrdersButtons);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(928, 349);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kundenbestellungen";
            // 
            // CustomerManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(928, 710);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "CustomerManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kunden und Bestellungen verwalten";
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerGrid;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button manageOrdersButtons;
        private System.Windows.Forms.DataGridView orderGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}