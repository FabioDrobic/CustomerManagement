
using System.Windows.Forms;

namespace CustomerManagement
{
    partial class OrderManagementForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.productGrid = new System.Windows.Forms.DataGridView();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.productAmount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.paymentTermsComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sameAddressRadioButton = new System.Windows.Forms.RadioButton();
            this.ownAddressRadioButton = new System.Windows.Forms.RadioButton();
            this.addressLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.streetLabel = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.houseNumberLabel = new System.Windows.Forms.Label();
            this.houseNumberTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.internationalCountryLabel = new System.Windows.Forms.Label();
            this.internationalCountryTextBox = new System.Windows.Forms.TextBox();
            this.localCountryLabel = new System.Windows.Forms.Label();
            this.localCountryTextBox = new System.Windows.Forms.TextBox();
            this.countryShortTitleLabel = new System.Windows.Forms.Label();
            this.countryShortTitleTextBox = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.doorNumberLabel = new System.Windows.Forms.Label();
            this.doorNumberTextBox = new System.Windows.Forms.TextBox();
            this.orderPositionGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.productGroup = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.productPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cartPage = new System.Windows.Forms.TabPage();
            this.orderDataGroup = new System.Windows.Forms.GroupBox();
            this.rootLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.childLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productAmount)).BeginInit();
            this.addressLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderPositionGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.productGroup.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.productPage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.cartPage.SuspendLayout();
            this.orderDataGroup.SuspendLayout();
            this.childLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, -32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(402, 38);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(150, 31);
            this.statusTextBox.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(207, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 31);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, -32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bestelldatum";
            // 
            // productGrid
            // 
            this.productGrid.AllowUserToAddRows = false;
            this.productGrid.AllowUserToDeleteRows = false;
            this.productGrid.BackgroundColor = System.Drawing.Color.White;
            this.productGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productGrid.Location = new System.Drawing.Point(3, 27);
            this.productGrid.MultiSelect = false;
            this.productGrid.Name = "productGrid";
            this.productGrid.ReadOnly = true;
            this.productGrid.RowHeadersWidth = 62;
            this.productGrid.RowTemplate.Height = 33;
            this.productGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productGrid.Size = new System.Drawing.Size(778, 194);
            this.productGrid.TabIndex = 8;
            // 
            // createOrderButton
            // 
            this.createOrderButton.AutoSize = true;
            this.createOrderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createOrderButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.createOrderButton.Location = new System.Drawing.Point(637, 702);
            this.createOrderButton.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(170, 35);
            this.createOrderButton.TabIndex = 9;
            this.createOrderButton.Text = "Bestellung anlegen";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.CreateOrderButtonClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, -32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kunde";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(10, 38);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.ReadOnly = true;
            this.customerNameTextBox.Size = new System.Drawing.Size(150, 31);
            this.customerNameTextBox.TabIndex = 11;
            // 
            // productAmount
            // 
            this.productAmount.Location = new System.Drawing.Point(3, 258);
            this.productAmount.Name = "productAmount";
            this.productAmount.Size = new System.Drawing.Size(85, 31);
            this.productAmount.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Menge";
            // 
            // addToCartButton
            // 
            this.addToCartButton.AutoSize = true;
            this.addToCartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addToCartButton.Location = new System.Drawing.Point(3, 295);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(177, 35);
            this.addToCartButton.TabIndex = 16;
            this.addToCartButton.Text = "In Warenkorb legen";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.AddToCartButtonClicked);
            // 
            // paymentTermsComboBox
            // 
            this.paymentTermsComboBox.FormattingEnabled = true;
            this.paymentTermsComboBox.Location = new System.Drawing.Point(601, 36);
            this.paymentTermsComboBox.Name = "paymentTermsComboBox";
            this.paymentTermsComboBox.Size = new System.Drawing.Size(171, 33);
            this.paymentTermsComboBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(627, -36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Zahlungsbedingung";
            // 
            // sameAddressRadioButton
            // 
            this.sameAddressRadioButton.AutoSize = true;
            this.sameAddressRadioButton.Checked = true;
            this.sameAddressRadioButton.Location = new System.Drawing.Point(10, 80);
            this.sameAddressRadioButton.Name = "sameAddressRadioButton";
            this.sameAddressRadioButton.Size = new System.Drawing.Size(373, 29);
            this.sameAddressRadioButton.TabIndex = 19;
            this.sameAddressRadioButton.TabStop = true;
            this.sameAddressRadioButton.Text = "Rechnungsadresse entspricht Lieferadresse";
            this.sameAddressRadioButton.UseVisualStyleBackColor = true;
            this.sameAddressRadioButton.CheckedChanged += new System.EventHandler(this.SameAddressRadioButtonCheckedChanged);
            // 
            // ownAddressRadioButton
            // 
            this.ownAddressRadioButton.AutoSize = true;
            this.ownAddressRadioButton.Location = new System.Drawing.Point(389, 80);
            this.ownAddressRadioButton.Name = "ownAddressRadioButton";
            this.ownAddressRadioButton.Size = new System.Drawing.Size(245, 29);
            this.ownAddressRadioButton.TabIndex = 20;
            this.ownAddressRadioButton.Text = "Andere Rechnungsadresse";
            this.ownAddressRadioButton.UseVisualStyleBackColor = true;
            this.ownAddressRadioButton.CheckedChanged += new System.EventHandler(this.OwnAddressRadioButtonCheckedChanged);
            // 
            // addressLayoutPanel
            // 
            this.addressLayoutPanel.AutoSize = true;
            this.addressLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addressLayoutPanel.Controls.Add(this.streetLabel);
            this.addressLayoutPanel.Controls.Add(this.streetTextBox);
            this.addressLayoutPanel.Controls.Add(this.houseNumberLabel);
            this.addressLayoutPanel.Controls.Add(this.houseNumberTextBox);
            this.addressLayoutPanel.Controls.Add(this.label9);
            this.addressLayoutPanel.Controls.Add(this.cityTextBox);
            this.addressLayoutPanel.Controls.Add(this.internationalCountryLabel);
            this.addressLayoutPanel.Controls.Add(this.internationalCountryTextBox);
            this.addressLayoutPanel.Controls.Add(this.localCountryLabel);
            this.addressLayoutPanel.Controls.Add(this.localCountryTextBox);
            this.addressLayoutPanel.Controls.Add(this.countryShortTitleLabel);
            this.addressLayoutPanel.Controls.Add(this.countryShortTitleTextBox);
            this.addressLayoutPanel.Controls.Add(this.zipLabel);
            this.addressLayoutPanel.Controls.Add(this.zipTextBox);
            this.addressLayoutPanel.Controls.Add(this.doorNumberLabel);
            this.addressLayoutPanel.Controls.Add(this.doorNumberTextBox);
            this.addressLayoutPanel.Enabled = false;
            this.addressLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.addressLayoutPanel.Location = new System.Drawing.Point(10, 125);
            this.addressLayoutPanel.MaximumSize = new System.Drawing.Size(0, 125);
            this.addressLayoutPanel.MinimumSize = new System.Drawing.Size(0, 125);
            this.addressLayoutPanel.Name = "addressLayoutPanel";
            this.addressLayoutPanel.Size = new System.Drawing.Size(637, 125);
            this.addressLayoutPanel.TabIndex = 22;
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(3, 0);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(61, 25);
            this.streetLabel.TabIndex = 47;
            this.streetLabel.Text = "Straße";
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(3, 28);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(150, 31);
            this.streetTextBox.TabIndex = 46;
            // 
            // houseNumberLabel
            // 
            this.houseNumberLabel.AutoSize = true;
            this.houseNumberLabel.Location = new System.Drawing.Point(3, 62);
            this.houseNumberLabel.Name = "houseNumberLabel";
            this.houseNumberLabel.Size = new System.Drawing.Size(119, 25);
            this.houseNumberLabel.TabIndex = 45;
            this.houseNumberLabel.Text = "Hausnummer";
            // 
            // houseNumberTextBox
            // 
            this.houseNumberTextBox.Location = new System.Drawing.Point(3, 90);
            this.houseNumberTextBox.Name = "houseNumberTextBox";
            this.houseNumberTextBox.Size = new System.Drawing.Size(150, 31);
            this.houseNumberTextBox.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 51;
            this.label9.Text = "Stadt";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(159, 28);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(150, 31);
            this.cityTextBox.TabIndex = 50;
            // 
            // internationalCountryLabel
            // 
            this.internationalCountryLabel.AutoSize = true;
            this.internationalCountryLabel.Location = new System.Drawing.Point(159, 62);
            this.internationalCountryLabel.Name = "internationalCountryLabel";
            this.internationalCountryLabel.Size = new System.Drawing.Size(163, 25);
            this.internationalCountryLabel.TabIndex = 55;
            this.internationalCountryLabel.Text = "Land (international)";
            // 
            // internationalCountryTextBox
            // 
            this.internationalCountryTextBox.Location = new System.Drawing.Point(159, 90);
            this.internationalCountryTextBox.Name = "internationalCountryTextBox";
            this.internationalCountryTextBox.Size = new System.Drawing.Size(150, 31);
            this.internationalCountryTextBox.TabIndex = 54;
            // 
            // localCountryLabel
            // 
            this.localCountryLabel.AutoSize = true;
            this.localCountryLabel.Location = new System.Drawing.Point(328, 0);
            this.localCountryLabel.Name = "localCountryLabel";
            this.localCountryLabel.Size = new System.Drawing.Size(102, 25);
            this.localCountryLabel.TabIndex = 57;
            this.localCountryLabel.Text = "Land (lokal)";
            // 
            // localCountryTextBox
            // 
            this.localCountryTextBox.Location = new System.Drawing.Point(328, 28);
            this.localCountryTextBox.Name = "localCountryTextBox";
            this.localCountryTextBox.Size = new System.Drawing.Size(150, 31);
            this.localCountryTextBox.TabIndex = 56;
            // 
            // countryShortTitleLabel
            // 
            this.countryShortTitleLabel.AutoSize = true;
            this.countryShortTitleLabel.Location = new System.Drawing.Point(328, 62);
            this.countryShortTitleLabel.Name = "countryShortTitleLabel";
            this.countryShortTitleLabel.Size = new System.Drawing.Size(111, 25);
            this.countryShortTitleLabel.TabIndex = 59;
            this.countryShortTitleLabel.Text = "Länderkürzel";
            // 
            // countryShortTitleTextBox
            // 
            this.countryShortTitleTextBox.Location = new System.Drawing.Point(328, 90);
            this.countryShortTitleTextBox.Name = "countryShortTitleTextBox";
            this.countryShortTitleTextBox.Size = new System.Drawing.Size(150, 31);
            this.countryShortTitleTextBox.TabIndex = 58;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(484, 0);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(100, 25);
            this.zipLabel.TabIndex = 53;
            this.zipLabel.Text = "Postleitzahl";
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(484, 28);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(150, 31);
            this.zipTextBox.TabIndex = 52;
            // 
            // doorNumberLabel
            // 
            this.doorNumberLabel.AutoSize = true;
            this.doorNumberLabel.Location = new System.Drawing.Point(484, 62);
            this.doorNumberLabel.Name = "doorNumberLabel";
            this.doorNumberLabel.Size = new System.Drawing.Size(104, 25);
            this.doorNumberLabel.TabIndex = 49;
            this.doorNumberLabel.Text = "Türnummer";
            // 
            // doorNumberTextBox
            // 
            this.doorNumberTextBox.Location = new System.Drawing.Point(484, 90);
            this.doorNumberTextBox.Name = "doorNumberTextBox";
            this.doorNumberTextBox.Size = new System.Drawing.Size(150, 31);
            this.doorNumberTextBox.TabIndex = 48;
            // 
            // orderPositionGrid
            // 
            this.orderPositionGrid.AllowUserToAddRows = false;
            this.orderPositionGrid.AllowUserToDeleteRows = false;
            this.orderPositionGrid.BackgroundColor = System.Drawing.Color.White;
            this.orderPositionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderPositionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderPositionGrid.Location = new System.Drawing.Point(3, 27);
            this.orderPositionGrid.MultiSelect = false;
            this.orderPositionGrid.Name = "orderPositionGrid";
            this.orderPositionGrid.ReadOnly = true;
            this.orderPositionGrid.RowHeadersWidth = 62;
            this.orderPositionGrid.RowTemplate.Height = 33;
            this.orderPositionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderPositionGrid.Size = new System.Drawing.Size(784, 306);
            this.orderPositionGrid.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.orderPositionGrid);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(790, 336);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Warenkorb";
            // 
            // productGroup
            // 
            this.productGroup.Controls.Add(this.productGrid);
            this.productGroup.Location = new System.Drawing.Point(3, 3);
            this.productGroup.Name = "productGroup";
            this.productGroup.Size = new System.Drawing.Size(784, 224);
            this.productGroup.TabIndex = 24;
            this.productGroup.TabStop = false;
            this.productGroup.Text = "Produkte";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.productPage);
            this.tabControl.Controls.Add(this.cartPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(3, 289);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(804, 380);
            this.tabControl.TabIndex = 25;
            // 
            // productPage
            // 
            this.productPage.AutoScroll = true;
            this.productPage.Controls.Add(this.flowLayoutPanel1);
            this.productPage.Location = new System.Drawing.Point(4, 34);
            this.productPage.Name = "productPage";
            this.productPage.Padding = new System.Windows.Forms.Padding(3);
            this.productPage.Size = new System.Drawing.Size(796, 342);
            this.productPage.TabIndex = 0;
            this.productPage.Text = "Produkte";
            this.productPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.productGroup);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.productAmount);
            this.flowLayoutPanel1.Controls.Add(this.addToCartButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(790, 336);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // cartPage
            // 
            this.cartPage.Controls.Add(this.groupBox2);
            this.cartPage.Location = new System.Drawing.Point(4, 34);
            this.cartPage.Name = "cartPage";
            this.cartPage.Padding = new System.Windows.Forms.Padding(3);
            this.cartPage.Size = new System.Drawing.Size(796, 342);
            this.cartPage.TabIndex = 1;
            this.cartPage.Text = "Warenkorb";
            this.cartPage.UseVisualStyleBackColor = true;
            // 
            // orderDataGroup
            // 
            this.orderDataGroup.AutoSize = true;
            this.orderDataGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.orderDataGroup.Controls.Add(this.addressLayoutPanel);
            this.orderDataGroup.Controls.Add(this.statusTextBox);
            this.orderDataGroup.Controls.Add(this.label2);
            this.orderDataGroup.Controls.Add(this.dateTimePicker1);
            this.orderDataGroup.Controls.Add(this.label3);
            this.orderDataGroup.Controls.Add(this.sameAddressRadioButton);
            this.orderDataGroup.Controls.Add(this.label5);
            this.orderDataGroup.Controls.Add(this.label8);
            this.orderDataGroup.Controls.Add(this.customerNameTextBox);
            this.orderDataGroup.Controls.Add(this.paymentTermsComboBox);
            this.orderDataGroup.Controls.Add(this.ownAddressRadioButton);
            this.orderDataGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDataGroup.Location = new System.Drawing.Point(3, 3);
            this.orderDataGroup.Name = "orderDataGroup";
            this.orderDataGroup.Size = new System.Drawing.Size(804, 280);
            this.orderDataGroup.TabIndex = 26;
            this.orderDataGroup.TabStop = false;
            this.orderDataGroup.Text = "Bestelldaten";
            // 
            // rootLayoutPanel
            // 
            this.rootLayoutPanel.AutoSize = true;
            this.rootLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rootLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.rootLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.rootLayoutPanel.Name = "rootLayoutPanel";
            this.rootLayoutPanel.Size = new System.Drawing.Size(872, 752);
            this.rootLayoutPanel.TabIndex = 27;
            // 
            // childLayoutPanel
            // 
            this.childLayoutPanel.AutoSize = true;
            this.childLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.childLayoutPanel.Controls.Add(this.orderDataGroup);
            this.childLayoutPanel.Controls.Add(this.tabControl);
            this.childLayoutPanel.Controls.Add(this.createOrderButton);
            this.childLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.childLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.childLayoutPanel.Name = "childLayoutPanel";
            this.childLayoutPanel.Size = new System.Drawing.Size(810, 740);
            this.childLayoutPanel.TabIndex = 28;
            // 
            // OrderManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 752);
            this.Controls.Add(this.childLayoutPanel);
            this.Controls.Add(this.rootLayoutPanel);
            this.Name = "OrderManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kunden- und Bestellverwaltung";
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productAmount)).EndInit();
            this.addressLayoutPanel.ResumeLayout(false);
            this.addressLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderPositionGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.productGroup.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.productPage.ResumeLayout(false);
            this.productPage.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.cartPage.ResumeLayout(false);
            this.cartPage.PerformLayout();
            this.orderDataGroup.ResumeLayout(false);
            this.orderDataGroup.PerformLayout();
            this.childLayoutPanel.ResumeLayout(false);
            this.childLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView productGrid;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.NumericUpDown productAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.ComboBox paymentTermsComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton sameAddressRadioButton;
        private System.Windows.Forms.RadioButton ownAddressRadioButton;
        private System.Windows.Forms.Label countryShortTitleLabel;
        private System.Windows.Forms.Label internationalCountryLabel;
        private System.Windows.Forms.TextBox countryShortTitleTextBox;
        private System.Windows.Forms.TextBox houseNumberTextBox;
        private System.Windows.Forms.Label localCountryLabel;
        private System.Windows.Forms.Label houseNumberLabel;
        private System.Windows.Forms.TextBox localCountryTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.TextBox internationalCountryTextBox;
        private System.Windows.Forms.TextBox doorNumberTextBox;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label doorNumberLabel;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView orderPositionGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox productGroup;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage productPage;
        private System.Windows.Forms.TabPage cartPage;
        private System.Windows.Forms.GroupBox orderDataGroup;
        private System.Windows.Forms.FlowLayoutPanel rootLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel childLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel addressLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}