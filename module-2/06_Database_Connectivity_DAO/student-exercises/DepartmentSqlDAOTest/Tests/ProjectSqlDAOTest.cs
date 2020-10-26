using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectOrganizer.DAL;
using ProjectOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Transactions;

namespace ProjectOrganizerTest
{
    [TestClass]
    public class ProjectSqlDAOTest
    {
        private TransactionScope transaction { get; set; }
        private string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = EmployeeDB; Integrated Security = True";

        [TestInitialize]
        public void Initialize()
        {
            transaction = new TransactionScope();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from department", connection);

                cmd = new SqlCommand("insert into department (name) values ('Test');", connection);
                cmd.ExecuteNonQuery();
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            transaction.Dispose();
        }
        [TestMethod]
        public void GetAllProjectsTest()
        {
            ProjectSqlDAO projectSqlDAO = new ProjectSqlDAO(connectionString);
            List<Project> projectsTest = (List<Project>)projectSqlDAO.GetAllProjects();
            Assert.AreEqual(6, projectsTest.Count);
        }
        [TestMethod]

        public void AssignEmployeeToProjectTest()
        {
            ProjectSqlDAO projectSqlDAO = new ProjectSqlDAO(connectionString);
            bool result = projectSqlDAO.RemoveEmployeeFromProject(2, 1);
            Assert.AreEqual(false, result);
        }
        [TestMethod]

        public void RemoveEmployeeToProjectTest()
        {
            ProjectSqlDAO projectSqlDAO = new ProjectSqlDAO(connectionString);
            bool result = projectSqlDAO.RemoveEmployeeFromProject(1, 1);
            Assert.AreEqual(false, result);
        }
        [TestMethod]


        public void CreateProjectTest()
        {
            ProjectSqlDAO projectSqlDAO = new ProjectSqlDAO(connectionString);
            Project project = new Project();
            project.Name = "test";
            project.StartDate = DateTime.Parse("2010-03-19");
            project.EndDate = DateTime.Parse("2011-03-19");
            Assert.AreEqual("test", project.Name);
        }
    }
}
