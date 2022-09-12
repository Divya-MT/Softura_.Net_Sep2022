using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthDayAssesment
{
    public interface IBonus
    {
        public decimal SalesMarkBonus(decimal Salary);
        public decimal ProductionBonus(decimal Salary);
    }
    public class Bonus : IBonus
    {
        public decimal SalesMarkBonus(decimal Salary)
        {
            return (Salary * 20) / 100;

        }
        public decimal ProductionBonus(decimal Salary)
        {
            return (Salary * 10) / 100;

        }


    }
    public abstract class EmployeeAbstract
    {
        public abstract int EmployeID { get; set; }
        public abstract string EmployeeName { get; set; }
        public abstract string Gender { get; set; }
        public abstract int YearsOfExperience { get; set; }
        public abstract decimal Salary { get; set; }
        public abstract string Department { get; set; }
        public abstract decimal EmpBounus { get; set; }


    }
    public class EmployeeDetails : EmployeeAbstract
    {
        public int empId;
        public string name;
        public string gender;
        public int experience;
        public decimal salary;
        public string department;
        public decimal empBonus;

        public override int EmployeID
        {
            get
            {
                return empId;
            }
            set
            {
                empId = value;
            }
        }
        public override string EmployeeName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;

            }
        }
        public override string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;

            }
        }
        public override int YearsOfExperience
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;

            }
        }
        public override decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;

            }
        }
        public override string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;

            }
        }
        public override decimal EmpBounus
        {
            get
            {
                return empBonus;
            }
            set
            {
                empBonus = value;

            }
        }

    }
    public class EmployeePrint
    {
        public static void Main()
        {
            EmployeeDetails employeeDetails = new EmployeeDetails();
            Console.WriteLine("Enter Employe ID:");
            employeeDetails.empId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            employeeDetails.name = Console.ReadLine();
            Console.WriteLine("Enter Employee Gender:");
            employeeDetails.gender = Console.ReadLine();
            Console.WriteLine("Enter Employee Year Of Experience:");
            employeeDetails.experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Salary:");
            employeeDetails.salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Employee DepartMent:");
            employeeDetails.department = Console.ReadLine();
            IBonus bonus = new Bonus();
            if (employeeDetails.department.ToLower().Contains("sales"))
            {
                employeeDetails.empBonus = bonus.SalesMarkBonus(employeeDetails.salary);
            }
            else if (employeeDetails.department.ToLower().Contains("production"))
            {
                employeeDetails.empBonus = bonus.ProductionBonus(employeeDetails.salary);
            }

            //Print statements
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Id : {0}", employeeDetails.empId);
            Console.WriteLine("Name : {0}", employeeDetails.name);
            Console.WriteLine("Gender : {0}", employeeDetails.gender);
            Console.WriteLine("Experience : {0}", employeeDetails.experience);
            Console.WriteLine("Department : {0}", employeeDetails.department);
            Console.WriteLine("Salary : {0}", employeeDetails.salary);
            Console.WriteLine("Bonus : {0}", employeeDetails.empBonus);
        }

    }

}
