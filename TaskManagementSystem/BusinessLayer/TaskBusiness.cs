using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shared.Models;

namespace BusinessLayer
{
    public class TaskBusiness : ITaskBusiness
    {
        private readonly ITaskRepository taskRepository;

        public TaskBusiness(ITaskRepository _taskRepository)
        {
            taskRepository = _taskRepository;
        }
        public string InsertTask(Task task)
        {
            int rowsAffected = this.taskRepository.InsertTask(task);
            
            if(rowsAffected > 0)
            {
                return "Zadatak je uspešno dodat!";
            }
            else
            {
                return "Neuspešno dodavanje zadatka!";
            }
        }
        public string ProjectManagerUpdateTask(Task task)
        {
            int rowsAffected = this.taskRepository.ProjectManagerUpdateTask(task);

            if (rowsAffected > 0)
            {
                return "Zadatak je uspešno ažuriran!";
            }
            else
            {
                return "Neuspešno ažuriranje zadatka!";
            }
        }

        public string TeamMemberUpdateTask(Task task)
        {
            int rowsAffected = this.taskRepository.TeamMemberUpdateTask(task);

            if (rowsAffected > 0)
            {
                return "Zadatak je uspešno ažuriran!";
            }
            else
            {
                return "Neuspešno ažuriranje zadatka!";
            }
        }
        public Task GetTask(int id)
        {
            return this.taskRepository.GetTask(id);
        }
    }
}
