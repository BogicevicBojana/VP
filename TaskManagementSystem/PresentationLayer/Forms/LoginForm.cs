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

namespace PresentationLayer.Forms
{
    public partial class LoginForm : Form
    {
        bool mouseDown;
        private Point offset;

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

            InitializeComponent();
        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

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
            this.textBox_user.Text = "";
            this.textBox_user.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_MouseClick(object sender, MouseEventArgs e)
        {
            if(textBox_user.Text == "")
            {
                textBox_user.Text = "Unesi mejl";
                this.textBox_user.ForeColor = Color.FromArgb(200, 200, 200);
            }

            if (textBox_user.Focused)
            {
                this.textBox_user.Text = "";
                this.textBox_user.ForeColor = Color.FromArgb(255, 255, 255);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
