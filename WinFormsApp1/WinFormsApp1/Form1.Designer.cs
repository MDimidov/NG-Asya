namespace WinFormsApp1
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
            title = new Label();
            lbTitleNumber = new Label();
            lbTitleStock = new Label();
            lbTitlePrice = new Label();
            lbTitleQuantity = new Label();
            lbTtileTotalPrice = new Label();
            tbStockRow1 = new TextBox();
            lbNumberRow1 = new Label();
            tbPriceRow1 = new TextBox();
            tbQuantityRow1 = new TextBox();
            tbTotalPriceRow1 = new TextBox();
            btnSolve = new Button();
            label1 = new Label();
            textBox41 = new TextBox();
            textBox8 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox12 = new TextBox();
            label9 = new Label();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox16 = new TextBox();
            label10 = new Label();
            textBox15 = new TextBox();
            textBox14 = new TextBox();
            textBox13 = new TextBox();
            textBox20 = new TextBox();
            label11 = new Label();
            textBox19 = new TextBox();
            textBox18 = new TextBox();
            textBox17 = new TextBox();
            textBox24 = new TextBox();
            label12 = new Label();
            textBox23 = new TextBox();
            textBox22 = new TextBox();
            textBox21 = new TextBox();
            textBox28 = new TextBox();
            label13 = new Label();
            textBox27 = new TextBox();
            textBox26 = new TextBox();
            textBox25 = new TextBox();
            textBox32 = new TextBox();
            label14 = new Label();
            textBox31 = new TextBox();
            textBox30 = new TextBox();
            textBox29 = new TextBox();
            textBox36 = new TextBox();
            label15 = new Label();
            textBox35 = new TextBox();
            textBox34 = new TextBox();
            textBox33 = new TextBox();
            textBox40 = new TextBox();
            label16 = new Label();
            textBox39 = new TextBox();
            textBox38 = new TextBox();
            textBox37 = new TextBox();
            SuspendLayout();
            // 
            // title
            // 
            title.AccessibleRole = AccessibleRole.TitleBar;
            title.AutoSize = true;
            title.BackColor = SystemColors.Control;
            title.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 1, true);
            title.ImageAlign = ContentAlignment.MiddleRight;
            title.Location = new Point(187, 9);
            title.Name = "title";
            title.Size = new Size(382, 45);
            title.TabIndex = 1;
            title.Text = "Калкулатор за покупка";
            title.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbTitleNumber
            // 
            lbTitleNumber.AutoSize = true;
            lbTitleNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbTitleNumber.Location = new Point(52, 74);
            lbTitleNumber.Name = "lbTitleNumber";
            lbTitleNumber.Size = new Size(21, 15);
            lbTitleNumber.TabIndex = 2;
            lbTitleNumber.Text = "№";
            // 
            // lbTitleStock
            // 
            lbTitleStock.AutoSize = true;
            lbTitleStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbTitleStock.Location = new Point(197, 74);
            lbTitleStock.Name = "lbTitleStock";
            lbTitleStock.Size = new Size(39, 15);
            lbTitleStock.TabIndex = 3;
            lbTitleStock.Text = "Стока";
            // 
            // lbTitlePrice
            // 
            lbTitlePrice.AutoSize = true;
            lbTitlePrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbTitlePrice.Location = new Point(350, 74);
            lbTitlePrice.Name = "lbTitlePrice";
            lbTitlePrice.Size = new Size(94, 15);
            lbTitlePrice.TabIndex = 4;
            lbTitlePrice.Text = "Единична цена";
            // 
            // lbTitleQuantity
            // 
            lbTitleQuantity.AutoSize = true;
            lbTitleQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbTitleQuantity.Location = new Point(526, 74);
            lbTitleQuantity.Name = "lbTitleQuantity";
            lbTitleQuantity.Size = new Size(76, 15);
            lbTitleQuantity.TabIndex = 5;
            lbTitleQuantity.Text = "Количество";
            // 
            // lbTtileTotalPrice
            // 
            lbTtileTotalPrice.AutoSize = true;
            lbTtileTotalPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbTtileTotalPrice.Location = new Point(707, 74);
            lbTtileTotalPrice.Name = "lbTtileTotalPrice";
            lbTtileTotalPrice.Size = new Size(59, 15);
            lbTtileTotalPrice.TabIndex = 6;
            lbTtileTotalPrice.Text = "Стойност";
            // 
            // tbStockRow1
            // 
            tbStockRow1.Location = new Point(142, 102);
            tbStockRow1.Name = "tbStockRow1";
            tbStockRow1.Size = new Size(155, 23);
            tbStockRow1.TabIndex = 7;
            // 
            // lbNumberRow1
            // 
            lbNumberRow1.AutoSize = true;
            lbNumberRow1.Location = new Point(50, 104);
            lbNumberRow1.Name = "lbNumberRow1";
            lbNumberRow1.Size = new Size(16, 15);
            lbNumberRow1.TabIndex = 8;
            lbNumberRow1.Text = "1.";
            // 
            // tbPriceRow1
            // 
            tbPriceRow1.Location = new Point(337, 101);
            tbPriceRow1.Name = "tbPriceRow1";
            tbPriceRow1.Size = new Size(94, 23);
            tbPriceRow1.TabIndex = 9;
            tbPriceRow1.Text = "0";
            // 
            // tbQuantityRow1
            // 
            tbQuantityRow1.Location = new Point(526, 102);
            tbQuantityRow1.Name = "tbQuantityRow1";
            tbQuantityRow1.Size = new Size(76, 23);
            tbQuantityRow1.TabIndex = 10;
            tbQuantityRow1.Text = "0";
            // 
            // tbTotalPriceRow1
            // 
            tbTotalPriceRow1.BackColor = SystemColors.ScrollBar;
            tbTotalPriceRow1.Enabled = false;
            tbTotalPriceRow1.Location = new Point(697, 102);
            tbTotalPriceRow1.Name = "tbTotalPriceRow1";
            tbTotalPriceRow1.Size = new Size(91, 23);
            tbTotalPriceRow1.TabIndex = 11;
            // 
            // btnSolve
            // 
            btnSolve.BackColor = SystemColors.ControlLight;
            btnSolve.Location = new Point(64, 416);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(172, 53);
            btnSolve.TabIndex = 57;
            btnSolve.Text = "Изчисли";
            btnSolve.UseVisualStyleBackColor = false;
            btnSolve.Click += btnSolve_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 1, true);
            label1.Location = new Point(560, 432);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 58;
            label1.Text = "Обща сума:";
            // 
            // textBox41
            // 
            textBox41.BackColor = SystemColors.ScrollBar;
            textBox41.Enabled = false;
            textBox41.Location = new Point(667, 432);
            textBox41.Name = "textBox41";
            textBox41.Size = new Size(121, 23);
            textBox41.TabIndex = 59;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(142, 131);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(155, 23);
            textBox8.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 133);
            label8.Name = "label8";
            label8.Size = new Size(16, 15);
            label8.TabIndex = 13;
            label8.Text = "2.";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(337, 130);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(94, 23);
            textBox7.TabIndex = 14;
            textBox7.Text = "0";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(526, 131);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(76, 23);
            textBox6.TabIndex = 15;
            textBox6.Text = "0";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ScrollBar;
            textBox5.Enabled = false;
            textBox5.Location = new Point(697, 131);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(91, 23);
            textBox5.TabIndex = 16;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(142, 160);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(155, 23);
            textBox12.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(50, 162);
            label9.Name = "label9";
            label9.Size = new Size(16, 15);
            label9.TabIndex = 18;
            label9.Text = "3.";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(337, 159);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(94, 23);
            textBox11.TabIndex = 19;
            textBox11.Text = "0";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(526, 160);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(76, 23);
            textBox10.TabIndex = 20;
            textBox10.Text = "0";
            // 
            // textBox9
            // 
            textBox9.BackColor = SystemColors.ScrollBar;
            textBox9.Enabled = false;
            textBox9.Location = new Point(697, 160);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(91, 23);
            textBox9.TabIndex = 21;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(142, 189);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(155, 23);
            textBox16.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(50, 191);
            label10.Name = "label10";
            label10.Size = new Size(16, 15);
            label10.TabIndex = 23;
            label10.Text = "4.";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(337, 188);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(94, 23);
            textBox15.TabIndex = 24;
            textBox15.Text = "0";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(526, 189);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(76, 23);
            textBox14.TabIndex = 25;
            textBox14.Text = "0";
            // 
            // textBox13
            // 
            textBox13.BackColor = SystemColors.ScrollBar;
            textBox13.Enabled = false;
            textBox13.Location = new Point(697, 189);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(91, 23);
            textBox13.TabIndex = 26;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(142, 218);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(155, 23);
            textBox20.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(50, 220);
            label11.Name = "label11";
            label11.Size = new Size(16, 15);
            label11.TabIndex = 28;
            label11.Text = "5.";
            // 
            // textBox19
            // 
            textBox19.Location = new Point(337, 217);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(94, 23);
            textBox19.TabIndex = 29;
            textBox19.Text = "0";
            // 
            // textBox18
            // 
            textBox18.Location = new Point(526, 218);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(76, 23);
            textBox18.TabIndex = 30;
            textBox18.Text = "0";
            // 
            // textBox17
            // 
            textBox17.BackColor = SystemColors.ScrollBar;
            textBox17.Enabled = false;
            textBox17.Location = new Point(697, 218);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(91, 23);
            textBox17.TabIndex = 31;
            // 
            // textBox24
            // 
            textBox24.Location = new Point(142, 247);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(155, 23);
            textBox24.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(50, 249);
            label12.Name = "label12";
            label12.Size = new Size(16, 15);
            label12.TabIndex = 33;
            label12.Text = "6.";
            // 
            // textBox23
            // 
            textBox23.Location = new Point(337, 246);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(94, 23);
            textBox23.TabIndex = 34;
            textBox23.Text = "0";
            // 
            // textBox22
            // 
            textBox22.Location = new Point(526, 247);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(76, 23);
            textBox22.TabIndex = 35;
            textBox22.Text = "0";
            // 
            // textBox21
            // 
            textBox21.BackColor = SystemColors.ScrollBar;
            textBox21.Enabled = false;
            textBox21.Location = new Point(697, 247);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(91, 23);
            textBox21.TabIndex = 36;
            // 
            // textBox28
            // 
            textBox28.Location = new Point(142, 276);
            textBox28.Name = "textBox28";
            textBox28.Size = new Size(155, 23);
            textBox28.TabIndex = 37;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(50, 278);
            label13.Name = "label13";
            label13.Size = new Size(16, 15);
            label13.TabIndex = 38;
            label13.Text = "7.";
            // 
            // textBox27
            // 
            textBox27.Location = new Point(337, 275);
            textBox27.Name = "textBox27";
            textBox27.Size = new Size(94, 23);
            textBox27.TabIndex = 39;
            textBox27.Text = "0";
            // 
            // textBox26
            // 
            textBox26.Location = new Point(526, 276);
            textBox26.Name = "textBox26";
            textBox26.Size = new Size(76, 23);
            textBox26.TabIndex = 40;
            textBox26.Text = "0";
            // 
            // textBox25
            // 
            textBox25.BackColor = SystemColors.ScrollBar;
            textBox25.Enabled = false;
            textBox25.Location = new Point(697, 276);
            textBox25.Name = "textBox25";
            textBox25.Size = new Size(91, 23);
            textBox25.TabIndex = 41;
            // 
            // textBox32
            // 
            textBox32.Location = new Point(142, 305);
            textBox32.Name = "textBox32";
            textBox32.Size = new Size(155, 23);
            textBox32.TabIndex = 42;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(50, 307);
            label14.Name = "label14";
            label14.Size = new Size(16, 15);
            label14.TabIndex = 43;
            label14.Text = "8.";
            // 
            // textBox31
            // 
            textBox31.Location = new Point(337, 304);
            textBox31.Name = "textBox31";
            textBox31.Size = new Size(94, 23);
            textBox31.TabIndex = 44;
            textBox31.Text = "0";
            // 
            // textBox30
            // 
            textBox30.Location = new Point(526, 305);
            textBox30.Name = "textBox30";
            textBox30.Size = new Size(76, 23);
            textBox30.TabIndex = 45;
            textBox30.Text = "0";
            // 
            // textBox29
            // 
            textBox29.BackColor = SystemColors.ScrollBar;
            textBox29.Enabled = false;
            textBox29.Location = new Point(697, 305);
            textBox29.Name = "textBox29";
            textBox29.Size = new Size(91, 23);
            textBox29.TabIndex = 46;
            // 
            // textBox36
            // 
            textBox36.Location = new Point(142, 334);
            textBox36.Name = "textBox36";
            textBox36.Size = new Size(155, 23);
            textBox36.TabIndex = 47;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(50, 336);
            label15.Name = "label15";
            label15.Size = new Size(16, 15);
            label15.TabIndex = 48;
            label15.Text = "9.";
            // 
            // textBox35
            // 
            textBox35.Location = new Point(337, 333);
            textBox35.Name = "textBox35";
            textBox35.Size = new Size(94, 23);
            textBox35.TabIndex = 49;
            textBox35.Text = "0";
            // 
            // textBox34
            // 
            textBox34.Location = new Point(526, 334);
            textBox34.Name = "textBox34";
            textBox34.Size = new Size(76, 23);
            textBox34.TabIndex = 50;
            textBox34.Text = "0";
            // 
            // textBox33
            // 
            textBox33.BackColor = SystemColors.ScrollBar;
            textBox33.Enabled = false;
            textBox33.Location = new Point(697, 334);
            textBox33.Name = "textBox33";
            textBox33.Size = new Size(91, 23);
            textBox33.TabIndex = 51;
            // 
            // textBox40
            // 
            textBox40.Location = new Point(142, 363);
            textBox40.Name = "textBox40";
            textBox40.Size = new Size(155, 23);
            textBox40.TabIndex = 52;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(50, 365);
            label16.Name = "label16";
            label16.Size = new Size(22, 15);
            label16.TabIndex = 53;
            label16.Text = "10.";
            // 
            // textBox39
            // 
            textBox39.Location = new Point(337, 362);
            textBox39.Name = "textBox39";
            textBox39.Size = new Size(94, 23);
            textBox39.TabIndex = 54;
            textBox39.Text = "0";
            // 
            // textBox38
            // 
            textBox38.Location = new Point(526, 363);
            textBox38.Name = "textBox38";
            textBox38.Size = new Size(76, 23);
            textBox38.TabIndex = 55;
            textBox38.Text = "0";
            // 
            // textBox37
            // 
            textBox37.BackColor = SystemColors.ScrollBar;
            textBox37.Enabled = false;
            textBox37.Location = new Point(697, 363);
            textBox37.Name = "textBox37";
            textBox37.Size = new Size(91, 23);
            textBox37.TabIndex = 56;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(textBox41);
            Controls.Add(label1);
            Controls.Add(btnSolve);
            Controls.Add(textBox37);
            Controls.Add(textBox38);
            Controls.Add(textBox39);
            Controls.Add(label16);
            Controls.Add(textBox40);
            Controls.Add(textBox33);
            Controls.Add(textBox34);
            Controls.Add(textBox35);
            Controls.Add(label15);
            Controls.Add(textBox36);
            Controls.Add(textBox29);
            Controls.Add(textBox30);
            Controls.Add(textBox31);
            Controls.Add(label14);
            Controls.Add(textBox32);
            Controls.Add(textBox25);
            Controls.Add(textBox26);
            Controls.Add(textBox27);
            Controls.Add(label13);
            Controls.Add(textBox28);
            Controls.Add(textBox21);
            Controls.Add(textBox22);
            Controls.Add(textBox23);
            Controls.Add(label12);
            Controls.Add(textBox24);
            Controls.Add(textBox17);
            Controls.Add(textBox18);
            Controls.Add(textBox19);
            Controls.Add(label11);
            Controls.Add(textBox20);
            Controls.Add(textBox13);
            Controls.Add(textBox14);
            Controls.Add(textBox15);
            Controls.Add(label10);
            Controls.Add(textBox16);
            Controls.Add(textBox9);
            Controls.Add(textBox10);
            Controls.Add(textBox11);
            Controls.Add(label9);
            Controls.Add(textBox12);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox8);
            Controls.Add(tbTotalPriceRow1);
            Controls.Add(tbQuantityRow1);
            Controls.Add(tbPriceRow1);
            Controls.Add(lbNumberRow1);
            Controls.Add(tbStockRow1);
            Controls.Add(lbTtileTotalPrice);
            Controls.Add(lbTitleQuantity);
            Controls.Add(lbTitlePrice);
            Controls.Add(lbTitleStock);
            Controls.Add(lbTitleNumber);
            Controls.Add(title);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 1, true);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label lbTitleNumber;
        private Label lbTitleStock;
        private Label lbTitlePrice;
        private Label lbTitleQuantity;
        private Label lbTtileTotalPrice;
        private TextBox tbStockRow1;
        private Label lbNumberRow1;
        private TextBox tbPriceRow1;
        private TextBox tbQuantityRow1;
        private TextBox tbTotalPriceRow1;
        private Button btnSolve;
        private Label label1;
        private TextBox textBox41;
        private TextBox textBox8;
        private Label label8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox12;
        private Label label9;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox16;
        private Label label10;
        private TextBox textBox15;
        private TextBox textBox14;
        private TextBox textBox13;
        private TextBox textBox20;
        private Label label11;
        private TextBox textBox19;
        private TextBox textBox18;
        private TextBox textBox17;
        private TextBox textBox24;
        private Label label12;
        private TextBox textBox23;
        private TextBox textBox22;
        private TextBox textBox21;
        private TextBox textBox28;
        private Label label13;
        private TextBox textBox27;
        private TextBox textBox26;
        private TextBox textBox25;
        private TextBox textBox32;
        private Label label14;
        private TextBox textBox31;
        private TextBox textBox30;
        private TextBox textBox29;
        private TextBox textBox36;
        private Label label15;
        private TextBox textBox35;
        private TextBox textBox34;
        private TextBox textBox33;
        private TextBox textBox40;
        private Label label16;
        private TextBox textBox39;
        private TextBox textBox38;
        private TextBox textBox37;
    }
}
