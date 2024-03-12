namespace TestWork
{
    partial class EmployeeCard
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
            this.insertButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.newEmployeeButton = new System.Windows.Forms.Button();
            this.promoteButton = new System.Windows.Forms.Button();
            this.cardGroupBox = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.educationComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.dismissalDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.hireDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.birthdayDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.employeeNumberTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.promotionTextBlock = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableComboBox = new System.Windows.Forms.ComboBox();
            this.cardGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertButton
            // 
            this.insertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.insertButton.Location = new System.Drawing.Point(611, 352);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(76, 67);
            this.insertButton.TabIndex = 6;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.Location = new System.Drawing.Point(75, 352);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(76, 67);
            this.deleteButton.TabIndex = 21;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Location = new System.Drawing.Point(541, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(146, 21);
            this.updateButton.TabIndex = 22;
            this.updateButton.Text = "Update table";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // newEmployeeButton
            // 
            this.newEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newEmployeeButton.Location = new System.Drawing.Point(691, 32);
            this.newEmployeeButton.Name = "newEmployeeButton";
            this.newEmployeeButton.Size = new System.Drawing.Size(76, 67);
            this.newEmployeeButton.TabIndex = 23;
            this.newEmployeeButton.Text = "New employee";
            this.newEmployeeButton.UseVisualStyleBackColor = true;
            this.newEmployeeButton.Click += new System.EventHandler(this.NewEmployeeButton_Click);
            // 
            // promoteButton
            // 
            this.promoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.promoteButton.Location = new System.Drawing.Point(529, 352);
            this.promoteButton.Name = "promoteButton";
            this.promoteButton.Size = new System.Drawing.Size(76, 65);
            this.promoteButton.TabIndex = 27;
            this.promoteButton.Text = "Promote";
            this.promoteButton.UseVisualStyleBackColor = true;
            this.promoteButton.Click += new System.EventHandler(this.PromoteButton_Click);
            // 
            // cardGroupBox
            // 
            this.cardGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cardGroupBox.Controls.Add(this.idTextBox);
            this.cardGroupBox.Controls.Add(this.educationComboBox);
            this.cardGroupBox.Controls.Add(this.label7);
            this.cardGroupBox.Controls.Add(this.departmentComboBox);
            this.cardGroupBox.Controls.Add(this.patronymicTextBox);
            this.cardGroupBox.Controls.Add(this.label12);
            this.cardGroupBox.Controls.Add(this.label8);
            this.cardGroupBox.Controls.Add(this.surnameTextBox);
            this.cardGroupBox.Controls.Add(this.dismissalDatePicker);
            this.cardGroupBox.Controls.Add(this.label1);
            this.cardGroupBox.Controls.Add(this.hireDatePicker);
            this.cardGroupBox.Controls.Add(this.label9);
            this.cardGroupBox.Controls.Add(this.birthdayDatePicker);
            this.cardGroupBox.Controls.Add(this.label2);
            this.cardGroupBox.Controls.Add(this.sexComboBox);
            this.cardGroupBox.Controls.Add(this.employeeNumberTextBox);
            this.cardGroupBox.Controls.Add(this.label11);
            this.cardGroupBox.Controls.Add(this.label3);
            this.cardGroupBox.Controls.Add(this.promotionTextBlock);
            this.cardGroupBox.Controls.Add(this.label10);
            this.cardGroupBox.Controls.Add(this.nameTextBox);
            this.cardGroupBox.Controls.Add(this.label4);
            this.cardGroupBox.Controls.Add(this.label5);
            this.cardGroupBox.Controls.Add(this.label6);
            this.cardGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cardGroupBox.Location = new System.Drawing.Point(75, 32);
            this.cardGroupBox.Name = "cardGroupBox";
            this.cardGroupBox.Size = new System.Drawing.Size(612, 316);
            this.cardGroupBox.TabIndex = 32;
            this.cardGroupBox.TabStop = false;
            this.cardGroupBox.Text = "EmployeeCard";
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTextBox.Location = new System.Drawing.Point(162, 65);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(295, 20);
            this.idTextBox.TabIndex = 27;
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // educationComboBox
            // 
            this.educationComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.educationComboBox.FormattingEnabled = true;
            this.educationComboBox.Location = new System.Drawing.Point(313, 142);
            this.educationComboBox.Name = "educationComboBox";
            this.educationComboBox.Size = new System.Drawing.Size(111, 21);
            this.educationComboBox.TabIndex = 31;
            this.educationComboBox.Tag = "EmployeeDataControls";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Department";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(313, 116);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(111, 21);
            this.departmentComboBox.TabIndex = 29;
            this.departmentComboBox.Tag = "EmployeeDataControls";
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patronymicTextBox.Location = new System.Drawing.Point(190, 169);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(117, 20);
            this.patronymicTextBox.TabIndex = 3;
            this.patronymicTextBox.Tag = "EmployeeDataControls";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(284, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Index";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Education";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.surnameTextBox.Location = new System.Drawing.Point(190, 117);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(117, 20);
            this.surnameTextBox.TabIndex = 1;
            this.surnameTextBox.Tag = "EmployeeDataControls";
            // 
            // dismissalDatePicker
            // 
            this.dismissalDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dismissalDatePicker.Checked = false;
            this.dismissalDatePicker.CustomFormat = "";
            this.dismissalDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dismissalDatePicker.Location = new System.Drawing.Point(313, 195);
            this.dismissalDatePicker.Name = "dismissalDatePicker";
            this.dismissalDatePicker.ShowCheckBox = true;
            this.dismissalDatePicker.Size = new System.Drawing.Size(111, 20);
            this.dismissalDatePicker.TabIndex = 26;
            this.dismissalDatePicker.Tag = "EmployeeDataControls";
            this.dismissalDatePicker.Value = new System.DateTime(2024, 3, 11, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employee Number";
            // 
            // hireDatePicker
            // 
            this.hireDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hireDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hireDatePicker.Location = new System.Drawing.Point(313, 170);
            this.hireDatePicker.Name = "hireDatePicker";
            this.hireDatePicker.Size = new System.Drawing.Size(111, 20);
            this.hireDatePicker.TabIndex = 25;
            this.hireDatePicker.Tag = "EmployeeDataControls";
            this.hireDatePicker.Value = new System.DateTime(2024, 3, 11, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(432, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Hire date";
            // 
            // birthdayDatePicker
            // 
            this.birthdayDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthdayDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdayDatePicker.Location = new System.Drawing.Point(313, 92);
            this.birthdayDatePicker.Name = "birthdayDatePicker";
            this.birthdayDatePicker.Size = new System.Drawing.Size(111, 20);
            this.birthdayDatePicker.TabIndex = 24;
            this.birthdayDatePicker.Tag = "EmployeeDataControls";
            this.birthdayDatePicker.Value = new System.DateTime(2024, 3, 11, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Surname";
            // 
            // sexComboBox
            // 
            this.sexComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.sexComboBox.Location = new System.Drawing.Point(190, 195);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(117, 21);
            this.sexComboBox.TabIndex = 23;
            this.sexComboBox.Tag = "EmployeeDataControls";
            // 
            // employeeNumberTextBox
            // 
            this.employeeNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeNumberTextBox.Location = new System.Drawing.Point(190, 91);
            this.employeeNumberTextBox.MaxLength = 5;
            this.employeeNumberTextBox.Name = "employeeNumberTextBox";
            this.employeeNumberTextBox.Size = new System.Drawing.Size(117, 20);
            this.employeeNumberTextBox.TabIndex = 0;
            this.employeeNumberTextBox.Tag = "EmployeeDataControls";
            this.employeeNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeNumberTextBox_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(254, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "PerсentPromotion(%)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name";
            // 
            // promotionTextBlock
            // 
            this.promotionTextBlock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.promotionTextBlock.Location = new System.Drawing.Point(162, 220);
            this.promotionTextBlock.Name = "promotionTextBlock";
            this.promotionTextBlock.Size = new System.Drawing.Size(295, 20);
            this.promotionTextBlock.TabIndex = 21;
            this.promotionTextBlock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PromotionTextBlock_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Dismissal Date";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Location = new System.Drawing.Point(190, 143);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(117, 20);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.Tag = "EmployeeDataControls";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Patronymic";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sex";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Birthday date";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tableComboBox);
            this.panel1.Controls.Add(this.cardGroupBox);
            this.panel1.Controls.Add(this.promoteButton);
            this.panel1.Controls.Add(this.newEmployeeButton);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.insertButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 21;
            // 
            // tableComboBox
            // 
            this.tableComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableComboBox.FormattingEnabled = true;
            this.tableComboBox.Items.AddRange(new object[] {
            "Employee",
            "PromotedEmployee"});
            this.tableComboBox.Location = new System.Drawing.Point(237, 5);
            this.tableComboBox.Name = "tableComboBox";
            this.tableComboBox.Size = new System.Drawing.Size(295, 21);
            this.tableComboBox.TabIndex = 32;
            this.tableComboBox.Tag = "EmployeeDataControls";
            // 
            // EmployeeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "EmployeeCard";
            this.Text = "EmployeeCard";
            this.Load += new System.EventHandler(this.EmployeeCard_Load);
            this.cardGroupBox.ResumeLayout(false);
            this.cardGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button newEmployeeButton;
        private System.Windows.Forms.Button promoteButton;
        private System.Windows.Forms.GroupBox cardGroupBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox educationComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.DateTimePicker dismissalDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker hireDatePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker birthdayDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.TextBox employeeNumberTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox promotionTextBlock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox tableComboBox;
    }
}