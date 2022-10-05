using Microsoft.AspNetCore.Mvc;
using EmployeeApp.Models;

namespace EmployeeApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult GetEmployee()
        {
            List<Employee> liemployees = Employee.GetAllEmployee();
            return View(liemployees);
        }

        public IActionResult GetOneEmployee()
        {
            Employee employee1 = new Employee()
            {
                EmployeeId = 1004,
                FirstName = "siva",
                LastName = "Priya",
                Gender = "Female"
            };
            return View(employee1);
        }
        public IActionResult AddEmploye()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
       
    }
}
