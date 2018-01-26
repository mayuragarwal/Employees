using System.Collections.Generic;
using System.Linq;

namespace EmployeesDL
{
    public class EmployeeFactory : IEmployeeFactory
    {
        public IEnumerable<Employee> GetEmployees()
        {
            using (var entities = new EmployeeDBEntities())
            {
                return entities.Employees.ToList();
            }
        }
    }
}
