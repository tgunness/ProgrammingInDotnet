namespace CarDealershipWinForm
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
            this.makeBtn = new System.Windows.Forms.Button();
            this.fuelBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBtn
            // 
            this.listBtn.Location = new System.Drawing.Point(251, 12);
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(171, 43);
            this.listBtn.TabIndex = 0;
            this.listBtn.Text = "List all cars";
            this.listBtn.UseVisualStyleBackColor = true;
            this.listBtn.Click += new System.EventHandler(this.listBtn_Click);
            // 
            // makeBtn
            // 
            this.makeBtn.Location = new System.Drawing.Point(251, 74);
            this.makeBtn.Name = "makeBtn";
            this.makeBtn.Size = new System.Drawing.Size(170, 43);
            this.makeBtn.TabIndex = 1;
            this.makeBtn.Text = "List all Ford Cars";
            this.makeBtn.UseVisualStyleBackColor = true;
            this.makeBtn.Click += new System.EventHandler(this.makeBtn_Click);
            // 
            // fuelBtn
            // 
            this.fuelBtn.Location = new System.Drawing.Point(251, 143);
            this.fuelBtn.Name = "fuelBtn";
            this.fuelBtn.Size = new System.Drawing.Size(170, 55);
            this.fuelBtn.TabIndex = 2;
            this.fuelBtn.Text = "Get Best Mileage Car";
            this.fuelBtn.UseVisualStyleBackColor = true;
            this.fuelBtn.Click += new System.EventHandler(this.fuelBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(307, 401);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 226);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 133);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.fuelBtn);
            this.Controls.Add(this.makeBtn);
            this.Controls.Add(this.listBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listBtn;
        private System.Windows.Forms.Button makeBtn;
        private System.Windows.Forms.Button fuelBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

