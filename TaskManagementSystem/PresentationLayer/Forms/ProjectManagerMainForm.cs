using PresentationLayer.UserControls.ProjectManager;
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
using BusinessLayer;
using DataAccessLayer.Repositories;

namespace PresentationLayer
{
    public partial class ProjectManagerMainForm : Form
    {
        private ProjectManager projectManager;

        private ProjectManagerBusiness projectManagerBusiness;
        private ProjectManagerRepository projectManagerRepository;

        private TaskBusiness taskBusiness;
        private TaskRepository taskRepository;

        Forms.LoginForm prevForm;

        public ProjectManagerMainForm(ProjectManager pm, Forms.LoginForm prevForm)
        {
            this.projectManagerRepository = new ProjectManagerRepository();
            this.projectManagerBusiness = new ProjectManagerBusiness(projectManagerRepository);

            this.taskRepository = new TaskRepository();
            this.taskBusiness = new TaskBusiness(taskRepository);

            this.projectManager = pm;
            this.prevForm = prevForm;

            InitializeComponent();
            InitializeManagerProfile();
        }

        private void InitializeManagerProfile()
        {
            UC_ProjectMangerProfile control = new UC_ProjectMangerProfile();
            control.setProjectManager(projectManager);
            AddUserControl(control);
        }

        private void btnAddManager_Click(object sender, EventArgs e)
        {
            UC_AddTeamMember control = new UC_AddTeamMember(projectManagerBusiness);
            AddUserControl(control);
            HandleButtonClick(btnAddTeamMember);
        }

        private void btnMinimzeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdminProfile_Click(object sender, EventArgs e)
        {
            UC_ProjectMangerProfile control = new UC_ProjectMangerProfile();
            control.setProjectManager(projectManager);
            AddUserControl(control);
            HandleButtonClick(btnProfile);
        }

        private void HandleButtonClick(Button button)
        {
            ResetButtons();
            button.BackColor = Color.FromArgb(42, 42, 42);
            this.currentBtnSelection.Top = button.Top;
        }

        private void ResetButtons()
        {
            btnProfile.BackColor =
            btnTeamMembers.BackColor =
            btnAddTeamMember.BackColor =
            btnTasks.BackColor =
            Color.FromArgb(39, 39, 39);
        }

        private void AddUserControl(UserControl userControl)
        {
            if (!panelContainer.Controls.Contains(userControl))
            {
                userControl.Dock = DockStyle.Fill;
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(userControl);
            }
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTeamMembers_Click(object sender, EventArgs e)
        {
            UC_TeamMembers control = new UC_TeamMembers(projectManagerBusiness);
            AddUserControl(control);
            HandleButtonClick(btnTeamMembers);
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            UC_Tasks control = new UC_Tasks(
                projectManager,
                projectManagerBusiness,
                taskBusiness);
            AddUserControl(control);
            HandleButtonClick(btnTasks);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.projectManager = null;
            this.Close();
        }
    }
}
