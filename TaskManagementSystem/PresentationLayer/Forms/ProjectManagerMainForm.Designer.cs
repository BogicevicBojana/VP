namespace PresentationLayer
{
    partial class ProjectManagerMainForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.currentBtnSelection = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnMinimzeWindow = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnAddTeamMember = new System.Windows.Forms.Button();
            this.btnTeamMembers = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
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
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(299, 76);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1208, 773);
            this.panelContainer.TabIndex = 9;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
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
            this.panel1.Size = new System.Drawing.Size(1208, 76);
            this.panel1.TabIndex = 8;
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
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.currentBtnSelection);
            this.panelMenu.Controls.Add(this.btnTasks);
            this.panelMenu.Controls.Add(this.btnAddTeamMember);
            this.panelMenu.Controls.Add(this.btnTeamMembers);
            this.panelMenu.Controls.Add(this.btnProfile);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.MinimumSize = new System.Drawing.Size(299, 777);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(299, 849);
            this.panelMenu.TabIndex = 7;
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
            // btnMinimzeWindow
            // 
            this.btnMinimzeWindow.BackgroundImage = global::PresentationLayer.Properties.Resources.macos_minimize_24px;
            this.btnMinimzeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimzeWindow.FlatAppearance.BorderSize = 0;
            this.btnMinimzeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimzeWindow.Location = new System.Drawing.Point(1111, 20);
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
            this.btnCloseWindow.Location = new System.Drawing.Point(1155, 20);
            this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(41, 37);
            this.btnCloseWindow.TabIndex = 18;
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
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
            this.btnLogout.Location = new System.Drawing.Point(0, 372);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(299, 74);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "   Odjavi se";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTasks.FlatAppearance.BorderSize = 0;
            this.btnTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasks.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasks.ForeColor = System.Drawing.Color.DarkGray;
            this.btnTasks.Image = global::PresentationLayer.Properties.Resources.icons8_tasks_24;
            this.btnTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.Location = new System.Drawing.Point(0, 298);
            this.btnTasks.Margin = new System.Windows.Forms.Padding(4);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnTasks.Size = new System.Drawing.Size(299, 74);
            this.btnTasks.TabIndex = 4;
            this.btnTasks.Text = "   Zadaci";
            this.btnTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTasks.UseVisualStyleBackColor = true;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnAddTeamMember
            // 
            this.btnAddTeamMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddTeamMember.FlatAppearance.BorderSize = 0;
            this.btnAddTeamMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeamMember.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeamMember.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAddTeamMember.Image = global::PresentationLayer.Properties.Resources.icons8_add_administrator_28;
            this.btnAddTeamMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTeamMember.Location = new System.Drawing.Point(0, 224);
            this.btnAddTeamMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTeamMember.Name = "btnAddTeamMember";
            this.btnAddTeamMember.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnAddTeamMember.Size = new System.Drawing.Size(299, 74);
            this.btnAddTeamMember.TabIndex = 3;
            this.btnAddTeamMember.Text = "   Dodaj člana tima";
            this.btnAddTeamMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTeamMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddTeamMember.UseVisualStyleBackColor = true;
            this.btnAddTeamMember.Click += new System.EventHandler(this.btnAddManager_Click);
            // 
            // btnTeamMembers
            // 
            this.btnTeamMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeamMembers.FlatAppearance.BorderSize = 0;
            this.btnTeamMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeamMembers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeamMembers.ForeColor = System.Drawing.Color.DarkGray;
            this.btnTeamMembers.Image = global::PresentationLayer.Properties.Resources.icons8_businessman_281;
            this.btnTeamMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeamMembers.Location = new System.Drawing.Point(0, 150);
            this.btnTeamMembers.Margin = new System.Windows.Forms.Padding(4);
            this.btnTeamMembers.Name = "btnTeamMembers";
            this.btnTeamMembers.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnTeamMembers.Size = new System.Drawing.Size(299, 74);
            this.btnTeamMembers.TabIndex = 2;
            this.btnTeamMembers.Text = "   Članovi tima";
            this.btnTeamMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeamMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeamMembers.UseVisualStyleBackColor = true;
            this.btnTeamMembers.Click += new System.EventHandler(this.btnTeamMembers_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProfile.Image = global::PresentationLayer.Properties.Resources.icons8_user_28;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 76);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(299, 74);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "   Profil";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnAdminProfile_Click);
            // 
            // ProjectManagerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1507, 849);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1347, 825);
            this.Name = "ProjectManagerMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectManagerMainForm";
            this.panel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimzeWindow;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel currentBtnSelection;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnAddTeamMember;
        private System.Windows.Forms.Button btnTeamMembers;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel panelLogo;
    }
}