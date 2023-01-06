using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Shared.Models;

namespace DataAccessLayer.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        string connectionString = Constants.ConnectionString;
        public int InsertTask(Task task)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Tasks VALUES(@date_issued,@due_date,@project_manager_id,@team_member_id,@title,@is_completed,@description)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@date_issued", DateTime.Now);
                command.Parameters.AddWithValue("@due_date", task.DueDate);
                command.Parameters.AddWithValue("@project_manager_id", task.ProjectManagerId);
                command.Parameters.AddWithValue("@team_member_id", task.TeamMemberId);
                command.Parameters.AddWithValue("@title", task.Title);
                command.Parameters.AddWithValue("@is_completed", false);
                command.Parameters.AddWithValue("@description", task.Description);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }
        public int ProjectManagerUpdateTask(Task task)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Tasks SET due_date=@dueDate,title=@title,description=@description WHERE id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@dueDate", task.DueDate);
                command.Parameters.AddWithValue("@title", task.DueDate);
                command.Parameters.AddWithValue("@description", task.Description);
                command.Parameters.AddWithValue("@id", task.Id);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }

        public int TeamMemberUpdateTask(Task task)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Tasks SET is_completed=@isCompleted, hours_spent=@hours WHERE id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@isCompleted", task.IsCompleted);
                command.Parameters.AddWithValue("@hours", task.HoursSpent);
                command.Parameters.AddWithValue("@id", task.Id);

                query = "SELECT * FROM Team_Members WHERE id=@id";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", task.TeamMemberId);
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

                query = "UPDATE Team_Members SET completed_tasks=@completedTasks,not_completed_tasks=@notCompleted,hours_spent=@hours WHERE id=@id";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@completedTasks", tm.CompletedTasks + 1);
                command.Parameters.AddWithValue("@notCompleted", tm.NotCompletedTasks - 1);
                command.Parameters.AddWithValue("@hours", tm.HoursSpent + task.HoursSpent);
                command.Parameters.AddWithValue("@id", tm.Id);
                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }
        public Task GetTask(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Tasks WHERE id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                Task task = new Task();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    task.Id = reader.GetInt32(0);
                    task.DateIssued = reader.GetDateTime(1);
                    task.DueDate = reader.GetDateTime(2);
                    task.ProjectManagerId = reader.GetInt32(3);
                    task.TeamMemberId = reader.GetInt32(4);
                    task.Title = reader.GetString(5);
                    task.IsCompleted = reader.GetBoolean(6);
                    task.Description = reader.GetString(7);
                    task.HoursSpent = reader.GetDouble(8);
                }
                reader.Close();
                connection.Close();
                return task;
            }
        }
    }
}
