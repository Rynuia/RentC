namespace RentC
{
    partial class RegCustForm
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
            this.bDate_tp = new System.Windows.Forms.DateTimePicker();
            this.zip_tb = new System.Windows.Forms.TextBox();
            this.cname_tb = new System.Windows.Forms.TextBox();
            this.zip_label = new System.Windows.Forms.Label();
            this.bDate_label = new System.Windows.Forms.Label();
            this.cname_label = new System.Windows.Forms.Label();
            this.city_tb = new System.Windows.Forms.TextBox();
            this.city_lb = new System.Windows.Forms.Label();
            this.opt_lb = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bDate_tp
            // 
            this.bDate_tp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bDate_tp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bDate_tp.Location = new System.Drawing.Point(165, 80);
            this.bDate_tp.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.bDate_tp.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.bDate_tp.Name = "bDate_tp";
            this.bDate_tp.Size = new System.Drawing.Size(153, 26);
            this.bDate_tp.TabIndex = 19;
            this.bDate_tp.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // zip_tb
            // 
            this.zip_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zip_tb.Location = new System.Drawing.Point(165, 170);
            this.zip_tb.MaxLength = 5;
            this.zip_tb.Name = "zip_tb";
            this.zip_tb.Size = new System.Drawing.Size(153, 26);
            this.zip_tb.TabIndex = 18;
            this.zip_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zip_tb_KeyPress);
            // 
            // cname_tb
            // 
            this.cname_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cname_tb.Location = new System.Drawing.Point(165, 35);
            this.cname_tb.MaxLength = 50;
            this.cname_tb.Name = "cname_tb";
            this.cname_tb.Size = new System.Drawing.Size(153, 26);
            this.cname_tb.TabIndex = 17;
            this.cname_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cname_tb_KeyPress);
            // 
            // zip_label
            // 
            this.zip_label.AutoSize = true;
            this.zip_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zip_label.Location = new System.Drawing.Point(38, 173);
            this.zip_label.Name = "zip_label";
            this.zip_label.Size = new System.Drawing.Size(76, 20);
            this.zip_label.TabIndex = 15;
            this.zip_label.Text = "ZIP Code";
            // 
            // bDate_label
            // 
            this.bDate_label.AutoSize = true;
            this.bDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bDate_label.Location = new System.Drawing.Point(38, 85);
            this.bDate_label.Name = "bDate_label";
            this.bDate_label.Size = new System.Drawing.Size(81, 20);
            this.bDate_label.TabIndex = 14;
            this.bDate_label.Text = "Birth Date";
            // 
            // cname_label
            // 
            this.cname_label.AutoSize = true;
            this.cname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cname_label.Location = new System.Drawing.Point(38, 38);
            this.cname_label.Name = "cname_label";
            this.cname_label.Size = new System.Drawing.Size(95, 20);
            this.cname_label.TabIndex = 13;
            this.cname_label.Text = "Client Name";
            // 
            // city_tb
            // 
            this.city_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.city_tb.Location = new System.Drawing.Point(165, 126);
            this.city_tb.MaxLength = 50;
            this.city_tb.Name = "city_tb";
            this.city_tb.Size = new System.Drawing.Size(153, 26);
            this.city_tb.TabIndex = 21;
            this.city_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.city_tb_KeyPress);
            // 
            // city_lb
            // 
            this.city_lb.AutoSize = true;
            this.city_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.city_lb.Location = new System.Drawing.Point(38, 129);
            this.city_lb.Name = "city_lb";
            this.city_lb.Size = new System.Drawing.Size(35, 20);
            this.city_lb.TabIndex = 20;
            this.city_lb.Text = "City";
            // 
            // opt_lb
            // 
            this.opt_lb.AutoSize = true;
            this.opt_lb.Location = new System.Drawing.Point(324, 178);
            this.opt_lb.Name = "opt_lb";
            this.opt_lb.Size = new System.Drawing.Size(52, 13);
            this.opt_lb.TabIndex = 22;
            this.opt_lb.Text = "(Optional)";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(244, 268);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(99, 43);
            this.btn_exit.TabIndex = 24;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(66, 268);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(99, 43);
            this.btn_confirm.TabIndex = 23;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // RegCustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 352);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.opt_lb);
            this.Controls.Add(this.city_tb);
            this.Controls.Add(this.city_lb);
            this.Controls.Add(this.bDate_tp);
            this.Controls.Add(this.zip_tb);
            this.Controls.Add(this.cname_tb);
            this.Controls.Add(this.zip_label);
            this.Controls.Add(this.bDate_label);
            this.Controls.Add(this.cname_label);
            this.Name = "RegCustForm";
            this.Text = "RegCustForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker bDate_tp;
        private System.Windows.Forms.TextBox zip_tb;
        private System.Windows.Forms.TextBox cname_tb;
        private System.Windows.Forms.Label zip_label;
        private System.Windows.Forms.Label bDate_label;
        private System.Windows.Forms.Label cname_label;
        private System.Windows.Forms.TextBox city_tb;
        private System.Windows.Forms.Label city_lb;
        private System.Windows.Forms.Label opt_lb;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_confirm;
    }
}