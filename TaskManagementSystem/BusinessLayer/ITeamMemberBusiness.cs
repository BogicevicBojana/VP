using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shared.Models;

namespace BusinessLayer
{
    public interface ITeamMemberBusiness
    {
        List<Task> GetPersonalTasks(int teamMemberId);
        string UpdateSelf(TeamMember tm);
        TeamMember GetTeamMember(string email, string password);
    }
}
