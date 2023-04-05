namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            btnload = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            lbCarID = new Label();
            lbCarName = new Label();
            lbManufacturer = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            txtManufacturer = new TextBox();
            txtReleaseYear = new TextBox();
            txtPrice = new TextBox();
            dgvCarList = new DataGridView();
            btnClose = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            cbSearch = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // btnload
            // 
            btnload.BackColor = Color.Blue;
            btnload.FlatStyle = FlatStyle.System;
            btnload.ForeColor = Color.GhostWhite;
            btnload.Location = new Point(427, 205);
            btnload.Name = "btnload";
            btnload.Size = new Size(94, 29);
            btnload.TabIndex = 0;
            btnload.Text = "Load";
            btnload.UseVisualStyleBackColor = false;
            btnload.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Orange;
            btnNew.Location = new Point(537, 204);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 1;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.OrangeRed;
            btnDelete.Location = new Point(664, 205);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(54, 49);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(50, 20);
            lbCarID.TabIndex = 3;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(54, 93);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(75, 20);
            lbCarName.TabIndex = 4;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(54, 142);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(97, 20);
            lbManufacturer.TabIndex = 5;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(427, 49);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 6;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(427, 93);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(88, 20);
            lbReleaseYear.TabIndex = 7;
            lbReleaseYear.Text = "ReleaseYear";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(156, 46);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(210, 27);
            txtCarID.TabIndex = 8;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(156, 90);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(210, 27);
            txtCarName.TabIndex = 9;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(156, 139);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(210, 27);
            txtManufacturer.TabIndex = 10;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(537, 90);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(198, 27);
            txtReleaseYear.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(537, 46);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(198, 27);
            txtPrice.TabIndex = 12;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(22, 240);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 51;
            dgvCarList.RowTemplate.Height = 29;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(755, 170);
            dgvCarList.TabIndex = 13;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.AppWorkspace;
            btnClose.Location = new Point(357, 416);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(54, 204);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(171, 27);
            txtSearch.TabIndex = 15;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.PaleGoldenrod;
            btnSearch.Location = new Point(246, 204);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cbSearch.Location = new Point(537, 159);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(198, 28);
            cbSearch.TabIndex = 17;
            cbSearch.SelectedIndexChanged += cbSearch_SelectedIndexChanged;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(800, 450);
            Controls.Add(cbSearch);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnClose);
            Controls.Add(dgvCarList);
            Controls.Add(txtPrice);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnload);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnload;
        private Button btnNew;
        private Button btnDelete;
        private Label lbCarID;
        private Label lbCarName;
        private Label lbManufacturer;
        private Label lbPrice;
        private Label lbReleaseYear;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private TextBox txtManufacturer;
        private TextBox txtReleaseYear;
        private TextBox txtPrice;
        private DataGridView dgvCarList;
        private Button btnClose;
        private TextBox txtSearch;
        private Button btnSearch;
        private ComboBox cbSearch;
    }
}