namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            tbRow1TotalPrice.Text = (double.Parse(tbRow1Price.Text) * int.Parse(tbRow1Quantity.Text)).ToString("F2");
            tbRow2TotalPrice.Text = (double.Parse(tbRow2Price.Text) * int.Parse(tbRow2Quantity.Text)).ToString("F2");
            tbRow3TotalPrice.Text = (double.Parse(tbRow3Price.Text) * int.Parse(tbRow3Quantity.Text)).ToString("F2");
            tbRow4TotalPrice.Text = (double.Parse(tbRow4Price.Text) * int.Parse(tbRow4Quantity.Text)).ToString("F2");
            tbRow5TotalPrice.Text = (double.Parse(tbRow5Price.Text) * int.Parse(tbRow5Quantity.Text)).ToString("F2");
            tbRow6TotalPrice.Text = (double.Parse(tbRow6Price.Text) * int.Parse(tbRow6Quantity.Text)).ToString("F2");
            tbRow7TotalPrice.Text = (double.Parse(tbRow7Price.Text) * int.Parse(tbRow7Quantity.Text)).ToString("F2");
            tbRow8TotalPrice.Text = (double.Parse(tbRow8Price.Text) * int.Parse(tbRow8Quantity.Text)).ToString("F2");
            tbRow9TotalPrice.Text = (double.Parse(tbRow9Price.Text) * int.Parse(tbRow9Quantity.Text)).ToString("F2");
            tbRow10TotalPrice.Text = (double.Parse(tbRow10Price.Text) * int.Parse(tbRow10Quantity.Text)).ToString("F2");

            tbTotalPrice.Text = (double.Parse(tbRow1TotalPrice.Text) + double.Parse(tbRow2TotalPrice.Text) + double.Parse(tbRow3TotalPrice.Text) + double.Parse(tbRow4TotalPrice.Text) + double.Parse(tbRow5TotalPrice.Text) + double.Parse(tbRow6TotalPrice.Text) + double.Parse(tbRow7TotalPrice.Text) + double.Parse(tbRow8TotalPrice.Text) + double.Parse(tbRow9TotalPrice.Text) + double.Parse(tbRow10TotalPrice.Text)).ToString("F2");

            tbTotalPrice.Visible = true;
            lbTotalPrice.Visible = true;
        }
    }
}
