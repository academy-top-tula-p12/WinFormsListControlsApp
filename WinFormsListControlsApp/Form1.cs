namespace WinFormsListControlsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.AcceptButton = btnAdd;
            lblCity.Text = "";
            lblCity.ForeColor = Color.Red;

            lstCities.Items.AddRange(new object[] { "Москва", "Тула", "Воронеж" });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCity.Text.Trim().Length > 0)
            {
                lstCities.Items.Add(txtCity.Text.Trim());
                txtCity.Text = "";
            }

        }

        private void lstCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCity.Text = lstCities.SelectedItem?.ToString();
        }
    }
}
