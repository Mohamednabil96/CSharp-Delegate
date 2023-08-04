using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialAdvCSDay06
{
    public static class Repository
    {
        static List<Employee> employees;

        public static List<Employee> Employees
        {
            get
            {
                return new List<Employee>()
                {
                new Employee() { ID = 1, Name = "Mohamed", Age = 26, Salary = 1234, DeptId = 10 },
                new Employee() { ID = 2, Name = "Nabil", Age = 22, Salary = 1234, DeptId = 20 },
                new Employee() { ID = 3, Name = "Ahmed", Age = 24, Salary = 1234, DeptId = 30 },
                new Employee() { ID = 4, Name = "Sara", Age = 25, Salary = 1234, DeptId = 30 },
                new Employee() { ID = 5, Name = "Sherif", Age = 29, Salary = 3234, DeptId = 20 },
                new Employee() { ID = 6, Name = "Yasin", Age = 23, Salary = 8234, DeptId = 10 },
                new Employee() { ID = 7, Name = "Mazin", Age = 26, Salary = 6234, DeptId = 10 },
                new Employee() { ID = 8, Name = "Mona", Age = 28, Salary = 2234, DeptId = 20 },
                new Employee() { ID = 9, Name = "Hala", Age = 21, Salary = 7234, DeptId = 30 },
                new Employee() { ID = 10, Name = "Ali", Age = 20, Salary = 4234, DeptId = 10 },


                };
            }
        }
    }
}
