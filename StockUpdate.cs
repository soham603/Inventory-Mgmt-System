using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_mgmt
{
    public partial class StockUpdate : Form
    {
        CommonMethods cm = new CommonMethods();
        public StockUpdate()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProBox_SelectedIndexChange(object sender, EventArgs e)
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

                    string currentqty = cm.getStringFromQuery("SELECT SUM(quantity) FROM Stock WHERE proid = '" + addProductIdTb.Text + "'");

                    // Debugging
                    Console.WriteLine("Current Quantity Query: " + currentqty);

                    if (!string.IsNullOrEmpty(currentqty))
                    {
                        presentQuantityTb.Text = currentqty;
                    }
                    else
                    {
                        presentQuantityTb.Text = "0";
                    }
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

        private void loadStockUpdateScreen(object sender, EventArgs e)
        {
            cm.loadDataSelectnBox("SELECT proname FROM Products", cmbProBox);
        }

        private void addQuantityBtn_Click(object sender, EventArgs e)
        {
            if (presentQuantityTb.Text != "" && updateQuantityTb.Text !="")
            {
                MessageBox.Show("Success : New Quantity is : "+(int.Parse(presentQuantityTb.Text) + int.Parse(updateQuantityTb.Text)).ToString());
                upqty = int.Parse(updateQuantityTb.Text);
            }
            else
            {
                MessageBox.Show("Present Or Update Quantity Cannot be empty");
            }
        }

        private void minusQtBtn_Click(object sender, EventArgs e)
        {
            if (presentQuantityTb.Text != "" && updateQuantityTb.Text != "")
            {
                MessageBox.Show("Success : New Quantity is : " + (int.Parse(presentQuantityTb.Text) - int.Parse(updateQuantityTb.Text)).ToString());
                upqty = int.Parse(updateQuantityTb.Text) * (-1);
            }
            else
            {
                MessageBox.Show("Present Or Update Quantity Cannot be empty");
            }
        }

        int upqty = 0;

       
        public void clear()
        {
            addProductIdTb.Text = "";
            addProductTb.Text = "";
            addCategoryTb.Text = "";
            addQuantityTb.Text = "";
            addPurchasePTb.Text = "";
            addSalesPTb.Text = "";
            presentQuantityTb.Text = "";
            updateQuantityTb.Text = "";
            cmbProBox.Text = "";
            cmbProBox.Items.Clear();
        }
       

        private void updateQuantityBtn_Click(object sender, EventArgs e)
        {
            if (addProductIdTb.Text != "" && updateQuantityTb.Text != "")
            {
                string query = "INSERT INTO Stock (proid, quantity, txndate, username) VALUES ('"
                               + addProductIdTb.Text + "', "
                               + upqty + ", '"
                               + DateTime.Today.ToString("yyyy-MM-dd HH:mm:ss") + "', '"
                               + GlobalData.uname + "')";

                cm.ExecuteSqlQuery(query);
                MessageBox.Show("Stock Updated Successfully");
                clear();
            }
            else
            {
                MessageBox.Show("Select Proper Product/Quantity");
            }

        }

        private void addQuantityTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
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
            Form gotoAddProduct = new UpdateProduct();
            gotoAddProduct.Show();
            this.Hide();
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
