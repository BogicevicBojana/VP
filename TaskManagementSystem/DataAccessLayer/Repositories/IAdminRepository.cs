using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public interface IAdminRepository
    {
        List<ProjectManager> GetAllProjectManagers();
        int UpdateProjectManager(ProjectManager pm);
        int InsertProjectManager(ProjectManager pm);
        Admin GetAdmin(string email, string password);
        int DeleteProjectManager(int id);
    }
}
