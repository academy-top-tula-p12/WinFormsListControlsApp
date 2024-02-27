namespace WinFormsListControlsApp
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
            lstCities = new ListBox();
            txtCity = new TextBox();
            btnAdd = new Button();
            btnInsert = new Button();
            btnRemove = new Button();
            btnEdit = new Button();
            cmbCities = new ComboBox();
            SuspendLayout();
            // 
            // lstCities
            // 
            lstCities.Font = new Font("Segoe UI", 22F);
            lstCities.FormattingEnabled = true;
            lstCities.ItemHeight = 40;
            lstCities.Location = new Point(26, 94);
            lstCities.Name = "lstCities";
            lstCities.Size = new Size(279, 324);
            lstCities.TabIndex = 0;
            lstCities.SelectedIndexChanged += lstCities_SelectedIndexChanged;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 22F);
            txtCity.Location = new Point(26, 22);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(279, 47);
            txtCity.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 22F);
            btnAdd.Location = new Point(366, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(213, 67);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 22F);
            btnInsert.Location = new Point(366, 114);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(213, 67);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Вставить";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 22F);
            btnRemove.Location = new Point(366, 206);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(213, 67);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Удалить";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 22F);
            btnEdit.Location = new Point(366, 299);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(213, 67);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Изменить";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // cmbCities
            // 
            cmbCities.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCities.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCities.DropDownHeight = 100;
            cmbCities.DropDownStyle = ComboBoxStyle.Simple;
            cmbCities.Font = new Font("Segoe UI", 22F);
            cmbCities.FormattingEnabled = true;
            cmbCities.IntegralHeight = false;
            cmbCities.Location = new Point(666, 22);
            cmbCities.MaxDropDownItems = 4;
            cmbCities.Name = "cmbCities";
            cmbCities.Size = new Size(339, 48);
            cmbCities.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 450);
            Controls.Add(cmbCities);
            Controls.Add(btnEdit);
            Controls.Add(btnRemove);
            Controls.Add(btnInsert);
            Controls.Add(btnAdd);
            Controls.Add(txtCity);
            Controls.Add(lstCities);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCities;
        private TextBox txtCity;
        private Button btnAdd;
        private Button btnInsert;
        private Button btnRemove;
        private Button btnEdit;
        private ComboBox cmbCities;
    }
}
