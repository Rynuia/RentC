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
    public partial class ListCustForm : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\rentc_db.mdf;Integrated Security = True; Connect Timeout = 30; User Instance = False"; //Connection String

        public ListCustForm()
        {
            InitializeComponent();
        }

        private void ListCustForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                SqlCommand CheckRows = new SqlCommand();
                CheckRows.Connection = sqlCon;
                CheckRows.CommandText = "SELECT COUNT(*) FROM Customers";  //Check if the table is empty
                int rows = (int)CheckRows.ExecuteScalar();

                if (rows > 0)
                {

                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customers ORDER BY CostumerID ASC", sqlCon);  //Order by CostumerID ascending by default
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("There are no customers registered.", "Error");
                    btn_cID_sort.Enabled = false;
                    btn_cname_sort.Enabled = false;
                    btn_bDate_sort.Enabled = false;
                    btn_city_sort.Enabled = false;
                    btn_zip_sort.Enabled = false;
                    btn_cID_sort.Text = "Ascending";
                    cursort_lb.Text = "";
                    cs_lb.Text = "There are no registered customers.";
                }

                sqlCon.Close();
            }
        }

        private void btn_cID_sort_Click(object sender, EventArgs e)
        {
            if (btn_cID_sort.Text == "Ascending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customers ORDER BY CostumerID ASC", sqlCon);  //Order by CostumerID ascending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_cID_sort.Text = "Descending";
                btn_cname_sort.Text = "Ascending";
                btn_bDate_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                btn_zip_sort.Text = "Ascending";
                cs_lb.Text = "Client ID Ascending";
            }

            else if (btn_cID_sort.Text == "Descending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customers ORDER BY CostumerID DESC", sqlCon);  //Order by CostumerID descending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_cID_sort.Text = "Ascending";
                btn_cname_sort.Text = "Ascending";
                btn_bDate_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                btn_zip_sort.Text = "Ascending";
                cs_lb.Text = "Client ID Descending";
            }
        }

        private void btn_cname_sort_Click(object sender, EventArgs e)
        {
            if (btn_cname_sort.Text == "Ascending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customers ORDER BY Name ASC", sqlCon);  //Order by Name ascending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_cID_sort.Text = "Ascending";
                btn_cname_sort.Text = "Descending";
                btn_bDate_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                btn_zip_sort.Text = "Ascending";
                cs_lb.Text = "Client Name Ascending";
            }

            else if (btn_cname_sort.Text == "Descending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customers ORDER BY Name DESC", sqlCon);  //Order by Name descending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_cID_sort.Text = "Ascending";
                btn_cname_sort.Text = "Ascending";
                btn_bDate_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                btn_zip_sort.Text = "Ascending";
                cs_lb.Text = "Name Descending";
            }
        }

        private void btn_bDate_sort_Click(object sender, EventArgs e)
        {
            if (btn_bDate_sort.Text == "Ascending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customers ORDER BY BirthDate ASC", sqlCon);  //Order by BirthDate ascending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_cID_sort.Text = "Ascending";
                btn_cname_sort.Text = "Ascending";
                btn_bDate_sort.Text = "Descending";
                btn_city_sort.Text = "Ascending";
                btn_zip_sort.Text = "Ascending";
                cs_lb.Text = "Birth Date Ascending";
            }

            else if (btn_bDate_sort.Text == "Descending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customers ORDER BY BirthDate DESC", sqlCon);  //Order by BirthDate descending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_cID_sort.Text = "Ascending";
                btn_cname_sort.Text = "Ascending";
                btn_bDate_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                btn_zip_sort.Text = "Ascending";
                cs_lb.Text = "Birth Date Descending";
            }
        }

        private void btn_city_sort_Click(object sender, EventArgs e)
        {
            if (btn_city_sort.Text == "Ascending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customers ORDER BY Location ASC", sqlCon);  //Order by Location ascending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_cID_sort.Text = "Ascending";
                btn_cname_sort.Text = "Ascending";
                btn_bDate_sort.Text = "Ascending";
                btn_city_sort.Text = "Descending";
                btn_zip_sort.Text = "Ascending";
                cs_lb.Text = "City Ascending";
            }

            else if (btn_city_sort.Text == "Descending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customers ORDER BY Location DESC", sqlCon);  //Order by Location descending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_cID_sort.Text = "Ascending";
                btn_cname_sort.Text = "Ascending";
                btn_bDate_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                btn_zip_sort.Text = "Ascending";
                cs_lb.Text = "City Descending";
            }
        }

        private void btn_zip_sort_Click(object sender, EventArgs e)
        {
            if (btn_zip_sort.Text == "Ascending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customers ORDER BY Zip ASC", sqlCon);  //Order by Zip ascending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_cID_sort.Text = "Ascending";
                btn_cname_sort.Text = "Ascending";
                btn_bDate_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                btn_zip_sort.Text = "Descending";
                cs_lb.Text = "ZIP Code Ascending";
            }

            else if (btn_zip_sort.Text == "Descending")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customers ORDER BY Zip DESC", sqlCon);  //Order by Zip descending
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    sqlCon.Close();
                }

                btn_cID_sort.Text = "Ascending";
                btn_cname_sort.Text = "Ascending";
                btn_bDate_sort.Text = "Ascending";
                btn_city_sort.Text = "Ascending";
                btn_zip_sort.Text = "Ascending";
                cs_lb.Text = "ZIP Code Descending";
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
