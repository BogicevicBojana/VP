namespace PresentationLayer.Forms
{
    partial class LoginForm
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_teamMember = new System.Windows.Forms.RadioButton();
            this.radioButton_manager = new System.Windows.Forms.RadioButton();
            this.radioButton_admin = new System.Windows.Forms.RadioButton();
            this.panel_top.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel_top.Controls.Add(this.label5);
            this.panel_top.Controls.Add(this.button4);
            this.panel_top.Controls.Add(this.button5);
            this.panel_top.Controls.Add(this.button2);
            this.panel_top.Controls.Add(this.button1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(490, 50);
            this.panel_top.TabIndex = 6;
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseDown);
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            this.panel_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseUp);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "AnyTask | Prijava";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::PresentationLayer.Properties.Resources.macos_minimize_24px;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(417, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 30);
            this.button4.TabIndex = 17;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::PresentationLayer.Properties.Resources.macos_close_24px;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(450, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 30);
            this.button5.TabIndex = 16;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(710, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 30);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(744, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 30);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.SlateBlue;
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(19, 501);
            this.button_login.Margin = new System.Windows.Forms.Padding(10);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(452, 42);
            this.button_login.TabIndex = 7;
            this.button_login.Text = "Prijavi Se";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_user
            // 
            this.textBox_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.textBox_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_user.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBox_user.Location = new System.Drawing.Point(10, 10);
            this.textBox_user.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(432, 19);
            this.textBox_user.TabIndex = 8;
            this.textBox_user.Text = "Unesi email";
            this.textBox_user.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_user_MouseClick);
            this.textBox_user.TabIndexChanged += new System.EventHandler(this.textBox_user_TabIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.textBox_user);
            this.panel1.Location = new System.Drawing.Point(19, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 40);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(17, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(17, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lozinka";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.textBox_password);
            this.panel2.Location = new System.Drawing.Point(19, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 40);
            this.panel2.TabIndex = 11;
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_password.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBox_password.Location = new System.Drawing.Point(10, 10);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '●';
            this.textBox_password.Size = new System.Drawing.Size(432, 19);
            this.textBox_password.TabIndex = 8;
            this.textBox_password.Text = "Unesi lozinku";
            this.textBox_password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_password_MouseClick);
            this.textBox_password.TabIndexChanged += new System.EventHandler(this.textBox_password_TabIndexChanged);
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(490, 48);
            this.label3.TabIndex = 13;
            this.label3.Text = "ANYTASK";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(17, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Uloga";
            // 
            // radioButton_teamMember
            // 
            this.radioButton_teamMember.AutoSize = true;
            this.radioButton_teamMember.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_teamMember.ForeColor = System.Drawing.Color.White;
            this.radioButton_teamMember.Location = new System.Drawing.Point(363, 428);
            this.radioButton_teamMember.Name = "radioButton_teamMember";
            this.radioButton_teamMember.Size = new System.Drawing.Size(96, 24);
            this.radioButton_teamMember.TabIndex = 2;
            this.radioButton_teamMember.TabStop = true;
            this.radioButton_teamMember.Text = "Član tima";
            this.radioButton_teamMember.UseVisualStyleBackColor = true;
            this.radioButton_teamMember.CheckedChanged += new System.EventHandler(this.radioButton_teamMember_CheckedChanged);
            // 
            // radioButton_manager
            // 
            this.radioButton_manager.AutoSize = true;
            this.radioButton_manager.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_manager.ForeColor = System.Drawing.Color.White;
            this.radioButton_manager.Location = new System.Drawing.Point(147, 428);
            this.radioButton_manager.Name = "radioButton_manager";
            this.radioButton_manager.Size = new System.Drawing.Size(167, 24);
            this.radioButton_manager.TabIndex = 1;
            this.radioButton_manager.TabStop = true;
            this.radioButton_manager.Text = "Menadžer projekta";
            this.radioButton_manager.UseVisualStyleBackColor = true;
            this.radioButton_manager.CheckedChanged += new System.EventHandler(this.radioButton_manager_CheckedChanged);
            // 
            // radioButton_admin
            // 
            this.radioButton_admin.AutoSize = true;
            this.radioButton_admin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_admin.ForeColor = System.Drawing.Color.White;
            this.radioButton_admin.Location = new System.Drawing.Point(24, 428);
            this.radioButton_admin.Name = "radioButton_admin";
            this.radioButton_admin.Size = new System.Drawing.Size(73, 24);
            this.radioButton_admin.TabIndex = 0;
            this.radioButton_admin.TabStop = true;
            this.radioButton_admin.Text = "Admin";
            this.radioButton_admin.UseVisualStyleBackColor = true;
            this.radioButton_admin.CheckedChanged += new System.EventHandler(this.radioButton_admin_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(490, 585);
            this.Controls.Add(this.radioButton_teamMember);
            this.Controls.Add(this.radioButton_manager);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton_admin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.panel_top);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseClick);
            this.panel_top.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton_teamMember;
        private System.Windows.Forms.RadioButton radioButton_manager;
        private System.Windows.Forms.RadioButton radioButton_admin;
    }
}