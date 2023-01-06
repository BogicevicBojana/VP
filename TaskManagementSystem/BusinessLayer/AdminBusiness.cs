using DataAccessLayer.Repositories;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AdminBusiness : IAdminBusiness
    {
        private readonly IAdminRepository adminRepository;

        public AdminBusiness(IAdminRepository _adminRepository)
        {
            adminRepository = _adminRepository;
        }

        public List<ProjectManager> GetAllProjectManagers()
        {
            return this.adminRepository.GetAllProjectManagers();
        }
        public string InsertProjectManager(ProjectManager pm)
        {
            int rowsAffected = this.adminRepository.InsertProjectManager(pm);

            if (rowsAffected > 0)
            {
                return "Menadžer projekta je uspešno dodat!";
            }
            else
            {
                return "Neuspešno dodavanje menadžera projekta!";
            }
        }
        public string UpdateProjectManager(ProjectManager pm)
        {
            int rowsAffected = this.adminRepository.UpdateProjectManager(pm);

            if (rowsAffected > 0)
            {
                return "Menadžer projekta je uspešno ažuriran!";
            }
            else
            {
                return "Neuspešno ažuriranje menadžera projekta!";
            }
        }
        public string DeleteProjectManager(int id)
        {
            int rowsAffected = this.adminRepository.DeleteProjectManager(id);

            if (rowsAffected > 0)
            {
                return "Menadžer projekta je uspešno izbrisan!";
            }
            else
            {
                return "Neuspešno brisanje menadžera projekta";
            }
        }


        public Admin GetAdmin(string email, string password)
        {
            return this.adminRepository.GetAdmin(email, password);
        }
    }
}
