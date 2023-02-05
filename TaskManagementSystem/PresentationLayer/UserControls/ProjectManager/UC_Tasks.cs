using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer.UserControls.ProjectManager
{
    public partial class UC_Tasks : UserControl
    {

        private IProjectManagerBusiness projectManagerBusiness;
        private ITaskBusiness taskBusiness;
        private Shared.Models.ProjectManager currentProjectManager;

        public UC_Tasks(Shared.Models.ProjectManager pm, IProjectManagerBusiness _projectManagerBusiness, ITaskBusiness _taskBusiness)
        {
            this.projectManagerBusiness = _projectManagerBusiness;
            this.taskBusiness = _taskBusiness;
            this.currentProjectManager = pm;
            InitializeComponent();
            InitializeDGW();
        }

        private void UC_Tasks_Load(object sender, EventArgs e)
        {

        }

        public void InitializeDGW()
        {
            dataGridView1.Rows.Clear();
            List<Shared.Models.Task> list = new List<Shared.Models.Task>();


            if (!checkBox_Mine.Checked)
            {
                 list = projectManagerBusiness.GetAllTasks();
            } else
            {
                list = projectManagerBusiness.GetAllTasksForProjectManager(currentProjectManager.Id);
            }

            foreach (Shared.Models.Task item in list)
            {
                object[] newItem = {
                    item.Id.ToString(),
                    item.DateIssued.ToString(),
                    item.DueDate.ToString(),
                    item.ProjectManagerId,
                    GetTeamMemberByTask(item).FirstName + ' ' + GetTeamMemberByTask(item).LastName,
                    item.Title,
                    item.IsCompleted,
                    item.Description,
                    item.HoursSpent
                };

                dataGridView1.Rows.Add(newItem);
            }
        }

        private Shared.Models.TeamMember GetTeamMemberByTask(Shared.Models.Task task)
        {
            return projectManagerBusiness
                .GetAllTeamMembers()
                .Find(t => t.Id == task.TeamMemberId);
        }

        private void checkBox_Mine_CheckedChanged(object sender, EventArgs e)
        {
            InitializeDGW();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Da li ste sigurni da želite da obrišete zapis?", "Potvrdite akciju", MessageBoxButtons.OKCancel);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    String message = projectManagerBusiness.DeleteTask(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                    MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitializeDGW();
                }
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Forms.AddTaskForm addTaskForm = new Forms.AddTaskForm(taskBusiness, projectManagerBusiness, currentProjectManager);
            addTaskForm.ShowDialog();
            InitializeDGW();
        }
    }
}
