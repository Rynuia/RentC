using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RentC
{
    public partial class RegCustForm : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\rentc_db.mdf;Integrated Security = True; Connect Timeout = 30; User Instance = False"; //Connection String

        public RegCustForm()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);

            bool allgood = true;  //Flag for checking if there are any problems with the operation
            bool datepass;  //Flag for checking if the customer is at least 18 years old
            bool zippass;  //Flag for checking if the ZIP code is in the correct format if entered
            bool birthpass = true;  //Flag for checking birthdate
            bool cnepass;  //Flag for checking if name textbox is empty
            bool cepass;  //Flag for checking if city textbox is empty

            int year = DateTime.Now.Year - bDate_tp.Value.Year;
            int month = DateTime.Now.Month - bDate_tp.Value.Month;
            int day = DateTime.Now.Day - bDate_tp.Value.Day;

            if (cname_tb.Text.Length == 0)  //Check name field
            {
                cnepass = false;
                allgood = false;
            }
            else cnepass = true;

            if (city_tb.Text.Length == 0)  //Check city field
            {
                cepass = false;
                allgood = false;
            }
            else cepass = true;

            if (year < 0 || year == 0 && month < 0 || year == 0 && month == 0 && day < 0)  //Check customer birthdate
            {
                birthpass = false;
                datepass = false;
                allgood = false;
            }

            else if (year < 18 || year == 18 && month < 0 || year == 18 && month == 0 && day < 0)  //Check if the customer is at least 18 years old
            {
                allgood = false;
                datepass = false;
            }
            else datepass = true;

            if (zip_tb.Text.Length == 5 || zip_tb.Text.Length == 0) zippass = true;  //Check the zip is in the correct format, if entered
            else
            {
                allgood = false;
                zippass = false;
            }

            if (allgood == false)
            {
                string dateerr;
                string ziperr;
                string bderr;
                string cneerr;
                string ceerr;
                string errmsg = "";

                String nl = Environment.NewLine;

                if (datepass == false) dateerr = "Client should be at least 18 years old." + nl;
                else dateerr = "";

                if (birthpass == false)
                {
                    dateerr = "";
                    bderr = "Entered birthdate is in the future. Please make sure if the client is born yet." + nl;
                }
                else bderr = "";

                if (zippass == false) ziperr = "Invalid ZIP format. A valid ZIP format is: XXXXX." + nl;
                else ziperr = "";

                if (cnepass == false) cneerr = "The Client Name field can not be empty." + nl;
                else cneerr = "";

                if (cepass == false) ceerr = "The City field can not be empty." + nl;
                else ceerr = "";

                errmsg = "The following errors have been encountered and should be resolved:" + nl + nl + cneerr + ceerr + dateerr + bderr + ziperr;
                MessageBox.Show(errmsg, "Error");
            }

            else if (allgood == true)
            {
                int? zip = string.IsNullOrEmpty(zip_tb.Text) ? (int?)null : Convert.ToInt32(zip_tb.Text);

                String query = "INSERT INTO Customers(Name, BirthDate, Location, Zip)VALUES(@Name, @BirthDate, @Location, @Zip)";

                using (SqlCommand doRegister = new SqlCommand(query, sqlCon))
                {
                    doRegister.Parameters.AddWithValue("@Name", cname_tb.Text);
                    doRegister.Parameters.Add("@BirthDate", SqlDbType.Date).Value = bDate_tp.Value.Date;
                    doRegister.Parameters.AddWithValue("@Location", city_tb.Text);
                    doRegister.Parameters.AddWithValue("@Zip", (object)zip ?? DBNull.Value);

                    sqlCon.Open();

                    int i = doRegister.ExecuteNonQuery();

                    if (i != 0) MessageBox.Show("Successfully saved the new customer record");  //Operation successful
                    else MessageBox.Show("Error saving the customer record", "Error");  //Operation failed

                    sqlCon.Close();
                }
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)  //Exit Button
        {
            this.Close();
        }

        private void zip_tb_KeyPress(object sender, KeyPressEventArgs e)  //Restricts input so that only numbers can be entered to ZIP Code field
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void city_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cname_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
