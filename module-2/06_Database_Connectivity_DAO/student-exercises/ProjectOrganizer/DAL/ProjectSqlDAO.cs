using ProjectOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrganizer.DAL
{
    public class ProjectSqlDAO : IProjectDAO
    {
        private string connectionString;

        // Single Parameter Constructor
        public ProjectSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        /// <summary>
        /// Returns all projects.
        /// </summary>
        /// <returns></returns>
        public IList<Project> GetAllProjects()
        {
            List<Project> output = new List<Project>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    string sqlText = "select * from project";

                    command.CommandText = sqlText;
                    command.Connection = connection;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Project project = new Project();
                        project.ProjectId = Convert.ToInt32(reader["project_id"]);
                        project.Name = Convert.ToString(reader["name"]);
                        project.StartDate = Convert.ToDateTime(reader["from_date"]);
                        project.EndDate = Convert.ToDateTime(reader["to_date"]);

                        output.Add(project);
                    }
                }
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
            return output;


        }

        /// <summary>
        /// Assigns an employee to a project using their IDs.
        /// </summary>
        /// <param name="projectId">The project's id.</param>
        /// <param name="employeeId">The employee's id.</param>
        /// <returns>If it was successful.</returns>
        public bool AssignEmployeeToProject(int projectId, int employeeId)
        {
            List<Project> projects = new List<Project>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(@"insert into project_employee(project_id, employee_id) values (@projectId, @employeeId);", connection);
                    command.Parameters.AddWithValue("@projectId", projectId);
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                   
                    int rowsEffected = command.ExecuteNonQuery();

                    return (rowsEffected > 0);
                }
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Removes an employee from a project.
        /// </summary>
        /// <param name="projectId">The project's id.</param>
        /// <param name="employeeId">The employee's id.</param>
        /// <returns>If it was successful.</returns>
        public bool RemoveEmployeeFromProject(int projectId, int employeeId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    string sqlText = ($"delete from project_employee where project_id = {projectId} and employee_id = {employeeId};");
                    command.Parameters.AddWithValue("@projectId", projectId);
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    command.CommandText = sqlText;
                    command.Connection = connection;

                    int rowsEffected = command.ExecuteNonQuery();

                    return (rowsEffected > 0);
                }
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Creates a new project.
        /// </summary>
        /// <param name="newProject">The new project object.</param>
        /// <returns>The new id of the project.</returns>
        public int CreateProject(Project newProject)
        {
            List<Department> output = new List<Department>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    string sqlText = "insert into project (project_id, name, from_date, to_date) values (@project_id, @name, @fromDate, @toDate);";

                    command.CommandText = sqlText;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@project_id", newProject.ProjectId);
                    command.Parameters.AddWithValue("@name", newProject.Name);
                    command.Parameters.AddWithValue("@fromDate", newProject.StartDate);
                    command.Parameters.AddWithValue("@toDate", newProject.EndDate);


                    return newProject.ProjectId;
                }
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }

        }
    }
}

