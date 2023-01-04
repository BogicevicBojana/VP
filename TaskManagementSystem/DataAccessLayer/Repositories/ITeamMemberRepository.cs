using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shared.Models;

namespace DataAccessLayer.Repositories
{
    public interface ITeamMemberRepository
    {
        List<Task> GetPersonalTasks(int teamMemberId);
        int UpdateSelf(TeamMember tm);
        TeamMember GetTeamMember(string email, string password);
    }
}
