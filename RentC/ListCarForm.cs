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
    public partial class ListCarForm : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\rentc_db.mdf;Integrated Security = True; Connect Timeout = 30; User Instance = False"; //Connection String

        public ListCarForm()
        {
            InitializeComponent();
        }

        private void ListCarForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                SqlCommand CheckRows = new SqlCommand();
                CheckRows.Connection = sqlCon;
                CheckRows.CommandText = "SELECT COUNT(*) FROM Cars";  //Check if the table is empty
                int rows = (int)CheckRows.ExecuteScalar();

                if (rows > 0)
                {

                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cars ORDER BY CarID ASC", sqlCon);  //Order by CarID ascending by default
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("There are no cars registered.", "Error");
                    btn_carID_sort.Enabled = false;
                    btn_plate_sort.Enabled = false;
                    btn_manu_sort.Enabled = false;
                    btn_model_sort.Enabled = false;
                    btn_ppd_sort.Enabled = false;
                    btn_city_sort.Enabled = false;
                    btn_carID_sort.Text = "Ascending";
                    cursort_lb.Text = "";
                    cs_lb.Text = "There are no registered cars.";
                }

                sqlCon.Close();
            }
        }

        private void btn_carID_sort_Click(object sender, EventArgs e)
        {
            if (btn_carID_sort.Text == "Ascending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cars ORDER BY CarID ASC", sqlCon);  //Order by CarID ascending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                }

                btn_carID_sort.Text = "Descending";
                btn_plate_sort.Text = "Ascending";
                btn_manu_sort.Text = "Ascending";
                btn_model_sort.Text = "Ascending";
                btn_ppd_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "Car ID Ascending";
            }

            else if (btn_carID_sort.Text == "Descending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cars ORDER BY CarID DESC", sqlCon);  //Order by CarID descending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                }

                btn_carID_sort.Text = "Ascending";
                btn_plate_sort.Text = "Ascending";
                btn_manu_sort.Text = "Ascending";
                btn_model_sort.Text = "Ascending";
                btn_ppd_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "Car ID Descending";
            }
        }

        private void btn_plate_sort_Click(object sender, EventArgs e)
        {
            if (btn_plate_sort.Text == "Ascending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cars ORDER BY Plate ASC", sqlCon);  //Order by Plate ascending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                }

                btn_carID_sort.Text = "Ascending";
                btn_plate_sort.Text = "Descending";
                btn_manu_sort.Text = "Ascending";
                btn_model_sort.Text = "Ascending";
                btn_ppd_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "Plate Ascending";
            }

            else if (btn_plate_sort.Text == "Descending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cars ORDER BY Plate DESC", sqlCon);  //Order by Plate descending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                }

                btn_carID_sort.Text = "Ascending";
                btn_plate_sort.Text = "Ascending";
                btn_manu_sort.Text = "Ascending";
                btn_model_sort.Text = "Ascending";
                btn_ppd_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "Plate Descending";
            }
        }

        private void btn_manu_sort_Click(object sender, EventArgs e)
        {
            if (btn_manu_sort.Text == "Ascending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cars ORDER BY Manufacturer ASC", sqlCon);  //Order by Manufacturer ascending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                }

                btn_carID_sort.Text = "Ascending";
                btn_plate_sort.Text = "Ascending";
                btn_manu_sort.Text = "Descending";
                btn_model_sort.Text = "Ascending";
                btn_ppd_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "Manufacturer Ascending";
            }

            else if (btn_manu_sort.Text == "Descending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cars ORDER BY Manufacturer DESC", sqlCon);  //Order by Manufacturer descending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                }

                btn_carID_sort.Text = "Ascending";
                btn_plate_sort.Text = "Ascending";
                btn_manu_sort.Text = "Ascending";
                btn_model_sort.Text = "Ascending";
                btn_ppd_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "Manufacturer Descending";
            }
        }

        private void btn_model_sort_Click(object sender, EventArgs e)
        {
            if (btn_model_sort.Text == "Ascending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cars ORDER BY Model ASC", sqlCon);  //Order by Model ascending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                }

                btn_carID_sort.Text = "Ascending";
                btn_plate_sort.Text = "Ascending";
                btn_manu_sort.Text = "Ascending";
                btn_model_sort.Text = "Descending";
                btn_ppd_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "Model Ascending";
            }

            else if (btn_model_sort.Text == "Descending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cars ORDER BY Model DESC", sqlCon);  //Order by Model descending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                }

                btn_carID_sort.Text = "Ascending";
                btn_plate_sort.Text = "Ascending";
                btn_manu_sort.Text = "Ascending";
                btn_model_sort.Text = "Ascending";
                btn_ppd_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "Model Descending";
            }
        }

        private void btn_ppd_sort_Click(object sender, EventArgs e)
        {
            if (btn_ppd_sort.Text == "Ascending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cars ORDER BY PricePerDay ASC", sqlCon);  //Order by PricePerDay ascending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                }

                btn_carID_sort.Text = "Ascending";
                btn_plate_sort.Text = "Ascending";
                btn_manu_sort.Text = "Ascending";
                btn_model_sort.Text = "Ascending";
                btn_ppd_sort.Text = "Descending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "Price Per Day Ascending";
            }

            else if (btn_ppd_sort.Text == "Descending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cars ORDER BY PricePerDay DESC", sqlCon);  //Order by PricePerDay descending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                }

                btn_carID_sort.Text = "Ascending";
                btn_plate_sort.Text = "Ascending";
                btn_manu_sort.Text = "Ascending";
                btn_model_sort.Text = "Ascending";
                btn_ppd_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "PricePerDay Descending";
            }
        }

        private void btn_city_sort_Click(object sender, EventArgs e)
        {
            if (btn_city_sort.Text == "Ascending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cars ORDER BY Location ASC", sqlCon);  //Order by Location ascending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                }

                btn_carID_sort.Text = "Ascending";
                btn_plate_sort.Text = "Ascending";
                btn_manu_sort.Text = "Ascending";
                btn_model_sort.Text = "Ascending";
                btn_ppd_sort.Text = "Ascending";
                btn_city_sort.Text = "Descending";
                cs_lb.Text = "City Ascending";
            }

            else if (btn_city_sort.Text == "Descending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cars ORDER BY Location DESC", sqlCon);  //Order by Location descending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                }

                btn_carID_sort.Text = "Ascending";
                btn_plate_sort.Text = "Ascending";
                btn_manu_sort.Text = "Ascending";
                btn_model_sort.Text = "Ascending";
                btn_ppd_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                cs_lb.Text = "City Descending";
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
