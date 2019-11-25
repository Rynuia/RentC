namespace RentC
{
    partial class ListCustForm
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
            this.cs_lb = new System.Windows.Forms.Label();
            this.cursort_lb = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.zip_lb = new System.Windows.Forms.Label();
            this.city_lb = new System.Windows.Forms.Label();
            this.bDate_lb = new System.Windows.Forms.Label();
            this.cname_lb = new System.Windows.Forms.Label();
            this.cID_lb = new System.Windows.Forms.Label();
            this.btn_zip_sort = new System.Windows.Forms.Button();
            this.btn_city_sort = new System.Windows.Forms.Button();
            this.btn_bDate_sort = new System.Windows.Forms.Button();
            this.btn_cname_sort = new System.Windows.Forms.Button();
            this.btn_cID_sort = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.CostumerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cs_lb
            // 
            this.cs_lb.AutoSize = true;
            this.cs_lb.Location = new System.Drawing.Point(112, 511);
            this.cs_lb.Name = "cs_lb";
            this.cs_lb.Size = new System.Drawing.Size(100, 13);
            this.cs_lb.TabIndex = 40;
            this.cs_lb.Text = "Client ID Ascending";
            // 
            // cursort_lb
            // 
            this.cursort_lb.AutoSize = true;
            this.cursort_lb.Location = new System.Drawing.Point(16, 511);
            this.cursort_lb.Name = "cursort_lb";
            this.cursort_lb.Size = new System.Drawing.Size(99, 13);
            this.cursort_lb.TabIndex = 39;
            this.cursort_lb.Text = "Currently sorting by:";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(489, 527);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 38;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Sort By:";
            // 
            // zip_lb
            // 
            this.zip_lb.AutoSize = true;
            this.zip_lb.Location = new System.Drawing.Point(435, 446);
            this.zip_lb.Name = "zip_lb";
            this.zip_lb.Size = new System.Drawing.Size(52, 13);
            this.zip_lb.TabIndex = 36;
            this.zip_lb.Text = "ZIP Code";
            // 
            // city_lb
            // 
            this.city_lb.AutoSize = true;
            this.city_lb.Location = new System.Drawing.Point(355, 446);
            this.city_lb.Name = "city_lb";
            this.city_lb.Size = new System.Drawing.Size(24, 13);
            this.city_lb.TabIndex = 35;
            this.city_lb.Text = "City";
            // 
            // bDate_lb
            // 
            this.bDate_lb.AutoSize = true;
            this.bDate_lb.Location = new System.Drawing.Point(248, 446);
            this.bDate_lb.Name = "bDate_lb";
            this.bDate_lb.Size = new System.Drawing.Size(54, 13);
            this.bDate_lb.TabIndex = 34;
            this.bDate_lb.Text = "Birth Date";
            // 
            // cname_lb
            // 
            this.cname_lb.AutoSize = true;
            this.cname_lb.Location = new System.Drawing.Point(152, 446);
            this.cname_lb.Name = "cname_lb";
            this.cname_lb.Size = new System.Drawing.Size(64, 13);
            this.cname_lb.TabIndex = 33;
            this.cname_lb.Text = "Client Name";
            // 
            // cID_lb
            // 
            this.cID_lb.AutoSize = true;
            this.cID_lb.Location = new System.Drawing.Point(68, 446);
            this.cID_lb.Name = "cID_lb";
            this.cID_lb.Size = new System.Drawing.Size(47, 13);
            this.cID_lb.TabIndex = 32;
            this.cID_lb.Text = "Client ID";
            // 
            // btn_zip_sort
            // 
            this.btn_zip_sort.Location = new System.Drawing.Point(424, 472);
            this.btn_zip_sort.Name = "btn_zip_sort";
            this.btn_zip_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_zip_sort.TabIndex = 31;
            this.btn_zip_sort.Text = "Ascending";
            this.btn_zip_sort.UseVisualStyleBackColor = true;
            this.btn_zip_sort.Click += new System.EventHandler(this.btn_zip_sort_Click);
            // 
            // btn_city_sort
            // 
            this.btn_city_sort.Location = new System.Drawing.Point(331, 472);
            this.btn_city_sort.Name = "btn_city_sort";
            this.btn_city_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_city_sort.TabIndex = 30;
            this.btn_city_sort.Text = "Ascending";
            this.btn_city_sort.UseVisualStyleBackColor = true;
            this.btn_city_sort.Click += new System.EventHandler(this.btn_city_sort_Click);
            // 
            // btn_bDate_sort
            // 
            this.btn_bDate_sort.Location = new System.Drawing.Point(237, 472);
            this.btn_bDate_sort.Name = "btn_bDate_sort";
            this.btn_bDate_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_bDate_sort.TabIndex = 29;
            this.btn_bDate_sort.Text = "Ascending";
            this.btn_bDate_sort.UseVisualStyleBackColor = true;
            this.btn_bDate_sort.Click += new System.EventHandler(this.btn_bDate_sort_Click);
            // 
            // btn_cname_sort
            // 
            this.btn_cname_sort.Location = new System.Drawing.Point(147, 472);
            this.btn_cname_sort.Name = "btn_cname_sort";
            this.btn_cname_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_cname_sort.TabIndex = 28;
            this.btn_cname_sort.Text = "Ascending";
            this.btn_cname_sort.UseVisualStyleBackColor = true;
            this.btn_cname_sort.Click += new System.EventHandler(this.btn_cname_sort_Click);
            // 
            // btn_cID_sort
            // 
            this.btn_cID_sort.Location = new System.Drawing.Point(53, 472);
            this.btn_cID_sort.Name = "btn_cID_sort";
            this.btn_cID_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_cID_sort.TabIndex = 27;
            this.btn_cID_sort.Text = "Descending";
            this.btn_cID_sort.UseVisualStyleBackColor = true;
            this.btn_cID_sort.Click += new System.EventHandler(this.btn_cID_sort_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CostumerID,
            this.cName,
            this.BirthDate,
            this.cLocation,
            this.Zip});
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.ShowEditingIcon = false;
            this.dgv.Size = new System.Drawing.Size(561, 389);
            this.dgv.TabIndex = 26;
            // 
            // CostumerID
            // 
            this.CostumerID.DataPropertyName = "CostumerID";
            this.CostumerID.HeaderText = "Client ID";
            this.CostumerID.Name = "CostumerID";
            this.CostumerID.ReadOnly = true;
            this.CostumerID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cName
            // 
            this.cName.DataPropertyName = "Name";
            this.cName.HeaderText = "Client Name";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            this.cName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BirthDate
            // 
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "Birth Date";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            this.BirthDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cLocation
            // 
            this.cLocation.DataPropertyName = "Location";
            this.cLocation.HeaderText = "City";
            this.cLocation.Name = "cLocation";
            this.cLocation.ReadOnly = true;
            this.cLocation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Zip
            // 
            this.Zip.DataPropertyName = "Zip";
            this.Zip.HeaderText = "ZIP Code";
            this.Zip.Name = "Zip";
            this.Zip.ReadOnly = true;
            this.Zip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ListCustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 573);
            this.Controls.Add(this.cs_lb);
            this.Controls.Add(this.cursort_lb);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zip_lb);
            this.Controls.Add(this.city_lb);
            this.Controls.Add(this.bDate_lb);
            this.Controls.Add(this.cname_lb);
            this.Controls.Add(this.cID_lb);
            this.Controls.Add(this.btn_zip_sort);
            this.Controls.Add(this.btn_city_sort);
            this.Controls.Add(this.btn_bDate_sort);
            this.Controls.Add(this.btn_cname_sort);
            this.Controls.Add(this.btn_cID_sort);
            this.Controls.Add(this.dgv);
            this.Name = "ListCustForm";
            this.Text = "ListCustForm";
            this.Load += new System.EventHandler(this.ListCustForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cs_lb;
        private System.Windows.Forms.Label cursort_lb;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label zip_lb;
        private System.Windows.Forms.Label city_lb;
        private System.Windows.Forms.Label bDate_lb;
        private System.Windows.Forms.Label cname_lb;
        private System.Windows.Forms.Label cID_lb;
        private System.Windows.Forms.Button btn_zip_sort;
        private System.Windows.Forms.Button btn_city_sort;
        private System.Windows.Forms.Button btn_bDate_sort;
        private System.Windows.Forms.Button btn_cname_sort;
        private System.Windows.Forms.Button btn_cID_sort;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostumerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zip;
    }
}