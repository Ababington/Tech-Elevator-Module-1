using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectOrganizer.DAL;
using ProjectOrganizer.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Transactions;

namespace EmployeeSqlDAOTest
{
    [TestClass]
    public class EmployeeSqlDAOTest
    {
        string ConnectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = EmployeeDB; Integrated Security = True";
        private TransactionScope tran { get; set; }

        int testEmployeeId = 0;
        int testEmployeeIdAssignedToProject = 0;
        int testDepartmentId = 0;
        int testProjectId = 0;

        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select count(*) from employee:", conn);

                cmd = new SqlCommand("insert into department (name) values ('Test');", conn);
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }


        public void GetAllEmployeesTest()
        {
            //Arrange
            EmployeeSqlDAO dao = new EmployeeSqlDAO(ConnectionString);

            //Act
            List<Employee> employees = (List<Employee>)dao.GetAllEmployees();


            //Assert
            Assert.AreEqual(12, employees.Count);
        }


        [TestMethod]
        public void SearchTest()
        {
            //Arrange
            EmployeeSqlDAO dao = new EmployeeSqlDAO(ConnectionString);

            //Act
            List<Employee> employees = (List<Employee>)dao.Search("Sid","Goodman");
         
            //Assert
            Assert.AreEqual(1, employees.Count);
        }

        [TestMethod]
        public void GetEmployeesWithoutProjectsTest()
        {
            //Arrange
            EmployeeSqlDAO dao = new EmployeeSqlDAO(ConnectionString);

            //Act
            List<Employee> employees = (List<Employee>)dao.GetEmployeesWithoutProjects();

            //Assert
            Assert.AreEqual(2, employees.Count);
            
        }
    }
}

