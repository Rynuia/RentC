namespace RentC
{
    partial class ListCarForm
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
            this.city_lb = new System.Windows.Forms.Label();
            this.ppd_lb = new System.Windows.Forms.Label();
            this.model_lb = new System.Windows.Forms.Label();
            this.manu_lb = new System.Windows.Forms.Label();
            this.plate_lb = new System.Windows.Forms.Label();
            this.carID_lb = new System.Windows.Forms.Label();
            this.btn_city_sort = new System.Windows.Forms.Button();
            this.btn_ppd_sort = new System.Windows.Forms.Button();
            this.btn_model_sort = new System.Windows.Forms.Button();
            this.btn_manu_sort = new System.Windows.Forms.Button();
            this.btn_plate_sort = new System.Windows.Forms.Button();
            this.btn_carID_sort = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.CarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cs_lb
            // 
            this.cs_lb.AutoSize = true;
            this.cs_lb.Location = new System.Drawing.Point(110, 450);
            this.cs_lb.Name = "cs_lb";
            this.cs_lb.Size = new System.Drawing.Size(90, 13);
            this.cs_lb.TabIndex = 41;
            this.cs_lb.Text = "Car ID Ascending";
            // 
            // cursort_lb
            // 
            this.cursort_lb.AutoSize = true;
            this.cursort_lb.Location = new System.Drawing.Point(14, 450);
            this.cursort_lb.Name = "cursort_lb";
            this.cursort_lb.Size = new System.Drawing.Size(99, 13);
            this.cursort_lb.TabIndex = 40;
            this.cursort_lb.Text = "Currently sorting by:";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(568, 476);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 39;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Sort By:";
            // 
            // city_lb
            // 
            this.city_lb.AutoSize = true;
            this.city_lb.Location = new System.Drawing.Point(537, 385);
            this.city_lb.Name = "city_lb";
            this.city_lb.Size = new System.Drawing.Size(24, 13);
            this.city_lb.TabIndex = 37;
            this.city_lb.Text = "City";
            // 
            // ppd_lb
            // 
            this.ppd_lb.AutoSize = true;
            this.ppd_lb.Location = new System.Drawing.Point(423, 385);
            this.ppd_lb.Name = "ppd_lb";
            this.ppd_lb.Size = new System.Drawing.Size(72, 13);
            this.ppd_lb.TabIndex = 36;
            this.ppd_lb.Text = "Price Per Day";
            // 
            // model_lb
            // 
            this.model_lb.AutoSize = true;
            this.model_lb.Location = new System.Drawing.Point(347, 385);
            this.model_lb.Name = "model_lb";
            this.model_lb.Size = new System.Drawing.Size(36, 13);
            this.model_lb.TabIndex = 35;
            this.model_lb.Text = "Model";
            // 
            // manu_lb
            // 
            this.manu_lb.AutoSize = true;
            this.manu_lb.Location = new System.Drawing.Point(237, 385);
            this.manu_lb.Name = "manu_lb";
            this.manu_lb.Size = new System.Drawing.Size(70, 13);
            this.manu_lb.TabIndex = 34;
            this.manu_lb.Text = "Manufacturer";
            // 
            // plate_lb
            // 
            this.plate_lb.AutoSize = true;
            this.plate_lb.Location = new System.Drawing.Point(168, 385);
            this.plate_lb.Name = "plate_lb";
            this.plate_lb.Size = new System.Drawing.Size(31, 13);
            this.plate_lb.TabIndex = 33;
            this.plate_lb.Text = "Plate";
            // 
            // carID_lb
            // 
            this.carID_lb.AutoSize = true;
            this.carID_lb.Location = new System.Drawing.Point(70, 385);
            this.carID_lb.Name = "carID_lb";
            this.carID_lb.Size = new System.Drawing.Size(37, 13);
            this.carID_lb.TabIndex = 32;
            this.carID_lb.Text = "Car ID";
            // 
            // btn_city_sort
            // 
            this.btn_city_sort.Location = new System.Drawing.Point(512, 411);
            this.btn_city_sort.Name = "btn_city_sort";
            this.btn_city_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_city_sort.TabIndex = 31;
            this.btn_city_sort.Text = "Ascending";
            this.btn_city_sort.UseVisualStyleBackColor = true;
            this.btn_city_sort.Click += new System.EventHandler(this.btn_city_sort_Click);
            // 
            // btn_ppd_sort
            // 
            this.btn_ppd_sort.Location = new System.Drawing.Point(422, 411);
            this.btn_ppd_sort.Name = "btn_ppd_sort";
            this.btn_ppd_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_ppd_sort.TabIndex = 30;
            this.btn_ppd_sort.Text = "Ascending";
            this.btn_ppd_sort.UseVisualStyleBackColor = true;
            this.btn_ppd_sort.Click += new System.EventHandler(this.btn_ppd_sort_Click);
            // 
            // btn_model_sort
            // 
            this.btn_model_sort.Location = new System.Drawing.Point(329, 411);
            this.btn_model_sort.Name = "btn_model_sort";
            this.btn_model_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_model_sort.TabIndex = 29;
            this.btn_model_sort.Text = "Ascending";
            this.btn_model_sort.UseVisualStyleBackColor = true;
            this.btn_model_sort.Click += new System.EventHandler(this.btn_model_sort_Click);
            // 
            // btn_manu_sort
            // 
            this.btn_manu_sort.Location = new System.Drawing.Point(235, 411);
            this.btn_manu_sort.Name = "btn_manu_sort";
            this.btn_manu_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_manu_sort.TabIndex = 28;
            this.btn_manu_sort.Text = "Ascending";
            this.btn_manu_sort.UseVisualStyleBackColor = true;
            this.btn_manu_sort.Click += new System.EventHandler(this.btn_manu_sort_Click);
            // 
            // btn_plate_sort
            // 
            this.btn_plate_sort.Location = new System.Drawing.Point(145, 411);
            this.btn_plate_sort.Name = "btn_plate_sort";
            this.btn_plate_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_plate_sort.TabIndex = 27;
            this.btn_plate_sort.Text = "Ascending";
            this.btn_plate_sort.UseVisualStyleBackColor = true;
            this.btn_plate_sort.Click += new System.EventHandler(this.btn_plate_sort_Click);
            // 
            // btn_carID_sort
            // 
            this.btn_carID_sort.Location = new System.Drawing.Point(51, 411);
            this.btn_carID_sort.Name = "btn_carID_sort";
            this.btn_carID_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_carID_sort.TabIndex = 26;
            this.btn_carID_sort.Text = "Descending";
            this.btn_carID_sort.UseVisualStyleBackColor = true;
            this.btn_carID_sort.Click += new System.EventHandler(this.btn_carID_sort_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarID,
            this.Plate,
            this.Manufacturer,
            this.Model,
            this.PricePerDay,
            this.cLocation});
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.ShowEditingIcon = false;
            this.dgv.Size = new System.Drawing.Size(661, 334);
            this.dgv.TabIndex = 42;
            // 
            // CarID
            // 
            this.CarID.DataPropertyName = "CarID";
            this.CarID.HeaderText = "Car ID";
            this.CarID.Name = "CarID";
            this.CarID.ReadOnly = true;
            this.CarID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Plate
            // 
            this.Plate.DataPropertyName = "Plate";
            this.Plate.HeaderText = "Plate";
            this.Plate.Name = "Plate";
            this.Plate.ReadOnly = true;
            this.Plate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Manufacturer
            // 
            this.Manufacturer.DataPropertyName = "Manufacturer";
            this.Manufacturer.HeaderText = "Manufacturer";
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            this.Manufacturer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PricePerDay
            // 
            this.PricePerDay.DataPropertyName = "PricePerDay";
            this.PricePerDay.HeaderText = "Price Per Day";
            this.PricePerDay.Name = "PricePerDay";
            this.PricePerDay.ReadOnly = true;
            this.PricePerDay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cLocation
            // 
            this.cLocation.DataPropertyName = "Location";
            this.cLocation.HeaderText = "City";
            this.cLocation.Name = "cLocation";
            this.cLocation.ReadOnly = true;
            this.cLocation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ListCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 524);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cs_lb);
            this.Controls.Add(this.cursort_lb);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.city_lb);
            this.Controls.Add(this.ppd_lb);
            this.Controls.Add(this.model_lb);
            this.Controls.Add(this.manu_lb);
            this.Controls.Add(this.plate_lb);
            this.Controls.Add(this.carID_lb);
            this.Controls.Add(this.btn_city_sort);
            this.Controls.Add(this.btn_ppd_sort);
            this.Controls.Add(this.btn_model_sort);
            this.Controls.Add(this.btn_manu_sort);
            this.Controls.Add(this.btn_plate_sort);
            this.Controls.Add(this.btn_carID_sort);
            this.Name = "ListCarForm";
            this.Text = "ListCarForm";
            this.Load += new System.EventHandler(this.ListCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cs_lb;
        private System.Windows.Forms.Label cursort_lb;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label city_lb;
        private System.Windows.Forms.Label ppd_lb;
        private System.Windows.Forms.Label model_lb;
        private System.Windows.Forms.Label manu_lb;
        private System.Windows.Forms.Label plate_lb;
        private System.Windows.Forms.Label carID_lb;
        private System.Windows.Forms.Button btn_city_sort;
        private System.Windows.Forms.Button btn_ppd_sort;
        private System.Windows.Forms.Button btn_model_sort;
        private System.Windows.Forms.Button btn_manu_sort;
        private System.Windows.Forms.Button btn_plate_sort;
        private System.Windows.Forms.Button btn_carID_sort;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLocation;
    }
}