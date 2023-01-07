using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.Admin
{
    public partial class UC_AdminProfile : UserControl
    {
        private Shared.Models.Admin admin;

        public UC_AdminProfile()
        {
            InitializeComponent();
        }

        
        private void UC_AdminProfile_Load(object sender, EventArgs e)
        {
            lbl_firstName.Text = admin.FirstName + ' ' + admin.LastName;
            lbl_Email.Text = admin.Email;
        }

        public void SetAdmin(Shared.Models.Admin admin) 
        {
            this.admin = admin;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
