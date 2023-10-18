namespace Week6InClassDemo.Dropdown
{
    partial class ComboBoxes
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
            this.myComboBoxGroup = new System.Windows.Forms.GroupBox();
            this.myComboBox = new System.Windows.Forms.ComboBox();
            this.showButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.myComboBoxGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // myComboBoxGroup
            // 
            this.myComboBoxGroup.Controls.Add(this.exitButton);
            this.myComboBoxGroup.Controls.Add(this.showButton);
            this.myComboBoxGroup.Controls.Add(this.myComboBox);
            this.myComboBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myComboBoxGroup.Location = new System.Drawing.Point(13, 13);
            this.myComboBoxGroup.Name = "myComboBoxGroup";
            this.myComboBoxGroup.Size = new System.Drawing.Size(775, 425);
            this.myComboBoxGroup.TabIndex = 0;
            this.myComboBoxGroup.TabStop = false;
            this.myComboBoxGroup.Text = "ComboBoxes";
            // 
            // myComboBox
            // 
            this.myComboBox.FormattingEnabled = true;
            this.myComboBox.Location = new System.Drawing.Point(6, 56);
            this.myComboBox.Name = "myComboBox";
            this.myComboBox.Size = new System.Drawing.Size(287, 37);
            this.myComboBox.TabIndex = 0;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(510, 121);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(131, 55);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.ShowWhatsInComboxBox);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(510, 211);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(131, 55);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.Exit);
            // 
            // ComboBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myComboBoxGroup);
            this.Name = "ComboBoxes";
            this.Text = "Form1";
            this.myComboBoxGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox myComboBoxGroup;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ComboBox myComboBox;
    }
}

