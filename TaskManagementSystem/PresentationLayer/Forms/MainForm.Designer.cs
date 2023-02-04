namespace PresentationLayer
{
    partial class MainForm
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimzeWindow = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.currentBtnSelection = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAddManager = new System.Windows.Forms.Button();
            this.btnManagers = new System.Windows.Forms.Button();
            this.btnAdminProfile = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(299, 76);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1048, 749);
            this.panelContainer.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.btnMinimzeWindow);
            this.panel1.Controls.Add(this.btnCloseWindow);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(299, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 76);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnMinimzeWindow
            // 
            this.btnMinimzeWindow.BackgroundImage = global::PresentationLayer.Properties.Resources.macos_minimize_24px;
            this.btnMinimzeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimzeWindow.FlatAppearance.BorderSize = 0;
            this.btnMinimzeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimzeWindow.Location = new System.Drawing.Point(943, 20);
            this.btnMinimzeWindow.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimzeWindow.Name = "btnMinimzeWindow";
            this.btnMinimzeWindow.Size = new System.Drawing.Size(41, 37);
            this.btnMinimzeWindow.TabIndex = 19;
            this.btnMinimzeWindow.UseVisualStyleBackColor = true;
            this.btnMinimzeWindow.Click += new System.EventHandler(this.btnMinimzeWindow_Click);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.BackgroundImage = global::PresentationLayer.Properties.Resources.macos_close_24px;
            this.btnCloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWindow.Location = new System.Drawing.Point(987, 20);
            this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(41, 37);
            this.btnCloseWindow.TabIndex = 18;
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(947, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 37);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(992, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 37);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSize = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.currentBtnSelection);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnAddManager);
            this.panelMenu.Controls.Add(this.btnManagers);
            this.panelMenu.Controls.Add(this.btnAdminProfile);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.MinimumSize = new System.Drawing.Size(299, 777);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(299, 825);
            this.panelMenu.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(93, 794);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Task Manager";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // currentBtnSelection
            // 
            this.currentBtnSelection.BackColor = System.Drawing.Color.SlateBlue;
            this.currentBtnSelection.Location = new System.Drawing.Point(0, 76);
            this.currentBtnSelection.Margin = new System.Windows.Forms.Padding(4);
            this.currentBtnSelection.Name = "currentBtnSelection";
            this.currentBtnSelection.Size = new System.Drawing.Size(7, 74);
            this.currentBtnSelection.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLogout.Image = global::PresentationLayer.Properties.Resources.icons8_log_out_24;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 298);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(299, 74);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "   Odjavi se";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAddManager
            // 
            this.btnAddManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddManager.FlatAppearance.BorderSize = 0;
            this.btnAddManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddManager.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddManager.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAddManager.Image = global::PresentationLayer.Properties.Resources.icons8_add_administrator_28;
            this.btnAddManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddManager.Location = new System.Drawing.Point(0, 224);
            this.btnAddManager.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddManager.Name = "btnAddManager";
            this.btnAddManager.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnAddManager.Size = new System.Drawing.Size(299, 74);
            this.btnAddManager.TabIndex = 3;
            this.btnAddManager.Text = "   Dodaj menadžera";
            this.btnAddManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddManager.UseVisualStyleBackColor = true;
            this.btnAddManager.Click += new System.EventHandler(this.btnAddManager_Click);
            // 
            // btnManagers
            // 
            this.btnManagers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagers.FlatAppearance.BorderSize = 0;
            this.btnManagers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagers.ForeColor = System.Drawing.Color.DarkGray;
            this.btnManagers.Image = global::PresentationLayer.Properties.Resources.icons8_businessman_281;
            this.btnManagers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagers.Location = new System.Drawing.Point(0, 150);
            this.btnManagers.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagers.Name = "btnManagers";
            this.btnManagers.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnManagers.Size = new System.Drawing.Size(299, 74);
            this.btnManagers.TabIndex = 2;
            this.btnManagers.Text = "   Menadžeri";
            this.btnManagers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManagers.UseVisualStyleBackColor = true;
            this.btnManagers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnAdminProfile
            // 
            this.btnAdminProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAdminProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminProfile.FlatAppearance.BorderSize = 0;
            this.btnAdminProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminProfile.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdminProfile.Image = global::PresentationLayer.Properties.Resources.icons8_user_28;
            this.btnAdminProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminProfile.Location = new System.Drawing.Point(0, 76);
            this.btnAdminProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminProfile.Name = "btnAdminProfile";
            this.btnAdminProfile.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnAdminProfile.Size = new System.Drawing.Size(299, 74);
            this.btnAdminProfile.TabIndex = 1;
            this.btnAdminProfile.Text = "   Profil";
            this.btnAdminProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminProfile.UseVisualStyleBackColor = false;
            this.btnAdminProfile.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelLogo.Controls.Add(this.label3);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(299, 76);
            this.panelLogo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 76);
            this.label3.TabIndex = 14;
            this.label3.Text = "ANYTASK";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1347, 825);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1347, 825);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel currentBtnSelection;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAddManager;
        private System.Windows.Forms.Button btnManagers;
        private System.Windows.Forms.Button btnAdminProfile;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMinimzeWindow;
        private System.Windows.Forms.Button btnCloseWindow;
        private UserControls.Admin.UC_AdminProfile UC_AdminProfile;
        private UserControls.Admin.UC_Managers UC_Managers;
        private UserControls.Admin.UC_AddManager UC_AddManager;
    }
}
