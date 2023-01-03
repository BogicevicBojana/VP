using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ProjectManagerRepository : IProjectManagerRepository
    {
        string connectionString = Constants.ConnectionString;

        public List<TeamMember> GetAllTeamMembers()
        {
            List<TeamMember> ListOfTeamMembers = new List<TeamMember>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Team_Members";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TeamMember tm = new TeamMember();
                    tm.Id = reader.GetInt32(0);
                    tm.FirstName = reader.GetString(1);
                    tm.LastName = reader.GetString(2);
                    tm.PersonalNumber = reader.GetString(3);
                    tm.DateOfBirth = reader.GetDateTime(4);
                    tm.PlaceOfBirth = reader.GetString(5);
                    tm.DateEmployed = reader.GetDateTime(6);
                    tm.PhoneNumber = reader.GetString(9);
                    tm.CompletedTasks = reader.GetInt32(10);
                    tm.NotCompletedTasks = reader.GetInt32(11);
                    tm.HoursSpent = reader.GetDouble(12);
                    ListOfTeamMembers.Add(tm);
                }
                reader.Close();
                connection.Close();

                return ListOfTeamMembers;
            }
        }
        public int UpdateTeamMember(TeamMember tm)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Team_Members SET first_name=@firstName,last_name=@lastName,personal_number=@personalNumber,employment_date=@employmentDate,date_of_birth=@dob,place_of_birth=@pob,phone_number=@phoneNumber,completed_tasks=@completedTasks,not_completed_tasks=@notCompletedTasks, hours_spent=@hoursSpent WHERE id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@firstName", tm.FirstName);
                command.Parameters.AddWithValue("@lastName", tm.LastName);
                command.Parameters.AddWithValue("@personalNumber", tm.PersonalNumber);
                command.Parameters.AddWithValue("@employmentDate", tm.DateEmployed);
                command.Parameters.AddWithValue("@dob", tm.DateOfBirth);
                command.Parameters.AddWithValue("@pob", tm.PlaceOfBirth);
                command.Parameters.AddWithValue("@phoneNumber", tm.PhoneNumber);
                command.Parameters.AddWithValue("@completedTasks", tm.CompletedTasks);
                command.Parameters.AddWithValue("@notCompletedTasks", tm.NotCompletedTasks);
                command.Parameters.AddWithValue("@hoursSpent", tm.HoursSpent);
                command.Parameters.AddWithValue("@id", tm.Id);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }

        public int InsertTeamMember(TeamMember tm)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Team_Members (first_name,last_name,personal_number,date_of_birth,place_of_birth,employment_date,email,password,phone_number,completed_tasks,not_completed_tasks,hours_spent) VALUES(@firstName,@lastName,@personalNumber,@dob,@pob,@employed,@email,'Mypass123@',@phoneNumber,0,0,0)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@firstName", tm.FirstName);
                command.Parameters.AddWithValue("@lastName", tm.LastName);
                command.Parameters.AddWithValue("@personalNumber", tm.PersonalNumber);
                command.Parameters.AddWithValue("@employed", tm.DateEmployed);
                command.Parameters.AddWithValue("@dob", tm.DateOfBirth);
                command.Parameters.AddWithValue("@pob", tm.PlaceOfBirth);
                command.Parameters.AddWithValue("@email", tm.Email);
                command.Parameters.AddWithValue("@phoneNumber", tm.PhoneNumber);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }
        public ProjectManager GetProjectManager(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Project_Managers WHERE email=@email AND password=@password AND status=1";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                connection.Open();
                ProjectManager pm = new ProjectManager();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    pm.Id = reader.GetInt32(0);
                    pm.FirstName = reader.GetString(1);
                    pm.LastName = reader.GetString(2);
                    pm.Status = reader.GetBoolean(3);
                    pm.PersonalNumber = reader.GetString(4);
                    pm.PhoneNumber = reader.GetString(5);
                    pm.DateEmployed = reader.GetDateTime(6);
                    pm.Email = reader.GetString(7);
                    pm.Password = reader.GetString(8);
                }
                reader.Close();
                connection.Close();
                return pm;
            }
        }
        public int DeleteTeamMember(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Team_Members WHERE id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }
    }
}
