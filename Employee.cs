using System.Reflection;

namespace EmployeeApp.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

   

    public static List<Employee> GetAllEmployee()
    {
        List<Employee> employees = new()
        {
            new Employee(){ EmployeeId =1001,FirstName="Banu",LastName="Priya",Gender="Female"},
            new Employee(){ EmployeeId =1002,FirstName="Divya",LastName="Bharathi",Gender="Female"},
            new Employee(){ EmployeeId =1003,FirstName="Deepika",LastName="sri",Gender="Female"},
            new Employee(){ EmployeeId =1003,FirstName="Bharathi",LastName="Arivu",Gender="Female"},
            new Employee(){ EmployeeId =1004,FirstName="siva",LastName="Priya",Gender="Female"},
        };
        return employees;
    }
        public static Employee GetEmpInfo()
        {
            Employee employee1 = new Employee()
            {
                EmployeeId = 1004,
                FirstName = "siva",
                LastName = "Priya",
                Gender = "Female"
            };
            return employee1;
        }

    }
}
