using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        string connectionString = Constants.ConnectionString;

        public List<ProjectManager> GetAllProjectManagers()
        {
            List<ProjectManager> ListOfProjectManagers = new List<ProjectManager>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Project_Managers";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ProjectManager pm = new ProjectManager();
                    pm.Id = reader.GetInt32(0);
                    pm.FirstName = reader.GetString(1);
                    pm.LastName = reader.GetString(2);
                    pm.Status = reader.GetBoolean(3);
                    pm.PersonalNumber = reader.GetString(4);
                    pm.PhoneNumber = reader.GetString(5);
                    pm.DateEmployed = reader.GetDateTime(6);
                    pm.Email = reader.GetString(7);
                    pm.Password = reader.GetString(8);
                    ListOfProjectManagers.Add(pm);
                }
                reader.Close();
                connection.Close();

                return ListOfProjectManagers;
            }
        }
        public int UpdateProjectManager(ProjectManager pm)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Project_Managers SET first_name=@firstName,last_name=@lastName,status=@status,personal_number=@personalNumber,phone_number=@phoneNumber,date_employed=@dateEmployed,email=@email,password=@password WHERE id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@firstName", pm.FirstName);
                command.Parameters.AddWithValue("@lastName", pm.LastName);
                command.Parameters.AddWithValue("@email", pm.Email);
                command.Parameters.AddWithValue("@password", pm.Password);
                command.Parameters.AddWithValue("@personalNumber", pm.PersonalNumber);
                command.Parameters.AddWithValue("@phoneNumber", pm.PhoneNumber);
                command.Parameters.AddWithValue("@dateEmployed", pm.DateEmployed);
                command.Parameters.AddWithValue("@status", pm.Status);
                command.Parameters.AddWithValue("@id", pm.Id);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;

            }
        }
        public int InsertProjectManager(ProjectManager pm)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Project_Managers (first_name,last_name,status,personal_number,phone_number,date_employed,email,password,admin_id) VALUES(@firstName,@lastName,1,@personalNumber,@phoneNumber,@dateEmployed,@email,@password,1)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@firstName", pm.FirstName);
                command.Parameters.AddWithValue("@lastName", pm.LastName);
                command.Parameters.AddWithValue("@email", pm.Email);
                command.Parameters.AddWithValue("@password", pm.Password);
                command.Parameters.AddWithValue("@personalNumber", pm.PersonalNumber);
                command.Parameters.AddWithValue("@phoneNumber", pm.PhoneNumber);
                command.Parameters.AddWithValue("@dateEmployed", pm.DateEmployed);
                command.Parameters.AddWithValue("@status", pm.Status);
                command.Parameters.AddWithValue("@id", pm.Id);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }
        public Admin GetAdmin(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Admins WHERE email=@email AND password=@password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                connection.Open();
                Admin admin = new Admin();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    admin.Id = reader.GetInt32(0);
                    admin.FirstName = reader.GetString(1);
                    admin.LastName = reader.GetString(2);
                    admin.Email = reader.GetString(3);
                    admin.Password = reader.GetString(4);
                }
                reader.Close();
                connection.Close();
                return admin;
            }
        }

        public int DeleteProjectManager(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Project_Managers WHERE id=@id";
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
