using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_mgmt
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient; // Declare HttpClient as a private member

        public Form1()
        {
            InitializeComponent();
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:5167/") // Base address for API
            };
            register_btn.Click += register_btn_clicked; // Wire up the event
            route_to_login.Click += route_to_login_click;
            show_pass.Click += show_pass_clicked;
        }

        public void route_to_login_click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }

        public void show_pass_clicked(object sender, EventArgs e)
        {
            if(show_pass.Checked)
            {
                password_input.UseSystemPasswordChar = false;
            }
            else
            {
                password_input.UseSystemPasswordChar=true;
            }

        }
        public async void register_btn_clicked(object sender, EventArgs e)
        {
            var username = username_input.Text;
            var email = password_input.Text;
            var password = conf_pass_input.Text;

            // Define password criteria using regular expressions
            bool hasSpecialChar = Regex.IsMatch(password, @"[!@#$%^&*(),.?""':;{}|<>]");
            bool hasCapitalLetter = Regex.IsMatch(password, @"[A-Z]");
            bool hasNumber = Regex.IsMatch(password, @"[0-9]");

            // Check if password meets all criteria
            if (password != null && username != null && email != null)
            {
                if (!hasSpecialChar || !hasCapitalLetter || !hasNumber || password.Length<7)
                {
                    MessageBox.Show("Password must contain at least one special character, one capital letter, and one number and greater then 8 characters.", "Password Criteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    var registerDto = new RegisterDto
                    {
                        Username = username,
                        Email = email,
                        Password = password
                    };

                    var response = await _httpClient.PostAsJsonAsync("api/account/register", registerDto);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Registration successful!");
                        this.Hide();
                        Form toLogin = new loginForm();
                        toLogin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please fill out all required fields.");
            }
        }

        public class RegisterDto
        {
            public string Username { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label click event
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Handle text box text changed event
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Handle label click event
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Handle label click event
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Handle label click event
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void google_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clear_all_fields_Click(object sender, EventArgs e)
        {
            username_input.Text = "";
            password_input.Text = "";
            conf_pass_input.Text = "";
        }

        private void show_pass_CheckedChanged(object sender, EventArgs e)
        {
            conf_pass_input.UseSystemPasswordChar = !conf_pass_input.UseSystemPasswordChar;
        }
    }
}
