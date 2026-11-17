namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbRegisterPerson.Clear();

            rtbRegisterPerson.AppendText($"Име: {tbName.Text} {Environment.NewLine}");
            rtbRegisterPerson.AppendText($"Фамилия: {tbLastName.Text} {Environment.NewLine}");

            string gender = string.Empty;

            if (rbMale.Checked)
            {
                gender = "Мъж";
            
            }
            else if (rbFemale.Checked)
            {
                gender = "Жена";
            }

            rtbRegisterPerson.AppendText($"Пол: {gender}");
            rtbRegisterPerson.AppendText(Environment.NewLine);
            rtbRegisterPerson.AppendText($"Код на града: {tbPostCode.Text}");
            rtbRegisterPerson.AppendText(Environment.NewLine);
            rtbRegisterPerson.AppendText($"Адрес: {tbAddress.Text}");
            rtbRegisterPerson.AppendText(Environment.NewLine);
            rtbRegisterPerson.AppendText($"Град: {cmbCity.Text}");
        }
    }
}
