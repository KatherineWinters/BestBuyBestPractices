using System.Collections.Generic;

namespace BestBuyBestPractices
{
    internal interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
    }
}
