namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            // За всеки ред умножаваме цената на една бройка по броя бройки.
            double totalPriceRow1 = double.Parse(tbPriceRow1.Text) * int.Parse(tbQuantityRow1.Text);
            double totalPriceRow2 = double.Parse(tbPriceRow2.Text) * int.Parse(tbQuantityRow2.Text);
            double totalPriceRow3 = double.Parse(tbPriceRow3.Text) * int.Parse(tbQuantityRow3.Text);
            double totalPriceRow4 = double.Parse(tbPriceRow4.Text) * int.Parse(tbQuantityRow4.Text);
            double totalPriceRow5 = double.Parse(tbPriceRow5.Text) * int.Parse(tbQuantityRow5.Text);
            double totalPriceRow6 = double.Parse(tbPriceRow6.Text) * int.Parse(tbQuantityRow6.Text);
            double totalPriceRow7 = double.Parse(tbPriceRow7.Text) * int.Parse(tbQuantityRow7.Text);
            double totalPriceRow8 = double.Parse(tbPriceRow8.Text) * int.Parse(tbQuantityRow8.Text);
            double totalPriceRow9 = double.Parse(tbPriceRow9.Text) * int.Parse(tbQuantityRow9.Text);
            double totalPriceRow10 = double.Parse(tbPriceRow10.Text) * int.Parse(tbQuantityRow10.Text);

            // Показваме цената на всеки ред винаги с две цифри след десетичния знак.
            tbTotalPriceRow1.Text = totalPriceRow1.ToString("F2");
            tbTotalPriceRow2.Text = totalPriceRow2.ToString("F2");
            tbTotalPriceRow3.Text = totalPriceRow3.ToString("F2");
            tbTotalPriceRow4.Text = totalPriceRow4.ToString("F2");
            tbTotalPriceRow5.Text = totalPriceRow5.ToString("F2");
            tbTotalPriceRow6.Text = totalPriceRow6.ToString("F2");
            tbTotalPriceRow7.Text = totalPriceRow7.ToString("F2");
            tbTotalPriceRow8.Text = totalPriceRow8.ToString("F2");
            tbTotalPriceRow9.Text = totalPriceRow9.ToString("F2");
            tbTotalPriceRow10.Text = totalPriceRow10.ToString("F2");

            // Събираме всички редове, за да получим цената на цялата покупка.
            double grandTotal = totalPriceRow1 + totalPriceRow2 + totalPriceRow3 + totalPriceRow4 + totalPriceRow5
                + totalPriceRow6 + totalPriceRow7 + totalPriceRow8 + totalPriceRow9 + totalPriceRow10;
            tbGrandTotal.Text = grandTotal.ToString("F2");
        }
    }
}
