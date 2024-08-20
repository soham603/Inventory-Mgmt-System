using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace stock_mgmt
{
    internal class CommonMethods
    {
        private readonly string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=Stock_Mgmt_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;MultiSubnetFailover=False";

        public void ExecuteSqlQuery(string query)
        {
            using (SqlConnection sc = new SqlConnection(connectionString))
            {
                try
                {
                    sc.Open();
                    using (SqlCommand cmd = new SqlCommand(query, sc))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void loadDataSelectnBox(string query, Guna2ComboBox comboBox)
        {
            comboBox.Items.Clear();

            using (SqlConnection sc = new SqlConnection(connectionString))
            {
                try
                {
                    sc.Open();
                    using (SqlCommand cmd = new SqlCommand(query, sc))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                comboBox.Items.Add(dr[0].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void RetrieveDataForUpdate(string query, Control control, int columnIndex, string parameterValue)
        {
            using (SqlConnection sc = new SqlConnection(connectionString))
            {
                try
                {
                    sc.Open();
                    using (SqlCommand cmd = new SqlCommand(query, sc))
                    {
                        // Add parameter to command
                        cmd.Parameters.AddWithValue("@proname", parameterValue);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                if (control is Guna2TextBox gunaTextBox)
                                {
                                    gunaTextBox.Text = dr[columnIndex].ToString();
                                }
                                else if (control is TextBox textBox)
                                {
                                    textBox.Text = dr[columnIndex].ToString();
                                }
                            }
                            else
                            {
                                MessageBox.Show("No data found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void ExecuteSqlQuery2(string query, SqlParameter[] parameters)
        {
            using (SqlConnection sc = new SqlConnection(connectionString))
            {
                try
                {
                    sc.Open();
                    using (SqlCommand cmd = new SqlCommand(query, sc))
                    {
                        cmd.Parameters.AddRange(parameters);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public string getStringFromQuery(string query)
        {
            string result = string.Empty;

            using (SqlConnection sc = new SqlConnection(connectionString))
            {
                try
                {
                    sc.Open(); // Open the connection before executing the command

                    using (SqlCommand cmd = new SqlCommand(query, sc))
                    {
                        object queryResult = cmd.ExecuteScalar();

                        if (queryResult != null)
                        {
                            result = queryResult.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Stck " + ex.Message);
                }
            }

            return result;
        }

        public void loadDataGrid(string str, DataGridView dgv)
        {
            using (SqlConnection sc = new SqlConnection(connectionString))
            {
                try
                {
                    if (sc.State == ConnectionState.Open)
                        sc.Close();
                    sc.Open();

                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(str, sc);
                    sda.Fill(dt);
                    dgv.DataSource = dt;

                    sc.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



    }
}
