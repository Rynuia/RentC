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
    public partial class UpCustForm : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\rentc_db.mdf;Integrated Security = True; Connect Timeout = 30; User Instance = False"; //Connection String

        public UpCustForm()
        {
            InitializeComponent();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);


            bool allgood = true;

            SqlDataReader dr;

            SqlCommand getdata = new SqlCommand();

            int cID = Int32.Parse(cID_tb.Text);

            string selquery = "SELECT * FROM Customers WHERE CostumerID=@CostumerID";

            sqlCon.Open();

            getdata.Connection = sqlCon;
            getdata.CommandText = selquery;  //Get entry data from Customers
            getdata.Parameters.Add("@CostumerID", SqlDbType.Int).Value = cID;
            dr = getdata.ExecuteReader();
            if (dr.Read())  
            {
                if (dr.HasRows)
                {
                    cID_db.Text = dr["CostumerID"].ToString();
                    cname_db.Text = dr["Name"].ToString();
                    city_db.Text = dr["Location"].ToString();
                    zip_db.Text = dr["Zip"].ToString();
                    cname_tb.Text = dr["Name"].ToString();
                    bDate_tp.Text = dr["BirthDate"].ToString();
                    city_tb.Text = dr["Location"].ToString();
                    zip_tb.Text = dr["Zip"].ToString();
                    bDate_db.Text = bDate_tp.Value.ToShortDateString();
                }

                else
                {
                    MessageBox.Show("There are no customers registered with this ID.");
                    allgood = false;
                }
            }

            else
            {
                MessageBox.Show("There are no customers registered with this ID.");
                allgood = false;
            }
            dr.Close();

            sqlCon.Close();

            if (allgood == true)
            {
                cname_tb.Enabled = true;
                bDate_tp.Enabled = true;
                city_tb.Enabled = true;
                zip_tb.Enabled = true;
                btn_delete.Enabled = true;
                btn_update.Enabled = true;
            }
            else
            {
                cname_tb.Enabled = false;
                bDate_tp.Enabled = false;
                city_tb.Enabled = false;
                zip_tb.Enabled = false;
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
                cID_db.Text = "";
                cname_db.Text = "";
                city_db.Text = "";
                zip_db.Text = "";
                cname_tb.Text = "";
                bDate_tp.Text = "";
                city_tb.Text = "";
                zip_tb.Text = "";
                bDate_db.Text = "";
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
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

                int cid = Convert.ToInt32(cID_db.Text);

                String query = "UPDATE Customers SET Name = @Name, BirthDate = @BirthDate, Location = @Location, Zip = @Zip WHERE CostumerID = @CostumerID";

                using (SqlCommand doUpdate = new SqlCommand(query, sqlCon))
                { 
                    doUpdate.Parameters.AddWithValue("@Name", cname_tb.Text);
                    doUpdate.Parameters.Add("@BirthDate", SqlDbType.Date).Value = bDate_tp.Value.Date;
                    doUpdate.Parameters.AddWithValue("@Location", city_tb.Text);
                    doUpdate.Parameters.AddWithValue("@Zip", (object)zip ?? DBNull.Value);
                    doUpdate.Parameters.Add("@CostumerID", SqlDbType.Int).Value = cid;

                    sqlCon.Open();

                    int i = doUpdate.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show("Successfully updated the customer record");  //Operation successful
                        cID_db.Text = cid.ToString();
                        cname_db.Text = cname_tb.Text;
                        bDate_db.Text = bDate_tp.Value.ToShortDateString();
                        city_db.Text = city_tb.Text;
                        zip_db.Text = zip_tb.Text;
                    }
                    else MessageBox.Show("Error updating the customer record", "Error");  //Operation failed

                    sqlCon.Close();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer record?", "Warning", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection sqlCon = new SqlConnection(connectionString);


                String query = "DELETE FROM Customers WHERE CostumerID = @CostumerID";

                using (SqlCommand doDelete = new SqlCommand(query, sqlCon))
                {
                    doDelete.Parameters.AddWithValue("@CostumerID", Convert.ToInt32(cID_db.Text));

                    sqlCon.Open();

                    int i = doDelete.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show("Successfully deleted the customer record");  //Operation successful

                        cname_tb.Enabled = false;
                        bDate_tp.Enabled = false;
                        city_tb.Enabled = false;
                        zip_tb.Enabled = false;
                        btn_delete.Enabled = false;
                        btn_update.Enabled = false;
                        cID_db.Text = "";
                        cname_db.Text = "";
                        city_db.Text = "";
                        zip_db.Text = "";
                        cname_tb.Text = "";
                        bDate_tp.Text = "";
                        city_tb.Text = "";
                        zip_tb.Text = "";
                        bDate_db.Text = "";

                    }

                    else MessageBox.Show("Error deleting the customer record", "Error");  //Operation failed

                    sqlCon.Close();
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cID_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

        private void city_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void zip_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
