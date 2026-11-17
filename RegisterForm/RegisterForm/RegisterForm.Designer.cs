namespace RegisterForm
{
    partial class RegisterForm
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
            lblName = new Label();
            txtName = new TextBox();
            lblSurname = new Label();
            txtSurname = new TextBox();
            grpGender = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            lblCityCode = new Label();
            txtCityCode = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblCity = new Label();
            comboCity = new ComboBox();
            lblRegistration = new Label();
            richTextBox1 = new RichTextBox();
            grpGender.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(28, 31);
            lblName.Name = "lblName";
            lblName.Size = new Size(34, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Име:";
            // 
            // txtName
            // 
            txtName.Location = new Point(28, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 23);
            txtName.TabIndex = 1;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(28, 89);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(60, 15);
            lblSurname.TabIndex = 2;
            lblSurname.Text = "Фамилия:";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(28, 109);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(220, 23);
            txtSurname.TabIndex = 3;
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rbFemale);
            grpGender.Controls.Add(rbMale);
            grpGender.Location = new Point(28, 151);
            grpGender.Name = "grpGender";
            grpGender.Size = new Size(220, 65);
            grpGender.TabIndex = 4;
            grpGender.TabStop = false;
            grpGender.Text = "Пол";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(117, 28);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(54, 19);
            rbFemale.TabIndex = 1;
            rbFemale.TabStop = true;
            rbFemale.Text = "Жена";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(24, 28);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(54, 19);
            rbMale.TabIndex = 0;
            rbMale.TabStop = true;
            rbMale.Text = "Мъж";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // lblCityCode
            // 
            lblCityCode.AutoSize = true;
            lblCityCode.Location = new Point(28, 235);
            lblCityCode.Name = "lblCityCode";
            lblCityCode.Size = new Size(88, 15);
            lblCityCode.TabIndex = 5;
            lblCityCode.Text = "Код на града:";
            // 
            // txtCityCode
            // 
            txtCityCode.Location = new Point(28, 255);
            txtCityCode.Name = "txtCityCode";
            txtCityCode.Size = new Size(220, 23);
            txtCityCode.TabIndex = 6;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(28, 293);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(47, 15);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Адрес:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(28, 313);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(220, 23);
            txtAddress.TabIndex = 8;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(28, 351);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(39, 15);
            lblCity.TabIndex = 9;
            lblCity.Text = "Град:";
            // 
            // comboCity
            // 
            comboCity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCity.FormattingEnabled = true;
            comboCity.Items.AddRange(new object[] { "София", "Пловдив", "Варна", "Бургас", "Русе" });
            comboCity.Location = new Point(28, 371);
            comboCity.Name = "comboCity";
            comboCity.Size = new Size(220, 23);
            comboCity.TabIndex = 10;
            comboCity.SelectedIndexChanged += comboCity_SelectedIndexChanged;
            // 
            // lblRegistration
            // 
            lblRegistration.AutoSize = true;
            lblRegistration.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRegistration.Location = new Point(300, 31);
            lblRegistration.Name = "lblRegistration";
            lblRegistration.Size = new Size(163, 19);
            lblRegistration.TabIndex = 11;
            lblRegistration.Text = "Регистрация на лице";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(300, 57);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(360, 337);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 430);
            Controls.Add(richTextBox1);
            Controls.Add(lblRegistration);
            Controls.Add(comboCity);
            Controls.Add(lblCity);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtCityCode);
            Controls.Add(lblCityCode);
            Controls.Add(grpGender);
            Controls.Add(txtSurname);
            Controls.Add(lblSurname);
            Controls.Add(txtName);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация на лице";
            grpGender.ResumeLayout(false);
            grpGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblSurname;
        private TextBox txtSurname;
        private GroupBox grpGender;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Label lblCityCode;
        private TextBox txtCityCode;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblCity;
        private ComboBox comboCity;
        private Label lblRegistration;
        private RichTextBox richTextBox1;
    }
}
