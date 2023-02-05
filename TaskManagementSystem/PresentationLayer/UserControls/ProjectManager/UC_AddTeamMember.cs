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

namespace PresentationLayer.UserControls.ProjectManager
{
    public partial class UC_AddTeamMember : UserControl
    {

        private IProjectManagerBusiness projectManagerBusiness;

        public UC_AddTeamMember(IProjectManagerBusiness projectManagerBusiness)
        {
            this.projectManagerBusiness = projectManagerBusiness;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TeamMember newMember = new TeamMember();

            String firstName = txtFirstName.Text.Trim();
            String lastName = txtLastName.Text.Trim();
            String email = txtEmail.Text.Trim();
            String placeOfBirth = txtPlaceOfBirth.Text.Trim();
            String password = txtPassword.Text.Trim();
            String phoneNumber = txtPassword.Text.Trim();
            String personalNumber = txtPersonalNumber.Text.Trim();
            DateTime dateOfBirth = dtpDateOfBirth.Value;
            DateTime employmentDate = dtpEmploymentDaye.Value;

            if (firstName != "" && lastName != "" && email != "" && placeOfBirth != "" &&
                password != "" && phoneNumber != "" && personalNumber != "")
            {

                newMember.FirstName = firstName;
                newMember.LastName = lastName;
                newMember.Email = email;
                newMember.PlaceOfBirth = placeOfBirth;
                newMember.Password = password;
                newMember.PhoneNumber = phoneNumber;
                newMember.DateEmployed = employmentDate;
                newMember.DateOfBirth = dateOfBirth;
                newMember.PersonalNumber = personalNumber;

                try
                {
                    String resultMessage = projectManagerBusiness.InsertTeamMember(newMember);
                    MessageBox.Show(resultMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch(Exception ex)
                {
                    MessageBox.Show("Greška prilikom dodavanja menadžera!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Popunite sva polja", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
