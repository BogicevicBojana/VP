using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Shared.Models;
using BusinessLayer;
using PresentationLayer.Forms;

namespace PresentationLayer.UserControls.Admin
{
    public partial class UC_Managers : UserControl
    {
        readonly IAdminBusiness adminBusiness;

        public UC_Managers(IAdminBusiness adminBusiness)
        {
            this.adminBusiness = adminBusiness;

            InitializeComponent();
            InitializeDGW();
        }

        private void UC_Managers_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void InitializeDGW()
        {
            dataGridView1.Rows.Clear();
            List<Shared.Models.ProjectManager> list = adminBusiness.GetAllProjectManagers();
            foreach (Shared.Models.ProjectManager pj in list)
            {
                object[] newItem = {
                    pj.Id.ToString(),
                    pj.FirstName,
                    pj.LastName,
                    pj.Status,
                    pj.PersonalNumber,
                    pj.PhoneNumber,
                    pj.Email,
                    pj.DateEmployed.ToString(),
                    pj.Password
                };

                dataGridView1.Rows.Add(newItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Da li ste sigurni da želite da obrišete zapis?", "Potvrdite akciju", MessageBoxButtons.OKCancel);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    String message = adminBusiness.DeleteProjectManager(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                    MessageBox.Show(message, "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitializeDGW();
                }
            }
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            // get selected item
            var selectedProjectManager = new Shared.Models.ProjectManager();

            selectedProjectManager.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            selectedProjectManager.FirstName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            selectedProjectManager.LastName = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            selectedProjectManager.Status = Boolean.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            selectedProjectManager.PersonalNumber = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            selectedProjectManager.PhoneNumber = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            selectedProjectManager.Email = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            selectedProjectManager.DateEmployed = DateTime.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            selectedProjectManager.Password = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            // pass it to edit form and show form as dialog
            UpdateProjectManagerForm updateProjectManagerForm = new UpdateProjectManagerForm(adminBusiness, selectedProjectManager);
            //updateProjectManagerForm.SetProjectManager(selectedProjectManager);
            updateProjectManagerForm.ShowDialog();

            InitializeDGW();
        }
    }
}
