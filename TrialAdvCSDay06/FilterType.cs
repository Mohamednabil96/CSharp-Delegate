using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialAdvCSDay06
{
    public static class FilterType
    {
        public static bool PerSalary(Employee item)
        {
            return item.Salary > 4000;
        } 

        public static  bool PerDeptId(Employee item)
        {
            return item.DeptId == 20;
        }

        public static bool PerName(Employee item)
        {
            return item.Name.ToLower().Contains("m");
        }
    }
}
