using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shared.Models;

namespace DataAccessLayer.Repositories
{
    public interface ITaskRepository
    {
        int InsertTask(Task task);
        int ProjectManagerUpdateTask(Task task);
        int TeamMemberUpdateTask(Task task);
        Task GetTask(int id);
    }
}
