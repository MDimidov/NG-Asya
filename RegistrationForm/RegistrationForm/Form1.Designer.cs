namespace RegistrationForm
{
    partial class Form1
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
            lbName = new Label();
            tbName = new TextBox();
            tbLastName = new TextBox();
            lbLastName = new Label();
            gpGender = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            tbAddress = new TextBox();
            lbAddress = new Label();
            tbPostCode = new TextBox();
            lbPostCode = new Label();
            cmbCity = new ComboBox();
            lbCity = new Label();
            lbRegisterPerson = new Label();
            rtbRegisterPerson = new RichTextBox();
            gpGender.SuspendLayout();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(38, 27);
            lbName.Name = "lbName";
            lbName.Size = new Size(31, 15);
            lbName.TabIndex = 0;
            lbName.Text = "Име";
            // 
            // tbName
            // 
            tbName.Location = new Point(38, 57);
            tbName.Name = "tbName";
            tbName.Size = new Size(200, 23);
            tbName.TabIndex = 1;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(38, 124);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(200, 23);
            tbLastName.TabIndex = 3;
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Location = new Point(38, 94);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(58, 15);
            lbLastName.TabIndex = 2;
            lbLastName.Text = "Фамилия";
            // 
            // gpGender
            // 
            gpGender.Controls.Add(rbFemale);
            gpGender.Controls.Add(rbMale);
            gpGender.Location = new Point(38, 175);
            gpGender.Name = "gpGender";
            gpGender.Size = new Size(200, 109);
            gpGender.TabIndex = 4;
            gpGender.TabStop = false;
            gpGender.Text = "Пол";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(26, 61);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(55, 19);
            rbFemale.TabIndex = 1;
            rbFemale.TabStop = true;
            rbFemale.Text = "Жена";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(26, 22);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(52, 19);
            rbMale.TabIndex = 0;
            rbMale.TabStop = true;
            rbMale.Text = "Мъж";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(38, 398);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(200, 23);
            tbAddress.TabIndex = 8;
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(38, 368);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(40, 15);
            lbAddress.TabIndex = 7;
            lbAddress.Text = "Адрес";
            // 
            // tbPostCode
            // 
            tbPostCode.Location = new Point(38, 331);
            tbPostCode.Name = "tbPostCode";
            tbPostCode.Size = new Size(200, 23);
            tbPostCode.TabIndex = 6;
            // 
            // lbPostCode
            // 
            lbPostCode.AutoSize = true;
            lbPostCode.Location = new Point(38, 301);
            lbPostCode.Name = "lbPostCode";
            lbPostCode.Size = new Size(76, 15);
            lbPostCode.TabIndex = 5;
            lbPostCode.Text = "Код на града";
            // 
            // cmbCity
            // 
            cmbCity.FormattingEnabled = true;
            cmbCity.Items.AddRange(new object[] { "Варна", "София", "Ямбол", "Бургас", "Несебър" });
            cmbCity.Location = new Point(38, 466);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(200, 23);
            cmbCity.TabIndex = 9;
            cmbCity.SelectedIndexChanged += cmbCity_SelectedIndexChanged;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(38, 442);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(32, 15);
            lbCity.TabIndex = 10;
            lbCity.Text = "Град";
            // 
            // lbRegisterPerson
            // 
            lbRegisterPerson.AutoSize = true;
            lbRegisterPerson.Location = new Point(359, 49);
            lbRegisterPerson.Name = "lbRegisterPerson";
            lbRegisterPerson.Size = new Size(122, 15);
            lbRegisterPerson.TabIndex = 11;
            lbRegisterPerson.Text = "Регистрацяи на лице";
            // 
            // rtbRegisterPerson
            // 
            rtbRegisterPerson.Location = new Point(359, 71);
            rtbRegisterPerson.Name = "rtbRegisterPerson";
            rtbRegisterPerson.Size = new Size(277, 312);
            rtbRegisterPerson.TabIndex = 12;
            rtbRegisterPerson.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 531);
            Controls.Add(rtbRegisterPerson);
            Controls.Add(lbRegisterPerson);
            Controls.Add(lbCity);
            Controls.Add(cmbCity);
            Controls.Add(tbAddress);
            Controls.Add(lbAddress);
            Controls.Add(tbPostCode);
            Controls.Add(lbPostCode);
            Controls.Add(gpGender);
            Controls.Add(tbLastName);
            Controls.Add(lbLastName);
            Controls.Add(tbName);
            Controls.Add(lbName);
            Name = "Form1";
            Text = "Form1";
            gpGender.ResumeLayout(false);
            gpGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private TextBox tbName;
        private TextBox tbLastName;
        private Label lbLastName;
        private GroupBox gpGender;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private TextBox tbAddress;
        private Label lbAddress;
        private TextBox tbPostCode;
        private Label lbPostCode;
        private ComboBox cmbCity;
        private Label lbCity;
        private Label lbRegisterPerson;
        private RichTextBox rtbRegisterPerson;
    }
}
