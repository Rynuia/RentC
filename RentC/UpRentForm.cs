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
    public partial class UpRentForm : Form
    {

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\rentc_db.mdf;Integrated Security = True; Connect Timeout = 30; User Instance = False"; //Connection String

        public UpRentForm()
        {
            InitializeComponent();
        }

        private void UpRentForm_Load(object sender, EventArgs e)
        {


        }

        private void btn_select_Click(object sender, EventArgs e)  //Select button
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);

            int carID = 0;

            bool allgood = true;

            SqlDataReader dr;

            SqlCommand getcarID = new SqlCommand();
            SqlCommand getdata = new SqlCommand();

            string carIDquery = "SELECT CarID FROM Cars WHERE Plate=@Plate";
            string selquery = "SELECT * FROM Reservations WHERE CarID=@CarID";

            sqlCon.Open();

            getcarID.Connection = sqlCon;
            getcarID.CommandText = carIDquery;  //Get CarID from cars
            getcarID.Parameters.AddWithValue("@Plate", cPlate_tb.Text);
            dr = getcarID.ExecuteReader();
            if (dr.Read())  
            {
                if (dr.HasRows)
                {
                    carID_db.Text = dr["CarID"].ToString();
                    carID = Int32.Parse(carID_db.Text);
                }

                else
                {
                    MessageBox.Show("There are no cars registered with this plate.");
                    allgood = false;
                }
            }

            else
            {
                MessageBox.Show("There are no cars registered with this plate.");
                allgood = false;
            }
            dr.Close();

            if (allgood == true)
            {
                getdata.Connection = sqlCon;
                getdata.CommandText = selquery;  //Get entry data from Reservations
                getdata.Parameters.Add("@CarID", SqlDbType.Int).Value = carID;
                dr = getdata.ExecuteReader();
                if (dr.Read())  
                {
                    if (dr.HasRows)
                    {
                        cID_db.Text = dr["CostumerID"].ToString();
                        city_db.Text = dr["Location"].ToString();
                        cID_tb.Text = dr["CostumerID"].ToString();
                        start_tp.Text = dr["StartDate"].ToString();
                        end_tp.Text = dr["EndDate"].ToString();
                        city_tb.Text = dr["Location"].ToString();
                        sDate_db.Text = start_tp.Value.ToShortDateString();
                        eDate_db.Text = end_tp.Value.ToShortDateString();
                    }

                    else
                    {
                        carID_db.Text = String.Empty;
                        MessageBox.Show("There are no reservations registered.");
                        allgood = false;
                    }
                }
                else
                {
                    carID_db.Text = String.Empty;
                    MessageBox.Show("There are no reservations registered for this car.");
                    allgood = false;
                }
                dr.Close();
            }
            sqlCon.Close();

            if (allgood == true)
            {
                cPlate_new_tb.Text = cPlate_tb.Text;
                cPlate_new_tb.Enabled = true;
                cID_tb.Enabled = true;
                start_tp.Enabled = true;
                end_tp.Enabled = true;
                city_tb.Enabled = true;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }
            else
            {
                cPlate_new_tb.Text = String.Empty;
                cID_tb.Text = String.Empty;
                start_tp.Text = String.Empty;
                end_tp.Text = String.Empty;
                city_tb.Text = String.Empty;
                cID_db.Text = String.Empty;
                sDate_db.Text = String.Empty;
                eDate_db.Text = String.Empty;
                city_db.Text = String.Empty;
                cPlate_new_tb.Enabled = false;
                cID_tb.Enabled = false;
                start_tp.Enabled = false;
                end_tp.Enabled = false;
                city_tb.Enabled = false;
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
            }


        }

        private void btn_update_Click(object sender, EventArgs e)  //Update button
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);

            bool allgood = true; //Flag for checking if there are any problems with the operation
            bool platepass;  //Flag for checking if plate exists in Cars
            bool cIDpass;  //Flag for checking if customer ID is valid
            bool citypass;  //Flag for checking if the selected car is available in the entered city
            bool datepass;  //Flag for checking if entered date data is correct
            bool pepass;  //Flag for checking if the plate field is empty
            bool cIDepass;  //Flag for checking if the customer ID field is empty
            bool cepass;  //Flag for checking if the city field is empty

            SqlDataReader dr;

            SqlCommand checkModel = new SqlCommand();
            SqlCommand checkCar = new SqlCommand();
            SqlCommand checkcID = new SqlCommand();
            SqlCommand checkcCity = new SqlCommand();
            SqlCommand getcarID = new SqlCommand();
           
            sqlCon.Open();

            checkModel.Connection = sqlCon;
            checkModel.CommandText = "SELECT * FROM Cars where Plate=@Plate";  //Validation for car plate
            checkModel.Parameters.AddWithValue("@Plate", cPlate_tb.Text);
            dr = checkModel.ExecuteReader();
            if (dr.Read()) platepass = true;
            else
            {
                allgood = false;
                platepass = false;
            }
            dr.Close();

            checkcID.Connection = sqlCon;
            checkcID.CommandText = "SELECT * FROM Customers where CostumerID=@CostumerID";  //Validation for customer ID
            checkcID.Parameters.AddWithValue("@CostumerID", Convert.ToInt32(cID_tb.Text));
            dr = checkcID.ExecuteReader();
            if (dr.Read()) cIDpass = true;
            else
            {
                allgood = false;
                cIDpass = false;
            }
            dr.Close();

            checkcCity.Connection = sqlCon;
            checkcCity.CommandText = "SELECT * FROM Cars where Location=@Location and Plate=@Plate";  //Validation for car availability in the city
            checkcCity.Parameters.AddWithValue("@Location", city_tb.Text);
            checkcCity.Parameters.AddWithValue("@Plate", cPlate_new_tb.Text);
            dr = checkcCity.ExecuteReader();
            if (dr.Read()) citypass = true;
            else
            {
                allgood = false;
                citypass = false;
            }
            dr.Close();

            int year = end_tp.Value.Year - start_tp.Value.Year;
            int month = end_tp.Value.Month - start_tp.Value.Month;
            int day = end_tp.Value.Day - start_tp.Value.Day;

            if (year < 0 || year == 0 && month < 0 || year == 0 && month == 0 && day < 0)  //Date validation
            {
                allgood = false;
                datepass = false;
            }
            else datepass = true;

            sqlCon.Close();

            if (cPlate_new_tb.Text.Length == 0)  //Check plate field
            {
                pepass = false;
                allgood = false;
            }
            else pepass = true;

            if (cID_tb.Text.Length == 0)  //Check customer ID field
            {
                cIDepass = false;
                allgood = false;
            }
            else cIDepass = true;

            if (city_tb.Text.Length == 0)  //Check city field
            {
                cepass = false;
                allgood = false;
            }
            else cepass = true;

            if (allgood == false)
            {
                string plateerr;
                string cIDerr;
                string cityerr;
                string dateerr;
                string peerr;
                string cIDeerr;
                string ceerr;
                string errmsg = "";
                string nl = Environment.NewLine;

                if (platepass == false) plateerr = "There are no cars with this plate. Check the Car Plate field again. " + nl;
                else plateerr = "";


                if (cIDpass == false) cIDerr = "Client ID doesn't exists. Check the Client ID field again." + nl;
                else cIDerr = "";

                if (citypass == false)
                {
                    if (platepass == false) cityerr = "";
                    else cityerr = "The selected car is not available in the entered city." + nl;
                }
                else cityerr = "";

                if (datepass == false) dateerr = "End Date should be equal or bigger than the Start Date." + nl;
                else dateerr = "";

                if (pepass == false)
                {
                    cityerr = "";
                    peerr = "The Plate field can not be empty." + nl;
                }
                else peerr = "";

                if (cIDepass == false)
                {
                    cIDerr = "";
                    cIDeerr = "The Client ID field can not be empty." + nl;
                }
                else cIDeerr = "";

                if (cepass == false)
                {
                    cityerr = "";
                    ceerr = "The City field can not be empty." + nl;
                }
                else ceerr = "";



                errmsg = "The following errors have been encountered and should be resolved:" + nl + nl + peerr + cIDeerr + ceerr + plateerr + cIDerr + cityerr + dateerr;
                MessageBox.Show(errmsg, "Error");
            }

            else if (allgood == true)
            {
                sqlCon.Open();

                getcarID.Connection = sqlCon;
                getcarID.CommandText = "SELECT CarID FROM Cars WHERE Plate=@Plate";  //Get carID from Cars table using Plate
                getcarID.Parameters.AddWithValue("@Plate", cPlate_new_tb.Text);
                int carID = (int)getcarID.ExecuteScalar();

                String query = "UPDATE Reservations SET CarID = @CarID, CostumerID = @CostumerID, StartDate = @StartDate, EndDate = @EndDate, Location = @Location, Plate = @Plate WHERE CarID = @oCarID";

                using (SqlCommand doUpdate = new SqlCommand(query, sqlCon))
                {
                    doUpdate.Parameters.Add("@CarID", SqlDbType.Int).Value = carID;
                    doUpdate.Parameters.AddWithValue("@CostumerID", Convert.ToInt32(cID_tb.Text));
                    doUpdate.Parameters.Add("@StartDate", SqlDbType.Date).Value = start_tp.Value.Date;
                    doUpdate.Parameters.Add("@EndDate", SqlDbType.Date).Value = end_tp.Value.Date;
                    doUpdate.Parameters.AddWithValue("@Location", city_tb.Text);
                    doUpdate.Parameters.AddWithValue("@oCarID", Convert.ToInt32(carID_db.Text));
                    doUpdate.Parameters.AddWithValue("@Plate", cPlate_new_tb.Text);

                    int i = doUpdate.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show("Successfully updated the registration record");  //Operation successful

                        carID_db.Text = carID.ToString();
                        cID_db.Text = cID_tb.Text;
                        city_db.Text = city_tb.Text;
                        sDate_db.Text = start_tp.Value.ToShortDateString();
                        eDate_db.Text = end_tp.Value.ToShortDateString();

                    }

                    else MessageBox.Show("Error updating the registration record", "Error");  //Operation failed

                    sqlCon.Close();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)  //Delete button
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this reservation record?", "Warning", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection sqlCon = new SqlConnection(connectionString);


                String query = "DELETE FROM Reservations WHERE CarID = @CarID";

                using (SqlCommand doDelete = new SqlCommand(query, sqlCon))
                {
                    doDelete.Parameters.AddWithValue("@CarID", Convert.ToInt32(carID_db.Text));

                    sqlCon.Open();

                    int i = doDelete.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show("Successfully deleted the registration record");  //Operation successful

                        carID_db.Text = String.Empty;
                        cPlate_new_tb.Text = String.Empty;
                        cID_tb.Text = String.Empty;
                        start_tp.Text = String.Empty;
                        end_tp.Text = String.Empty;
                        city_tb.Text = String.Empty;
                        cID_db.Text = String.Empty;
                        sDate_db.Text = String.Empty;
                        eDate_db.Text = String.Empty;
                        city_db.Text = String.Empty;
                        cPlate_new_tb.Enabled = false;
                        cID_tb.Enabled = false;
                        start_tp.Enabled = false;
                        end_tp.Enabled = false;
                        city_tb.Enabled = false;
                        btn_update.Enabled = false;
                        btn_delete.Enabled = false;

                    }

                    else MessageBox.Show("Error deleting the registration record", "Error");  //Operation failed

                    sqlCon.Close();
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)  //Exit button
        {
            this.Close();
        }

        private void cID_tb_KeyPress(object sender, KeyPressEventArgs e)  //Restricts input so that only numbers can be entered to Customer ID field
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
    }
}
