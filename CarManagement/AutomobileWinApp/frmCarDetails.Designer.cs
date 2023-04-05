namespace AutomobileWinApp
{
    partial class frmCarDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            btnCancel = new Button();
            cboManufacturer = new ComboBox();
            txtPrice = new MaskedTextBox();
            txtReleaseYear = new MaskedTextBox();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            lbCarID = new Label();
            lbCarName = new Label();
            lbManufacturer = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkOrange;
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(96, 318);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonShadow;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(249, 318);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new Point(192, 157);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(188, 28);
            cboManufacturer.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(192, 203);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(188, 27);
            txtPrice.TabIndex = 3;
            txtPrice.Text = "0";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(192, 250);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(188, 27);
            txtReleaseYear.TabIndex = 4;
            txtReleaseYear.Text = "0";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(192, 64);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(188, 27);
            txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(192, 109);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(188, 27);
            txtCarName.TabIndex = 6;
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(47, 67);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(50, 20);
            lbCarID.TabIndex = 7;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(47, 112);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(75, 20);
            lbCarName.TabIndex = 8;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(47, 160);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(97, 20);
            lbManufacturer.TabIndex = 9;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(47, 206);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 10;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(47, 253);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(88, 20);
            lbReleaseYear.TabIndex = 11;
            lbReleaseYear.Text = "ReleaseYear";
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(447, 371);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(cboManufacturer);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmCarDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private ComboBox cboManufacturer;
        private MaskedTextBox txtPrice;
        private MaskedTextBox txtReleaseYear;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private Label lbCarID;
        private Label lbCarName;
        private Label lbManufacturer;
        private Label lbPrice;
        private Label lbReleaseYear;
    }
}