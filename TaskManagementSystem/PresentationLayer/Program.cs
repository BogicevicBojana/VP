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

            var services = new ServiceCollection();
            ConfigureServices(services);


            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form = serviceProvider.GetRequiredService<Forms.LoginForm>();
                Application.Run(form);
            }
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

            services.AddScoped<Forms.LoginForm>();
        }
    }
}
