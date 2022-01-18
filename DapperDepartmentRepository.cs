using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BestBuyBestPractices
{
    public class DapperDepartmentRepository : IDepartmentRepository
    {
        private readonly IDbConnection _connection;

        public DapperDepartmentRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            // removed tolist
            return _connection.Query<Department>("SELECT * FROM Departments;");
        }


        public void CreateDepartment(string newDepartmentName)
        {
            _connection.Execute("INSERT INTO DEPARTMENTS (Name) VALUES (@departmentName);",
            new { departmentName = newDepartmentName });
        }
        
        public void UpdateDepartment(int Id, string newName)
        {
            _connection.Execute("UPDATE * DEPARTMENT ID AND PRODUCT;");
        }
    }
}


