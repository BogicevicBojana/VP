using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public interface IProjectManagerRepository
    {
        List<TeamMember> GetAllTeamMembers();
        int UpdateTeamMember(TeamMember tm);
        int InsertTeamMember(TeamMember tm);
        ProjectManager GetProjectManager(string email, string password);
        int DeleteTeamMember(int id);
        List<Task> GetAllTasks();
        int DeleteTask(int id);

    }
}
