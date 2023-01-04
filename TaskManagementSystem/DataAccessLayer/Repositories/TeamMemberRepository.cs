using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Shared.Models;

namespace DataAccessLayer.Repositories
{
    public class TeamMemberRepository : ITeamMemberRepository
    {
        string connectionString = Constants.ConnectionString;

        public List<Task> GetPersonalTasks(int teamMemberId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<Task> ListOfTasks = new List<Task>();
                string query = "SELECT * FROM Tasks WHERE team_member_id=@teamMemberId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@teamMemberId", teamMemberId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Task task = new Task();
                    task.Id = reader.GetInt32(0);
                    task.DateIssued = reader.GetDateTime(1);
                    task.DueDate = reader.GetDateTime(2);
                    task.ProjectManagerId = reader.GetInt32(3);
                    task.TeamMemberId = reader.GetInt32(4);
                    task.Title = reader.GetString(5);
                    task.IsCompleted = reader.GetBoolean(6);
                    task.Description = reader.GetString(7);
                    ListOfTasks.Add(task);
                }
                reader.Close();
                connection.Close();

                return ListOfTasks;
            }
        }
        public int UpdateSelf(TeamMember tm)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Team_Members SET phone_number=@phoneNumber, email=@email,password=@password WHERE id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@phoneNumber", tm.PhoneNumber);
                command.Parameters.AddWithValue("@email", tm.Email);
                command.Parameters.AddWithValue("@password", tm.Password);
                command.Parameters.AddWithValue("@id", tm.Id);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }
        public TeamMember GetTeamMember(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Team_Members WHERE email=@email AND password=@password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                connection.Open();
                TeamMember tm = new TeamMember();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tm.Id = reader.GetInt32(0);
                    tm.FirstName = reader.GetString(1);
                    tm.LastName = reader.GetString(2);
                    tm.PersonalNumber = reader.GetString(3);
                    tm.DateOfBirth = reader.GetDateTime(4);
                    tm.PlaceOfBirth = reader.GetString(5);
                    tm.DateEmployed = reader.GetDateTime(6);
                    tm.Email = reader.GetString(7);
                    tm.Password = reader.GetString(8);
                    tm.PhoneNumber = reader.GetString(9);
                    tm.CompletedTasks = reader.GetInt32(10);
                    tm.NotCompletedTasks = reader.GetInt32(11);
                    tm.HoursSpent = reader.GetDouble(12);
                }
                reader.Close();
                connection.Close();
                return tm;
            }
        }
    }
}
