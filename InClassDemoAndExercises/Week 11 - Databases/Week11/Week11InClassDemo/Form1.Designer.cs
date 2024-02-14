namespace Week11InClassDemo
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
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label contactNameLabel;
            System.Windows.Forms.Label contactTitleLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label regionLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label faxLabel;
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwind2DataSet = new Week11InClassDemo.Northwind2DataSet();
            this.customersTableAdapter = new Week11InClassDemo.Northwind2DataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new Week11InClassDemo.Northwind2DataSetTableAdapters.TableAdapterManager();
            this.insertButton = new System.Windows.Forms.Button();
            this.customerDetailGroup = new System.Windows.Forms.GroupBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.contactNameTextBox = new System.Windows.Forms.TextBox();
            this.contactTitleTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.regionTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            customerIDLabel = new System.Windows.Forms.Label();
            companyNameLabel = new System.Windows.Forms.Label();
            contactNameLabel = new System.Windows.Forms.Label();
            contactTitleLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            regionLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwind2DataSet)).BeginInit();
            this.customerDetailGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.customersBindingSource;
            this.listBox1.DisplayMember = "CompanyName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(24, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(377, 554);
            this.listBox1.TabIndex = 0;
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
            this.tableAdapterManager.Order_DetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.TerritoriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Week11InClassDemo.Northwind2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(689, 544);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(141, 83);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "Insert Record";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // customerDetailGroup
            // 
            this.customerDetailGroup.Controls.Add(customerIDLabel);
            this.customerDetailGroup.Controls.Add(this.customerIDTextBox);
            this.customerDetailGroup.Controls.Add(companyNameLabel);
            this.customerDetailGroup.Controls.Add(this.companyNameTextBox);
            this.customerDetailGroup.Controls.Add(contactNameLabel);
            this.customerDetailGroup.Controls.Add(this.contactNameTextBox);
            this.customerDetailGroup.Controls.Add(contactTitleLabel);
            this.customerDetailGroup.Controls.Add(this.contactTitleTextBox);
            this.customerDetailGroup.Controls.Add(addressLabel);
            this.customerDetailGroup.Controls.Add(this.addressTextBox);
            this.customerDetailGroup.Controls.Add(cityLabel);
            this.customerDetailGroup.Controls.Add(this.cityTextBox);
            this.customerDetailGroup.Controls.Add(regionLabel);
            this.customerDetailGroup.Controls.Add(this.regionTextBox);
            this.customerDetailGroup.Controls.Add(postalCodeLabel);
            this.customerDetailGroup.Controls.Add(this.postalCodeTextBox);
            this.customerDetailGroup.Controls.Add(countryLabel);
            this.customerDetailGroup.Controls.Add(this.countryTextBox);
            this.customerDetailGroup.Controls.Add(phoneLabel);
            this.customerDetailGroup.Controls.Add(this.phoneTextBox);
            this.customerDetailGroup.Controls.Add(faxLabel);
            this.customerDetailGroup.Controls.Add(this.faxTextBox);
            this.customerDetailGroup.Location = new System.Drawing.Point(428, 40);
            this.customerDetailGroup.Name = "customerDetailGroup";
            this.customerDetailGroup.Size = new System.Drawing.Size(625, 480);
            this.customerDetailGroup.TabIndex = 24;
            this.customerDetailGroup.TabStop = false;
            this.customerDetailGroup.Text = "Customer Details";
            this.customerDetailGroup.Enter += new System.EventHandler(this.customerDetailGroup_Enter);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(449, 544);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(141, 83);
            this.ClearButton.TabIndex = 25;
            this.ClearButton.Text = "Clear Form";
            this.ClearButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(891, 544);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(141, 83);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "Delete Record";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(62, 48);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(127, 25);
            customerIDLabel.TabIndex = 24;
            customerIDLabel.Text = "Customer ID:";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(228, 45);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(335, 30);
            this.customerIDTextBox.TabIndex = 25;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(62, 84);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(160, 25);
            companyNameLabel.TabIndex = 26;
            companyNameLabel.Text = "Company Name:";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CompanyName", true));
            this.companyNameTextBox.Location = new System.Drawing.Point(228, 81);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(335, 30);
            this.companyNameTextBox.TabIndex = 27;
            // 
            // contactNameLabel
            // 
            contactNameLabel.AutoSize = true;
            contactNameLabel.Location = new System.Drawing.Point(62, 120);
            contactNameLabel.Name = "contactNameLabel";
            contactNameLabel.Size = new System.Drawing.Size(143, 25);
            contactNameLabel.TabIndex = 28;
            contactNameLabel.Text = "Contact Name:";
            // 
            // contactNameTextBox
            // 
            this.contactNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ContactName", true));
            this.contactNameTextBox.Location = new System.Drawing.Point(228, 117);
            this.contactNameTextBox.Name = "contactNameTextBox";
            this.contactNameTextBox.Size = new System.Drawing.Size(335, 30);
            this.contactNameTextBox.TabIndex = 29;
            // 
            // contactTitleLabel
            // 
            contactTitleLabel.AutoSize = true;
            contactTitleLabel.Location = new System.Drawing.Point(62, 156);
            contactTitleLabel.Name = "contactTitleLabel";
            contactTitleLabel.Size = new System.Drawing.Size(128, 25);
            contactTitleLabel.TabIndex = 30;
            contactTitleLabel.Text = "Contact Title:";
            // 
            // contactTitleTextBox
            // 
            this.contactTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ContactTitle", true));
            this.contactTitleTextBox.Location = new System.Drawing.Point(228, 153);
            this.contactTitleTextBox.Name = "contactTitleTextBox";
            this.contactTitleTextBox.Size = new System.Drawing.Size(335, 30);
            this.contactTitleTextBox.TabIndex = 31;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(62, 192);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(91, 25);
            addressLabel.TabIndex = 32;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(228, 189);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(335, 30);
            this.addressTextBox.TabIndex = 33;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(62, 228);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(52, 25);
            cityLabel.TabIndex = 34;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(228, 225);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(335, 30);
            this.cityTextBox.TabIndex = 35;
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Location = new System.Drawing.Point(62, 264);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new System.Drawing.Size(79, 25);
            regionLabel.TabIndex = 36;
            regionLabel.Text = "Region:";
            // 
            // regionTextBox
            // 
            this.regionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Region", true));
            this.regionTextBox.Location = new System.Drawing.Point(228, 261);
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.Size = new System.Drawing.Size(335, 30);
            this.regionTextBox.TabIndex = 37;
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(62, 300);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(125, 25);
            postalCodeLabel.TabIndex = 38;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "PostalCode", true));
            this.postalCodeTextBox.Location = new System.Drawing.Point(228, 297);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(335, 30);
            this.postalCodeTextBox.TabIndex = 39;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(62, 336);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(87, 25);
            countryLabel.TabIndex = 40;
            countryLabel.Text = "Country:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(228, 333);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(335, 30);
            this.countryTextBox.TabIndex = 41;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(62, 372);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(75, 25);
            phoneLabel.TabIndex = 42;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(228, 369);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(335, 30);
            this.phoneTextBox.TabIndex = 43;
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(62, 408);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(51, 25);
            faxLabel.TabIndex = 44;
            faxLabel.Text = "Fax:";
            // 
            // faxTextBox
            // 
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(228, 405);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(335, 30);
            this.faxTextBox.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 703);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.customerDetailGroup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwind2DataSet)).EndInit();
            this.customerDetailGroup.ResumeLayout(false);
            this.customerDetailGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private Northwind2DataSet northwind2DataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Northwind2DataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private Northwind2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.GroupBox customerDetailGroup;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox contactNameTextBox;
        private System.Windows.Forms.TextBox contactTitleTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox regionTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox faxTextBox;
    }
}

