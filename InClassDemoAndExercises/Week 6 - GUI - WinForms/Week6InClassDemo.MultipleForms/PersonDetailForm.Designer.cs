﻿namespace Week6InClassDemo.MultipleForms
{
    partial class PersonDetailForm
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
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(10, 18);
            this.output.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(35, 13);
            this.output.TabIndex = 0;
            this.output.Text = "label1";
            // 
            // PersonDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.output);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PersonDetailForm";
            this.Text = "PersonDetailForm";
            this.Load += new System.EventHandler(this.PersonDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label output;
    }
}