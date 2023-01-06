using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shared.Models;
using DataAccessLayer.Repositories;

namespace BusinessLayer
{
    public class TeamMemberBusiness : ITeamMemberBusiness
    {
        private readonly ITeamMemberRepository teamMemberRepository;

        public TeamMemberBusiness(ITeamMemberRepository _teamMemberRepository)
        {
            teamMemberRepository = _teamMemberRepository;
        }

        public List<Task> GetPersonalTasks(int teamMemberId)
        {
            return this.teamMemberRepository.GetPersonalTasks(teamMemberId);
        }

        public string UpdateSelf(TeamMember tm)
        {
            int rowsAffected = this.teamMemberRepository.UpdateSelf(tm);

            if(rowsAffected > 0)
            {
                return "Vaši podaci su uspešno ažurirani!";
            }
            else
            {
                return "Neuspešno ažuriranje Vaših podataka!";
            }
        }
        public TeamMember GetTeamMember(string email, string password)
        {
            return this.teamMemberRepository.GetTeamMember(email, password);
        }
    }
}
