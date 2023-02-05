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
using PresentationLayer.Forms;

namespace PresentationLayer.UserControls.ProjectManager
{
    public partial class UC_TeamMembers : UserControl
    {

        private IProjectManagerBusiness projectManagerBusiness;

        public UC_TeamMembers(IProjectManagerBusiness projectManagerBusiness)
        {
            this.projectManagerBusiness = projectManagerBusiness;
            InitializeComponent();
            InitializeDGW();
        }

        private void UC_TeamMembers_Load(object sender, EventArgs e)
        {

        }

        public void InitializeDGW()
        {
            dataGridView1.Rows.Clear();
            List<Shared.Models.TeamMember> list = projectManagerBusiness.GetAllTeamMembers();
            foreach (Shared.Models.TeamMember item in list)
            {
                object[] newItem = {
                    item.Id.ToString(),
                    item.FirstName,
                    item.LastName,
                    item.PersonalNumber,
                    item.DateOfBirth,
                    item.PlaceOfBirth,
                    item.DateEmployed,
                    item.Email,
                    item.Password,
                    item.PhoneNumber,
                    item.CompletedTasks,
                    item.NotCompletedTasks,
                    item.HoursSpent
                };

                dataGridView1.Rows.Add(newItem);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Da li ste sigurni da želite da obrišete zapis?", "Potvrdite akciju", MessageBoxButtons.OKCancel);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    String message = projectManagerBusiness.DeleteTeamMember(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                    MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitializeDGW();
                }
            }
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            // get selected item
            var selectedTeamMember = new Shared.Models.TeamMember();

            selectedTeamMember.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            selectedTeamMember.FirstName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            selectedTeamMember.LastName = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            selectedTeamMember.PersonalNumber = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            selectedTeamMember.DateOfBirth = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            selectedTeamMember.PlaceOfBirth = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            selectedTeamMember.DateEmployed = DateTime.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            selectedTeamMember.Email = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            selectedTeamMember.PhoneNumber = dataGridView1.CurrentRow.Cells[9].Value.ToString();

            // pass it to edit form and show form as dialog
            UpdateTeamMemberForm updateTeamMemberForm = new UpdateTeamMemberForm(projectManagerBusiness, selectedTeamMember);
            //updateProjectManagerForm.SetProjectManager(selectedProjectManager);
            updateTeamMemberForm.ShowDialog();

            InitializeDGW();
        }
    }
}
