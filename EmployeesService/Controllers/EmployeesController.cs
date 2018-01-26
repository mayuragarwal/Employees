using EmployeesDL;
using System.Collections.Generic;
using System.Web.Http;

namespace EmployeesService.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            var employeeFactory = new EmployeeFactory();
                return employeeFactory.GetEmployees();
            
        }
    }
}
