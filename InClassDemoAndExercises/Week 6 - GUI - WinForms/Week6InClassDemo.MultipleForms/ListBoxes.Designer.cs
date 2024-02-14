namespace Week6InClassDemo.MultipleForms
{
    partial class ListBoxes
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
            this.listboxGroup = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.myListBox = new System.Windows.Forms.ListBox();
            this.listboxGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // listboxGroup
            // 
            this.listboxGroup.Controls.Add(this.exitButton);
            this.listboxGroup.Controls.Add(this.showButton);
            this.listboxGroup.Controls.Add(this.myListBox);
            this.listboxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxGroup.Location = new System.Drawing.Point(13, 13);
            this.listboxGroup.Name = "listboxGroup";
            this.listboxGroup.Size = new System.Drawing.Size(775, 416);
            this.listboxGroup.TabIndex = 0;
            this.listboxGroup.TabStop = false;
            this.listboxGroup.Text = "ListBox";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(535, 196);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(135, 70);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.Exit);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(535, 83);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(135, 70);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseMnemonic = false;
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.DisplayPerson);
            // 
            // myListBox
            // 
            this.myListBox.FormattingEnabled = true;
            this.myListBox.ItemHeight = 25;
            this.myListBox.Location = new System.Drawing.Point(7, 42);
            this.myListBox.Name = "myListBox";
            this.myListBox.Size = new System.Drawing.Size(428, 354);
            this.myListBox.TabIndex = 1;
            // 
            // ListBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listboxGroup);
            this.Name = "ListBoxes";
            this.Text = "Form1";
            this.listboxGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox listboxGroup;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ListBox myListBox;
    }
}

