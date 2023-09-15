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
            this.listButton = new System.Windows.Forms.Button();
            this.mileageButton = new System.Windows.Forms.Button();
            this.makeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(12, 12);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(177, 66);
            this.listButton.TabIndex = 0;
            this.listButton.Text = "List All Cars";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.DisplayListAllCars);
            // 
            // mileageButton
            // 
            this.mileageButton.Location = new System.Drawing.Point(12, 93);
            this.mileageButton.Name = "mileageButton";
            this.mileageButton.Size = new System.Drawing.Size(177, 66);
            this.mileageButton.TabIndex = 1;
            this.mileageButton.Text = "Car with Best Mileage";
            this.mileageButton.UseVisualStyleBackColor = true;
            this.mileageButton.Click += new System.EventHandler(this.DisplayBestMileageCar);
            // 
            // makeButton
            // 
            this.makeButton.Location = new System.Drawing.Point(12, 175);
            this.makeButton.Name = "makeButton";
            this.makeButton.Size = new System.Drawing.Size(177, 66);
            this.makeButton.TabIndex = 2;
            this.makeButton.Text = "Cars Built By Ford";
            this.makeButton.UseVisualStyleBackColor = true;
            this.makeButton.Click += new System.EventHandler(this.DisplayCarByMake);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 264);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(177, 66);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitApp);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(234, 56);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(517, 368);
            this.outputBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.makeButton);
            this.Controls.Add(this.mileageButton);
            this.Controls.Add(this.listButton);
            this.Name = "Form1";
            this.Text = "COMP10204 - Week #2 In Lab Exercise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button mileageButton;
        private System.Windows.Forms.Button makeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label1;
    }
}

