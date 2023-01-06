using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using DataAccessLayer.Repositories;
using BusinessLayer;

namespace PresentationLayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.LoginForm());
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IProjectManagerRepository, ProjectManagerRepository>();
            services.AddScoped<ITeamMemberRepository, TeamMemberRepository>();
            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddScoped<IAdminBusiness, AdminBusiness>();
            services.AddScoped<IProjectManagerBusiness, ProjectManagerBusiness>();
            services.AddScoped<ITeamMemberBusiness, TeamMemberBusiness>();
            services.AddScoped<ITaskBusiness, TaskBusiness>();
        }
    }
}
