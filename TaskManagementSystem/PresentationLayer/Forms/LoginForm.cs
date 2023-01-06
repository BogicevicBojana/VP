using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Shared.Models;

namespace PresentationLayer.Forms
{
    public partial class LoginForm : Form
    {
        bool mouseDown;
        private Point offset;
        private Roles selectedRole;

        private readonly IAdminBusiness adminBusiness;
        private readonly IProjectManagerBusiness projectManagerBusiness;
        private readonly ITaskBusiness taskBusiness;
        private readonly ITeamMemberBusiness teamMemberBusiness;

        public LoginForm(IAdminBusiness _adminBusiness, IProjectManagerBusiness _projectManagerBusiness, ITaskBusiness _taskBusiness, ITeamMemberBusiness _teamMemberBusiness)
        {
            this.adminBusiness = _adminBusiness;
            this.projectManagerBusiness = _projectManagerBusiness;
            this.taskBusiness = _taskBusiness;
            this.teamMemberBusiness = _teamMemberBusiness;

            selectedRole = Roles.ADMINISTRATOR;
            InitializeComponent();
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point currentMousePosition = PointToScreen(e.Location);
                Location = new Point(currentMousePosition.X - offset.X, currentMousePosition.Y - offset.Y);
            }
        }

        private void panel_top_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel_top_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void textBox_user_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_user.Text == "Unesi email")
            {
                this.textBox_user.Text = "";
                this.textBox_user.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void LoginForm_MouseClick(object sender, MouseEventArgs e)
        {
            if(textBox_user.Text == "")
            {
                textBox_user.Text = "Unesi email";
                this.textBox_user.ForeColor = Color.FromArgb(200, 200, 200);
            }

            if (textBox_password.Text == "")
            {
                textBox_password.Text = "Unesi lozinku";
                textBox_password.PasswordChar = default;
                this.textBox_password.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }

        private void textBox_user_TabIndexChanged(object sender, EventArgs e)
        {
            if (textBox_user.Focused)
            {
                this.textBox_user.Text = "";
                this.textBox_user.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox_password_TabIndexChanged(object sender, EventArgs e)
        {
            if (textBox_password.Focused)
            {
                this.textBox_password.Text = "";
                this.textBox_password.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void textBox_password_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_password.Text == "Unesi lozinku")
            {
                this.textBox_password.Text = "";
                this.textBox_password.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (textBox_password.Text == "Unesi lozinku")
            {
                textBox_password.PasswordChar = default;
            }
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '●';
        }


        private void radioButton_admin_CheckedChanged(object sender, EventArgs e)
        {
            selectedRole = Roles.ADMINISTRATOR;
        }

        private void radioButton_manager_CheckedChanged(object sender, EventArgs e)
        {
            selectedRole = Roles.PROJECT_MANAGER;
        }

        private void radioButton_teamMember_CheckedChanged(object sender, EventArgs e)
        {
            selectedRole = Roles.TEAM_MEMBER;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            switch (selectedRole)
            {
                case Roles.ADMINISTRATOR:
                    adminLogin();
                    break;
                case Roles.PROJECT_MANAGER:
                    
                    break;
                case Roles.TEAM_MEMBER:
                    
                    break;
            }
        }

        private void adminLogin()
        {
            String email = textBox_user.Text;
            String password = textBox_password.Text;
            Admin admin = null;

            try
            {
                admin = adminBusiness.GetAdmin(email, password);

                if (admin.FirstName != null)
                {
                   // MainForm adminForm = new MainForm(admin);
                   // adminForm.Show();
                    this.Hide();
                }
                else if (email == "Unesi email" || password == "Unesi lozinku" 
                    || email == "" || password == "")
                {
                    MessageBox.Show("Popuni sva tražena polja.", "Neispravan unos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Korsnik nije pronađen! Proveri podatke i probaj ponovo.", "Došlo je do greške", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(NullReferenceException NRE)
            {
                MessageBox.Show("Korsnik nije pronađen! Proveri podatke i probaj ponovo.", "Došlo je do greške", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
