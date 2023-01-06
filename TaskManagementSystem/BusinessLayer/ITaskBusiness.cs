using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shared.Models;

namespace BusinessLayer
{
    public interface ITaskBusiness
    {
        string InsertTask(Task task);
        string ProjectManagerUpdateTask(Task task);
        string TeamMemberUpdateTask(Task task);
        Task GetTask(int id);
    }
}
