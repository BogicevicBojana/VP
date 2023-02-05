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

namespace PresentationLayer.Forms
{
    public partial class EditTaskForm : Form
    {

        private Shared.Models.Task currentTask;
        private TeamMember taskTeamMember;
        private ITaskBusiness taskBusiness;

        public EditTaskForm(Shared.Models.Task currentTask, TeamMember teamMember, ITaskBusiness taskBusiness)
        {
            this.taskBusiness = taskBusiness;
            this.taskTeamMember = teamMember;
            this.currentTask = currentTask;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Shared.Models.Task task = currentTask;
            TeamMember selectedTeamMember = (TeamMember)comboTeamMember.SelectedItem;

            task.Description = txtDescription.Text.Trim();
            task.DueDate = dtpDueDate.Value;
            task.Title = txtTitle.Text.Trim();
            task.TeamMemberId = selectedTeamMember.Id;

            try
            {
                String resultMessage = taskBusiness.ProjectManagerUpdateTask(task);
                var messageBoxResult = MessageBox.Show(resultMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (messageBoxResult == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }

            } catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom ažuriranja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditTaskForm_Load(object sender, EventArgs e)
        {
            txtTitle.Text = currentTask.Title;
            txtDescription.Text = currentTask.Description;
            dtpDueDate.Value = currentTask.DueDate;
            comboTeamMember.Items.Add(taskTeamMember);
            comboTeamMember.SelectedIndex = 0;
        }
    }
}
