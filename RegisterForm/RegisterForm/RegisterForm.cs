namespace RegisterForm
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void comboCity_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string gender = rbMale.Checked ? "мъж" : rbFemale.Checked ? "жена" : "не е посочен";

            richTextBox1.Text =
                $"Име: {txtName.Text}{Environment.NewLine}" +
                $"Фамилия: {txtSurname.Text}{Environment.NewLine}" +
                $"Пол: {gender}{Environment.NewLine}" +
                $"Код на града: {txtCityCode.Text}{Environment.NewLine}" +
                $"Адрес: {txtAddress.Text}{Environment.NewLine}" +
                $"Град: {comboCity.Text}";
        }
    }
}
