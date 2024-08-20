namespace stock_mgmt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Greetings_heading = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.username_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.show_pass = new System.Windows.Forms.CheckBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.clear_all_fields = new System.Windows.Forms.Button();
            this.password_input = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.conf_pass_input = new System.Windows.Forms.TextBox();
            this.route_to_login = new System.Windows.Forms.Label();
            this.already_acc_text = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.fb_logo = new System.Windows.Forms.Label();
            this.google_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.google_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Greetings_heading
            // 
            this.Greetings_heading.AutoSize = true;
            this.Greetings_heading.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Greetings_heading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(144)))));
            this.Greetings_heading.Location = new System.Drawing.Point(479, 17);
            this.Greetings_heading.Name = "Greetings_heading";
            this.Greetings_heading.Size = new System.Drawing.Size(219, 50);
            this.Greetings_heading.TabIndex = 0;
            this.Greetings_heading.Text = "Get Started";
            this.Greetings_heading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Greetings_heading.Click += new System.EventHandler(this.label1_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.BackColor = System.Drawing.Color.White;
            this.username_label.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.username_label.Location = new System.Drawing.Point(420, 92);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(153, 25);
            this.username_label.TabIndex = 2;
            this.username_label.Text = "Enter Username";
            // 
            // username_input
            // 
            this.username_input.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.username_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_input.Location = new System.Drawing.Point(424, 126);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(303, 22);
            this.username_input.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 5;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // show_pass
            // 
            this.show_pass.AutoSize = true;
            this.show_pass.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_pass.ForeColor = System.Drawing.Color.DimGray;
            this.show_pass.Location = new System.Drawing.Point(619, 318);
            this.show_pass.Name = "show_pass";
            this.show_pass.Size = new System.Drawing.Size(118, 21);
            this.show_pass.TabIndex = 7;
            this.show_pass.Text = "Show Password";
            this.show_pass.UseVisualStyleBackColor = true;
            this.show_pass.CheckedChanged += new System.EventHandler(this.show_pass_CheckedChanged);
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.register_btn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.ForeColor = System.Drawing.Color.White;
            this.register_btn.Location = new System.Drawing.Point(424, 354);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(303, 38);
            this.register_btn.TabIndex = 8;
            this.register_btn.Text = "REGISTER";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // clear_all_fields
            // 
            this.clear_all_fields.BackColor = System.Drawing.Color.White;
            this.clear_all_fields.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clear_all_fields.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_all_fields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.clear_all_fields.Location = new System.Drawing.Point(424, 407);
            this.clear_all_fields.Name = "clear_all_fields";
            this.clear_all_fields.Size = new System.Drawing.Size(303, 38);
            this.clear_all_fields.TabIndex = 9;
            this.clear_all_fields.Text = "CLEAR";
            this.clear_all_fields.UseVisualStyleBackColor = false;
            this.clear_all_fields.Click += new System.EventHandler(this.clear_all_fields_Click);
            // 
            // password_input
            // 
            this.password_input.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.password_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_input.Location = new System.Drawing.Point(424, 201);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(303, 22);
            this.password_input.TabIndex = 12;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.White;
            this.password_label.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.password_label.Location = new System.Drawing.Point(420, 165);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(111, 25);
            this.password_label.TabIndex = 11;
            this.password_label.Text = "Enter Email";
            this.password_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // conf_pass_input
            // 
            this.conf_pass_input.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.conf_pass_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conf_pass_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conf_pass_input.Location = new System.Drawing.Point(424, 274);
            this.conf_pass_input.Name = "conf_pass_input";
            this.conf_pass_input.Size = new System.Drawing.Size(303, 22);
            this.conf_pass_input.TabIndex = 14;
            this.conf_pass_input.UseSystemPasswordChar = true;
            // 
            // route_to_login
            // 
            this.route_to_login.AutoSize = true;
            this.route_to_login.BackColor = System.Drawing.Color.White;
            this.route_to_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.route_to_login.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.route_to_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(84)))), ((int)(((byte)(174)))));
            this.route_to_login.Location = new System.Drawing.Point(520, 505);
            this.route_to_login.Name = "route_to_login";
            this.route_to_login.Size = new System.Drawing.Size(97, 17);
            this.route_to_login.TabIndex = 15;
            this.route_to_login.Text = "Back to LOGIN";
            // 
            // already_acc_text
            // 
            this.already_acc_text.AutoSize = true;
            this.already_acc_text.BackColor = System.Drawing.Color.White;
            this.already_acc_text.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.already_acc_text.ForeColor = System.Drawing.Color.DimGray;
            this.already_acc_text.Location = new System.Drawing.Point(484, 475);
            this.already_acc_text.Name = "already_acc_text";
            this.already_acc_text.Size = new System.Drawing.Size(171, 20);
            this.already_acc_text.TabIndex = 16;
            this.already_acc_text.Text = "Already have an account";
            this.already_acc_text.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(84)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.guna2Panel4);
            this.panel1.Controls.Add(this.google_panel);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 550);
            this.panel1.TabIndex = 17;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.guna2Panel4.BorderRadius = 10;
            this.guna2Panel4.BorderThickness = 2;
            this.guna2Panel4.Controls.Add(this.guna2Panel5);
            this.guna2Panel4.Controls.Add(this.fb_logo);
            this.guna2Panel4.Location = new System.Drawing.Point(197, 457);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(164, 45);
            this.guna2Panel4.TabIndex = 14;
            this.guna2Panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel4_Paint);
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
            // 
            // google_panel
            // 
            this.google_panel.BorderColor = System.Drawing.Color.Orange;
            this.google_panel.BorderRadius = 10;
            this.google_panel.BorderThickness = 2;
            this.google_panel.Controls.Add(this.guna2Panel3);
            this.google_panel.Controls.Add(this.label6);
            this.google_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.google_panel.Location = new System.Drawing.Point(14, 457);
            this.google_panel.Name = "google_panel";
            this.google_panel.Size = new System.Drawing.Size(165, 45);
            this.google_panel.TabIndex = 13;
            this.google_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.google_panel_Paint);
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
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel1.Location = new System.Drawing.Point(28, 148);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(314, 262);
            this.guna2Panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Application";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(321, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "Inventory Management";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(419, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.already_acc_text);
            this.Controls.Add(this.route_to_login);
            this.Controls.Add(this.conf_pass_input);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.clear_all_fields);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.show_pass);
            this.Controls.Add(this.username_input);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.Greetings_heading);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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

        private System.Windows.Forms.Label Greetings_heading;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.TextBox username_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox show_pass;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Button clear_all_fields;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox conf_pass_input;
        private System.Windows.Forms.Label route_to_login;
        private System.Windows.Forms.Label already_acc_text;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label fb_logo;
        private Guna.UI2.WinForms.Guna2Panel google_panel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}

