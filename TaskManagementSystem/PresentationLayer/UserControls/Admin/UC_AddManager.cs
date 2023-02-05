using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared.Models;
using BusinessLayer;

namespace PresentationLayer.UserControls.Admin
{
    public partial class UC_AddManager : UserControl
    {
        private readonly IAdminBusiness adminBusiness;

        public UC_AddManager(IAdminBusiness adminBusiness)
        {
            this.adminBusiness = adminBusiness;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Shared.Models.ProjectManager projectManager = new Shared.Models.ProjectManager();

            string firstName = txtFirstName.Text.Trim();
            projectManager.FirstName = firstName;

            string lastName = txtLastName.Text.Trim();
            projectManager.LastName = lastName;

            string password = txtPassword.Text.Trim();
            projectManager.Password = password;

            string personalNumber = txtPersonalNumber.Text.Trim();
            projectManager.PersonalNumber = personalNumber;

            string phoneNumber = txtPhoneNumber.Text.Trim();
            projectManager.PhoneNumber = phoneNumber;

            DateTime dateEmployed = dtpEmploymentDaye.Value;
            projectManager.DateEmployed = dateEmployed;

            string email = txtEmail.Text.Trim();
            projectManager.Email = email;

            projectManager.Status = toggleStatus.Checked;

            if (firstName != "" && lastName != "" && password != "" && personalNumber != "" && phoneNumber != "" && email != "")
            {
                try
                {
                    String resultMessage = adminBusiness.InsertProjectManager(projectManager);
                    MessageBox.Show(resultMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška prilikom dodavanja menadžera!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Popunite sva polja", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
