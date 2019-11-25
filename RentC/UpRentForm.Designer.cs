namespace RentC
{
    partial class UpRentForm
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
            this.components = new System.ComponentModel.Container();
            this.city_label = new System.Windows.Forms.Label();
            this.eDate_label = new System.Windows.Forms.Label();
            this.sDate_label = new System.Windows.Forms.Label();
            this.cID_label = new System.Windows.Forms.Label();
            this.cPlate_label = new System.Windows.Forms.Label();
            this.end_tp = new System.Windows.Forms.DateTimePicker();
            this.start_tp = new System.Windows.Forms.DateTimePicker();
            this.city_tb = new System.Windows.Forms.TextBox();
            this.cID_tb = new System.Windows.Forms.TextBox();
            this.cPlate_tb = new System.Windows.Forms.TextBox();
            this.rentc_dbDataSet = new RentC.rentc_dbDataSet();
            this.reservationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationsTableAdapter = new RentC.rentc_dbDataSetTableAdapters.ReservationsTableAdapter();
            this.carID_db_lb = new System.Windows.Forms.Label();
            this.carID_db = new System.Windows.Forms.Label();
            this.cID_db = new System.Windows.Forms.Label();
            this.cID_db_lb = new System.Windows.Forms.Label();
            this.sDate_db = new System.Windows.Forms.Label();
            this.sDate_db_lb = new System.Windows.Forms.Label();
            this.eDate_db = new System.Windows.Forms.Label();
            this.eDate_db_lb = new System.Windows.Forms.Label();
            this.city_db = new System.Windows.Forms.Label();
            this.city_db_lb = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.cPlate_new_tb = new System.Windows.Forms.TextBox();
            this.cPlate_n_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rentc_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // city_label
            // 
            this.city_label.AutoSize = true;
            this.city_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.city_label.Location = new System.Drawing.Point(71, 330);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(35, 20);
            this.city_label.TabIndex = 9;
            this.city_label.Text = "City";
            // 
            // eDate_label
            // 
            this.eDate_label.AutoSize = true;
            this.eDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eDate_label.Location = new System.Drawing.Point(71, 285);
            this.eDate_label.Name = "eDate_label";
            this.eDate_label.Size = new System.Drawing.Size(77, 20);
            this.eDate_label.TabIndex = 8;
            this.eDate_label.Text = "End Date";
            // 
            // sDate_label
            // 
            this.sDate_label.AutoSize = true;
            this.sDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sDate_label.Location = new System.Drawing.Point(71, 240);
            this.sDate_label.Name = "sDate_label";
            this.sDate_label.Size = new System.Drawing.Size(83, 20);
            this.sDate_label.TabIndex = 7;
            this.sDate_label.Text = "Start Date";
            // 
            // cID_label
            // 
            this.cID_label.AutoSize = true;
            this.cID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cID_label.Location = new System.Drawing.Point(71, 195);
            this.cID_label.Name = "cID_label";
            this.cID_label.Size = new System.Drawing.Size(70, 20);
            this.cID_label.TabIndex = 6;
            this.cID_label.Text = "Client ID";
            // 
            // cPlate_label
            // 
            this.cPlate_label.AutoSize = true;
            this.cPlate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cPlate_label.Location = new System.Drawing.Point(71, 40);
            this.cPlate_label.Name = "cPlate_label";
            this.cPlate_label.Size = new System.Drawing.Size(74, 20);
            this.cPlate_label.TabIndex = 5;
            this.cPlate_label.Text = "Car Plate";
            // 
            // end_tp
            // 
            this.end_tp.Enabled = false;
            this.end_tp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.end_tp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.end_tp.Location = new System.Drawing.Point(186, 282);
            this.end_tp.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.end_tp.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.end_tp.Name = "end_tp";
            this.end_tp.Size = new System.Drawing.Size(120, 26);
            this.end_tp.TabIndex = 17;
            this.end_tp.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // start_tp
            // 
            this.start_tp.Enabled = false;
            this.start_tp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.start_tp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.start_tp.Location = new System.Drawing.Point(186, 237);
            this.start_tp.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.start_tp.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.start_tp.Name = "start_tp";
            this.start_tp.Size = new System.Drawing.Size(120, 26);
            this.start_tp.TabIndex = 16;
            this.start_tp.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // city_tb
            // 
            this.city_tb.Enabled = false;
            this.city_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.city_tb.Location = new System.Drawing.Point(186, 327);
            this.city_tb.MaxLength = 40;
            this.city_tb.Name = "city_tb";
            this.city_tb.Size = new System.Drawing.Size(120, 26);
            this.city_tb.TabIndex = 15;
            this.city_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.city_tb_KeyPress);
            // 
            // cID_tb
            // 
            this.cID_tb.Enabled = false;
            this.cID_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cID_tb.Location = new System.Drawing.Point(186, 192);
            this.cID_tb.MaxLength = 6;
            this.cID_tb.Name = "cID_tb";
            this.cID_tb.Size = new System.Drawing.Size(120, 26);
            this.cID_tb.TabIndex = 14;
            this.cID_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cID_tb_KeyPress);
            // 
            // cPlate_tb
            // 
            this.cPlate_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cPlate_tb.Location = new System.Drawing.Point(186, 37);
            this.cPlate_tb.MaxLength = 10;
            this.cPlate_tb.Name = "cPlate_tb";
            this.cPlate_tb.Size = new System.Drawing.Size(120, 26);
            this.cPlate_tb.TabIndex = 13;
            // 
            // rentc_dbDataSet
            // 
            this.rentc_dbDataSet.DataSetName = "rentc_dbDataSet";
            this.rentc_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationsBindingSource
            // 
            this.reservationsBindingSource.DataMember = "Reservations";
            this.reservationsBindingSource.DataSource = this.rentc_dbDataSet;
            // 
            // reservationsTableAdapter
            // 
            this.reservationsTableAdapter.ClearBeforeFill = true;
            // 
            // carID_db_lb
            // 
            this.carID_db_lb.AutoSize = true;
            this.carID_db_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carID_db_lb.Location = new System.Drawing.Point(21, 97);
            this.carID_db_lb.Name = "carID_db_lb";
            this.carID_db_lb.Size = new System.Drawing.Size(48, 16);
            this.carID_db_lb.TabIndex = 18;
            this.carID_db_lb.Text = "Car ID:";
            // 
            // carID_db
            // 
            this.carID_db.AutoSize = true;
            this.carID_db.BackColor = System.Drawing.SystemColors.Info;
            this.carID_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carID_db.Location = new System.Drawing.Point(75, 97);
            this.carID_db.MinimumSize = new System.Drawing.Size(41, 16);
            this.carID_db.Name = "carID_db";
            this.carID_db.Size = new System.Drawing.Size(41, 16);
            this.carID_db.TabIndex = 19;
            // 
            // cID_db
            // 
            this.cID_db.AutoSize = true;
            this.cID_db.BackColor = System.Drawing.SystemColors.Info;
            this.cID_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cID_db.Location = new System.Drawing.Point(206, 97);
            this.cID_db.MinimumSize = new System.Drawing.Size(50, 16);
            this.cID_db.Name = "cID_db";
            this.cID_db.Size = new System.Drawing.Size(50, 16);
            this.cID_db.TabIndex = 21;
            // 
            // cID_db_lb
            // 
            this.cID_db_lb.AutoSize = true;
            this.cID_db_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cID_db_lb.Location = new System.Drawing.Point(140, 97);
            this.cID_db_lb.Name = "cID_db_lb";
            this.cID_db_lb.Size = new System.Drawing.Size(60, 16);
            this.cID_db_lb.TabIndex = 20;
            this.cID_db_lb.Text = "Client ID:";
            // 
            // sDate_db
            // 
            this.sDate_db.AutoSize = true;
            this.sDate_db.BackColor = System.Drawing.SystemColors.Info;
            this.sDate_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sDate_db.Location = new System.Drawing.Point(351, 97);
            this.sDate_db.MinimumSize = new System.Drawing.Size(75, 16);
            this.sDate_db.Name = "sDate_db";
            this.sDate_db.Size = new System.Drawing.Size(75, 16);
            this.sDate_db.TabIndex = 23;
            // 
            // sDate_db_lb
            // 
            this.sDate_db_lb.AutoSize = true;
            this.sDate_db_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sDate_db_lb.Location = new System.Drawing.Point(275, 97);
            this.sDate_db_lb.Name = "sDate_db_lb";
            this.sDate_db_lb.Size = new System.Drawing.Size(70, 16);
            this.sDate_db_lb.TabIndex = 22;
            this.sDate_db_lb.Text = "Start Date:";
            // 
            // eDate_db
            // 
            this.eDate_db.AutoSize = true;
            this.eDate_db.BackColor = System.Drawing.SystemColors.Info;
            this.eDate_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eDate_db.Location = new System.Drawing.Point(524, 97);
            this.eDate_db.MinimumSize = new System.Drawing.Size(75, 16);
            this.eDate_db.Name = "eDate_db";
            this.eDate_db.Size = new System.Drawing.Size(75, 16);
            this.eDate_db.TabIndex = 25;
            // 
            // eDate_db_lb
            // 
            this.eDate_db_lb.AutoSize = true;
            this.eDate_db_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eDate_db_lb.Location = new System.Drawing.Point(451, 97);
            this.eDate_db_lb.Name = "eDate_db_lb";
            this.eDate_db_lb.Size = new System.Drawing.Size(67, 16);
            this.eDate_db_lb.TabIndex = 24;
            this.eDate_db_lb.Text = "End Date:";
            // 
            // city_db
            // 
            this.city_db.AutoSize = true;
            this.city_db.BackColor = System.Drawing.SystemColors.Info;
            this.city_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.city_db.Location = new System.Drawing.Point(666, 97);
            this.city_db.MinimumSize = new System.Drawing.Size(150, 16);
            this.city_db.Name = "city_db";
            this.city_db.Size = new System.Drawing.Size(150, 16);
            this.city_db.TabIndex = 27;
            // 
            // city_db_lb
            // 
            this.city_db_lb.AutoSize = true;
            this.city_db_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.city_db_lb.Location = new System.Drawing.Point(627, 97);
            this.city_db_lb.Name = "city_db_lb";
            this.city_db_lb.Size = new System.Drawing.Size(33, 16);
            this.city_db_lb.TabIndex = 26;
            this.city_db_lb.Text = "City:";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(351, 40);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 28;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_update
            // 
            this.btn_update.Enabled = false;
            this.btn_update.Location = new System.Drawing.Point(460, 208);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(95, 42);
            this.btn_update.TabIndex = 29;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(626, 208);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(95, 42);
            this.btn_delete.TabIndex = 30;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(541, 306);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(95, 42);
            this.btn_exit.TabIndex = 31;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // cPlate_new_tb
            // 
            this.cPlate_new_tb.Enabled = false;
            this.cPlate_new_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cPlate_new_tb.Location = new System.Drawing.Point(186, 147);
            this.cPlate_new_tb.MaxLength = 10;
            this.cPlate_new_tb.Name = "cPlate_new_tb";
            this.cPlate_new_tb.Size = new System.Drawing.Size(120, 26);
            this.cPlate_new_tb.TabIndex = 33;
            // 
            // cPlate_n_label
            // 
            this.cPlate_n_label.AutoSize = true;
            this.cPlate_n_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cPlate_n_label.Location = new System.Drawing.Point(71, 150);
            this.cPlate_n_label.Name = "cPlate_n_label";
            this.cPlate_n_label.Size = new System.Drawing.Size(74, 20);
            this.cPlate_n_label.TabIndex = 32;
            this.cPlate_n_label.Text = "Car Plate";
            // 
            // UpRentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 442);
            this.Controls.Add(this.cPlate_new_tb);
            this.Controls.Add(this.cPlate_n_label);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.city_db);
            this.Controls.Add(this.city_db_lb);
            this.Controls.Add(this.eDate_db);
            this.Controls.Add(this.eDate_db_lb);
            this.Controls.Add(this.sDate_db);
            this.Controls.Add(this.sDate_db_lb);
            this.Controls.Add(this.cID_db);
            this.Controls.Add(this.cID_db_lb);
            this.Controls.Add(this.carID_db);
            this.Controls.Add(this.carID_db_lb);
            this.Controls.Add(this.end_tp);
            this.Controls.Add(this.start_tp);
            this.Controls.Add(this.city_tb);
            this.Controls.Add(this.cID_tb);
            this.Controls.Add(this.cPlate_tb);
            this.Controls.Add(this.city_label);
            this.Controls.Add(this.eDate_label);
            this.Controls.Add(this.sDate_label);
            this.Controls.Add(this.cID_label);
            this.Controls.Add(this.cPlate_label);
            this.Name = "UpRentForm";
            this.Text = "Update Car Rent";
            this.Load += new System.EventHandler(this.UpRentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentc_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label city_label;
        private System.Windows.Forms.Label eDate_label;
        private System.Windows.Forms.Label sDate_label;
        private System.Windows.Forms.Label cID_label;
        private System.Windows.Forms.Label cPlate_label;
        private System.Windows.Forms.DateTimePicker end_tp;
        private System.Windows.Forms.DateTimePicker start_tp;
        private System.Windows.Forms.TextBox city_tb;
        private System.Windows.Forms.TextBox cID_tb;
        private System.Windows.Forms.TextBox cPlate_tb;
        private rentc_dbDataSet rentc_dbDataSet;
        private System.Windows.Forms.BindingSource reservationsBindingSource;
        private rentc_dbDataSetTableAdapters.ReservationsTableAdapter reservationsTableAdapter;
        private System.Windows.Forms.Label carID_db_lb;
        private System.Windows.Forms.Label carID_db;
        private System.Windows.Forms.Label cID_db;
        private System.Windows.Forms.Label cID_db_lb;
        private System.Windows.Forms.Label sDate_db;
        private System.Windows.Forms.Label sDate_db_lb;
        private System.Windows.Forms.Label eDate_db;
        private System.Windows.Forms.Label eDate_db_lb;
        private System.Windows.Forms.Label city_db;
        private System.Windows.Forms.Label city_db_lb;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox cPlate_new_tb;
        private System.Windows.Forms.Label cPlate_n_label;
    }
}