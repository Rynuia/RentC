﻿namespace RentC
{
    partial class RegRentForm
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
            this.cPlate_label = new System.Windows.Forms.Label();
            this.cID_label = new System.Windows.Forms.Label();
            this.sDate_label = new System.Windows.Forms.Label();
            this.eDate_label = new System.Windows.Forms.Label();
            this.city_label = new System.Windows.Forms.Label();
            this.cPlate_tb = new System.Windows.Forms.TextBox();
            this.cID_tb = new System.Windows.Forms.TextBox();
            this.city_tb = new System.Windows.Forms.TextBox();
            this.confirmb = new System.Windows.Forms.Button();
            this.rentc_dbDataSet = new RentC.rentc_dbDataSet();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new RentC.rentc_dbDataSetTableAdapters.CarsTableAdapter();
            this.start_tp = new System.Windows.Forms.DateTimePicker();
            this.end_tp = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.rentc_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cPlate_label
            // 
            this.cPlate_label.AutoSize = true;
            this.cPlate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cPlate_label.Location = new System.Drawing.Point(45, 43);
            this.cPlate_label.Name = "cPlate_label";
            this.cPlate_label.Size = new System.Drawing.Size(74, 20);
            this.cPlate_label.TabIndex = 0;
            this.cPlate_label.Text = "Car Plate";
            // 
            // cID_label
            // 
            this.cID_label.AutoSize = true;
            this.cID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cID_label.Location = new System.Drawing.Point(45, 89);
            this.cID_label.Name = "cID_label";
            this.cID_label.Size = new System.Drawing.Size(70, 20);
            this.cID_label.TabIndex = 1;
            this.cID_label.Text = "Client ID";
            // 
            // sDate_label
            // 
            this.sDate_label.AutoSize = true;
            this.sDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sDate_label.Location = new System.Drawing.Point(45, 134);
            this.sDate_label.Name = "sDate_label";
            this.sDate_label.Size = new System.Drawing.Size(83, 20);
            this.sDate_label.TabIndex = 2;
            this.sDate_label.Text = "Start Date";
            // 
            // eDate_label
            // 
            this.eDate_label.AutoSize = true;
            this.eDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eDate_label.Location = new System.Drawing.Point(45, 179);
            this.eDate_label.Name = "eDate_label";
            this.eDate_label.Size = new System.Drawing.Size(77, 20);
            this.eDate_label.TabIndex = 3;
            this.eDate_label.Text = "End Date";
            // 
            // city_label
            // 
            this.city_label.AutoSize = true;
            this.city_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.city_label.Location = new System.Drawing.Point(45, 224);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(35, 20);
            this.city_label.TabIndex = 4;
            this.city_label.Text = "City";
            // 
            // cPlate_tb
            // 
            this.cPlate_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cPlate_tb.Location = new System.Drawing.Point(172, 43);
            this.cPlate_tb.Name = "cPlate_tb";
            this.cPlate_tb.Size = new System.Drawing.Size(120, 26);
            this.cPlate_tb.TabIndex = 5;
            // 
            // cID_tb
            // 
            this.cID_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cID_tb.Location = new System.Drawing.Point(172, 89);
            this.cID_tb.Name = "cID_tb";
            this.cID_tb.Size = new System.Drawing.Size(120, 26);
            this.cID_tb.TabIndex = 6;
            // 
            // city_tb
            // 
            this.city_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.city_tb.Location = new System.Drawing.Point(172, 224);
            this.city_tb.Name = "city_tb";
            this.city_tb.Size = new System.Drawing.Size(120, 26);
            this.city_tb.TabIndex = 9;
            // 
            // confirmb
            // 
            this.confirmb.Location = new System.Drawing.Point(156, 303);
            this.confirmb.Name = "confirmb";
            this.confirmb.Size = new System.Drawing.Size(99, 43);
            this.confirmb.TabIndex = 10;
            this.confirmb.Text = "Confirm";
            this.confirmb.UseVisualStyleBackColor = true;
            this.confirmb.Click += new System.EventHandler(this.button1_Click);
            // 
            // rentc_dbDataSet
            // 
            this.rentc_dbDataSet.DataSetName = "rentc_dbDataSet";
            this.rentc_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.rentc_dbDataSet;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // start_tp
            // 
            this.start_tp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.start_tp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.start_tp.Location = new System.Drawing.Point(172, 134);
            this.start_tp.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.start_tp.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.start_tp.Name = "start_tp";
            this.start_tp.Size = new System.Drawing.Size(120, 26);
            this.start_tp.TabIndex = 11;
            this.start_tp.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // end_tp
            // 
            this.end_tp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.end_tp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.end_tp.Location = new System.Drawing.Point(172, 179);
            this.end_tp.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.end_tp.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.end_tp.Name = "end_tp";
            this.end_tp.Size = new System.Drawing.Size(120, 26);
            this.end_tp.TabIndex = 12;
            this.end_tp.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // RegRentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 392);
            this.Controls.Add(this.end_tp);
            this.Controls.Add(this.start_tp);
            this.Controls.Add(this.confirmb);
            this.Controls.Add(this.city_tb);
            this.Controls.Add(this.cID_tb);
            this.Controls.Add(this.cPlate_tb);
            this.Controls.Add(this.city_label);
            this.Controls.Add(this.eDate_label);
            this.Controls.Add(this.sDate_label);
            this.Controls.Add(this.cID_label);
            this.Controls.Add(this.cPlate_label);
            this.Name = "RegRentForm";
            this.Text = "Register new Car Rent";
            this.Load += new System.EventHandler(this.RegRentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentc_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cPlate_label;
        private System.Windows.Forms.Label cID_label;
        private System.Windows.Forms.Label sDate_label;
        private System.Windows.Forms.Label eDate_label;
        private System.Windows.Forms.Label city_label;
        private System.Windows.Forms.TextBox cPlate_tb;
        private System.Windows.Forms.TextBox cID_tb;
        private System.Windows.Forms.TextBox city_tb;
        private System.Windows.Forms.Button confirmb;
        private rentc_dbDataSet rentc_dbDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private rentc_dbDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.DateTimePicker start_tp;
        private System.Windows.Forms.DateTimePicker end_tp;
    }
}