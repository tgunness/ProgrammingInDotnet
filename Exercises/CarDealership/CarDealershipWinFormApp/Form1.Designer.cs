namespace CarDealershipWinFormApp
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
            this.listBtn = new System.Windows.Forms.Button();
            this.mileageBtn = new System.Windows.Forms.Button();
            this.makeBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBtn
            // 
            this.listBtn.Location = new System.Drawing.Point(24, 25);
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(152, 75);
            this.listBtn.TabIndex = 0;
            this.listBtn.Text = "List All Cars";
            this.listBtn.UseVisualStyleBackColor = true;
            this.listBtn.Click += new System.EventHandler(this.DisplayAllCars);
            // 
            // mileageBtn
            // 
            this.mileageBtn.Location = new System.Drawing.Point(24, 127);
            this.mileageBtn.Name = "mileageBtn";
            this.mileageBtn.Size = new System.Drawing.Size(152, 75);
            this.mileageBtn.TabIndex = 1;
            this.mileageBtn.Text = "Car with best mileage";
            this.mileageBtn.UseVisualStyleBackColor = true;
            this.mileageBtn.Click += new System.EventHandler(this.DisplayBestMileage);
            // 
            // makeBtn
            // 
            this.makeBtn.Location = new System.Drawing.Point(24, 224);
            this.makeBtn.Name = "makeBtn";
            this.makeBtn.Size = new System.Drawing.Size(152, 75);
            this.makeBtn.TabIndex = 2;
            this.makeBtn.Text = "Cars built by Ford";
            this.makeBtn.UseVisualStyleBackColor = true;
            this.makeBtn.Click += new System.EventHandler(this.DisplayMake);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(24, 323);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(152, 75);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.Exit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Output";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(222, 56);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(542, 342);
            this.outputBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.makeBtn);
            this.Controls.Add(this.mileageBtn);
            this.Controls.Add(this.listBtn);
            this.Name = "Form1";
            this.Text = "Car Dearlership GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listBtn;
        private System.Windows.Forms.Button mileageBtn;
        private System.Windows.Forms.Button makeBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputBox;
    }
}

