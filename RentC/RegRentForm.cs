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
    public partial class RegRentForm : Form
    {
        //SqlCommand statsID;
        //SqlCommand checkrows;

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\rentc_db.mdf;Integrated Security = True; Connect Timeout = 30; User Instance = False"; //Connection String

        public RegRentForm()
        {
            InitializeComponent();
            start_tp.Value = DateTime.Now; //Selects current date as default
            end_tp.Value = DateTime.Now;  //Selects current date as default
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);

            bool allgood = true; //Flag for checking if there are any problems with the operation
            bool platepass;  //Flag for checking if plate exists in Cars
            bool carpass;  //Flag for checking if the selected car is available
            bool cIDpass;  //Flag for checking if customer ID is valid
            bool citypass;  //Flag for checking if the selected car is available in the entered city
            bool datepass;  //Flag for checking if entered date data is correct

            SqlDataReader dr;

            SqlCommand checkModel = new SqlCommand();
            SqlCommand checkCar = new SqlCommand();
            SqlCommand checkcID = new SqlCommand();
            SqlCommand checkcCity = new SqlCommand();
            SqlCommand getcarID = new SqlCommand();
            //statsID = new SqlCommand();
            //checkrows = new SqlCommand();

            sqlCon.Open();

            checkModel.Connection = sqlCon;
            checkModel.CommandText = "SELECT * FROM Cars where Plate='" + cPlate_tb.Text + "'";  //Validation for car plate
            dr = checkModel.ExecuteReader();
            if (dr.Read()) platepass = true;
            else
            {
                allgood = false;
                platepass = false;
            }
            dr.Close();

            checkCar.Connection = sqlCon;
            checkCar.CommandText = "SELECT * FROM Reservations where CarID IN (SELECT CarID FROM Cars WHERE Plate='" + cPlate_tb.Text + "')";  //Validation for car availability
            dr = checkCar.ExecuteReader();
            if (dr.Read())
            {
                allgood = false;
                carpass = false;
            }
            else carpass = true;
            dr.Close();

            checkcID.Connection = sqlCon;
            checkcID.CommandText = "SELECT * FROM Customers where CostumerID='" + cID_tb.Text + "'";  //Validation for customer ID
            dr = checkcID.ExecuteReader();
            if (dr.Read()) cIDpass = true;
            else
            {
                allgood = false;
                cIDpass = false;
            }
            dr.Close();

            checkcCity.Connection = sqlCon;
            checkcCity.CommandText = "SELECT * FROM Cars where Location='" + city_tb.Text + "' and Plate='" + cPlate_tb.Text + "'";  //Validation for car availability in the city
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
            
            getcarID.Connection = sqlCon;
            getcarID.CommandText = "SELECT CarID FROM Cars WHERE Plate='" + cPlate_tb.Text + "'";  //Get carID from Cars table using Plate
            int carID = (int)getcarID.ExecuteScalar();

            //checkrows.Connection = sqlCon;
            //checkrows.CommandText = "SELECT COUNT(*) FROM Reservations";
            //int rows = (int)checkrows.ExecuteScalar();
            //if (rows > 0) isNull = false;
            //else isNull = true;

            //int StatsID;

            //if (isNull == false)
            //{
            //    statsID.Connection = sqlCon;
            //    statsID.CommandText = "SELECT MAX(ReservStatsID) FROM Reservations";
            //    StatsID = (int)statsID.ExecuteScalar();
            //}
            //else
            //{
            //    StatsID = 1;
            //}

            sqlCon.Close();

            String plateerr;
            String carerr;
            String cIDerr;
            String cityerr;
            String dateerr;
            String errmsg = "";
            String nl = Environment.NewLine;

            if (platepass == false) plateerr = "Invalid Car plate doesn't exists. Check the Car Plate field again. " + nl;
            else plateerr = "";

            if (carpass == false)
            {
                if (platepass == false) carerr = "";
                else carerr = "The selected car is already reserved." + nl;
            }
            else carerr = "";

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

            if (allgood == false)
            {
                errmsg = "The following errors have been encountered and should be resolved:" + nl + nl + plateerr + carerr + cIDerr + cityerr + dateerr;
                MessageBox.Show(errmsg, "Error");
            }

            else if (allgood == true)
            {
                //SqlCommand doRegister = new SqlCommand();

                //String query = "INSERT INTO Reservations(CarID, CostumerID, ReservStatsID, StartDate, EndDate, Location) VALUES (@CarID, @CostumerID, @ReservStatsID, @StartDate, @EndDate, @Location)";
                String query = "INSERT INTO Reservations(CarID, CostumerID, StartDate, EndDate, Location)VALUES(@CarID, @CostumerID, @StartDate, @EndDate, @Location)";

                using (SqlCommand doRegister = new SqlCommand(query, sqlCon))
                {
                    //doRegister.CommandText = ("INSERT INTO Reservations(CarID, CostumerID, ReservStatsID, StartDate, EndDate, Location) VALUES (@CarID, @CostumerID, @ReservStatsID, @StartDate, @EndDate, @Location)");
                    doRegister.Parameters.Add("@CarID", SqlDbType.Int).Value = carID;
                    doRegister.Parameters.AddWithValue("@CostumerID", Convert.ToInt32(cID_tb.Text));
                    //doRegister.Parameters.Add("@ReservStatsID", SqlDbType.TinyInt).Value = statsID;
                    doRegister.Parameters.Add("@StartDate", SqlDbType.Date).Value = start_tp.Value.Date;
                    doRegister.Parameters.Add("@EndDate", SqlDbType.Date).Value = end_tp.Value.Date;
                    doRegister.Parameters.AddWithValue("@Location", city_tb.Text);

                    sqlCon.Open();

                    int i = doRegister.ExecuteNonQuery();

                    if (i != 0) MessageBox.Show("Successfully saved the new registration entry");  //Operation successful
                    else MessageBox.Show("Error saving the registration");  //Operation failed

                    sqlCon.Close();
                }
            }
        }

        private void RegRentForm_Load(object sender, EventArgs e)
        {


        }

        private void cID_tb_KeyPress(object sender, KeyPressEventArgs e)  //Restricts input so that only numbers can be entered to Customer ID field
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)  //Exit button
        {
            this.Close();
        }
    }
}
