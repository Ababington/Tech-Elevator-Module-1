using ProjectOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProjectOrganizer.DAL
{
    public class DepartmentSqlDAO : IDepartmentDAO
    {
        private string connectionString;

        // Single Parameter Constructor
        public DepartmentSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        /// <summary>
        /// Returns a list of all of the departments.
        /// </summary>
        /// <returns></returns>
        public IList<Department> GetDepartments()
        {
            List<Department> output = new List<Department>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    string sqlText = "select * from department";

                    command.CommandText = sqlText;
                    command.Connection = connection;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Department department = new Department();
                        department.Id = Convert.ToInt32(reader["department_id"]);
                        department.Name = Convert.ToString(reader["name"]);

                        output.Add(department);
                    }
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
            return output;
        }

        /// <summary>
        /// Creates a new department.
        /// </summary>
        /// <param name="newDepartment">The department object.</param>
        /// <returns>The id of the new department (if successful).</returns>
        public int CreateDepartment(Department newDepartment)
        {
            List<Department> output = new List<Department>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    string sqlText = "insert into department values (@name);select SCOPE_IDENTITY();";

                    command.CommandText = sqlText;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@name", newDepartment.Name);

                    int newDepartmentId = Convert.ToInt32(command.ExecuteScalar());

                    return newDepartmentId; 
                }
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }

        }


        /// <summary>
        /// Updates an existing department.
        /// </summary>
        /// <param name="updatedDepartment">The department object.</param>
        /// <returns>True, if successful.</returns>
        public bool UpdateDepartment(Department updatedDepartment)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    string sqlText = ($"update department set name = '{updatedDepartment.Name}' where department_id = {updatedDepartment.Id};");

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
    }
}
