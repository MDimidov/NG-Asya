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
            double totalPriceRow1 = double.Parse(tbPriceRow1.Text) * int.Parse(tbQuantityRow1.Text);
            tbTotalPriceRow1.Text = totalPriceRow1.ToString("F2");
        }
    }
}
