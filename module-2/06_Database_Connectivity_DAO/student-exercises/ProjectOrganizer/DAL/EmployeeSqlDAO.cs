using ProjectOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrganizer.DAL
{
    public class EmployeeSqlDAO : IEmployeeDAO
    {
        private string connectionString;

        // Single Parameter Constructor
        public EmployeeSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        /// <summary>
        /// Returns a list of all of the employees.
        /// </summary>
        /// <returns>A list of all employees.</returns>
        public IList<Employee> GetAllEmployees()
        {
            List<Employee> output = new List<Employee>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    string sqlText = "select * from employee";

                    cmd.CommandText = sqlText;
                    cmd.Connection = conn;

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Employee employee = new Employee();

                        employee.EmployeeId = Convert.ToInt32(reader["employee_id"]);
                        employee.DepartmentId = Convert.ToInt32(reader["department_id"]);
                        employee.FirstName = Convert.ToString(reader["first_name"]);
                        employee.LastName = Convert.ToString(reader["last_name"]);
                        employee.JobTitle = Convert.ToString(reader["job_title"]);
                        employee.BirthDate = Convert.ToDateTime(reader["birth_date"]);
                        employee.Gender = Convert.ToString(reader["gender"]);
                        employee.HireDate = Convert.ToDateTime(reader["hire_date"]);

                        output.Add(employee);
                    }
                }
                return output;

            }
            catch
            {
                throw new NotImplementedException();
            }
        }



        /// <summary>
        /// Searches the system for an employee by first name or last name.
        /// </summary>
        /// <remarks>The search performed is a wildcard search.</remarks>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <returns>A list of employees that match the search.</returns>
        public IList<Employee> Search(string firstname, string lastname)
        {
            List<Employee> output2 = new List<Employee>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    string sqlText = ($"select * from employee where first_name = '{firstname}' and last_name = '{lastname}';");

                    command.CommandText = sqlText;
                    command.Connection = connection;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Employee employee = new Employee();

                        employee.EmployeeId = Convert.ToInt32(reader["employee_id"]);
                        employee.DepartmentId = Convert.ToInt32(reader["department_id"]);
                        employee.FirstName = Convert.ToString(reader["first_name"]);
                        employee.LastName = Convert.ToString(reader["last_name"]);
                        employee.JobTitle = Convert.ToString(reader["job_title"]);
                        employee.BirthDate = Convert.ToDateTime(reader["birth_date"]);
                        employee.Gender = Convert.ToString(reader["gender"]);
                        employee.HireDate = Convert.ToDateTime(reader["hire_date"]);

                        output2.Add(employee);
                    }
                }
                return output2;

            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets a list of employees who are not assigned to any active projects.
        /// </summary>
        /// <returns></returns>
        public IList<Employee> GetEmployeesWithoutProjects()
        {
            List<Employee> output3 = new List<Employee>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    string sqlText = ($"select * from employee where employee_id not in (select employee_id from project_employee);");


                    command.CommandText = sqlText;
                    command.Connection = connection;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Employee employee = new Employee();

                        employee.EmployeeId = Convert.ToInt32(reader["employee_id"]);
                        employee.DepartmentId = Convert.ToInt32(reader["department_id"]);
                        employee.FirstName = Convert.ToString(reader["first_name"]);
                        employee.LastName = Convert.ToString(reader["last_name"]);
                        employee.JobTitle = Convert.ToString(reader["job_title"]);
                        employee.BirthDate = Convert.ToDateTime(reader["birth_date"]);
                        employee.Gender = Convert.ToString(reader["gender"]);
                        employee.HireDate = Convert.ToDateTime(reader["hire_date"]);

                        output3.Add(employee);
                    }
                }
                return output3;

            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
