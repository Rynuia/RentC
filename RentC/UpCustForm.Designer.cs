namespace RentC
{
    partial class UpCustForm
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
            this.btn_select = new System.Windows.Forms.Button();
            this.city_db = new System.Windows.Forms.Label();
            this.city_db_lb = new System.Windows.Forms.Label();
            this.bDate_db = new System.Windows.Forms.Label();
            this.bDate_db_lb = new System.Windows.Forms.Label();
            this.zip_db = new System.Windows.Forms.Label();
            this.zip_db_lb = new System.Windows.Forms.Label();
            this.cID_db = new System.Windows.Forms.Label();
            this.cID_db_lb = new System.Windows.Forms.Label();
            this.cID_tb = new System.Windows.Forms.TextBox();
            this.cID_label = new System.Windows.Forms.Label();
            this.opt_lb = new System.Windows.Forms.Label();
            this.city_tb = new System.Windows.Forms.TextBox();
            this.city_lb = new System.Windows.Forms.Label();
            this.bDate_tp = new System.Windows.Forms.DateTimePicker();
            this.zip_tb = new System.Windows.Forms.TextBox();
            this.cname_tb = new System.Windows.Forms.TextBox();
            this.zip_label = new System.Windows.Forms.Label();
            this.bDate_label = new System.Windows.Forms.Label();
            this.cname_label = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.cname_db = new System.Windows.Forms.Label();
            this.cname_db_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(338, 23);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 39;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // city_db
            // 
            this.city_db.AutoSize = true;
            this.city_db.BackColor = System.Drawing.SystemColors.Info;
            this.city_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.city_db.Location = new System.Drawing.Point(616, 80);
            this.city_db.MinimumSize = new System.Drawing.Size(150, 16);
            this.city_db.Name = "city_db";
            this.city_db.Size = new System.Drawing.Size(150, 16);
            this.city_db.TabIndex = 38;
            // 
            // city_db_lb
            // 
            this.city_db_lb.AutoSize = true;
            this.city_db_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.city_db_lb.Location = new System.Drawing.Point(577, 80);
            this.city_db_lb.Name = "city_db_lb";
            this.city_db_lb.Size = new System.Drawing.Size(33, 16);
            this.city_db_lb.TabIndex = 37;
            this.city_db_lb.Text = "City:";
            // 
            // bDate_db
            // 
            this.bDate_db.AutoSize = true;
            this.bDate_db.BackColor = System.Drawing.SystemColors.Info;
            this.bDate_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bDate_db.Location = new System.Drawing.Point(485, 80);
            this.bDate_db.MinimumSize = new System.Drawing.Size(75, 16);
            this.bDate_db.Name = "bDate_db";
            this.bDate_db.Size = new System.Drawing.Size(75, 16);
            this.bDate_db.TabIndex = 36;
            // 
            // bDate_db_lb
            // 
            this.bDate_db_lb.AutoSize = true;
            this.bDate_db_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bDate_db_lb.Location = new System.Drawing.Point(409, 80);
            this.bDate_db_lb.Name = "bDate_db_lb";
            this.bDate_db_lb.Size = new System.Drawing.Size(69, 16);
            this.bDate_db_lb.TabIndex = 35;
            this.bDate_db_lb.Text = "Birth Date:";
            // 
            // zip_db
            // 
            this.zip_db.AutoSize = true;
            this.zip_db.BackColor = System.Drawing.SystemColors.Info;
            this.zip_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zip_db.Location = new System.Drawing.Point(860, 80);
            this.zip_db.MinimumSize = new System.Drawing.Size(60, 16);
            this.zip_db.Name = "zip_db";
            this.zip_db.Size = new System.Drawing.Size(60, 16);
            this.zip_db.TabIndex = 34;
            // 
            // zip_db_lb
            // 
            this.zip_db_lb.AutoSize = true;
            this.zip_db_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zip_db_lb.Location = new System.Drawing.Point(787, 80);
            this.zip_db_lb.Name = "zip_db_lb";
            this.zip_db_lb.Size = new System.Drawing.Size(67, 16);
            this.zip_db_lb.TabIndex = 33;
            this.zip_db_lb.Text = "ZIP Code:";
            // 
            // cID_db
            // 
            this.cID_db.AutoSize = true;
            this.cID_db.BackColor = System.Drawing.SystemColors.Info;
            this.cID_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cID_db.Location = new System.Drawing.Point(78, 80);
            this.cID_db.MinimumSize = new System.Drawing.Size(50, 16);
            this.cID_db.Name = "cID_db";
            this.cID_db.Size = new System.Drawing.Size(50, 16);
            this.cID_db.TabIndex = 32;
            // 
            // cID_db_lb
            // 
            this.cID_db_lb.AutoSize = true;
            this.cID_db_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cID_db_lb.Location = new System.Drawing.Point(12, 80);
            this.cID_db_lb.Name = "cID_db_lb";
            this.cID_db_lb.Size = new System.Drawing.Size(60, 16);
            this.cID_db_lb.TabIndex = 31;
            this.cID_db_lb.Text = "Client ID:";
            // 
            // cID_tb
            // 
            this.cID_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cID_tb.Location = new System.Drawing.Point(185, 20);
            this.cID_tb.MaxLength = 6;
            this.cID_tb.Name = "cID_tb";
            this.cID_tb.Size = new System.Drawing.Size(120, 26);
            this.cID_tb.TabIndex = 30;
            this.cID_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cID_tb_KeyPress);
            // 
            // cID_label
            // 
            this.cID_label.AutoSize = true;
            this.cID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cID_label.Location = new System.Drawing.Point(58, 23);
            this.cID_label.Name = "cID_label";
            this.cID_label.Size = new System.Drawing.Size(70, 20);
            this.cID_label.TabIndex = 29;
            this.cID_label.Text = "Client ID";
            // 
            // opt_lb
            // 
            this.opt_lb.AutoSize = true;
            this.opt_lb.Location = new System.Drawing.Point(344, 283);
            this.opt_lb.Name = "opt_lb";
            this.opt_lb.Size = new System.Drawing.Size(52, 13);
            this.opt_lb.TabIndex = 48;
            this.opt_lb.Text = "(Optional)";
            // 
            // city_tb
            // 
            this.city_tb.Enabled = false;
            this.city_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.city_tb.Location = new System.Drawing.Point(185, 231);
            this.city_tb.MaxLength = 50;
            this.city_tb.Name = "city_tb";
            this.city_tb.Size = new System.Drawing.Size(150, 26);
            this.city_tb.TabIndex = 47;
            this.city_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.city_tb_KeyPress);
            // 
            // city_lb
            // 
            this.city_lb.AutoSize = true;
            this.city_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.city_lb.Location = new System.Drawing.Point(58, 234);
            this.city_lb.Name = "city_lb";
            this.city_lb.Size = new System.Drawing.Size(35, 20);
            this.city_lb.TabIndex = 46;
            this.city_lb.Text = "City";
            // 
            // bDate_tp
            // 
            this.bDate_tp.Enabled = false;
            this.bDate_tp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bDate_tp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bDate_tp.Location = new System.Drawing.Point(185, 185);
            this.bDate_tp.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.bDate_tp.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.bDate_tp.Name = "bDate_tp";
            this.bDate_tp.Size = new System.Drawing.Size(150, 26);
            this.bDate_tp.TabIndex = 45;
            this.bDate_tp.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // zip_tb
            // 
            this.zip_tb.Enabled = false;
            this.zip_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zip_tb.Location = new System.Drawing.Point(185, 275);
            this.zip_tb.MaxLength = 5;
            this.zip_tb.Name = "zip_tb";
            this.zip_tb.Size = new System.Drawing.Size(150, 26);
            this.zip_tb.TabIndex = 44;
            this.zip_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zip_tb_KeyPress);
            // 
            // cname_tb
            // 
            this.cname_tb.Enabled = false;
            this.cname_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cname_tb.Location = new System.Drawing.Point(185, 140);
            this.cname_tb.MaxLength = 50;
            this.cname_tb.Name = "cname_tb";
            this.cname_tb.Size = new System.Drawing.Size(150, 26);
            this.cname_tb.TabIndex = 43;
            this.cname_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cname_tb_KeyPress);
            // 
            // zip_label
            // 
            this.zip_label.AutoSize = true;
            this.zip_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zip_label.Location = new System.Drawing.Point(58, 278);
            this.zip_label.Name = "zip_label";
            this.zip_label.Size = new System.Drawing.Size(76, 20);
            this.zip_label.TabIndex = 42;
            this.zip_label.Text = "ZIP Code";
            // 
            // bDate_label
            // 
            this.bDate_label.AutoSize = true;
            this.bDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bDate_label.Location = new System.Drawing.Point(58, 190);
            this.bDate_label.Name = "bDate_label";
            this.bDate_label.Size = new System.Drawing.Size(81, 20);
            this.bDate_label.TabIndex = 41;
            this.bDate_label.Text = "Birth Date";
            // 
            // cname_label
            // 
            this.cname_label.AutoSize = true;
            this.cname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cname_label.Location = new System.Drawing.Point(58, 143);
            this.cname_label.Name = "cname_label";
            this.cname_label.Size = new System.Drawing.Size(95, 20);
            this.cname_label.TabIndex = 40;
            this.cname_label.Text = "Client Name";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(610, 259);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(95, 42);
            this.btn_exit.TabIndex = 51;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(695, 170);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(95, 42);
            this.btn_delete.TabIndex = 50;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Enabled = false;
            this.btn_update.Location = new System.Drawing.Point(529, 170);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(95, 42);
            this.btn_update.TabIndex = 49;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // cname_db
            // 
            this.cname_db.AutoSize = true;
            this.cname_db.BackColor = System.Drawing.SystemColors.Info;
            this.cname_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cname_db.Location = new System.Drawing.Point(237, 80);
            this.cname_db.MinimumSize = new System.Drawing.Size(150, 16);
            this.cname_db.Name = "cname_db";
            this.cname_db.Size = new System.Drawing.Size(150, 16);
            this.cname_db.TabIndex = 53;
            // 
            // cname_db_lb
            // 
            this.cname_db_lb.AutoSize = true;
            this.cname_db_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cname_db_lb.Location = new System.Drawing.Point(147, 80);
            this.cname_db_lb.Name = "cname_db_lb";
            this.cname_db_lb.Size = new System.Drawing.Size(84, 16);
            this.cname_db_lb.TabIndex = 52;
            this.cname_db_lb.Text = "Client Name:";
            // 
            // UpCustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 352);
            this.Controls.Add(this.cname_db);
            this.Controls.Add(this.cname_db_lb);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.opt_lb);
            this.Controls.Add(this.city_tb);
            this.Controls.Add(this.city_lb);
            this.Controls.Add(this.bDate_tp);
            this.Controls.Add(this.zip_tb);
            this.Controls.Add(this.cname_tb);
            this.Controls.Add(this.zip_label);
            this.Controls.Add(this.bDate_label);
            this.Controls.Add(this.cname_label);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.city_db);
            this.Controls.Add(this.city_db_lb);
            this.Controls.Add(this.bDate_db);
            this.Controls.Add(this.bDate_db_lb);
            this.Controls.Add(this.zip_db);
            this.Controls.Add(this.zip_db_lb);
            this.Controls.Add(this.cID_db);
            this.Controls.Add(this.cID_db_lb);
            this.Controls.Add(this.cID_tb);
            this.Controls.Add(this.cID_label);
            this.Name = "UpCustForm";
            this.Text = "UpCustForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Label city_db;
        private System.Windows.Forms.Label city_db_lb;
        private System.Windows.Forms.Label bDate_db;
        private System.Windows.Forms.Label bDate_db_lb;
        private System.Windows.Forms.Label zip_db;
        private System.Windows.Forms.Label zip_db_lb;
        private System.Windows.Forms.Label cID_db;
        private System.Windows.Forms.Label cID_db_lb;
        private System.Windows.Forms.TextBox cID_tb;
        private System.Windows.Forms.Label cID_label;
        private System.Windows.Forms.Label opt_lb;
        private System.Windows.Forms.TextBox city_tb;
        private System.Windows.Forms.Label city_lb;
        private System.Windows.Forms.DateTimePicker bDate_tp;
        private System.Windows.Forms.TextBox zip_tb;
        private System.Windows.Forms.TextBox cname_tb;
        private System.Windows.Forms.Label zip_label;
        private System.Windows.Forms.Label bDate_label;
        private System.Windows.Forms.Label cname_label;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label cname_db;
        private System.Windows.Forms.Label cname_db_lb;
    }
}