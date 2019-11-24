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
    public partial class ListRentForm : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\rentc_db.mdf;Integrated Security = True; Connect Timeout = 30; User Instance = False"; //Connection String

        public ListRentForm()
        {
            InitializeComponent();
        }

        private void ListRentForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                SqlCommand CheckRows = new SqlCommand();
                CheckRows.Connection = sqlCon;
                CheckRows.CommandText = "SELECT COUNT(*) FROM Reservations";  //Check if the table is empty
                int rows = (int)CheckRows.ExecuteScalar();

                if (rows > 0)
                {

                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Reservations ORDER BY ReservStatsID ASC", sqlCon);  //Order by ReservStatsID ascending by default
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("There are no rentals registered.", "Error");
                    btn_eno_sort.Enabled = false;
                    btn_plate_sort.Enabled = false;
                    btn_carID_sort.Enabled = false;
                    btn_cID_sort.Enabled = false;
                    btn_sdate_sort.Enabled = false;
                    btn_edate_sort.Enabled = false;
                    btn_city_sort.Enabled = false;
                    btn_eno_sort.Text = "Ascending";
                    cursort_lb.Text = "";
                    cs_lb.Text = "There are no active rentals.";
                }

                sqlCon.Close();
            }
        }

        private void btn_eno_sort_Click(object sender, EventArgs e)
        {
            if (btn_eno_sort.Text == "Ascending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Reservations ORDER BY ReservStatsID ASC", sqlCon);  //Order by ReservStatsID ascending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_eno_sort.Text = "Descending";
                btn_plate_sort.Text = "Ascending";
                btn_carID_sort.Text = "Ascending";
                btn_cID_sort.Text = "Ascending";
                btn_sdate_sort.Text = "Ascending";
                btn_edate_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "Entry No Ascending";
            }

            else if (btn_eno_sort.Text == "Descending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Reservations ORDER BY ReservStatsID DESC", sqlCon);  //Order by ReservStatsID descending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_eno_sort.Text = "Ascending";
                btn_plate_sort.Text = "Ascending";
                btn_carID_sort.Text = "Ascending";
                btn_cID_sort.Text = "Ascending";
                btn_sdate_sort.Text = "Ascending";
                btn_edate_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "Entry No Descending";
            }
        }

        private void btn_plate_sort_Click(object sender, EventArgs e)
        {
            if (btn_plate_sort.Text == "Ascending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Reservations ORDER BY Plate ASC", sqlCon);  //Order by Plate ascending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_eno_sort.Text = "Ascending";
                btn_plate_sort.Text = "Descending";
                btn_carID_sort.Text = "Ascending";
                btn_cID_sort.Text = "Ascending";
                btn_sdate_sort.Text = "Ascending";
                btn_edate_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "Plate Ascending";
            }

            else if (btn_plate_sort.Text == "Descending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Reservations ORDER BY Plate DESC", sqlCon);  //Order by Plate descending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_eno_sort.Text = "Ascending";
                btn_plate_sort.Text = "Ascending";
                btn_carID_sort.Text = "Ascending";
                btn_cID_sort.Text = "Ascending";
                btn_sdate_sort.Text = "Ascending";
                btn_edate_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "Plate Descending";
            }
        }

        private void btn_carID_sort_Click(object sender, EventArgs e)
        {
            if (btn_carID_sort.Text == "Ascending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Reservations ORDER BY CarID ASC", sqlCon);  //Order by CarID ascending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_eno_sort.Text = "Ascending";
                btn_plate_sort.Text = "Ascending";
                btn_carID_sort.Text = "Descending";
                btn_cID_sort.Text = "Ascending";
                btn_sdate_sort.Text = "Ascending";
                btn_edate_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "Car ID Ascending";
            }

            else if (btn_carID_sort.Text == "Descending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Reservations ORDER BY CarID DESC", sqlCon);  //Order by CarID descending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_eno_sort.Text = "Ascending";
                btn_plate_sort.Text = "Ascending";
                btn_carID_sort.Text = "Ascending";
                btn_cID_sort.Text = "Ascending";
                btn_sdate_sort.Text = "Ascending";
                btn_edate_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "Car ID Descending";
            }
        }

        private void btn_cID_sort_Click(object sender, EventArgs e)
        {
            if (btn_cID_sort.Text == "Ascending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Reservations ORDER BY CostumerID ASC", sqlCon);  //Order by CostumerID ascending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_eno_sort.Text = "Ascending";
                btn_plate_sort.Text = "Ascending";
                btn_carID_sort.Text = "Ascending";
                btn_cID_sort.Text = "Descending";
                btn_sdate_sort.Text = "Ascending";
                btn_edate_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "Customer ID Ascending";
            }

            else if (btn_cID_sort.Text == "Descending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Reservations ORDER BY CostumerID DESC", sqlCon);  //Order by CostumerID descending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_eno_sort.Text = "Ascending";
                btn_plate_sort.Text = "Ascending";
                btn_carID_sort.Text = "Ascending";
                btn_cID_sort.Text = "Ascending";
                btn_sdate_sort.Text = "Ascending";
                btn_edate_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "Customer ID Descending";
            }
        }

        private void btn_sdate_sort_Click(object sender, EventArgs e)
        {
            if (btn_sdate_sort.Text == "Ascending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Reservations ORDER BY StartDate ASC", sqlCon);  //Order by StartDate ascending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_eno_sort.Text = "Ascending";
                btn_plate_sort.Text = "Ascending";
                btn_carID_sort.Text = "Ascending";
                btn_cID_sort.Text = "Ascending";
                btn_sdate_sort.Text = "Descending";
                btn_edate_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "Start Date Ascending";
            }

            else if (btn_sdate_sort.Text == "Descending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Reservations ORDER BY StartDate DESC", sqlCon);  //Order by StartDate descending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_eno_sort.Text = "Ascending";
                btn_plate_sort.Text = "Ascending";
                btn_carID_sort.Text = "Ascending";
                btn_cID_sort.Text = "Ascending";
                btn_sdate_sort.Text = "Ascending";
                btn_edate_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "Start Date Descending";
            }
        }

        private void btn_edate_sort_Click(object sender, EventArgs e)
        {
            if (btn_edate_sort.Text == "Ascending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Reservations ORDER BY EndDate ASC", sqlCon);  //Order by EndDate ascending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_eno_sort.Text = "Ascending";
                btn_plate_sort.Text = "Ascending";
                btn_carID_sort.Text = "Ascending";
                btn_cID_sort.Text = "Ascending";
                btn_sdate_sort.Text = "Ascending";
                btn_edate_sort.Text = "Descending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "End Date Ascending";
            }

            else if (btn_edate_sort.Text == "Descending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Reservations ORDER BY EndDate DESC", sqlCon);  //Order by EndDate descending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_eno_sort.Text = "Ascending";
                btn_plate_sort.Text = "Ascending";
                btn_carID_sort.Text = "Ascending";
                btn_cID_sort.Text = "Ascending";
                btn_sdate_sort.Text = "Ascending";
                btn_edate_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "End Date Descending";
            }
        }

        private void btn_city_sort_Click(object sender, EventArgs e)
        {
            if (btn_city_sort.Text == "Ascending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Reservations ORDER BY Location ASC", sqlCon);  //Order by Location ascending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_eno_sort.Text = "Ascending";
                btn_plate_sort.Text = "Ascending";
                btn_carID_sort.Text = "Ascending";
                btn_cID_sort.Text = "Ascending";
                btn_sdate_sort.Text = "Ascending";
                btn_edate_sort.Text = "Ascending";
                btn_city_sort.Text = "Descending";
                cs_lb.Text = "City Ascending";
            }

            else if (btn_city_sort.Text == "Descending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Reservations ORDER BY Location DESC", sqlCon);  //Order by Location descending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_eno_sort.Text = "Ascending";
                btn_plate_sort.Text = "Ascending";
                btn_carID_sort.Text = "Ascending";
                btn_cID_sort.Text = "Ascending";
                btn_sdate_sort.Text = "Ascending";
                btn_edate_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "City Descending";
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();  //Exit form
        }
    }
}
