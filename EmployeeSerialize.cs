using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace FifthDayAssesment
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        //public Employee(int id, string name, string gender, int age)
        //{
        //    this.Id = id;
        //    this.Name = name;
        //    this.Gender = gender;
        //    this.Age = age;
        //}

    }
    public class EmployeeSerialize
    {
        public void WriteEmployee()
        {
            
            XmlSerializer serialization = new XmlSerializer(typeof(Employee));
            Employee employee = new Employee { Id = 1, Name="Divya", Gender="Female", Age=25 };

            FileStream fs = new FileStream("C:\\Users\\YKG\\Employee.txt", FileMode.Create, FileAccess.Write);
            
            StreamWriter sw = new StreamWriter(fs);
            serialization.Serialize(sw,employee);
            fs.Close();
        }
        public void ReadEmployee()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            FileStream fs = new FileStream("C:\\Users\\YKG\\Employee.txt", FileMode.Open);
            Employee employee;
            employee = (Employee)serializer.Deserialize(fs);
            Console.WriteLine("Employee Id: {0} " , employee.Id);
            Console.WriteLine("Employee Name: {0} " , employee.Name);
            Console.WriteLine("Employee Gender: {0} ", employee.Gender);
            Console.WriteLine("Employee Age: {0} ", employee.Age);
        }
        public static void Main()
        {
            EmployeeSerialize emp = new EmployeeSerialize();
            emp.WriteEmployee();
            emp.ReadEmployee();
        }
    }
}
