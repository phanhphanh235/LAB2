namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lbCarID = new Label();
            txtCarID = new TextBox();
            lbCarName = new Label();
            txtCarName = new TextBox();
            lbManufacturer = new Label();
            txtManufacturer = new TextBox();
            lbPrice = new Label();
            txtPrice = new TextBox();
            lbReleaseYear = new Label();
            txtReleaseYear = new TextBox();
            dgvCarList = new DataGridView();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(31, 35);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(39, 15);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(125, 27);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(210, 23);
            txtCarID.TabIndex = 1;
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(31, 79);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(60, 15);
            lbCarName.TabIndex = 0;
            lbCarName.Text = "Car Name";
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(125, 71);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(210, 23);
            txtCarName.TabIndex = 1;
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(31, 128);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(79, 15);
            lbManufacturer.TabIndex = 0;
            lbManufacturer.Text = "Manufacturer";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(125, 120);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(210, 23);
            txtManufacturer.TabIndex = 1;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(423, 35);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 0;
            lbPrice.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(517, 27);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(210, 23);
            txtPrice.TabIndex = 1;
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(423, 79);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(68, 15);
            lbReleaseYear.TabIndex = 0;
            lbReleaseYear.Text = "ReleaseYear";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(517, 71);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(210, 23);
            txtReleaseYear.TabIndex = 1;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(31, 205);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(710, 167);
            dgvCarList.TabIndex = 2;
            dgvCarList.CellContentClick += DgvCarList_CellDoubleClick;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(125, 166);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(99, 23);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(325, 166);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 23);
            btnNew.TabIndex = 4;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(544, 164);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 25);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(325, 388);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 23);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 423);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(dgvCarList);
            Controls.Add(txtReleaseYear);
            Controls.Add(lbReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(lbPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(lbManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(lbCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarID;
        private TextBox txtCarID;
        private Label lbCarName;
        private TextBox txtCarName;
        private Label lbManufacturer;
        private TextBox txtManufacturer;
        private Label lbPrice;
        private TextBox txtPrice;
        private Label lbReleaseYear;
        private TextBox txtReleaseYear;
        private DataGridView dgvCarList;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private Button btnClose;
    }
}
