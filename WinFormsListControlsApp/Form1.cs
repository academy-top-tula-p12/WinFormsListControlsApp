namespace WinFormsListControlsApp
{
    public partial class Form1 : Form
    {
        Color color = Color.Black;

        public Form1()
        {
            InitializeComponent();

            this.AcceptButton = btnAdd;
            //lblCity.Text = "";
            //lblCity.ForeColor = Color.Red;

            lstCities.SelectionMode = SelectionMode.MultiExtended;

            lstCities.Items.AddRange(new object[] { "Москва", "Тула", "Воронеж", "Калуга", "Новгород", "Казань", "Иркутск" });
            cmbCities.Items.AddRange(new object[] { "Москва", "Тула", "Воронеж", "Калуга", "Новгород", "Казань", "Иркутск" });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCity.Text.Trim().Length > 0)
            {
                lstCities.Items.Add(txtCity.Text.Trim());
                cmbCities.Items.Add(txtCity.Text.Trim());
                txtCity.Text = "";
            }

        }

        private void lstCities_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtCity.Text.Trim().Length > 0)
            {
                int index = lstCities.SelectedIndex;
                lstCities.Items.Insert(index + 1, txtCity.Text.Trim());
                lstCities.SelectedIndex = index + 1;
                txtCity.Text = "";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstCities.SelectedItem is not null)
            {
                //lstCities.Items.Remove(lstCities.SelectedItem);
                int index = lstCities.SelectedIndex;
                lstCities.Items.RemoveAt(index);
                if (index >= lstCities.Items.Count)
                    lstCities.SelectedIndex = lstCities.Items.Count - 1;
                else
                    lstCities.SelectedIndex = index;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(lstCities.SelectedItem is not null)
            {
                using (EditForm editForm = new(lstCities.SelectedItem.ToString()))
                {
                    editForm.CityEdit = lstCities.SelectedItem.ToString()!;

                    var result = editForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        //lstCities.SelectedItem = editForm.CityEdit;
                        lstCities.Items[lstCities.SelectedIndex] = editForm.CityEdit;
                    }
                }
            }
            
        }
    }
}
