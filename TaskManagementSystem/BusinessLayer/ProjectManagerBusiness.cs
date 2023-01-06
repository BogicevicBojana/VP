using DataAccessLayer.Repositories;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class ProjectManagerBusiness : IProjectManagerBusiness
    {
        private readonly IProjectManagerRepository projectManagerRepository;

        public ProjectManagerBusiness(IProjectManagerRepository _projectManagerRepository)
        {
            projectManagerRepository = _projectManagerRepository;
        }

        public List<TeamMember> GetAllTeamMembers()
        {
            return this.projectManagerRepository.GetAllTeamMembers();
        }
        public string InsertTeamMember(TeamMember tm)
        {
            int rowsAffected = this.projectManagerRepository.InsertTeamMember(tm);

            if (rowsAffected > 0)
            {
                return "Član tima je uspešno dodat!";
            }
            else
            {
                return "Neuspešno dodavanje člana tima!";
            }
        }
        public string UpdateTeamMember(TeamMember tm)
        {
            int rowsAffected = this.projectManagerRepository.UpdateTeamMember(tm);

            if (rowsAffected > 0)
            {
                return "Član tima je uspešno ažuriran!";
            }
            else
            {
                return "Neuspešno ažuriranje člana tima!";
            }
        }

        public string DeleteTeamMember(int id)
        {
            int rowsAffected = this.projectManagerRepository.DeleteTeamMember(id);

            if (rowsAffected > 0)
            {
                return "Član tima je uspešno izbrisan!";
            }
            else
            {
                return "Neuspešno brisanje člana tima";
            }
        }

        public ProjectManager GetProjectManager(string email, string password)
        {
            return this.projectManagerRepository.GetProjectManager(email, password);
        }

        public List<Task> GetAllTasks()
        {
            return this.projectManagerRepository.GetAllTasks();
        }

        public string DeleteTask(int id)
        {
            int rowsAffected = this.projectManagerRepository.DeleteTask(id);
            if(rowsAffected > 0)
            {
                return "Zadatak je uspešno obrisan!";
            }
            else
            {
                return "Neuspešno brisanje zadatka!";
            }
        }
    }
}
