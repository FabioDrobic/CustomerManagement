
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customerGrid
            // 
            this.customerGrid.AllowUserToAddRows = false;
            this.customerGrid.AllowUserToDeleteRows = false;
            this.customerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerGrid.BackgroundColor = System.Drawing.Color.White;
            this.customerGrid.ColumnHeadersHeight = 34;
            this.customerGrid.Location = new System.Drawing.Point(12, 41);
            this.customerGrid.MultiSelect = false;
            this.customerGrid.Name = "customerGrid";
            this.customerGrid.RowHeadersWidth = 62;
            this.customerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerGrid.ShowEditingIcon = false;
            this.customerGrid.Size = new System.Drawing.Size(773, 284);
            this.customerGrid.TabIndex = 0;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.AutoSize = true;
            this.addCustomerButton.Location = new System.Drawing.Point(646, 331);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(139, 35);
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
            this.manageOrdersButtons.Location = new System.Drawing.Point(583, 709);
            this.manageOrdersButtons.Name = "manageOrdersButtons";
            this.manageOrdersButtons.Size = new System.Drawing.Size(202, 35);
            this.manageOrdersButtons.TabIndex = 2;
            this.manageOrdersButtons.Text = "Bestellung anlegen";
            this.manageOrdersButtons.UseVisualStyleBackColor = true;
            this.manageOrdersButtons.Click += new System.EventHandler(this.ManageCustomerOrderButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kunden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bestellungen für Kunde";
            // 
            // orderGrid
            // 
            this.orderGrid.AllowUserToAddRows = false;
            this.orderGrid.AllowUserToDeleteRows = false;
            this.orderGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderGrid.BackgroundColor = System.Drawing.Color.White;
            this.orderGrid.ColumnHeadersHeight = 34;
            this.orderGrid.Location = new System.Drawing.Point(13, 402);
            this.orderGrid.MultiSelect = false;
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.ReadOnly = true;
            this.orderGrid.RowHeadersWidth = 62;
            this.orderGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.orderGrid.ShowEditingIcon = false;
            this.orderGrid.Size = new System.Drawing.Size(773, 284);
            this.orderGrid.TabIndex = 6;
            // 
            // CustomerManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(797, 749);
            this.Controls.Add(this.orderGrid);
            this.Controls.Add(this.manageOrdersButtons);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerGrid);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "CustomerManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kunden und Bestellungen verwalten";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerGrid;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button manageOrdersButtons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView orderGrid;
    }
}