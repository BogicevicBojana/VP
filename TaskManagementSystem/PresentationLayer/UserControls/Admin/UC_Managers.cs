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

namespace PresentationLayer.UserControls.Admin
{
    public partial class UC_Managers : UserControl
    {
        readonly IProjectManagerBusiness projectManagerBusiness;
        readonly IAdminBusiness adminBusiness;

        public UC_Managers(IProjectManagerBusiness projectManagerBusiness, IAdminBusiness adminBusiness)
        {
            this.projectManagerBusiness = projectManagerBusiness;
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
            List<ProjectManager> list = adminBusiness.GetAllProjectManagers();
            foreach (ProjectManager pj in list)
            {
                object[] newItem = {
                    pj.Id.ToString(),
                    pj.FirstName,
                    pj.LastName,
                    pj.Status,
                    pj.PersonalNumber,
                    pj.PhoneNumber,         
                    pj.Email,
                    pj.DateEmployed.ToString()
                };

                dataGridView1.Rows.Add(newItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Da li ste sigurni da želite da obrišete zapis?", "Potvrdite akciju", MessageBoxButtons.OKCancel);
                if(result == System.Windows.Forms.DialogResult.OK)
                {
                    String message = adminBusiness.DeleteProjectManager(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                    MessageBox.Show(message, "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitializeDGW();
                }
            }
        }

        /*
         * 
            if (apartmentDGW.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Ova akcija će takođe obrisati i sve rente povezane s ovim oglasom. Nastaviti?", "Confirm", MessageBoxButtons.OKCancel);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    int res1 = rentBusiness.DeleteRentByApartment(Convert.ToInt32(apartmentDGW.SelectedRows[0].Cells[0].Value));
                    int res2 = aptBusiness.RemoveApartment(Convert.ToInt32(apartmentDGW.SelectedRows[0].Cells[0].Value));
                    MessageBox.Show((res2 == 1) ? "Uspešno obrisano." : "Greška: Operacija brisanja nije uspela.");
                    initializeDGW();
                } else if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    // do nothing
                }
            }
         */
    }
}
