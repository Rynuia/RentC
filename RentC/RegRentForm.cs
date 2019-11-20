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

        SqlCommand checkModel;
        SqlCommand checkCar;
        SqlCommand checkcID;
        SqlCommand checkcCity;
        SqlCommand doRegister;
        SqlDataReader dr;

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\rentc_db.mdf;Integrated Security=True;Connect Timeout=30"; //Connection String

        public RegRentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                bool allgood = true; //Flag for checking if there are any problems with the operation
                bool platepass;  //Flag for checking if plate exists in Cars
                bool carpass;  //Flag for checking if the selected car is available
                bool cIDpass;  //Flag for checking if customer ID is valid
                bool citypass;  //Flag for checking if the selected car is available in the entered city
                bool datepass;  //Flag for checking if entered date data is correct

                string Plate = cPlate_tb.Text;
                string CostumerID = cID_tb.Text;
                string Location = city_tb.Text;

                DateTimePicker start_tp = new DateTimePicker();
                DateTimePicker end_tp = new DateTimePicker();

                checkModel = new SqlCommand();
                checkCar = new SqlCommand();
                checkcID = new SqlCommand();
                checkcCity = new SqlCommand();
                doRegister = new SqlCommand();

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

                checkCar.Connection = sqlCon;
                checkCar.CommandText = "SELECT * FROM Reservations where CarID IN (SELECT CarID FROM Cars WHERE Plate='" + cPlate_tb.Text + "'";  //Validation for car availability
                dr = checkCar.ExecuteReader();
                if (dr.Read())
                {
                    allgood = false;
                    carpass = false;
                }
                else carpass = true;

                checkcID.Connection = sqlCon;
                checkcID.CommandText = "SELECT * FROM Customers where CostumerID='" + cID_tb.Text + "'";  //Validation for customer ID
                dr = checkcID.ExecuteReader();
                if (dr.Read()) cIDpass = true;
                else
                {
                    allgood = false;
                    cIDpass = false;
                }

                checkcCity.Connection = sqlCon;
                checkcCity.CommandText = "SELECT * FROM Cars where Location='" + city_tb.Text + "' and Plate='" + cPlate_tb.Text + "'";  //Validation for car availability in the city
                dr = checkcCity.ExecuteReader();
                if (dr.Read()) citypass = true;
                else
                {
                    allgood = false;
                    citypass = false;
                }

                if (end_tp.Value >= start_tp.Value) datepass = true;
                else
                {
                    allgood = false;
                    datepass = false;
                }

                String plateerr;
                String carerr;
                String cIDerr;
                String cityerr;
                String dateerr;
                String errmsg = "";
                String nl = Environment.NewLine;

                if (platepass == false) plateerr = "Invalid Car Plate. Check the Car Plate field again. " + nl;
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
                    errmsg = "The following errors have been encountered and should be resolved:" + plateerr + carerr + cIDerr + cityerr + dateerr;
                    MessageBox.Show(errmsg, "Error");
                }

                else if (allgood == true)
                {
                    doRegister.Connection = sqlCon;

                    //AT HERE
                    //doRegister.CommandText = "INSERT INTO "

                    sqlCon.Close();

                }

                else MessageBox.Show("Unknown exception");
            }
        }

        private void RegRentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentc_dbDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.rentc_dbDataSet.Cars);

        }
    }
}
