using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsListControlsApp
{
    public partial class EditForm : Form
    {
        public string CityEdit { get; set; } = "";

        public EditForm(string cityEdit)
        {
            InitializeComponent();

            txtEdit.Text = cityEdit;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CityEdit = txtEdit.Text;
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
