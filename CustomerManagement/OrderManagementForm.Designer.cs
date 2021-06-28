
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.addressGroupBox = new System.Windows.Forms.GroupBox();
            this.countryShortTitleLabel = new System.Windows.Forms.Label();
            this.internationalCountryLabel = new System.Windows.Forms.Label();
            this.countryShortTitleTextBox = new System.Windows.Forms.TextBox();
            this.houseNumberTextBox = new System.Windows.Forms.TextBox();
            this.localCountryLabel = new System.Windows.Forms.Label();
            this.houseNumberLabel = new System.Windows.Forms.Label();
            this.localCountryTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.streetLabel = new System.Windows.Forms.Label();
            this.internationalCountryTextBox = new System.Windows.Forms.TextBox();
            this.doorNumberTextBox = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.doorNumberLabel = new System.Windows.Forms.Label();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.orderPositionGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productAmount)).BeginInit();
            this.addressGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderPositionGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bestellung anlegen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(404, 60);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(150, 31);
            this.statusTextBox.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(209, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 31);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 34);
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
            this.productGrid.Location = new System.Drawing.Point(6, 43);
            this.productGrid.MultiSelect = false;
            this.productGrid.Name = "productGrid";
            this.productGrid.ReadOnly = true;
            this.productGrid.RowHeadersWidth = 62;
            this.productGrid.RowTemplate.Height = 33;
            this.productGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productGrid.Size = new System.Drawing.Size(1011, 211);
            this.productGrid.TabIndex = 8;
            // 
            // createOrderButton
            // 
            this.createOrderButton.AutoSize = true;
            this.createOrderButton.Location = new System.Drawing.Point(871, 1003);
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
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kunde";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(12, 62);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.ReadOnly = true;
            this.customerNameTextBox.Size = new System.Drawing.Size(150, 31);
            this.customerNameTextBox.TabIndex = 11;
            // 
            // productAmount
            // 
            this.productAmount.Location = new System.Drawing.Point(715, 299);
            this.productAmount.Name = "productAmount";
            this.productAmount.Size = new System.Drawing.Size(85, 31);
            this.productAmount.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(715, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Menge";
            // 
            // addToCartButton
            // 
            this.addToCartButton.AutoSize = true;
            this.addToCartButton.Location = new System.Drawing.Point(837, 296);
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
            this.paymentTermsComboBox.Location = new System.Drawing.Point(601, 58);
            this.paymentTermsComboBox.Name = "paymentTermsComboBox";
            this.paymentTermsComboBox.Size = new System.Drawing.Size(171, 33);
            this.paymentTermsComboBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(601, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Zahlungsbedingung";
            // 
            // sameAddressRadioButton
            // 
            this.sameAddressRadioButton.AutoSize = true;
            this.sameAddressRadioButton.Checked = true;
            this.sameAddressRadioButton.Location = new System.Drawing.Point(12, 104);
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
            this.ownAddressRadioButton.Location = new System.Drawing.Point(404, 104);
            this.ownAddressRadioButton.Name = "ownAddressRadioButton";
            this.ownAddressRadioButton.Size = new System.Drawing.Size(245, 29);
            this.ownAddressRadioButton.TabIndex = 20;
            this.ownAddressRadioButton.Text = "Andere Rechnungsadresse";
            this.ownAddressRadioButton.UseVisualStyleBackColor = true;
            this.ownAddressRadioButton.CheckedChanged += new System.EventHandler(this.OwnAddressRadioButtonCheckedChanged);
            // 
            // addressGroupBox
            // 
            this.addressGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addressGroupBox.Controls.Add(this.countryShortTitleLabel);
            this.addressGroupBox.Controls.Add(this.internationalCountryLabel);
            this.addressGroupBox.Controls.Add(this.countryShortTitleTextBox);
            this.addressGroupBox.Controls.Add(this.houseNumberTextBox);
            this.addressGroupBox.Controls.Add(this.localCountryLabel);
            this.addressGroupBox.Controls.Add(this.houseNumberLabel);
            this.addressGroupBox.Controls.Add(this.localCountryTextBox);
            this.addressGroupBox.Controls.Add(this.streetTextBox);
            this.addressGroupBox.Controls.Add(this.streetLabel);
            this.addressGroupBox.Controls.Add(this.internationalCountryTextBox);
            this.addressGroupBox.Controls.Add(this.doorNumberTextBox);
            this.addressGroupBox.Controls.Add(this.zipLabel);
            this.addressGroupBox.Controls.Add(this.doorNumberLabel);
            this.addressGroupBox.Controls.Add(this.zipTextBox);
            this.addressGroupBox.Controls.Add(this.cityTextBox);
            this.addressGroupBox.Controls.Add(this.label9);
            this.addressGroupBox.Location = new System.Drawing.Point(18, 139);
            this.addressGroupBox.Name = "addressGroupBox";
            this.addressGroupBox.Size = new System.Drawing.Size(1023, 213);
            this.addressGroupBox.TabIndex = 21;
            this.addressGroupBox.TabStop = false;
            this.addressGroupBox.Text = "Eigene Rechnungsadresse";
            this.addressGroupBox.Visible = false;
            // 
            // countryShortTitleLabel
            // 
            this.countryShortTitleLabel.AutoSize = true;
            this.countryShortTitleLabel.Location = new System.Drawing.Point(421, 63);
            this.countryShortTitleLabel.Name = "countryShortTitleLabel";
            this.countryShortTitleLabel.Size = new System.Drawing.Size(111, 25);
            this.countryShortTitleLabel.TabIndex = 59;
            this.countryShortTitleLabel.Text = "Länderkürzel";
            // 
            // internationalCountryLabel
            // 
            this.internationalCountryLabel.AutoSize = true;
            this.internationalCountryLabel.Location = new System.Drawing.Point(31, 63);
            this.internationalCountryLabel.Name = "internationalCountryLabel";
            this.internationalCountryLabel.Size = new System.Drawing.Size(163, 25);
            this.internationalCountryLabel.TabIndex = 55;
            this.internationalCountryLabel.Text = "Land (international)";
            // 
            // countryShortTitleTextBox
            // 
            this.countryShortTitleTextBox.Location = new System.Drawing.Point(421, 91);
            this.countryShortTitleTextBox.Name = "countryShortTitleTextBox";
            this.countryShortTitleTextBox.Size = new System.Drawing.Size(150, 31);
            this.countryShortTitleTextBox.TabIndex = 58;
            // 
            // houseNumberTextBox
            // 
            this.houseNumberTextBox.Location = new System.Drawing.Point(31, 170);
            this.houseNumberTextBox.Name = "houseNumberTextBox";
            this.houseNumberTextBox.Size = new System.Drawing.Size(150, 31);
            this.houseNumberTextBox.TabIndex = 44;
            // 
            // localCountryLabel
            // 
            this.localCountryLabel.AutoSize = true;
            this.localCountryLabel.Location = new System.Drawing.Point(226, 63);
            this.localCountryLabel.Name = "localCountryLabel";
            this.localCountryLabel.Size = new System.Drawing.Size(102, 25);
            this.localCountryLabel.TabIndex = 57;
            this.localCountryLabel.Text = "Land (lokal)";
            // 
            // houseNumberLabel
            // 
            this.houseNumberLabel.AutoSize = true;
            this.houseNumberLabel.Location = new System.Drawing.Point(31, 142);
            this.houseNumberLabel.Name = "houseNumberLabel";
            this.houseNumberLabel.Size = new System.Drawing.Size(119, 25);
            this.houseNumberLabel.TabIndex = 45;
            this.houseNumberLabel.Text = "Hausnummer";
            // 
            // localCountryTextBox
            // 
            this.localCountryTextBox.Location = new System.Drawing.Point(226, 91);
            this.localCountryTextBox.Name = "localCountryTextBox";
            this.localCountryTextBox.Size = new System.Drawing.Size(150, 31);
            this.localCountryTextBox.TabIndex = 56;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(226, 170);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(150, 31);
            this.streetTextBox.TabIndex = 46;
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(226, 142);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(61, 25);
            this.streetLabel.TabIndex = 47;
            this.streetLabel.Text = "Straße";
            // 
            // internationalCountryTextBox
            // 
            this.internationalCountryTextBox.Location = new System.Drawing.Point(31, 91);
            this.internationalCountryTextBox.Name = "internationalCountryTextBox";
            this.internationalCountryTextBox.Size = new System.Drawing.Size(150, 31);
            this.internationalCountryTextBox.TabIndex = 54;
            // 
            // doorNumberTextBox
            // 
            this.doorNumberTextBox.Location = new System.Drawing.Point(421, 170);
            this.doorNumberTextBox.Name = "doorNumberTextBox";
            this.doorNumberTextBox.Size = new System.Drawing.Size(150, 31);
            this.doorNumberTextBox.TabIndex = 48;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(614, 63);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(100, 25);
            this.zipLabel.TabIndex = 53;
            this.zipLabel.Text = "Postleitzahl";
            // 
            // doorNumberLabel
            // 
            this.doorNumberLabel.AutoSize = true;
            this.doorNumberLabel.Location = new System.Drawing.Point(421, 142);
            this.doorNumberLabel.Name = "doorNumberLabel";
            this.doorNumberLabel.Size = new System.Drawing.Size(104, 25);
            this.doorNumberLabel.TabIndex = 49;
            this.doorNumberLabel.Text = "Türnummer";
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(614, 91);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(150, 31);
            this.zipTextBox.TabIndex = 52;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(811, 91);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(150, 31);
            this.cityTextBox.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(811, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 51;
            this.label9.Text = "Stadt";
            // 
            // orderPositionGrid
            // 
            this.orderPositionGrid.AllowUserToAddRows = false;
            this.orderPositionGrid.AllowUserToDeleteRows = false;
            this.orderPositionGrid.BackgroundColor = System.Drawing.Color.White;
            this.orderPositionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderPositionGrid.Location = new System.Drawing.Point(6, 30);
            this.orderPositionGrid.MultiSelect = false;
            this.orderPositionGrid.Name = "orderPositionGrid";
            this.orderPositionGrid.ReadOnly = true;
            this.orderPositionGrid.RowHeadersWidth = 62;
            this.orderPositionGrid.RowTemplate.Height = 33;
            this.orderPositionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderPositionGrid.Size = new System.Drawing.Size(1014, 178);
            this.orderPositionGrid.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.orderPositionGrid);
            this.groupBox2.Location = new System.Drawing.Point(12, 743);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1026, 238);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Warenkorb";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.productGrid);
            this.groupBox1.Controls.Add(this.productAmount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.addToCartButton);
            this.groupBox1.Location = new System.Drawing.Point(15, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1023, 361);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produkte";
            // 
            // OrderManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1053, 1050);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.addressGroupBox);
            this.Controls.Add(this.ownAddressRadioButton);
            this.Controls.Add(this.sameAddressRadioButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.paymentTermsComboBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.label1);
            this.Name = "OrderManagementForm";
            this.Text = "OrderManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productAmount)).EndInit();
            this.addressGroupBox.ResumeLayout(false);
            this.addressGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderPositionGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.GroupBox addressGroupBox;
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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}