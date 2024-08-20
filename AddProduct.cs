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
    public partial class AddProduct : Form
    {
        CommonMethods cm = new CommonMethods();

        public AddProduct()
        {
            InitializeComponent();
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void clear()
        {
            addCategoryTb.Text = "";
            addProductTb.Text = "";
            addQuantityTb.Text = "";
            addSalesPTb.Text = "";
            addPurchasePTb.Text = "";
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Form gotoAddProduct = new HomePage();
            gotoAddProduct.Show();
            this.Hide();
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            Form gotoAddProduct = new UpdateProduct();
            gotoAddProduct.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
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

        private void addQuantityTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            if (addProductTb.Text != "" && addCategoryTb.Text != "" && addQuantityTb.Text != "" && addSalesPTb.Text != "" && addPurchasePTb.Text != "")
            {
                cm.ExecuteSqlQuery("insert into Products(proname,category,quantity,purchaseprice,salesprice) values('" + addProductTb.Text + "','" + addCategoryTb.Text + "','" + addQuantityTb.Text + "','" + addPurchasePTb.Text + "','" + addSalesPTb.Text + "')");
                MessageBox.Show("Product Added Successfuly");
                clear();
            }
            else
            {
                MessageBox.Show("Enter All Details");
            }
        }

        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            addProductTb.Text = "";
            addCategoryTb.Text = "";
            addQuantityTb.Text = "";
            addSalesPTb.Text = "";
            addPurchasePTb.Text = "";
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/soham603");
        }
    }
}
