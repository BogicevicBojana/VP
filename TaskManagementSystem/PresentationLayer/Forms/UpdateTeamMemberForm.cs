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
    public partial class UpdateTeamMemberForm : Form
    {

        private IProjectManagerBusiness projectManagerBusiness;
        private TeamMember teamMember;

        public UpdateTeamMemberForm(IProjectManagerBusiness projectManagerBusiness, TeamMember teamMember)
        {
            this.projectManagerBusiness = projectManagerBusiness;
            this.teamMember = teamMember;
            InitializeComponent();
        }

        private void UpdateTeamMemberForm_Load(object sender, EventArgs e)
        {
            txtEmail.Text = teamMember.Email;
            txtFirstName.Text = teamMember.FirstName;
            txtLastName.Text = teamMember.LastName;
            txtPersonalNumber.Text = teamMember.PersonalNumber;
            txtPhoneNumber.Text = teamMember.PhoneNumber;
            txtId.Text = teamMember.Id.ToString();
            dtpEmploymentDaye.Value = teamMember.DateEmployed;
            dtpDateOfBirth.Value = teamMember.DateOfBirth;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TeamMember updatedTeamMember = teamMember;

            updatedTeamMember.FirstName = txtFirstName.Text.Trim();
            updatedTeamMember.LastName = txtLastName.Text.Trim();
            updatedTeamMember.PersonalNumber = txtPersonalNumber.Text.Trim();
            updatedTeamMember.PhoneNumber = txtPhoneNumber.Text.Trim();
            updatedTeamMember.DateEmployed = dtpEmploymentDaye.Value;
            updatedTeamMember.DateOfBirth = dtpDateOfBirth.Value;
            updatedTeamMember.Email = txtEmail.Text.Trim();

            try
            {
                string result = projectManagerBusiness.UpdateTeamMember(updatedTeamMember);
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
