using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace stock_mgmt
{
    public partial class UpdateProduct : Form
    {
        CommonMethods cm = new CommonMethods();

        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void loadDataFromProductsDbo(object sender, EventArgs e)
        {
            cm.loadDataSelectnBox("SELECT proname FROM Products", cmbProBox);
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {
            // Your custom painting code here
        }

        private void cmbProBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbProBox.Text))
            {
                string query = "SELECT proid, proname, category, quantity, purchaseprice, salesprice FROM Products WHERE proname = @proname";
                string selectedProduct = cmbProBox.Text;

                // Ensure the controls are not null
                if (addProductIdTb != null && addProductTb != null && addCategoryTb != null &&
                    addQuantityTb != null && addPurchasePTb != null && addSalesPTb != null)
                {
                    cm.RetrieveDataForUpdate(query, addProductIdTb, 0, selectedProduct);
                    cm.RetrieveDataForUpdate(query, addProductTb, 1, selectedProduct);
                    cm.RetrieveDataForUpdate(query, addCategoryTb, 2, selectedProduct);
                    cm.RetrieveDataForUpdate(query, addQuantityTb, 3, selectedProduct);
                    cm.RetrieveDataForUpdate(query, addPurchasePTb, 4, selectedProduct);
                    cm.RetrieveDataForUpdate(query, addSalesPTb, 5, selectedProduct);
                }
                else
                {
                    MessageBox.Show("One or more textboxes are not initialized.");
                }
            }
            else
            {
                MessageBox.Show("Select a Product");
            }
        }


        private void addProductTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void updateProBtn_Click(object sender, EventArgs e)
        {
            if (addProductIdTb.Text != "" &&
                addProductTb.Text != "" &&
                addCategoryTb.Text != "" &&
                addQuantityTb.Text != "" &&
                addPurchasePTb.Text != "" &&
                addSalesPTb.Text != "")
            {
                // Define the SQL query with parameters
                string query = "UPDATE Products SET proname = @proname, category = @category, quantity = @quantity, purchaseprice = @purchaseprice, salesprice = @salesprice WHERE proid = @proid";

                // Create parameters and assign values
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@proname", addProductTb.Text),
                    new SqlParameter("@category", addCategoryTb.Text),
                    new SqlParameter("@quantity", addQuantityTb.Text), // Directly use as string
                    new SqlParameter("@purchaseprice", addPurchasePTb.Text),
                    new SqlParameter("@salesprice", addSalesPTb.Text),
                    new SqlParameter("@proid", addProductIdTb.Text)
                };

                // Execute the query with parameters
                cm.ExecuteSqlQuery2(query, parameters);
                MessageBox.Show("Record Updated Successfully");
            }
            else
            {
                MessageBox.Show("Please fill all records");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(addProductIdTb.Text!="")
            {
                cm.ExecuteSqlQuery("delete from Products where proid = '" + addProductIdTb.Text + "'");
                cm.loadDataSelectnBox("SELECT proname FROM Products", cmbProBox);
                MessageBox.Show("Record Deleted Successfully");


            }
            else
            {
                MessageBox.Show("Please select a product to delete");
            }
        }

        public void guna2Button7_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            addProductIdTb.Text = "";
            addProductTb.Text = "";
            addCategoryTb.Text = "";
            addQuantityTb.Text = "";
            addPurchasePTb.Text = "";
            addSalesPTb.Text = "";
            cmbProBox.Text = "";
            cmbProBox.Items.Clear();
        }

        private void searchBoxPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form gotoAddProduct = new HomePage();
            gotoAddProduct.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form gotoAddProduct = new AddProduct();
            gotoAddProduct.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Form gotoAddProduct = new StockUpdate();
            gotoAddProduct.Show();
            this.Hide();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            Form gotoAddProduct = new loginForm();
            gotoAddProduct.Show();
            GlobalData.uname = null;
            this.Hide();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/soham603");
        }
    }
}
