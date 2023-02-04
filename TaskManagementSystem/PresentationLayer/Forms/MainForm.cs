using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared.Models;
using PresentationLayer.UserControls.Admin;
using BusinessLayer;
using DataAccessLayer.Repositories;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        bool mouseDown;
        private Point offset;
        private Admin admin;
        Forms.LoginForm prevForm;

        readonly IAdminBusiness adminBusiness;

        public MainForm(Admin _admin, Forms.LoginForm _prevForm)
        {
            this.admin = _admin;
            this.prevForm = _prevForm;
            InitializeComponent();
            InitializeAdminProfile();
        }

        private void InitializeAdminProfile()
        {
            var adminProfile = new UC_AdminProfile();
            adminProfile.SetAdmin(admin);
            AddUserControl(adminProfile);
            HandleButtonClick(btnAdminProfile);
        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point currentMousePosition = PointToScreen(e.Location);
                Location = new Point(currentMousePosition.X - offset.X, currentMousePosition.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UC_Managers u = new UC_Managers(new ProjectManagerBusiness(new ProjectManagerRepository()), new AdminBusiness(new AdminRepository()));
            AddUserControl(u);
            HandleButtonClick(btnManagers);
        }

        private void bringUcToTop(UserControl userControl)
        {
            userControl.BringToFront();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            var adminProfile = new UC_AdminProfile();
            adminProfile.SetAdmin(admin);
            AddUserControl(adminProfile);
            HandleButtonClick(btnAdminProfile);
        }

        private void HandleButtonClick(Button button)
        {
            ResetButtons();
            button.BackColor = Color.FromArgb(42, 42, 42);
            this.currentBtnSelection.Top = button.Top;
        }

        private void ResetButtons()
        {
            btnAdminProfile.BackColor =
            btnManagers.BackColor =
            btnAddManager.BackColor =
            btnLogout.BackColor =
            Color.FromArgb(39, 39, 39);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }


        private void btnAddManager_Click(object sender, EventArgs e)
        {
            HandleButtonClick(btnAddManager);
        }

        private void btnMinimzeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.admin = null;
            this.Close();
        }
    }
}
