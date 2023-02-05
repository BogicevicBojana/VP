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
    public partial class UpdateProjectManagerForm : Form
    {

        private ProjectManager projectManager;
        private IAdminBusiness adminBusiness;

        public UpdateProjectManagerForm(IAdminBusiness adminBusiness, ProjectManager pm)
        {
            this.adminBusiness = adminBusiness;
            this.projectManager = pm;
            InitializeComponent();
        }

        public void SetProjectManager(ProjectManager pm)
        {
            this.projectManager = pm;
        }

        private void UpdateProjectManagerForm_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = projectManager.FirstName;
            txtLastName.Text = projectManager.LastName;
            txtEmail.Text = projectManager.Email;
            txtPhoneNumber.Text = projectManager.PhoneNumber;
            txtPersonalNumber.Text = projectManager.PersonalNumber;
            txtId.Text = projectManager.Id.ToString();
            dtpEmploymentDaye.Value = projectManager.DateEmployed;
            toggleStatus.Checked = projectManager.Status;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFIrstName__TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateProjectManagerForm_Shown(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProjectManager updatedProjectManager = projectManager;

            updatedProjectManager.FirstName = txtFirstName.Text.Trim();
            updatedProjectManager.LastName = txtLastName.Text.Trim();
            updatedProjectManager.PersonalNumber = txtPersonalNumber.Text.Trim();
            updatedProjectManager.Status = toggleStatus.Checked;
            updatedProjectManager.PhoneNumber = txtPhoneNumber.Text.Trim();
            updatedProjectManager.DateEmployed = dtpEmploymentDaye.Value;
            updatedProjectManager.Email = txtEmail.Text.Trim();

            try {
                String result = adminBusiness.UpdateProjectManager(updatedProjectManager);
                var messageBoxResult = MessageBox.Show(result, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (messageBoxResult == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }

            } catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom ažuriranja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
