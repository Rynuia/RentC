namespace RentC
{
    partial class ListRentForm
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_eno_sort = new System.Windows.Forms.Button();
            this.btn_plate_sort = new System.Windows.Forms.Button();
            this.btn_cID_sort = new System.Windows.Forms.Button();
            this.btn_carID_sort = new System.Windows.Forms.Button();
            this.btn_city_sort = new System.Windows.Forms.Button();
            this.btn_edate_sort = new System.Windows.Forms.Button();
            this.btn_sdate_sort = new System.Windows.Forms.Button();
            this.eno_lb = new System.Windows.Forms.Label();
            this.plate_lb = new System.Windows.Forms.Label();
            this.carID_lb = new System.Windows.Forms.Label();
            this.cID_lb = new System.Windows.Forms.Label();
            this.sdate_lb = new System.Windows.Forms.Label();
            this.edate_lb = new System.Windows.Forms.Label();
            this.city_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.cursort_lb = new System.Windows.Forms.Label();
            this.cs_lb = new System.Windows.Forms.Label();
            this.ReservStatsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostumerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReservStatsID,
            this.Plate,
            this.CarID,
            this.CostumerID,
            this.StartDate,
            this.EndDate,
            this.Location});
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.ShowEditingIcon = false;
            this.dgv.Size = new System.Drawing.Size(800, 334);
            this.dgv.TabIndex = 0;
            // 
            // btn_eno_sort
            // 
            this.btn_eno_sort.Location = new System.Drawing.Point(50, 411);
            this.btn_eno_sort.Name = "btn_eno_sort";
            this.btn_eno_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_eno_sort.TabIndex = 1;
            this.btn_eno_sort.Text = "Descending";
            this.btn_eno_sort.UseVisualStyleBackColor = true;
            this.btn_eno_sort.Click += new System.EventHandler(this.btn_eno_sort_Click);
            // 
            // btn_plate_sort
            // 
            this.btn_plate_sort.Location = new System.Drawing.Point(144, 411);
            this.btn_plate_sort.Name = "btn_plate_sort";
            this.btn_plate_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_plate_sort.TabIndex = 2;
            this.btn_plate_sort.Text = "Ascending";
            this.btn_plate_sort.UseVisualStyleBackColor = true;
            this.btn_plate_sort.Click += new System.EventHandler(this.btn_plate_sort_Click);
            // 
            // btn_cID_sort
            // 
            this.btn_cID_sort.Location = new System.Drawing.Point(328, 411);
            this.btn_cID_sort.Name = "btn_cID_sort";
            this.btn_cID_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_cID_sort.TabIndex = 4;
            this.btn_cID_sort.Text = "Ascending";
            this.btn_cID_sort.UseVisualStyleBackColor = true;
            this.btn_cID_sort.Click += new System.EventHandler(this.btn_cID_sort_Click);
            // 
            // btn_carID_sort
            // 
            this.btn_carID_sort.Location = new System.Drawing.Point(234, 411);
            this.btn_carID_sort.Name = "btn_carID_sort";
            this.btn_carID_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_carID_sort.TabIndex = 3;
            this.btn_carID_sort.Text = "Ascending";
            this.btn_carID_sort.UseVisualStyleBackColor = true;
            this.btn_carID_sort.Click += new System.EventHandler(this.btn_carID_sort_Click);
            // 
            // btn_city_sort
            // 
            this.btn_city_sort.Location = new System.Drawing.Point(605, 411);
            this.btn_city_sort.Name = "btn_city_sort";
            this.btn_city_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_city_sort.TabIndex = 7;
            this.btn_city_sort.Text = "Ascending";
            this.btn_city_sort.UseVisualStyleBackColor = true;
            this.btn_city_sort.Click += new System.EventHandler(this.btn_city_sort_Click);
            // 
            // btn_edate_sort
            // 
            this.btn_edate_sort.Location = new System.Drawing.Point(511, 411);
            this.btn_edate_sort.Name = "btn_edate_sort";
            this.btn_edate_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_edate_sort.TabIndex = 6;
            this.btn_edate_sort.Text = "Ascending";
            this.btn_edate_sort.UseVisualStyleBackColor = true;
            this.btn_edate_sort.Click += new System.EventHandler(this.btn_edate_sort_Click);
            // 
            // btn_sdate_sort
            // 
            this.btn_sdate_sort.Location = new System.Drawing.Point(421, 411);
            this.btn_sdate_sort.Name = "btn_sdate_sort";
            this.btn_sdate_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_sdate_sort.TabIndex = 5;
            this.btn_sdate_sort.Text = "Ascending";
            this.btn_sdate_sort.UseVisualStyleBackColor = true;
            this.btn_sdate_sort.Click += new System.EventHandler(this.btn_sdate_sort_Click);
            // 
            // eno_lb
            // 
            this.eno_lb.AutoSize = true;
            this.eno_lb.Location = new System.Drawing.Point(61, 385);
            this.eno_lb.Name = "eno_lb";
            this.eno_lb.Size = new System.Drawing.Size(48, 13);
            this.eno_lb.TabIndex = 8;
            this.eno_lb.Text = "Entry No";
            // 
            // plate_lb
            // 
            this.plate_lb.AutoSize = true;
            this.plate_lb.Location = new System.Drawing.Point(163, 385);
            this.plate_lb.Name = "plate_lb";
            this.plate_lb.Size = new System.Drawing.Size(31, 13);
            this.plate_lb.TabIndex = 9;
            this.plate_lb.Text = "Plate";
            // 
            // carID_lb
            // 
            this.carID_lb.AutoSize = true;
            this.carID_lb.Location = new System.Drawing.Point(253, 385);
            this.carID_lb.Name = "carID_lb";
            this.carID_lb.Size = new System.Drawing.Size(37, 13);
            this.carID_lb.TabIndex = 10;
            this.carID_lb.Text = "Car ID";
            // 
            // cID_lb
            // 
            this.cID_lb.AutoSize = true;
            this.cID_lb.Location = new System.Drawing.Point(332, 385);
            this.cID_lb.Name = "cID_lb";
            this.cID_lb.Size = new System.Drawing.Size(65, 13);
            this.cID_lb.TabIndex = 11;
            this.cID_lb.Text = "Customer ID";
            // 
            // sdate_lb
            // 
            this.sdate_lb.AutoSize = true;
            this.sdate_lb.Location = new System.Drawing.Point(430, 385);
            this.sdate_lb.Name = "sdate_lb";
            this.sdate_lb.Size = new System.Drawing.Size(55, 13);
            this.sdate_lb.TabIndex = 12;
            this.sdate_lb.Text = "Start Date";
            // 
            // edate_lb
            // 
            this.edate_lb.AutoSize = true;
            this.edate_lb.Location = new System.Drawing.Point(522, 385);
            this.edate_lb.Name = "edate_lb";
            this.edate_lb.Size = new System.Drawing.Size(52, 13);
            this.edate_lb.TabIndex = 13;
            this.edate_lb.Text = "End Date";
            // 
            // city_lb
            // 
            this.city_lb.AutoSize = true;
            this.city_lb.Location = new System.Drawing.Point(627, 385);
            this.city_lb.Name = "city_lb";
            this.city_lb.Size = new System.Drawing.Size(24, 13);
            this.city_lb.TabIndex = 14;
            this.city_lb.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Sort By:";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(715, 476);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 23;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // cursort_lb
            // 
            this.cursort_lb.AutoSize = true;
            this.cursort_lb.Location = new System.Drawing.Point(13, 450);
            this.cursort_lb.Name = "cursort_lb";
            this.cursort_lb.Size = new System.Drawing.Size(99, 13);
            this.cursort_lb.TabIndex = 24;
            this.cursort_lb.Text = "Currently sorting by:";
            // 
            // cs_lb
            // 
            this.cs_lb.AutoSize = true;
            this.cs_lb.Location = new System.Drawing.Point(109, 450);
            this.cs_lb.Name = "cs_lb";
            this.cs_lb.Size = new System.Drawing.Size(101, 13);
            this.cs_lb.TabIndex = 25;
            this.cs_lb.Text = "Entry No Ascending";
            // 
            // ReservStatsID
            // 
            this.ReservStatsID.DataPropertyName = "ReservStatsID";
            this.ReservStatsID.HeaderText = "Entry No";
            this.ReservStatsID.Name = "ReservStatsID";
            // 
            // Plate
            // 
            this.Plate.DataPropertyName = "Plate";
            this.Plate.HeaderText = "Plate";
            this.Plate.Name = "Plate";
            // 
            // CarID
            // 
            this.CarID.DataPropertyName = "CarID";
            this.CarID.HeaderText = "Car ID";
            this.CarID.Name = "CarID";
            // 
            // CostumerID
            // 
            this.CostumerID.DataPropertyName = "CostumerID";
            this.CostumerID.HeaderText = "Customer ID";
            this.CostumerID.Name = "CostumerID";
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "End Date";
            this.EndDate.Name = "EndDate";
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "City";
            this.Location.Name = "Location";
            // 
            // ListRentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 524);
            this.Controls.Add(this.cs_lb);
            this.Controls.Add(this.cursort_lb);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.city_lb);
            this.Controls.Add(this.edate_lb);
            this.Controls.Add(this.sdate_lb);
            this.Controls.Add(this.cID_lb);
            this.Controls.Add(this.carID_lb);
            this.Controls.Add(this.plate_lb);
            this.Controls.Add(this.eno_lb);
            this.Controls.Add(this.btn_city_sort);
            this.Controls.Add(this.btn_edate_sort);
            this.Controls.Add(this.btn_sdate_sort);
            this.Controls.Add(this.btn_cID_sort);
            this.Controls.Add(this.btn_carID_sort);
            this.Controls.Add(this.btn_plate_sort);
            this.Controls.Add(this.btn_eno_sort);
            this.Controls.Add(this.dgv);
            this.Name = "ListRentForm";
            this.Text = "ListRentForm";
            this.Load += new System.EventHandler(this.ListRentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_eno_sort;
        private System.Windows.Forms.Button btn_plate_sort;
        private System.Windows.Forms.Button btn_cID_sort;
        private System.Windows.Forms.Button btn_carID_sort;
        private System.Windows.Forms.Button btn_city_sort;
        private System.Windows.Forms.Button btn_edate_sort;
        private System.Windows.Forms.Button btn_sdate_sort;
        private System.Windows.Forms.Label eno_lb;
        private System.Windows.Forms.Label plate_lb;
        private System.Windows.Forms.Label carID_lb;
        private System.Windows.Forms.Label cID_lb;
        private System.Windows.Forms.Label sdate_lb;
        private System.Windows.Forms.Label edate_lb;
        private System.Windows.Forms.Label city_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label cursort_lb;
        private System.Windows.Forms.Label cs_lb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservStatsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostumerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
    }
}