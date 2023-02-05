using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public interface IProjectManagerBusiness
    {
        List<TeamMember> GetAllTeamMembers();
        string InsertTeamMember(TeamMember tm);
        string UpdateTeamMember(TeamMember tm);
        string DeleteTeamMember(int id);
        List<Task> GetAllTasks();
        string DeleteTask(int id);
        ProjectManager GetProjectManager(String email, String password);
        List<Task> GetAllTasksForProjectManager(int id);
    }
}
