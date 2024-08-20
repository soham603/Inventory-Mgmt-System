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
    public partial class HomePage : Form
    {
        CommonMethods cm = new CommonMethods();
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            load_allData();
        }

        public void load_allData()
        {
            cmbProBox.Items.Clear();
            cmbProBox.Text = "";
            cm.loadDataSelectnBox("select distinct category from Products", cmbProBox);
            loadGridData("SELECT p.proid,\r\n       p.proname AS [Pro Name],\r\n       p.category AS [Category],\r\n       p.quantity AS [Unit],\r\n       p.purchaseprice AS [Pur Price],\r\n       p.salesprice AS [Sales Price],\r\n       SUM(s.quantity) AS [Quantity]\r\nFROM Products p\r\nLEFT JOIN Stock s ON p.proid = s.proid\r\nGROUP BY p.proid, p.proname, p.category, p.quantity, p.purchaseprice, p.salesprice\r\n");
            cmbProBox2.Items.Clear();
            cmbProBox2.Text = "";
            cm.loadDataSelectnBox("select proname from Products", cmbProBox2);
            loadGridData2("select p.proname,s.quantity,s.txndate from Stock s LEFT JOIN Products p on s.proid = p.proid group by p.proname,s.quantity,s.txndate");

        }

        public void loadGridData(string str)
        {
            cm.loadDataGrid(str, productRepGV);
        }

        public void loadGridData2(string str)
        {
            cm.loadDataGrid(str, transReportGV);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form gotoAddProduct = new AddProduct();
            gotoAddProduct.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form gotoUpdateScreen = new UpdateProduct();
            gotoUpdateScreen.Show();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Form gotoUpdateScreen = new StockUpdate();
            gotoUpdateScreen.Show();
            this.Hide();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void productRepGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbProBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbProBox.Text != "")
            {
                loadGridData("SELECT p.proid,\r\n       p.proname AS [Pro Name],\r\n       p.category AS [Category],\r\n       p.quantity AS [Unit],\r\n       p.purchaseprice AS [Pur Price],\r\n       p.salesprice AS [Sales Price],\r\n       SUM(s.quantity) AS [Quantity]\r\nFROM Products p\r\nLEFT JOIN Stock s ON p.proid = s.proid\r\n where p.category ='"+cmbProBox.Text+"' GROUP BY p.proid, p.proname, p.category, p.quantity, p.purchaseprice, p.salesprice\r\n");
            }
        }

        private void cmbProBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProBox2.Text != "")
            {
                loadGridData2("select p.proname,s.quantity,s.txndate from Stock s LEFT JOIN Products p on s.proid = p.proid where proname = '" +cmbProBox2.Text+ "' group by p.proname,s.quantity,s.txndate");   
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/soham603");
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form gotoAddProduct = new loginForm();
            gotoAddProduct.Show();
            GlobalData.uname = null;
            this.Hide();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
