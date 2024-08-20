using System.Windows.Forms;

namespace stock_mgmt
{
    partial class loginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.label7 = new System.Windows.Forms.Label();
            this.route_to_register = new System.Windows.Forms.Label();
            this.password_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.username_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.fb_logo = new System.Windows.Forms.Label();
            this.google_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.RemMeChkBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.panel1.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.google_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(129, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Are you a new user ?";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // route_to_register
            // 
            this.route_to_register.AutoSize = true;
            this.route_to_register.BackColor = System.Drawing.Color.White;
            this.route_to_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.route_to_register.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.route_to_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(84)))), ((int)(((byte)(174)))));
            this.route_to_register.Location = new System.Drawing.Point(142, 500);
            this.route_to_register.Name = "route_to_register";
            this.route_to_register.Size = new System.Drawing.Size(112, 17);
            this.route_to_register.TabIndex = 27;
            this.route_to_register.Text = "Register Yourself";
            this.route_to_register.Click += new System.EventHandler(this.label5_Click);
            // 
            // password_input
            // 
            this.password_input.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.password_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_input.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_input.Location = new System.Drawing.Point(56, 239);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(303, 26);
            this.password_input.TabIndex = 24;
            this.password_input.UseSystemPasswordChar = true;
            this.password_input.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(51, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Enter Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button2.Location = new System.Drawing.Point(56, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(303, 45);
            this.button2.TabIndex = 22;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(56, 329);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(303, 47);
            this.login_btn.TabIndex = 21;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // username_input
            // 
            this.username_input.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.username_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_input.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_input.Location = new System.Drawing.Point(56, 149);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(303, 26);
            this.username_input.TabIndex = 19;
            this.username_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(51, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Enter Username";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(144)))));
            this.label1.Location = new System.Drawing.Point(111, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 50);
            this.label1.TabIndex = 17;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(98, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Application";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(321, 37);
            this.label5.TabIndex = 3;
            this.label5.Text = "Inventory Management";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.guna2Panel4);
            this.panel1.Controls.Add(this.google_panel);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(415, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 550);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.guna2Panel4.BorderRadius = 10;
            this.guna2Panel4.BorderThickness = 2;
            this.guna2Panel4.Controls.Add(this.guna2Panel5);
            this.guna2Panel4.Controls.Add(this.fb_logo);
            this.guna2Panel4.Location = new System.Drawing.Point(197, 460);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(164, 45);
            this.guna2Panel4.TabIndex = 9;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel5.BackgroundImage")));
            this.guna2Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel5.BorderColor = System.Drawing.Color.Orange;
            this.guna2Panel5.BorderRadius = 10;
            this.guna2Panel5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2Panel5.Location = new System.Drawing.Point(9, 10);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(40, 27);
            this.guna2Panel5.TabIndex = 9;
            // 
            // fb_logo
            // 
            this.fb_logo.AutoSize = true;
            this.fb_logo.BackColor = System.Drawing.Color.Transparent;
            this.fb_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fb_logo.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fb_logo.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.fb_logo.Location = new System.Drawing.Point(53, 6);
            this.fb_logo.Name = "fb_logo";
            this.fb_logo.Size = new System.Drawing.Size(106, 30);
            this.fb_logo.TabIndex = 0;
            this.fb_logo.Text = "Facebook";
            this.fb_logo.Click += new System.EventHandler(this.fb_logo_Click);
            // 
            // google_panel
            // 
            this.google_panel.BorderColor = System.Drawing.Color.Orange;
            this.google_panel.BorderRadius = 10;
            this.google_panel.BorderThickness = 2;
            this.google_panel.Controls.Add(this.guna2Panel3);
            this.google_panel.Controls.Add(this.label6);
            this.google_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.google_panel.Location = new System.Drawing.Point(14, 460);
            this.google_panel.Name = "google_panel";
            this.google_panel.Size = new System.Drawing.Size(165, 45);
            this.google_panel.TabIndex = 8;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel3.BackgroundImage")));
            this.guna2Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Orange;
            this.guna2Panel3.BorderRadius = 10;
            this.guna2Panel3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2Panel3.Location = new System.Drawing.Point(12, 10);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(40, 27);
            this.guna2Panel3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(63, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Google";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel1.Location = new System.Drawing.Point(28, 142);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(314, 262);
            this.guna2Panel1.TabIndex = 5;
            // 
            // RemMeChkBox
            // 
            this.RemMeChkBox.AutoSize = true;
            this.RemMeChkBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RemMeChkBox.CheckedState.BorderRadius = 0;
            this.RemMeChkBox.CheckedState.BorderThickness = 0;
            this.RemMeChkBox.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RemMeChkBox.CheckMarkColor = System.Drawing.Color.RoyalBlue;
            this.RemMeChkBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.RemMeChkBox.ForeColor = System.Drawing.Color.Black;
            this.RemMeChkBox.Location = new System.Drawing.Point(56, 289);
            this.RemMeChkBox.Name = "RemMeChkBox";
            this.RemMeChkBox.Size = new System.Drawing.Size(114, 21);
            this.RemMeChkBox.TabIndex = 31;
            this.RemMeChkBox.Text = "Remember Me";
            this.RemMeChkBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RemMeChkBox.UncheckedState.BorderRadius = 0;
            this.RemMeChkBox.UncheckedState.BorderThickness = 0;
            this.RemMeChkBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RemMeChkBox.CheckedChanged += new System.EventHandler(this.RemMeChkBox_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox1.CheckedState.BorderRadius = 0;
            this.checkBox1.CheckedState.BorderThickness = 0;
            this.checkBox1.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkBox1.CheckMarkColor = System.Drawing.Color.RoyalBlue;
            this.checkBox1.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(245, 289);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 21);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBox1.UncheckedState.BorderRadius = 0;
            this.checkBox1.UncheckedState.BorderThickness = 0;
            this.checkBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.RemMeChkBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.route_to_register);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.username_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginForm";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.google_panel.ResumeLayout(false);
            this.google_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label route_to_register;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox username_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel google_panel;
        private Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Label fb_logo;
        private Guna.UI2.WinForms.Guna2CheckBox RemMeChkBox;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox1;
    }
}