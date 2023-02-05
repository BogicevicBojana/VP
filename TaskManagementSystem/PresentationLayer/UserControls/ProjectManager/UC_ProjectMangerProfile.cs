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

namespace PresentationLayer.UserControls.ProjectManager
{
    public partial class UC_ProjectMangerProfile : UserControl
    {
        private Shared.Models.ProjectManager projectManager;

        public UC_ProjectMangerProfile()
        {
            InitializeComponent();
        }

        public void setProjectManager(Shared.Models.ProjectManager pm)
        {
            this.projectManager = pm;
        }

        private void UC_ProjectMangerProfile_Load(object sender, EventArgs e)
        {
            lbl_name.Text = projectManager.FirstName + ' ' + projectManager.LastName;
            lbl_Email.Text = projectManager.Email;
            lbl_employmentDate.Text = projectManager.DateEmployed.ToString();
            lbl_personalNumber.Text = projectManager.PersonalNumber.ToString();
            lbl_phone.Text = projectManager.PhoneNumber.ToString();
        }
    }
}
