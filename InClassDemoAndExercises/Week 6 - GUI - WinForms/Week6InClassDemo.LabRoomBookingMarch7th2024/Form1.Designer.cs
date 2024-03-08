namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            this.roomGroupBox = new System.Windows.Forms.GroupBox();
            this.i110 = new System.Windows.Forms.RadioButton();
            this.a123 = new System.Windows.Forms.RadioButton();
            this.i102 = new System.Windows.Forms.RadioButton();
            this.bookingCalendar = new System.Windows.Forms.MonthCalendar();
            this.bookRoomBtn = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.roomGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lab Room Booking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(675, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "StudentId: ";
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(117, 71);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(199, 26);
            this.firstNameTextbox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(435, 71);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(199, 26);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.Location = new System.Drawing.Point(769, 71);
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.Size = new System.Drawing.Size(199, 26);
            this.studentIdTextBox.TabIndex = 6;
            // 
            // roomGroupBox
            // 
            this.roomGroupBox.Controls.Add(this.i110);
            this.roomGroupBox.Controls.Add(this.a123);
            this.roomGroupBox.Controls.Add(this.i102);
            this.roomGroupBox.Location = new System.Drawing.Point(21, 123);
            this.roomGroupBox.Name = "roomGroupBox";
            this.roomGroupBox.Size = new System.Drawing.Size(218, 342);
            this.roomGroupBox.TabIndex = 7;
            this.roomGroupBox.TabStop = false;
            this.roomGroupBox.Text = "Room";
            // 
            // i110
            // 
            this.i110.AutoSize = true;
            this.i110.Location = new System.Drawing.Point(16, 156);
            this.i110.Name = "i110";
            this.i110.Size = new System.Drawing.Size(57, 24);
            this.i110.TabIndex = 2;
            this.i110.TabStop = true;
            this.i110.Text = "i110";
            this.i110.UseVisualStyleBackColor = true;
            this.i110.CheckedChanged += new System.EventHandler(this.i110_CheckedChanged);
            // 
            // a123
            // 
            this.a123.AutoSize = true;
            this.a123.Location = new System.Drawing.Point(16, 103);
            this.a123.Name = "a123";
            this.a123.Size = new System.Drawing.Size(63, 24);
            this.a123.TabIndex = 1;
            this.a123.TabStop = true;
            this.a123.Text = "a123";
            this.a123.UseVisualStyleBackColor = true;
            this.a123.CheckedChanged += new System.EventHandler(this.a123_CheckedChanged);
            // 
            // i102
            // 
            this.i102.AutoSize = true;
            this.i102.Location = new System.Drawing.Point(16, 45);
            this.i102.Name = "i102";
            this.i102.Size = new System.Drawing.Size(57, 24);
            this.i102.TabIndex = 0;
            this.i102.TabStop = true;
            this.i102.Text = "i102";
            this.i102.UseVisualStyleBackColor = true;
            this.i102.CheckedChanged += new System.EventHandler(this.i102_CheckedChanged);
            // 
            // bookingCalendar
            // 
            this.bookingCalendar.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.bookingCalendar.Location = new System.Drawing.Point(364, 123);
            this.bookingCalendar.Name = "bookingCalendar";
            this.bookingCalendar.ShowToday = false;
            this.bookingCalendar.TabIndex = 8;
            // 
            // bookRoomBtn
            // 
            this.bookRoomBtn.Location = new System.Drawing.Point(549, 499);
            this.bookRoomBtn.Name = "bookRoomBtn";
            this.bookRoomBtn.Size = new System.Drawing.Size(129, 71);
            this.bookRoomBtn.TabIndex = 9;
            this.bookRoomBtn.Text = "Book Room";
            this.bookRoomBtn.UseVisualStyleBackColor = true;
            this.bookRoomBtn.Click += new System.EventHandler(this.bookRoomBtn_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(248, 602);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(65, 20);
            this.outputLabel.TabIndex = 10;
            this.outputLabel.Text = "{output}";
            this.outputLabel.UseMnemonic = false;
            this.outputLabel.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(848, 123);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(287, 324);
            this.listBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.bookRoomBtn);
            this.Controls.Add(this.bookingCalendar);
            this.Controls.Add(this.roomGroupBox);
            this.Controls.Add(this.studentIdTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "My Week 6 Demo";
            this.roomGroupBox.ResumeLayout(false);
            this.roomGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.GroupBox roomGroupBox;
        private System.Windows.Forms.RadioButton i110;
        private System.Windows.Forms.RadioButton a123;
        private System.Windows.Forms.RadioButton i102;
        private System.Windows.Forms.MonthCalendar bookingCalendar;
        private System.Windows.Forms.Button bookRoomBtn;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.ListBox listBox1;
    }
}

