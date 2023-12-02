namespace MyMockSolutionWinFormQuestion2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label requiredDateLabel;
            System.Windows.Forms.Label shippedDateLabel;
            System.Windows.Forms.Label shipAddressLabel;
            System.Windows.Forms.Label shipCityLabel;
            System.Windows.Forms.Label shipPostalCodeLabel;
            System.Windows.Forms.Label shipCountryLabel;
            this.customerGroupBox = new System.Windows.Forms.GroupBox();
            this.customerDetailGroupBox = new System.Windows.Forms.GroupBox();
            this.customerListBox = new System.Windows.Forms.ListBox();
            this.northWind3DataSet = new MyMockSolutionWinFormQuestion2.NorthWind3DataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new MyMockSolutionWinFormQuestion2.NorthWind3DataSetTableAdapters.CustomersTableAdapter();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.tableAdapterManager = new MyMockSolutionWinFormQuestion2.NorthWind3DataSetTableAdapters.TableAdapterManager();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.lastOrderDetailsLabel = new System.Windows.Forms.Label();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new MyMockSolutionWinFormQuestion2.NorthWind3DataSetTableAdapters.OrdersTableAdapter();
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.requiredDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shippedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shipAddressTextBox = new System.Windows.Forms.TextBox();
            this.shipCityTextBox = new System.Windows.Forms.TextBox();
            this.shipPostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.shipCountryTextBox = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.shipViaTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            requiredDateLabel = new System.Windows.Forms.Label();
            shippedDateLabel = new System.Windows.Forms.Label();
            shipAddressLabel = new System.Windows.Forms.Label();
            shipCityLabel = new System.Windows.Forms.Label();
            shipPostalCodeLabel = new System.Windows.Forms.Label();
            shipCountryLabel = new System.Windows.Forms.Label();
            this.customerGroupBox.SuspendLayout();
            this.customerDetailGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.northWind3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerGroupBox
            // 
            this.customerGroupBox.Controls.Add(this.customerListBox);
            this.customerGroupBox.Location = new System.Drawing.Point(13, 13);
            this.customerGroupBox.Name = "customerGroupBox";
            this.customerGroupBox.Size = new System.Drawing.Size(439, 529);
            this.customerGroupBox.TabIndex = 0;
            this.customerGroupBox.TabStop = false;
            this.customerGroupBox.Text = "Customers";
            // 
            // customerDetailGroupBox
            // 
            this.customerDetailGroupBox.Controls.Add(this.notesTextBox);
            this.customerDetailGroupBox.Controls.Add(this.shipViaTextBox);
            this.customerDetailGroupBox.Controls.Add(this.notesLabel);
            this.customerDetailGroupBox.Controls.Add(orderDateLabel);
            this.customerDetailGroupBox.Controls.Add(this.orderDateDateTimePicker);
            this.customerDetailGroupBox.Controls.Add(requiredDateLabel);
            this.customerDetailGroupBox.Controls.Add(this.requiredDateDateTimePicker);
            this.customerDetailGroupBox.Controls.Add(shippedDateLabel);
            this.customerDetailGroupBox.Controls.Add(this.shippedDateDateTimePicker);
            this.customerDetailGroupBox.Controls.Add(shipAddressLabel);
            this.customerDetailGroupBox.Controls.Add(this.shipAddressTextBox);
            this.customerDetailGroupBox.Controls.Add(shipCityLabel);
            this.customerDetailGroupBox.Controls.Add(this.shipCityTextBox);
            this.customerDetailGroupBox.Controls.Add(shipPostalCodeLabel);
            this.customerDetailGroupBox.Controls.Add(this.shipPostalCodeTextBox);
            this.customerDetailGroupBox.Controls.Add(shipCountryLabel);
            this.customerDetailGroupBox.Controls.Add(this.shipCountryTextBox);
            this.customerDetailGroupBox.Controls.Add(this.lastOrderDetailsLabel);
            this.customerDetailGroupBox.Controls.Add(countryLabel);
            this.customerDetailGroupBox.Controls.Add(this.countryTextBox);
            this.customerDetailGroupBox.Controls.Add(postalCodeLabel);
            this.customerDetailGroupBox.Controls.Add(this.postalCodeTextBox);
            this.customerDetailGroupBox.Controls.Add(cityLabel);
            this.customerDetailGroupBox.Controls.Add(this.cityTextBox);
            this.customerDetailGroupBox.Controls.Add(addressLabel);
            this.customerDetailGroupBox.Controls.Add(this.addressTextBox);
            this.customerDetailGroupBox.Controls.Add(this.customerNameLabel);
            this.customerDetailGroupBox.Location = new System.Drawing.Point(469, 13);
            this.customerDetailGroupBox.Name = "customerDetailGroupBox";
            this.customerDetailGroupBox.Size = new System.Drawing.Size(576, 637);
            this.customerDetailGroupBox.TabIndex = 1;
            this.customerDetailGroupBox.TabStop = false;
            this.customerDetailGroupBox.Text = "CustomerDetails";
            // 
            // customerListBox
            // 
            this.customerListBox.DataSource = this.customersBindingSource;
            this.customerListBox.DisplayMember = "CompanyName";
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.ItemHeight = 16;
            this.customerListBox.Location = new System.Drawing.Point(7, 22);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.Size = new System.Drawing.Size(426, 500);
            this.customerListBox.TabIndex = 0;
            this.customerListBox.SelectedIndexChanged += new System.EventHandler(this.customerListBox_SelectedIndexChanged);
            // 
            // northWind3DataSet
            // 
            this.northWind3DataSet.DataSetName = "NorthWind3DataSet";
            this.northWind3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.northWind3DataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CompanyName", true));
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(6, 35);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(265, 24);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "{InsertCustomerNameHere}";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomerCustomerDemoTableAdapter = null;
            this.tableAdapterManager.CustomerDemographicsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.EmployeeTerritoriesTableAdapter = null;
            this.tableAdapterManager.Order_DetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.TerritoriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MyMockSolutionWinFormQuestion2.NorthWind3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(18, 92);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(61, 16);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(108, 89);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(245, 22);
            this.addressTextBox.TabIndex = 2;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(18, 135);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(32, 16);
            cityLabel.TabIndex = 3;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(108, 129);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(245, 22);
            this.cityTextBox.TabIndex = 4;
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(18, 168);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(84, 16);
            postalCodeLabel.TabIndex = 5;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "PostalCode", true));
            this.postalCodeTextBox.Location = new System.Drawing.Point(108, 165);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(245, 22);
            this.postalCodeTextBox.TabIndex = 6;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(18, 196);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(55, 16);
            countryLabel.TabIndex = 7;
            countryLabel.Text = "Country:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(108, 196);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(245, 22);
            this.countryTextBox.TabIndex = 8;
            // 
            // lastOrderDetailsLabel
            // 
            this.lastOrderDetailsLabel.AutoSize = true;
            this.lastOrderDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastOrderDetailsLabel.Location = new System.Drawing.Point(10, 294);
            this.lastOrderDetailsLabel.Name = "lastOrderDetailsLabel";
            this.lastOrderDetailsLabel.Size = new System.Drawing.Size(137, 16);
            this.lastOrderDetailsLabel.TabIndex = 9;
            this.lastOrderDetailsLabel.Text = "Last Order Details";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "FK_Orders_Customers";
            this.ordersBindingSource.DataSource = this.customersBindingSource;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(18, 334);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(76, 16);
            orderDateLabel.TabIndex = 16;
            orderDateLabel.Text = "Order Date:";
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "OrderDate", true));
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(138, 330);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.orderDateDateTimePicker.TabIndex = 17;
            // 
            // requiredDateLabel
            // 
            requiredDateLabel.AutoSize = true;
            requiredDateLabel.Location = new System.Drawing.Point(18, 362);
            requiredDateLabel.Name = "requiredDateLabel";
            requiredDateLabel.Size = new System.Drawing.Size(98, 16);
            requiredDateLabel.TabIndex = 18;
            requiredDateLabel.Text = "Required Date:";
            // 
            // requiredDateDateTimePicker
            // 
            this.requiredDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "RequiredDate", true));
            this.requiredDateDateTimePicker.Location = new System.Drawing.Point(138, 358);
            this.requiredDateDateTimePicker.Name = "requiredDateDateTimePicker";
            this.requiredDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.requiredDateDateTimePicker.TabIndex = 19;
            // 
            // shippedDateLabel
            // 
            shippedDateLabel.AutoSize = true;
            shippedDateLabel.Location = new System.Drawing.Point(18, 390);
            shippedDateLabel.Name = "shippedDateLabel";
            shippedDateLabel.Size = new System.Drawing.Size(93, 16);
            shippedDateLabel.TabIndex = 20;
            shippedDateLabel.Text = "Shipped Date:";
            // 
            // shippedDateDateTimePicker
            // 
            this.shippedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "ShippedDate", true));
            this.shippedDateDateTimePicker.Location = new System.Drawing.Point(138, 386);
            this.shippedDateDateTimePicker.Name = "shippedDateDateTimePicker";
            this.shippedDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.shippedDateDateTimePicker.TabIndex = 21;
            // 
            // shipAddressLabel
            // 
            shipAddressLabel.AutoSize = true;
            shipAddressLabel.Location = new System.Drawing.Point(18, 420);
            shipAddressLabel.Name = "shipAddressLabel";
            shipAddressLabel.Size = new System.Drawing.Size(91, 16);
            shipAddressLabel.TabIndex = 28;
            shipAddressLabel.Text = "Ship Address:";
            // 
            // shipAddressTextBox
            // 
            this.shipAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipAddress", true));
            this.shipAddressTextBox.Location = new System.Drawing.Point(138, 417);
            this.shipAddressTextBox.Name = "shipAddressTextBox";
            this.shipAddressTextBox.Size = new System.Drawing.Size(200, 22);
            this.shipAddressTextBox.TabIndex = 29;
            // 
            // shipCityLabel
            // 
            shipCityLabel.AutoSize = true;
            shipCityLabel.Location = new System.Drawing.Point(18, 448);
            shipCityLabel.Name = "shipCityLabel";
            shipCityLabel.Size = new System.Drawing.Size(62, 16);
            shipCityLabel.TabIndex = 30;
            shipCityLabel.Text = "Ship City:";
            // 
            // shipCityTextBox
            // 
            this.shipCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipCity", true));
            this.shipCityTextBox.Location = new System.Drawing.Point(138, 445);
            this.shipCityTextBox.Name = "shipCityTextBox";
            this.shipCityTextBox.Size = new System.Drawing.Size(200, 22);
            this.shipCityTextBox.TabIndex = 31;
            // 
            // shipPostalCodeLabel
            // 
            shipPostalCodeLabel.AutoSize = true;
            shipPostalCodeLabel.Location = new System.Drawing.Point(18, 483);
            shipPostalCodeLabel.Name = "shipPostalCodeLabel";
            shipPostalCodeLabel.Size = new System.Drawing.Size(114, 16);
            shipPostalCodeLabel.TabIndex = 34;
            shipPostalCodeLabel.Text = "Ship Postal Code:";
            // 
            // shipPostalCodeTextBox
            // 
            this.shipPostalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipPostalCode", true));
            this.shipPostalCodeTextBox.Location = new System.Drawing.Point(138, 480);
            this.shipPostalCodeTextBox.Name = "shipPostalCodeTextBox";
            this.shipPostalCodeTextBox.Size = new System.Drawing.Size(200, 22);
            this.shipPostalCodeTextBox.TabIndex = 35;
            // 
            // shipCountryLabel
            // 
            shipCountryLabel.AutoSize = true;
            shipCountryLabel.Location = new System.Drawing.Point(18, 511);
            shipCountryLabel.Name = "shipCountryLabel";
            shipCountryLabel.Size = new System.Drawing.Size(85, 16);
            shipCountryLabel.TabIndex = 36;
            shipCountryLabel.Text = "Ship Country:";
            // 
            // shipCountryTextBox
            // 
            this.shipCountryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipCountry", true));
            this.shipCountryTextBox.Location = new System.Drawing.Point(138, 508);
            this.shipCountryTextBox.Name = "shipCountryTextBox";
            this.shipCountryTextBox.Size = new System.Drawing.Size(200, 22);
            this.shipCountryTextBox.TabIndex = 37;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesLabel.Location = new System.Drawing.Point(10, 562);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(49, 16);
            this.notesLabel.TabIndex = 38;
            this.notesLabel.Text = "Notes";
            // 
            // shipViaTextBox
            // 
            this.shipViaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipVia", true));
            this.shipViaTextBox.Location = new System.Drawing.Point(87, 536);
            this.shipViaTextBox.Name = "shipViaTextBox";
            this.shipViaTextBox.Size = new System.Drawing.Size(100, 22);
            this.shipViaTextBox.TabIndex = 40;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(13, 594);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(403, 22);
            this.notesTextBox.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 745);
            this.Controls.Add(this.customerDetailGroupBox);
            this.Controls.Add(this.customerGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Trishan Gunness 000237007";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.customerGroupBox.ResumeLayout(false);
            this.customerDetailGroupBox.ResumeLayout(false);
            this.customerDetailGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.northWind3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox customerGroupBox;
        private System.Windows.Forms.ListBox customerListBox;
        private System.Windows.Forms.GroupBox customerDetailGroupBox;
        private NorthWind3DataSet northWind3DataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private NorthWind3DataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private NorthWind3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lastOrderDetailsLabel;
        private NorthWind3DataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker requiredDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker shippedDateDateTimePicker;
        private System.Windows.Forms.TextBox shipAddressTextBox;
        private System.Windows.Forms.TextBox shipCityTextBox;
        private System.Windows.Forms.TextBox shipPostalCodeTextBox;
        private System.Windows.Forms.TextBox shipCountryTextBox;
        private System.Windows.Forms.TextBox shipViaTextBox;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox notesTextBox;
    }
}

