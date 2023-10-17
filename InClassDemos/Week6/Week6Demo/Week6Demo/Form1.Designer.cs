namespace Week6Demo
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
            this.firstName = new System.Windows.Forms.TextBox();
            this.myButton = new System.Windows.Forms.Button();
            this.bookMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.radio_room_i102 = new System.Windows.Forms.RadioButton();
            this.radio_room_a123 = new System.Windows.Forms.RadioButton();
            this.radio_room_i110 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.studentId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.confirmationLabel = new System.Windows.Forms.Label();
            this.myLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(97, 51);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 23);
            this.firstName.TabIndex = 1;
            this.firstName.Leave += new System.EventHandler(this.SetFirstName);
            // 
            // myButton
            // 
            this.myButton.Location = new System.Drawing.Point(208, 384);
            this.myButton.Name = "myButton";
            this.myButton.Size = new System.Drawing.Size(188, 46);
            this.myButton.TabIndex = 3;
            this.myButton.Text = "Book Room";
            this.myButton.UseVisualStyleBackColor = true;
            this.myButton.Click += new System.EventHandler(this.myButton_Click);
            // 
            // bookMonthCalendar
            // 
            this.bookMonthCalendar.Location = new System.Drawing.Point(206, 123);
            this.bookMonthCalendar.Name = "bookMonthCalendar";
            this.bookMonthCalendar.ShowToday = false;
            this.bookMonthCalendar.TabIndex = 4;
            this.bookMonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.bookMonthCalendar_DateChanged);
            this.bookMonthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.bookMonthCalendar_DateChanged);
            // 
            // radio_room_i102
            // 
            this.radio_room_i102.AutoSize = true;
            this.radio_room_i102.Location = new System.Drawing.Point(40, 123);
            this.radio_room_i102.Name = "radio_room_i102";
            this.radio_room_i102.Size = new System.Drawing.Size(56, 21);
            this.radio_room_i102.TabIndex = 5;
            this.radio_room_i102.TabStop = true;
            this.radio_room_i102.Text = "i102";
            this.radio_room_i102.UseVisualStyleBackColor = true;
            this.radio_room_i102.CheckedChanged += new System.EventHandler(this.radio_room_i102_CheckedChanged);
            // 
            // radio_room_a123
            // 
            this.radio_room_a123.AutoSize = true;
            this.radio_room_a123.Location = new System.Drawing.Point(40, 174);
            this.radio_room_a123.Name = "radio_room_a123";
            this.radio_room_a123.Size = new System.Drawing.Size(61, 21);
            this.radio_room_a123.TabIndex = 6;
            this.radio_room_a123.TabStop = true;
            this.radio_room_a123.Text = "a123";
            this.radio_room_a123.UseVisualStyleBackColor = true;
            this.radio_room_a123.CheckedChanged += new System.EventHandler(this.radio_room_a123_CheckedChanged);
            // 
            // radio_room_i110
            // 
            this.radio_room_i110.AutoSize = true;
            this.radio_room_i110.Location = new System.Drawing.Point(40, 217);
            this.radio_room_i110.Name = "radio_room_i110";
            this.radio_room_i110.Size = new System.Drawing.Size(56, 21);
            this.radio_room_i110.TabIndex = 7;
            this.radio_room_i110.TabStop = true;
            this.radio_room_i110.Text = "i110";
            this.radio_room_i110.UseVisualStyleBackColor = true;
            this.radio_room_i110.CheckedChanged += new System.EventHandler(this.radio_room_i110_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Last Name";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(287, 51);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 23);
            this.lastName.TabIndex = 9;
            this.lastName.Leave += new System.EventHandler(this.SetLastName);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "StudentId";
            // 
            // studentId
            // 
            this.studentId.Location = new System.Drawing.Point(474, 51);
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(100, 23);
            this.studentId.TabIndex = 11;
            this.studentId.Leave += new System.EventHandler(this.SetStudentId);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Room";
            // 
            // confirmationLabel
            // 
            this.confirmationLabel.AutoSize = true;
            this.confirmationLabel.Location = new System.Drawing.Point(17, 462);
            this.confirmationLabel.Name = "confirmationLabel";
            this.confirmationLabel.Size = new System.Drawing.Size(0, 17);
            this.confirmationLabel.TabIndex = 15;
            // 
            // myLabel
            // 
            this.myLabel.AutoSize = true;
            this.myLabel.Location = new System.Drawing.Point(17, 9);
            this.myLabel.Name = "myLabel";
            this.myLabel.Size = new System.Drawing.Size(128, 17);
            this.myLabel.TabIndex = 0;
            this.myLabel.Text = "Lab Room Booking";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 540);
            this.Controls.Add(this.confirmationLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radio_room_i110);
            this.Controls.Add(this.radio_room_a123);
            this.Controls.Add(this.radio_room_i102);
            this.Controls.Add(this.bookMonthCalendar);
            this.Controls.Add(this.myButton);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.myLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "My Week 6 Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Button myButton;
        private System.Windows.Forms.MonthCalendar bookMonthCalendar;
        private System.Windows.Forms.RadioButton radio_room_i102;
        private System.Windows.Forms.RadioButton radio_room_a123;
        private System.Windows.Forms.RadioButton radio_room_i110;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label confirmationLabel;
        private System.Windows.Forms.Label myLabel;
    }
}

