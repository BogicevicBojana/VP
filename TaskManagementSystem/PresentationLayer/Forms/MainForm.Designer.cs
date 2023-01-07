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
            this.panelContentArea = new System.Windows.Forms.Panel();
            this.uC_AdminProfile1 = new PresentationLayer.UserControls.Admin.UC_AdminProfile();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.currentBtnSelection = new System.Windows.Forms.Panel();
            this.btnRents = new System.Windows.Forms.Button();
            this.btnApartments = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelContentArea.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContentArea
            // 
            this.panelContentArea.Controls.Add(this.uC_AdminProfile1);
            this.panelContentArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentArea.Location = new System.Drawing.Point(224, 62);
            this.panelContentArea.Name = "panelContentArea";
            this.panelContentArea.Size = new System.Drawing.Size(786, 608);
            this.panelContentArea.TabIndex = 6;
            // 
            // uC_AdminProfile1
            // 
            this.uC_AdminProfile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.uC_AdminProfile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_AdminProfile1.Location = new System.Drawing.Point(0, 0);
            this.uC_AdminProfile1.Name = "uC_AdminProfile1";
            this.uC_AdminProfile1.Size = new System.Drawing.Size(786, 608);
            this.uC_AdminProfile1.TabIndex = 0;
            this.uC_AdminProfile1.Load += new System.EventHandler(this.uC_AdminProfile1_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(224, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 62);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::PresentationLayer.Properties.Resources.macos_minimize_24px;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(707, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 30);
            this.button4.TabIndex = 19;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::PresentationLayer.Properties.Resources.macos_close_24px;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(740, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 30);
            this.button5.TabIndex = 18;
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
            // panelMenu
            // 
            this.panelMenu.AutoSize = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.currentBtnSelection);
            this.panelMenu.Controls.Add(this.btnRents);
            this.panelMenu.Controls.Add(this.btnApartments);
            this.panelMenu.Controls.Add(this.btnUsers);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.MinimumSize = new System.Drawing.Size(224, 631);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(224, 670);
            this.panelMenu.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(70, 645);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Task Manager";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // currentBtnSelection
            // 
            this.currentBtnSelection.BackColor = System.Drawing.Color.SlateBlue;
            this.currentBtnSelection.Location = new System.Drawing.Point(0, 62);
            this.currentBtnSelection.Name = "currentBtnSelection";
            this.currentBtnSelection.Size = new System.Drawing.Size(5, 60);
            this.currentBtnSelection.TabIndex = 5;
            // 
            // btnRents
            // 
            this.btnRents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRents.FlatAppearance.BorderSize = 0;
            this.btnRents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRents.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRents.ForeColor = System.Drawing.Color.DarkGray;
            this.btnRents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRents.Location = new System.Drawing.Point(0, 242);
            this.btnRents.Name = "btnRents";
            this.btnRents.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRents.Size = new System.Drawing.Size(224, 60);
            this.btnRents.TabIndex = 4;
            this.btnRents.Text = "   Rente";
            this.btnRents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRents.UseVisualStyleBackColor = true;
            this.btnRents.Visible = false;
            // 
            // btnApartments
            // 
            this.btnApartments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnApartments.FlatAppearance.BorderSize = 0;
            this.btnApartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApartments.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApartments.ForeColor = System.Drawing.Color.DarkGray;
            this.btnApartments.Image = global::PresentationLayer.Properties.Resources.icons8_add_administrator_28;
            this.btnApartments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApartments.Location = new System.Drawing.Point(0, 182);
            this.btnApartments.Name = "btnApartments";
            this.btnApartments.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnApartments.Size = new System.Drawing.Size(224, 60);
            this.btnApartments.TabIndex = 3;
            this.btnApartments.Text = "   Dodaj menadžera";
            this.btnApartments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApartments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApartments.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.DarkGray;
            this.btnUsers.Image = global::PresentationLayer.Properties.Resources.icons8_businessman_281;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 122);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(224, 60);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "   Menadžeri";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.Image = global::PresentationLayer.Properties.Resources.icons8_user_28;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 62);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(224, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "   Profil";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelLogo.Controls.Add(this.label3);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(224, 62);
            this.panelLogo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 62);
            this.label3.TabIndex = 14;
            this.label3.Text = "ANYTASK";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1010, 670);
            this.Controls.Add(this.panelContentArea);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1010, 670);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelContentArea.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContentArea;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel currentBtnSelection;
        private System.Windows.Forms.Button btnRents;
        private System.Windows.Forms.Button btnApartments;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private UserControls.Admin.UC_AdminProfile uC_AdminProfile1;
    }
}
