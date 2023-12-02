namespace MockExam.InClassDemo
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
            this.customerListBox = new System.Windows.Forms.ListBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwind2DataSet = new MockExam.InClassDemo.Northwind2DataSet();
            this.customerDetailsBox = new System.Windows.Forms.GroupBox();
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requiredDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shippedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shipAddressTextBox = new System.Windows.Forms.TextBox();
            this.shipCityTextBox = new System.Windows.Forms.TextBox();
            this.shipPostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.shipCountryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customersTableAdapter = new MockExam.InClassDemo.Northwind2DataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new MockExam.InClassDemo.Northwind2DataSetTableAdapters.TableAdapterManager();
            this.ordersTableAdapter = new MockExam.InClassDemo.Northwind2DataSetTableAdapters.OrdersTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwind2DataSet)).BeginInit();
            this.customerDetailsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(11, 80);
            addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(66, 18);
            addressLabel.TabIndex = 9;
            addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.Location = new System.Drawing.Point(11, 112);
            cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(37, 18);
            cityLabel.TabIndex = 11;
            cityLabel.Text = "City:";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            postalCodeLabel.Location = new System.Drawing.Point(11, 145);
            postalCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(94, 18);
            postalCodeLabel.TabIndex = 15;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            countryLabel.Location = new System.Drawing.Point(11, 177);
            countryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(64, 18);
            countryLabel.TabIndex = 17;
            countryLabel.Text = "Country:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(18, 393);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(76, 16);
            orderDateLabel.TabIndex = 31;
            orderDateLabel.Text = "Order Date:";
            // 
            // requiredDateLabel
            // 
            requiredDateLabel.AutoSize = true;
            requiredDateLabel.Location = new System.Drawing.Point(18, 421);
            requiredDateLabel.Name = "requiredDateLabel";
            requiredDateLabel.Size = new System.Drawing.Size(98, 16);
            requiredDateLabel.TabIndex = 33;
            requiredDateLabel.Text = "Required Date:";
            // 
            // shippedDateLabel
            // 
            shippedDateLabel.AutoSize = true;
            shippedDateLabel.Location = new System.Drawing.Point(18, 449);
            shippedDateLabel.Name = "shippedDateLabel";
            shippedDateLabel.Size = new System.Drawing.Size(93, 16);
            shippedDateLabel.TabIndex = 35;
            shippedDateLabel.Text = "Shipped Date:";
            // 
            // shipAddressLabel
            // 
            shipAddressLabel.AutoSize = true;
            shipAddressLabel.Location = new System.Drawing.Point(18, 480);
            shipAddressLabel.Name = "shipAddressLabel";
            shipAddressLabel.Size = new System.Drawing.Size(91, 16);
            shipAddressLabel.TabIndex = 43;
            shipAddressLabel.Text = "Ship Address:";
            // 
            // shipCityLabel
            // 
            shipCityLabel.AutoSize = true;
            shipCityLabel.Location = new System.Drawing.Point(18, 508);
            shipCityLabel.Name = "shipCityLabel";
            shipCityLabel.Size = new System.Drawing.Size(62, 16);
            shipCityLabel.TabIndex = 45;
            shipCityLabel.Text = "Ship City:";
            // 
            // shipPostalCodeLabel
            // 
            shipPostalCodeLabel.AutoSize = true;
            shipPostalCodeLabel.Location = new System.Drawing.Point(18, 536);
            shipPostalCodeLabel.Name = "shipPostalCodeLabel";
            shipPostalCodeLabel.Size = new System.Drawing.Size(114, 16);
            shipPostalCodeLabel.TabIndex = 49;
            shipPostalCodeLabel.Text = "Ship Postal Code:";
            // 
            // shipCountryLabel
            // 
            shipCountryLabel.AutoSize = true;
            shipCountryLabel.Location = new System.Drawing.Point(18, 564);
            shipCountryLabel.Name = "shipCountryLabel";
            shipCountryLabel.Size = new System.Drawing.Size(85, 16);
            shipCountryLabel.TabIndex = 51;
            shipCountryLabel.Text = "Ship Country:";
            // 
            // customerGroupBox
            // 
            this.customerGroupBox.Controls.Add(this.customerListBox);
            this.customerGroupBox.Location = new System.Drawing.Point(17, 41);
            this.customerGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerGroupBox.Name = "customerGroupBox";
            this.customerGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.customerGroupBox.Size = new System.Drawing.Size(616, 833);
            this.customerGroupBox.TabIndex = 0;
            this.customerGroupBox.TabStop = false;
            this.customerGroupBox.Text = "Customers";
            // 
            // customerListBox
            // 
            this.customerListBox.DataSource = this.customersBindingSource;
            this.customerListBox.DisplayMember = "CompanyName";
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.ItemHeight = 16;
            this.customerListBox.Location = new System.Drawing.Point(9, 25);
            this.customerListBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.Size = new System.Drawing.Size(597, 804);
            this.customerListBox.TabIndex = 0;
            this.customerListBox.SelectedIndexChanged += new System.EventHandler(this.customerListBox_SelectedIndexChanged);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.northwind2DataSet;
            // 
            // northwind2DataSet
            // 
            this.northwind2DataSet.DataSetName = "Northwind2DataSet";
            this.northwind2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerDetailsBox
            // 
            this.customerDetailsBox.Controls.Add(this.textBox1);
            this.customerDetailsBox.Controls.Add(orderDateLabel);
            this.customerDetailsBox.Controls.Add(this.orderDateDateTimePicker);
            this.customerDetailsBox.Controls.Add(requiredDateLabel);
            this.customerDetailsBox.Controls.Add(this.requiredDateDateTimePicker);
            this.customerDetailsBox.Controls.Add(shippedDateLabel);
            this.customerDetailsBox.Controls.Add(this.shippedDateDateTimePicker);
            this.customerDetailsBox.Controls.Add(shipAddressLabel);
            this.customerDetailsBox.Controls.Add(this.shipAddressTextBox);
            this.customerDetailsBox.Controls.Add(shipCityLabel);
            this.customerDetailsBox.Controls.Add(this.shipCityTextBox);
            this.customerDetailsBox.Controls.Add(shipPostalCodeLabel);
            this.customerDetailsBox.Controls.Add(this.shipPostalCodeTextBox);
            this.customerDetailsBox.Controls.Add(shipCountryLabel);
            this.customerDetailsBox.Controls.Add(this.shipCountryTextBox);
            this.customerDetailsBox.Controls.Add(this.label2);
            this.customerDetailsBox.Controls.Add(this.label1);
            this.customerDetailsBox.Controls.Add(addressLabel);
            this.customerDetailsBox.Controls.Add(this.addressTextBox);
            this.customerDetailsBox.Controls.Add(cityLabel);
            this.customerDetailsBox.Controls.Add(this.cityTextBox);
            this.customerDetailsBox.Controls.Add(postalCodeLabel);
            this.customerDetailsBox.Controls.Add(this.postalCodeTextBox);
            this.customerDetailsBox.Controls.Add(countryLabel);
            this.customerDetailsBox.Controls.Add(this.countryTextBox);
            this.customerDetailsBox.Controls.Add(this.customerNameLabel);
            this.customerDetailsBox.Location = new System.Drawing.Point(659, 41);
            this.customerDetailsBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerDetailsBox.Name = "customerDetailsBox";
            this.customerDetailsBox.Padding = new System.Windows.Forms.Padding(4);
            this.customerDetailsBox.Size = new System.Drawing.Size(669, 833);
            this.customerDetailsBox.TabIndex = 1;
            this.customerDetailsBox.TabStop = false;
            this.customerDetailsBox.Text = "Customer Details";
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "OrderDate", true));
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(138, 389);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.orderDateDateTimePicker.TabIndex = 32;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "FK_Orders_Customers";
            this.ordersBindingSource.DataSource = this.customersBindingSource;
            // 
            // requiredDateDateTimePicker
            // 
            this.requiredDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "RequiredDate", true));
            this.requiredDateDateTimePicker.Location = new System.Drawing.Point(138, 417);
            this.requiredDateDateTimePicker.Name = "requiredDateDateTimePicker";
            this.requiredDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.requiredDateDateTimePicker.TabIndex = 34;
            // 
            // shippedDateDateTimePicker
            // 
            this.shippedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "ShippedDate", true));
            this.shippedDateDateTimePicker.Location = new System.Drawing.Point(138, 445);
            this.shippedDateDateTimePicker.Name = "shippedDateDateTimePicker";
            this.shippedDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.shippedDateDateTimePicker.TabIndex = 36;
            // 
            // shipAddressTextBox
            // 
            this.shipAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipAddress", true));
            this.shipAddressTextBox.Location = new System.Drawing.Point(138, 477);
            this.shipAddressTextBox.Name = "shipAddressTextBox";
            this.shipAddressTextBox.Size = new System.Drawing.Size(200, 22);
            this.shipAddressTextBox.TabIndex = 44;
            // 
            // shipCityTextBox
            // 
            this.shipCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipCity", true));
            this.shipCityTextBox.Location = new System.Drawing.Point(138, 505);
            this.shipCityTextBox.Name = "shipCityTextBox";
            this.shipCityTextBox.Size = new System.Drawing.Size(200, 22);
            this.shipCityTextBox.TabIndex = 46;
            // 
            // shipPostalCodeTextBox
            // 
            this.shipPostalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipPostalCode", true));
            this.shipPostalCodeTextBox.Location = new System.Drawing.Point(138, 533);
            this.shipPostalCodeTextBox.Name = "shipPostalCodeTextBox";
            this.shipPostalCodeTextBox.Size = new System.Drawing.Size(200, 22);
            this.shipPostalCodeTextBox.TabIndex = 50;
            // 
            // shipCountryTextBox
            // 
            this.shipCountryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipCountry", true));
            this.shipCountryTextBox.Location = new System.Drawing.Point(138, 561);
            this.shipCountryTextBox.Name = "shipCountryTextBox";
            this.shipCountryTextBox.Size = new System.Drawing.Size(200, 22);
            this.shipCountryTextBox.TabIndex = 52;
            this.shipCountryTextBox.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Last Order Details";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(163, 73);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(267, 24);
            this.addressTextBox.TabIndex = 10;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(163, 105);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(267, 24);
            this.cityTextBox.TabIndex = 12;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "PostalCode", true));
            this.postalCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalCodeTextBox.Location = new System.Drawing.Point(163, 138);
            this.postalCodeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(267, 24);
            this.postalCodeTextBox.TabIndex = 16;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Country", true));
            this.countryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryTextBox.Location = new System.Drawing.Point(163, 170);
            this.countryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(267, 24);
            this.countryTextBox.TabIndex = 18;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CompanyName", true));
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(8, 26);
            this.customerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(273, 25);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "{InsertCustomerNameHere}";
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.OrderDetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.TerritoriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MockExam.InClassDemo.Northwind2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 625);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Notes";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipCountry", true));
            this.textBox1.Location = new System.Drawing.Point(21, 663);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 22);
            this.textBox1.TabIndex = 53;
            this.textBox1.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 889);
            this.Controls.Add(this.customerDetailsBox);
            this.Controls.Add(this.customerGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Trishan Gunness - 000237007";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.customerGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwind2DataSet)).EndInit();
            this.customerDetailsBox.ResumeLayout(false);
            this.customerDetailsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox customerGroupBox;
        private System.Windows.Forms.ListBox customerListBox;
        private System.Windows.Forms.GroupBox customerDetailsBox;
        private System.Windows.Forms.Label customerNameLabel;
        private Northwind2DataSet northwind2DataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Northwind2DataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private Northwind2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private Northwind2DataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker requiredDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker shippedDateDateTimePicker;
        private System.Windows.Forms.TextBox shipAddressTextBox;
        private System.Windows.Forms.TextBox shipCityTextBox;
        private System.Windows.Forms.TextBox shipPostalCodeTextBox;
        private System.Windows.Forms.TextBox shipCountryTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

