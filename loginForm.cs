using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Windows.Forms;

namespace stock_mgmt
{
    public partial class loginForm : Form
    {
        private readonly HttpClient _httpClient;
        public loginForm()
        {
            InitializeComponent();
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("http://localhost:5167/")
            };
            login_btn.Click += login_btn_clicked; // Wire up the event
            route_to_register.Click += route_to_register_clicked;

        }

        public void route_to_register_clicked(object sender, EventArgs e)
        {
            Form1 Form1= new Form1();
            Form1.Show();
            this.Hide();
        }

        public async void login_btn_clicked(object sender, EventArgs e)
        {
            var username = username_input.Text;
            var password = password_input.Text;

            var loginDto = new LoginDto
            {
                Username = username,
                Password = password,
            };

            if(username!=null && password!=null )
            {
                try
                {
                    var response = await _httpClient.PostAsJsonAsync("api/account/login", loginDto);
                    if (response.IsSuccessStatusCode)
                    {
                 
                        MessageBox.Show("Login successful!");
                        GlobalData.uname = username_input.Text;

                        if(RemMeChkBox.Checked == true)
                        {
                            // Save User locally if remember me is ticked : 
                            Properties.Settings.Default.Username = username_input.Text;
                            Properties.Settings.Default.Password = password_input.Text;
                            Properties.Settings.Default.SaveDate = DateTime.Now;
                            Properties.Settings.Default.Save();
                        }

                        this.Hide();
                        Form passway = new HomePage();
                        passway.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login failed.Incorrect username / password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Entering Both Fields is mandatory");
            }
        }

        public class LoginDto
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            username_input.Text = "";
            password_input.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //retrieve, and then check
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password_input.UseSystemPasswordChar = !password_input.UseSystemPasswordChar;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            // Check if the saved username is valid (not older than 2 days)
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Username))
            {
                DateTime savedDate = Properties.Settings.Default.SaveDate;
                if (DateTime.Now.Subtract(savedDate).TotalDays <= 2)
                {
                    username_input.Text = Properties.Settings.Default.Username;
                    password_input.Text = Properties.Settings.Default.Password;
                    RemMeChkBox.Checked = true;
                }
                else
                {
                    // Remove the saved username if it's older than 2 days
                    Properties.Settings.Default.Username = string.Empty;
                    Properties.Settings.Default.Password = string.Empty;
                    Properties.Settings.Default.SaveDate = DateTime.MinValue;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com");
        }

        private void fb_logo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com");
        }

        private void RemMeChkBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
