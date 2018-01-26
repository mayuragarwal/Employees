using EmployeesDL;
using System.Collections.Generic;
using System.Web.Http;

namespace EmployeesService.Controllers
{
    public class EmployeesController : ApiController
    {
        IEmployeeFactory employeeFactory = new EmployeeFactory();

        public IEnumerable<Employee> Get()
        {
            return employeeFactory.GetEmployees();
        }
    }
}
