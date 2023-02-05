using BusinessLayer;
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

namespace PresentationLayer.Forms
{
    public partial class AddTaskForm : Form
    {

        private ITaskBusiness taskBusiness;
        private IProjectManagerBusiness projectManagerBusiness;
        private ProjectManager projectManager;

        public AddTaskForm(ITaskBusiness _taskBusiness, IProjectManagerBusiness projectManagerBusiness, ProjectManager _pm)
        {
            this.projectManagerBusiness = projectManagerBusiness;
            this.taskBusiness = _taskBusiness;
            this.projectManager = _pm;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var newTask = new Shared.Models.Task();
            TeamMember selectedTeamMember = (TeamMember)comboTeamMember.SelectedItem;

            if (txtDescription.Text.Trim() != "" && selectedTeamMember != null && txtTitle.Text.Trim() != "")
            {
                newTask.Title = txtTitle.Text.Trim();
                newTask.DateIssued = DateTime.Now;
                newTask.Description = txtDescription.Text.Trim();
                newTask.DueDate = dtpDueDate.Value;
                newTask.IsCompleted = false;
                newTask.ProjectManagerId = projectManager.Id;
                newTask.TeamMemberId = selectedTeamMember.Id;

                try
                {
                    String resultMessage = taskBusiness.InsertTask(newTask);
                    MessageBox.Show(resultMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška prilikom dodavanja zadatka!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Popunite sva polja", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            List<TeamMember> teamMembers = projectManagerBusiness.GetAllTeamMembers();

            foreach (var item in teamMembers)
            {
                comboTeamMember.Items.Add(item);
            }
        }
    }
}
