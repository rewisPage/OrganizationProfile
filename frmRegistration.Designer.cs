namespace OrganizationProfile
{
    partial class frmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            txtAge = new TextBox();
            label4 = new Label();
            txtFirstName = new TextBox();
            label5 = new Label();
            txtMiddleInitial = new TextBox();
            label6 = new Label();
            label7 = new Label();
            cbPrograms = new ComboBox();
            cbGender = new ComboBox();
            label8 = new Label();
            datePickerBirthday = new DateTimePicker();
            label9 = new Label();
            txtContactNo = new TextBox();
            label10 = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 32);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 1;
            label2.Text = "Student No.";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentNo.Location = new Point(109, 51);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(193, 29);
            txtStudentNo.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(109, 86);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(193, 29);
            txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(109, 121);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(193, 29);
            txtAge.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(59, 124);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 5;
            label4.Text = "Age";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(406, 86);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(193, 29);
            txtFirstName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(309, 89);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 7;
            label5.Text = "First Name";
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddleInitial.Location = new Point(649, 86);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(56, 29);
            txtMiddleInitial.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(612, 89);
            label6.Name = "label6";
            label6.Size = new Size(31, 21);
            label6.TabIndex = 9;
            label6.Text = "MI.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(309, 54);
            label7.Name = "label7";
            label7.Size = new Size(71, 21);
            label7.TabIndex = 11;
            label7.Text = "Program";
            // 
            // cbPrograms
            // 
            cbPrograms.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Location = new Point(406, 51);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(299, 29);
            cbPrograms.TabIndex = 12;
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(406, 121);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(193, 29);
            cbGender.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(309, 124);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 13;
            label8.Text = "Gender";
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datePickerBirthday.Location = new Point(109, 164);
            datePickerBirthday.Name = "datePickerBirthday";
            datePickerBirthday.Size = new Size(286, 29);
            datePickerBirthday.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(28, 167);
            label9.Name = "label9";
            label9.Size = new Size(68, 21);
            label9.TabIndex = 16;
            label9.Text = "Birthday";
            // 
            // txtContactNo
            // 
            txtContactNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContactNo.Location = new Point(512, 164);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(193, 29);
            txtContactNo.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(415, 167);
            label10.Name = "label10";
            label10.Size = new Size(91, 21);
            label10.TabIndex = 17;
            label10.Text = "Contact No.";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(595, 216);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(110, 41);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 270);
            Controls.Add(btnRegister);
            Controls.Add(txtContactNo);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(datePickerBirthday);
            Controls.Add(cbGender);
            Controls.Add(label8);
            Controls.Add(cbPrograms);
            Controls.Add(label7);
            Controls.Add(txtMiddleInitial);
            Controls.Add(label6);
            Controls.Add(txtFirstName);
            Controls.Add(label5);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtStudentNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Organization Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtAge;
        private Label label4;
        private TextBox txtFirstName;
        private Label label5;
        private TextBox txtMiddleInitial;
        private Label label6;
        private Label label7;
        private ComboBox cbPrograms;
        private ComboBox cbGender;
        private Label label8;
        private DateTimePicker datePickerBirthday;
        private Label label9;
        private TextBox txtContactNo;
        private Label label10;
        private Button btnRegister;
    }
}
