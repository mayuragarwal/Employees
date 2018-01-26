using System.Collections.Generic;

namespace EmployeesDL
{
    public interface IEmployeeFactory
    {
        IEnumerable<Employee> GetEmployees();
    }
}