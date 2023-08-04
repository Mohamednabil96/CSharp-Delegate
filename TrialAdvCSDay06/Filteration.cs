using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialAdvCSDay06
{
    public static class Filteration
    {
        public static List<Employee> FilterPerDeptId(List<Employee> param)
        {
            List<Employee> result = new List<Employee>();
            foreach (var item in param)
            {
                if (item.DeptId == 10)
                {
                    result.Add(item);
                };
            }
            return result;
        }

        public static List<Employee> FilterPerSalary(List<Employee> param)
        {
            List<Employee> result = new List<Employee>();
            foreach (var item in param)
            {
                if (item.Salary > 5000)
                {
                    result.Add(item);
                };
            }
            return result;
        }

        public static List<Employee> FilterPerAge(List<Employee> param)
        {
            List<Employee> result = new List<Employee>();
            foreach (var item in param)
            {
                if (item.Age > 25)
                {
                    result.Add(item);
                };
            }
            return result;
        }

        public static List<Employee> FilterPerAny(List<Employee> param)
        {
            List<Employee> result = new List<Employee>();
            foreach (var item in param)
            {
                if (FilterType.PerDeptId(item))
                {
                    result.Add(item);
                };
            }
            return result;
        }

        // fn to be written once, and can  be applicable for any inputs

        public static List<Employee> FilterPerDelegate(List<Employee> param, MyDelegate1 del1)
        {
            List<Employee> result = new List<Employee>();
            foreach (var item in param)
            {
                if (del1(item))
                {
                    result.Add(item);
                };
            }
            return result;
        }

    }
}
