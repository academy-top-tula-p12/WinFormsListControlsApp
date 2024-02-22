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
            lblCity = new Label();
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
            btnAdd.Size = new Size(213, 47);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 30F);
            lblCity.Location = new Point(366, 189);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(130, 54);
            lblCity.TabIndex = 3;
            lblCity.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCity);
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
        private Label lblCity;
    }
}
