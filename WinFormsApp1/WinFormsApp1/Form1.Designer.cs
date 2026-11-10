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
            lblTitle = new Label();
            lblColumnNumber = new Label();
            lblColumnProduct = new Label();
            lblColumnUnitPrice = new Label();
            lblColumnQuantity = new Label();
            lblColumnRowTotal = new Label();
            tbStockRow1 = new TextBox();
            lblNumberRow1 = new Label();
            tbPriceRow1 = new TextBox();
            tbQuantityRow1 = new TextBox();
            tbTotalPriceRow1 = new TextBox();
            btnSolve = new Button();
            lblGrandTotal = new Label();
            tbGrandTotal = new TextBox();
            tbStockRow2 = new TextBox();
            lblNumberRow2 = new Label();
            tbPriceRow2 = new TextBox();
            tbQuantityRow2 = new TextBox();
            tbTotalPriceRow2 = new TextBox();
            tbStockRow3 = new TextBox();
            lblNumberRow3 = new Label();
            tbPriceRow3 = new TextBox();
            tbQuantityRow3 = new TextBox();
            tbTotalPriceRow3 = new TextBox();
            tbStockRow4 = new TextBox();
            lblNumberRow4 = new Label();
            tbPriceRow4 = new TextBox();
            tbQuantityRow4 = new TextBox();
            tbTotalPriceRow4 = new TextBox();
            tbStockRow5 = new TextBox();
            lblNumberRow5 = new Label();
            tbPriceRow5 = new TextBox();
            tbQuantityRow5 = new TextBox();
            tbTotalPriceRow5 = new TextBox();
            tbStockRow6 = new TextBox();
            lblNumberRow6 = new Label();
            tbPriceRow6 = new TextBox();
            tbQuantityRow6 = new TextBox();
            tbTotalPriceRow6 = new TextBox();
            tbStockRow7 = new TextBox();
            lblNumberRow7 = new Label();
            tbPriceRow7 = new TextBox();
            tbQuantityRow7 = new TextBox();
            tbTotalPriceRow7 = new TextBox();
            tbStockRow8 = new TextBox();
            lblNumberRow8 = new Label();
            tbPriceRow8 = new TextBox();
            tbQuantityRow8 = new TextBox();
            tbTotalPriceRow8 = new TextBox();
            tbStockRow9 = new TextBox();
            lblNumberRow9 = new Label();
            tbPriceRow9 = new TextBox();
            tbQuantityRow9 = new TextBox();
            tbTotalPriceRow9 = new TextBox();
            tbStockRow10 = new TextBox();
            lblNumberRow10 = new Label();
            tbPriceRow10 = new TextBox();
            tbQuantityRow10 = new TextBox();
            tbTotalPriceRow10 = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AccessibleRole = AccessibleRole.TitleBar;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.Control;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 1, true);
            lblTitle.ImageAlign = ContentAlignment.MiddleRight;
            lblTitle.Location = new Point(187, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(382, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Калкулатор за покупка";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblColumnNumber
            // 
            lblColumnNumber.AutoSize = true;
            lblColumnNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblColumnNumber.Location = new Point(52, 74);
            lblColumnNumber.Name = "lblColumnNumber";
            lblColumnNumber.Size = new Size(21, 15);
            lblColumnNumber.TabIndex = 2;
            lblColumnNumber.Text = "№";
            // 
            // lblColumnProduct
            // 
            lblColumnProduct.AutoSize = true;
            lblColumnProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblColumnProduct.Location = new Point(197, 74);
            lblColumnProduct.Name = "lblColumnProduct";
            lblColumnProduct.Size = new Size(39, 15);
            lblColumnProduct.TabIndex = 3;
            lblColumnProduct.Text = "Стока";
            // 
            // lblColumnUnitPrice
            // 
            lblColumnUnitPrice.AutoSize = true;
            lblColumnUnitPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblColumnUnitPrice.Location = new Point(350, 74);
            lblColumnUnitPrice.Name = "lblColumnUnitPrice";
            lblColumnUnitPrice.Size = new Size(94, 15);
            lblColumnUnitPrice.TabIndex = 4;
            lblColumnUnitPrice.Text = "Единична цена";
            // 
            // lblColumnQuantity
            // 
            lblColumnQuantity.AutoSize = true;
            lblColumnQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblColumnQuantity.Location = new Point(526, 74);
            lblColumnQuantity.Name = "lblColumnQuantity";
            lblColumnQuantity.Size = new Size(76, 15);
            lblColumnQuantity.TabIndex = 5;
            lblColumnQuantity.Text = "Количество";
            // 
            // lblColumnRowTotal
            // 
            lblColumnRowTotal.AutoSize = true;
            lblColumnRowTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblColumnRowTotal.Location = new Point(707, 74);
            lblColumnRowTotal.Name = "lblColumnRowTotal";
            lblColumnRowTotal.Size = new Size(59, 15);
            lblColumnRowTotal.TabIndex = 6;
            lblColumnRowTotal.Text = "Стойност";
            // 
            // tbStockRow1
            // 
            tbStockRow1.Location = new Point(142, 102);
            tbStockRow1.Name = "tbStockRow1";
            tbStockRow1.Size = new Size(155, 23);
            tbStockRow1.TabIndex = 7;
            // 
            // lblNumberRow1
            // 
            lblNumberRow1.AutoSize = true;
            lblNumberRow1.Location = new Point(54, 104);
            lblNumberRow1.Name = "lblNumberRow1";
            lblNumberRow1.Size = new Size(16, 15);
            lblNumberRow1.TabIndex = 8;
            lblNumberRow1.Text = "1.";
            // 
            // tbPriceRow1
            // 
            tbPriceRow1.Location = new Point(350, 101);
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
            tbTotalPriceRow1.Location = new Point(697, 102);
            tbTotalPriceRow1.Name = "tbTotalPriceRow1";
            tbTotalPriceRow1.ReadOnly = true;
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
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.BackColor = SystemColors.Control;
            lblGrandTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 1, true);
            lblGrandTotal.Location = new Point(560, 432);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(101, 21);
            lblGrandTotal.TabIndex = 58;
            lblGrandTotal.Text = "Обща сума:";
            // 
            // tbGrandTotal
            // 
            tbGrandTotal.BackColor = SystemColors.ScrollBar;
            tbGrandTotal.Location = new Point(667, 432);
            tbGrandTotal.Name = "tbGrandTotal";
            tbGrandTotal.ReadOnly = true;
            tbGrandTotal.Size = new Size(121, 23);
            tbGrandTotal.TabIndex = 59;
            // 
            // tbStockRow2
            // 
            tbStockRow2.Location = new Point(142, 131);
            tbStockRow2.Name = "tbStockRow2";
            tbStockRow2.Size = new Size(155, 23);
            tbStockRow2.TabIndex = 12;
            // 
            // lblNumberRow2
            // 
            lblNumberRow2.AutoSize = true;
            lblNumberRow2.Location = new Point(54, 133);
            lblNumberRow2.Name = "lblNumberRow2";
            lblNumberRow2.Size = new Size(16, 15);
            lblNumberRow2.TabIndex = 13;
            lblNumberRow2.Text = "2.";
            // 
            // tbPriceRow2
            // 
            tbPriceRow2.Location = new Point(350, 130);
            tbPriceRow2.Name = "tbPriceRow2";
            tbPriceRow2.Size = new Size(94, 23);
            tbPriceRow2.TabIndex = 14;
            tbPriceRow2.Text = "0";
            // 
            // tbQuantityRow2
            // 
            tbQuantityRow2.Location = new Point(526, 131);
            tbQuantityRow2.Name = "tbQuantityRow2";
            tbQuantityRow2.Size = new Size(76, 23);
            tbQuantityRow2.TabIndex = 15;
            tbQuantityRow2.Text = "0";
            // 
            // tbTotalPriceRow2
            // 
            tbTotalPriceRow2.BackColor = SystemColors.ScrollBar;
            tbTotalPriceRow2.Location = new Point(697, 131);
            tbTotalPriceRow2.Name = "tbTotalPriceRow2";
            tbTotalPriceRow2.ReadOnly = true;
            tbTotalPriceRow2.Size = new Size(91, 23);
            tbTotalPriceRow2.TabIndex = 16;
            // 
            // tbStockRow3
            // 
            tbStockRow3.Location = new Point(142, 160);
            tbStockRow3.Name = "tbStockRow3";
            tbStockRow3.Size = new Size(155, 23);
            tbStockRow3.TabIndex = 17;
            // 
            // lblNumberRow3
            // 
            lblNumberRow3.AutoSize = true;
            lblNumberRow3.Location = new Point(54, 162);
            lblNumberRow3.Name = "lblNumberRow3";
            lblNumberRow3.Size = new Size(16, 15);
            lblNumberRow3.TabIndex = 18;
            lblNumberRow3.Text = "3.";
            // 
            // tbPriceRow3
            // 
            tbPriceRow3.Location = new Point(350, 159);
            tbPriceRow3.Name = "tbPriceRow3";
            tbPriceRow3.Size = new Size(94, 23);
            tbPriceRow3.TabIndex = 19;
            tbPriceRow3.Text = "0";
            // 
            // tbQuantityRow3
            // 
            tbQuantityRow3.Location = new Point(526, 160);
            tbQuantityRow3.Name = "tbQuantityRow3";
            tbQuantityRow3.Size = new Size(76, 23);
            tbQuantityRow3.TabIndex = 20;
            tbQuantityRow3.Text = "0";
            // 
            // tbTotalPriceRow3
            // 
            tbTotalPriceRow3.BackColor = SystemColors.ScrollBar;
            tbTotalPriceRow3.Location = new Point(697, 160);
            tbTotalPriceRow3.Name = "tbTotalPriceRow3";
            tbTotalPriceRow3.ReadOnly = true;
            tbTotalPriceRow3.Size = new Size(91, 23);
            tbTotalPriceRow3.TabIndex = 21;
            // 
            // tbStockRow4
            // 
            tbStockRow4.Location = new Point(142, 189);
            tbStockRow4.Name = "tbStockRow4";
            tbStockRow4.Size = new Size(155, 23);
            tbStockRow4.TabIndex = 22;
            // 
            // lblNumberRow4
            // 
            lblNumberRow4.AutoSize = true;
            lblNumberRow4.Location = new Point(54, 191);
            lblNumberRow4.Name = "lblNumberRow4";
            lblNumberRow4.Size = new Size(16, 15);
            lblNumberRow4.TabIndex = 23;
            lblNumberRow4.Text = "4.";
            // 
            // tbPriceRow4
            // 
            tbPriceRow4.Location = new Point(350, 188);
            tbPriceRow4.Name = "tbPriceRow4";
            tbPriceRow4.Size = new Size(94, 23);
            tbPriceRow4.TabIndex = 24;
            tbPriceRow4.Text = "0";
            // 
            // tbQuantityRow4
            // 
            tbQuantityRow4.Location = new Point(526, 189);
            tbQuantityRow4.Name = "tbQuantityRow4";
            tbQuantityRow4.Size = new Size(76, 23);
            tbQuantityRow4.TabIndex = 25;
            tbQuantityRow4.Text = "0";
            // 
            // tbTotalPriceRow4
            // 
            tbTotalPriceRow4.BackColor = SystemColors.ScrollBar;
            tbTotalPriceRow4.Location = new Point(697, 189);
            tbTotalPriceRow4.Name = "tbTotalPriceRow4";
            tbTotalPriceRow4.ReadOnly = true;
            tbTotalPriceRow4.Size = new Size(91, 23);
            tbTotalPriceRow4.TabIndex = 26;
            // 
            // tbStockRow5
            // 
            tbStockRow5.Location = new Point(142, 218);
            tbStockRow5.Name = "tbStockRow5";
            tbStockRow5.Size = new Size(155, 23);
            tbStockRow5.TabIndex = 27;
            // 
            // lblNumberRow5
            // 
            lblNumberRow5.AutoSize = true;
            lblNumberRow5.Location = new Point(54, 220);
            lblNumberRow5.Name = "lblNumberRow5";
            lblNumberRow5.Size = new Size(16, 15);
            lblNumberRow5.TabIndex = 28;
            lblNumberRow5.Text = "5.";
            // 
            // tbPriceRow5
            // 
            tbPriceRow5.Location = new Point(350, 217);
            tbPriceRow5.Name = "tbPriceRow5";
            tbPriceRow5.Size = new Size(94, 23);
            tbPriceRow5.TabIndex = 29;
            tbPriceRow5.Text = "0";
            // 
            // tbQuantityRow5
            // 
            tbQuantityRow5.Location = new Point(526, 218);
            tbQuantityRow5.Name = "tbQuantityRow5";
            tbQuantityRow5.Size = new Size(76, 23);
            tbQuantityRow5.TabIndex = 30;
            tbQuantityRow5.Text = "0";
            // 
            // tbTotalPriceRow5
            // 
            tbTotalPriceRow5.BackColor = SystemColors.ScrollBar;
            tbTotalPriceRow5.Location = new Point(697, 218);
            tbTotalPriceRow5.Name = "tbTotalPriceRow5";
            tbTotalPriceRow5.ReadOnly = true;
            tbTotalPriceRow5.Size = new Size(91, 23);
            tbTotalPriceRow5.TabIndex = 31;
            // 
            // tbStockRow6
            // 
            tbStockRow6.Location = new Point(142, 247);
            tbStockRow6.Name = "tbStockRow6";
            tbStockRow6.Size = new Size(155, 23);
            tbStockRow6.TabIndex = 32;
            // 
            // lblNumberRow6
            // 
            lblNumberRow6.AutoSize = true;
            lblNumberRow6.Location = new Point(54, 249);
            lblNumberRow6.Name = "lblNumberRow6";
            lblNumberRow6.Size = new Size(16, 15);
            lblNumberRow6.TabIndex = 33;
            lblNumberRow6.Text = "6.";
            // 
            // tbPriceRow6
            // 
            tbPriceRow6.Location = new Point(350, 246);
            tbPriceRow6.Name = "tbPriceRow6";
            tbPriceRow6.Size = new Size(94, 23);
            tbPriceRow6.TabIndex = 34;
            tbPriceRow6.Text = "0";
            // 
            // tbQuantityRow6
            // 
            tbQuantityRow6.Location = new Point(526, 247);
            tbQuantityRow6.Name = "tbQuantityRow6";
            tbQuantityRow6.Size = new Size(76, 23);
            tbQuantityRow6.TabIndex = 35;
            tbQuantityRow6.Text = "0";
            // 
            // tbTotalPriceRow6
            // 
            tbTotalPriceRow6.BackColor = SystemColors.ScrollBar;
            tbTotalPriceRow6.Location = new Point(697, 247);
            tbTotalPriceRow6.Name = "tbTotalPriceRow6";
            tbTotalPriceRow6.ReadOnly = true;
            tbTotalPriceRow6.Size = new Size(91, 23);
            tbTotalPriceRow6.TabIndex = 36;
            // 
            // tbStockRow7
            // 
            tbStockRow7.Location = new Point(142, 276);
            tbStockRow7.Name = "tbStockRow7";
            tbStockRow7.Size = new Size(155, 23);
            tbStockRow7.TabIndex = 37;
            // 
            // lblNumberRow7
            // 
            lblNumberRow7.AutoSize = true;
            lblNumberRow7.Location = new Point(54, 278);
            lblNumberRow7.Name = "lblNumberRow7";
            lblNumberRow7.Size = new Size(16, 15);
            lblNumberRow7.TabIndex = 38;
            lblNumberRow7.Text = "7.";
            // 
            // tbPriceRow7
            // 
            tbPriceRow7.Location = new Point(350, 275);
            tbPriceRow7.Name = "tbPriceRow7";
            tbPriceRow7.Size = new Size(94, 23);
            tbPriceRow7.TabIndex = 39;
            tbPriceRow7.Text = "0";
            // 
            // tbQuantityRow7
            // 
            tbQuantityRow7.Location = new Point(526, 276);
            tbQuantityRow7.Name = "tbQuantityRow7";
            tbQuantityRow7.Size = new Size(76, 23);
            tbQuantityRow7.TabIndex = 40;
            tbQuantityRow7.Text = "0";
            // 
            // tbTotalPriceRow7
            // 
            tbTotalPriceRow7.BackColor = SystemColors.ScrollBar;
            tbTotalPriceRow7.Location = new Point(697, 276);
            tbTotalPriceRow7.Name = "tbTotalPriceRow7";
            tbTotalPriceRow7.ReadOnly = true;
            tbTotalPriceRow7.Size = new Size(91, 23);
            tbTotalPriceRow7.TabIndex = 41;
            // 
            // tbStockRow8
            // 
            tbStockRow8.Location = new Point(142, 305);
            tbStockRow8.Name = "tbStockRow8";
            tbStockRow8.Size = new Size(155, 23);
            tbStockRow8.TabIndex = 42;
            // 
            // lblNumberRow8
            // 
            lblNumberRow8.AutoSize = true;
            lblNumberRow8.Location = new Point(54, 307);
            lblNumberRow8.Name = "lblNumberRow8";
            lblNumberRow8.Size = new Size(16, 15);
            lblNumberRow8.TabIndex = 43;
            lblNumberRow8.Text = "8.";
            // 
            // tbPriceRow8
            // 
            tbPriceRow8.Location = new Point(350, 304);
            tbPriceRow8.Name = "tbPriceRow8";
            tbPriceRow8.Size = new Size(94, 23);
            tbPriceRow8.TabIndex = 44;
            tbPriceRow8.Text = "0";
            // 
            // tbQuantityRow8
            // 
            tbQuantityRow8.Location = new Point(526, 305);
            tbQuantityRow8.Name = "tbQuantityRow8";
            tbQuantityRow8.Size = new Size(76, 23);
            tbQuantityRow8.TabIndex = 45;
            tbQuantityRow8.Text = "0";
            // 
            // tbTotalPriceRow8
            // 
            tbTotalPriceRow8.BackColor = SystemColors.ScrollBar;
            tbTotalPriceRow8.Location = new Point(697, 305);
            tbTotalPriceRow8.Name = "tbTotalPriceRow8";
            tbTotalPriceRow8.ReadOnly = true;
            tbTotalPriceRow8.Size = new Size(91, 23);
            tbTotalPriceRow8.TabIndex = 46;
            // 
            // tbStockRow9
            // 
            tbStockRow9.Location = new Point(142, 334);
            tbStockRow9.Name = "tbStockRow9";
            tbStockRow9.Size = new Size(155, 23);
            tbStockRow9.TabIndex = 47;
            // 
            // lblNumberRow9
            // 
            lblNumberRow9.AutoSize = true;
            lblNumberRow9.Location = new Point(54, 336);
            lblNumberRow9.Name = "lblNumberRow9";
            lblNumberRow9.Size = new Size(16, 15);
            lblNumberRow9.TabIndex = 48;
            lblNumberRow9.Text = "9.";
            // 
            // tbPriceRow9
            // 
            tbPriceRow9.Location = new Point(350, 333);
            tbPriceRow9.Name = "tbPriceRow9";
            tbPriceRow9.Size = new Size(94, 23);
            tbPriceRow9.TabIndex = 49;
            tbPriceRow9.Text = "0";
            // 
            // tbQuantityRow9
            // 
            tbQuantityRow9.Location = new Point(526, 334);
            tbQuantityRow9.Name = "tbQuantityRow9";
            tbQuantityRow9.Size = new Size(76, 23);
            tbQuantityRow9.TabIndex = 50;
            tbQuantityRow9.Text = "0";
            // 
            // tbTotalPriceRow9
            // 
            tbTotalPriceRow9.BackColor = SystemColors.ScrollBar;
            tbTotalPriceRow9.Location = new Point(697, 334);
            tbTotalPriceRow9.Name = "tbTotalPriceRow9";
            tbTotalPriceRow9.ReadOnly = true;
            tbTotalPriceRow9.Size = new Size(91, 23);
            tbTotalPriceRow9.TabIndex = 51;
            // 
            // tbStockRow10
            // 
            tbStockRow10.Location = new Point(142, 363);
            tbStockRow10.Name = "tbStockRow10";
            tbStockRow10.Size = new Size(155, 23);
            tbStockRow10.TabIndex = 52;
            // 
            // lblNumberRow10
            // 
            lblNumberRow10.AutoSize = true;
            lblNumberRow10.Location = new Point(51, 365);
            lblNumberRow10.Name = "lblNumberRow10";
            lblNumberRow10.Size = new Size(22, 15);
            lblNumberRow10.TabIndex = 53;
            lblNumberRow10.Text = "10.";
            // 
            // tbPriceRow10
            // 
            tbPriceRow10.Location = new Point(350, 362);
            tbPriceRow10.Name = "tbPriceRow10";
            tbPriceRow10.Size = new Size(94, 23);
            tbPriceRow10.TabIndex = 54;
            tbPriceRow10.Text = "0";
            // 
            // tbQuantityRow10
            // 
            tbQuantityRow10.Location = new Point(526, 363);
            tbQuantityRow10.Name = "tbQuantityRow10";
            tbQuantityRow10.Size = new Size(76, 23);
            tbQuantityRow10.TabIndex = 55;
            tbQuantityRow10.Text = "0";
            // 
            // tbTotalPriceRow10
            // 
            tbTotalPriceRow10.BackColor = SystemColors.ScrollBar;
            tbTotalPriceRow10.Location = new Point(697, 363);
            tbTotalPriceRow10.Name = "tbTotalPriceRow10";
            tbTotalPriceRow10.ReadOnly = true;
            tbTotalPriceRow10.Size = new Size(91, 23);
            tbTotalPriceRow10.TabIndex = 56;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(tbGrandTotal);
            Controls.Add(lblGrandTotal);
            Controls.Add(btnSolve);
            Controls.Add(tbTotalPriceRow10);
            Controls.Add(tbQuantityRow10);
            Controls.Add(tbPriceRow10);
            Controls.Add(lblNumberRow10);
            Controls.Add(tbStockRow10);
            Controls.Add(tbTotalPriceRow9);
            Controls.Add(tbQuantityRow9);
            Controls.Add(tbPriceRow9);
            Controls.Add(lblNumberRow9);
            Controls.Add(tbStockRow9);
            Controls.Add(tbTotalPriceRow8);
            Controls.Add(tbQuantityRow8);
            Controls.Add(tbPriceRow8);
            Controls.Add(lblNumberRow8);
            Controls.Add(tbStockRow8);
            Controls.Add(tbTotalPriceRow7);
            Controls.Add(tbQuantityRow7);
            Controls.Add(tbPriceRow7);
            Controls.Add(lblNumberRow7);
            Controls.Add(tbStockRow7);
            Controls.Add(tbTotalPriceRow6);
            Controls.Add(tbQuantityRow6);
            Controls.Add(tbPriceRow6);
            Controls.Add(lblNumberRow6);
            Controls.Add(tbStockRow6);
            Controls.Add(tbTotalPriceRow5);
            Controls.Add(tbQuantityRow5);
            Controls.Add(tbPriceRow5);
            Controls.Add(lblNumberRow5);
            Controls.Add(tbStockRow5);
            Controls.Add(tbTotalPriceRow4);
            Controls.Add(tbQuantityRow4);
            Controls.Add(tbPriceRow4);
            Controls.Add(lblNumberRow4);
            Controls.Add(tbStockRow4);
            Controls.Add(tbTotalPriceRow3);
            Controls.Add(tbQuantityRow3);
            Controls.Add(tbPriceRow3);
            Controls.Add(lblNumberRow3);
            Controls.Add(tbStockRow3);
            Controls.Add(tbTotalPriceRow2);
            Controls.Add(tbQuantityRow2);
            Controls.Add(tbPriceRow2);
            Controls.Add(lblNumberRow2);
            Controls.Add(tbStockRow2);
            Controls.Add(tbTotalPriceRow1);
            Controls.Add(tbQuantityRow1);
            Controls.Add(tbPriceRow1);
            Controls.Add(lblNumberRow1);
            Controls.Add(tbStockRow1);
            Controls.Add(lblColumnRowTotal);
            Controls.Add(lblColumnQuantity);
            Controls.Add(lblColumnUnitPrice);
            Controls.Add(lblColumnProduct);
            Controls.Add(lblColumnNumber);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 1, true);
            Name = "Form1";
            Text = "Моята покупка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblColumnNumber;
        private Label lblColumnProduct;
        private Label lblColumnUnitPrice;
        private Label lblColumnQuantity;
        private Label lblColumnRowTotal;
        private TextBox tbStockRow1;
        private Label lblNumberRow1;
        private TextBox tbPriceRow1;
        private TextBox tbQuantityRow1;
        private TextBox tbTotalPriceRow1;
        private Button btnSolve;
        private Label lblGrandTotal;
        private TextBox tbGrandTotal;
        private TextBox tbStockRow2;
        private Label lblNumberRow2;
        private TextBox tbPriceRow2;
        private TextBox tbQuantityRow2;
        private TextBox tbTotalPriceRow2;
        private TextBox tbStockRow3;
        private Label lblNumberRow3;
        private TextBox tbPriceRow3;
        private TextBox tbQuantityRow3;
        private TextBox tbTotalPriceRow3;
        private TextBox tbStockRow4;
        private Label lblNumberRow4;
        private TextBox tbPriceRow4;
        private TextBox tbQuantityRow4;
        private TextBox tbTotalPriceRow4;
        private TextBox tbStockRow5;
        private Label lblNumberRow5;
        private TextBox tbPriceRow5;
        private TextBox tbQuantityRow5;
        private TextBox tbTotalPriceRow5;
        private TextBox tbStockRow6;
        private Label lblNumberRow6;
        private TextBox tbPriceRow6;
        private TextBox tbQuantityRow6;
        private TextBox tbTotalPriceRow6;
        private TextBox tbStockRow7;
        private Label lblNumberRow7;
        private TextBox tbPriceRow7;
        private TextBox tbQuantityRow7;
        private TextBox tbTotalPriceRow7;
        private TextBox tbStockRow8;
        private Label lblNumberRow8;
        private TextBox tbPriceRow8;
        private TextBox tbQuantityRow8;
        private TextBox tbTotalPriceRow8;
        private TextBox tbStockRow9;
        private Label lblNumberRow9;
        private TextBox tbPriceRow9;
        private TextBox tbQuantityRow9;
        private TextBox tbTotalPriceRow9;
        private TextBox tbStockRow10;
        private Label lblNumberRow10;
        private TextBox tbPriceRow10;
        private TextBox tbQuantityRow10;
        private TextBox tbTotalPriceRow10;
    }
}

