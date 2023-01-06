using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IAdminBusiness
    {
        List<ProjectManager> GetAllProjectManagers();
        string InsertProjectManager(ProjectManager pm);
        string UpdateProjectManager(ProjectManager pm);
        string DeleteProjectManager(int id);
    }
}
