using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectOrganizer.DAL;
using ProjectOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Transactions;

namespace DepartmentSqlDAOTest
{
    [TestClass]
    public class DepartmentSqlDAOTest
    {

        string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = EmployeeDB; Integrated Security = True";

        private TransactionScope tran { get; set; }
        int departmentId = 0;

        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sqlTestDepartment = "insert into department values('Test Department'); select SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(sqlTestDepartment, conn);
                departmentId = Convert.ToInt32(cmd.ExecuteScalar());
                
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod]
        public void GetDepartmentsTest()

        {
            //Arrange

            DepartmentSqlDAO dao = new DepartmentSqlDAO(connectionString);

            //Act

            IList<Department> result = (List<Department>)dao.GetDepartments();

            //Assert

            int startCount = GetRowCount("department");

            Assert.IsTrue(result.Count >= startCount);

        }

        [TestMethod]

        public void CreateDepartmentTest()
        {
            //Arrange
            int originalCount = GetCountOfDepartments();
            Department newDept = new Department
            {
                Name = "New Department"
            };
            DepartmentSqlDAO dao = new DepartmentSqlDAO(connectionString);

            //Act
            int result = dao.CreateDepartment(newDept);

            //Assert 
            Assert.AreEqual(originalCount + 1, GetCountOfDepartments());

        }

        [TestMethod]

        public void UpdateDepartmentTest()
        {
            //Arrange
            Department updatedDepartment = new Department

            {
                Id = departmentId,
                Name = "Updated Department"
            };
            DepartmentSqlDAO dao = new DepartmentSqlDAO(connectionString);

            //Act
            bool result = dao.UpdateDepartment(updatedDepartment);

            //Assert
            Assert.IsTrue(result);
        }

        private int GetCountOfDepartments()
        {
            int counts = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sqlTestGetCount = "select count(*) from department";
                SqlCommand cmd = new SqlCommand(sqlTestGetCount, conn);
                counts = (int)cmd.ExecuteScalar();
            }
            return counts;
        }

        private int GetRowCount(string tenet)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand($"select count(*) from {tenet}", conn);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count;
            }
        }

    }
}

