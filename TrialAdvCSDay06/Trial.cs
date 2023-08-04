using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialAdvCSDay06
{
    public static class Trial
    {
        public static bool PerSalary(Employee item)
        {
            return item.Salary > 4000;
        }

        public static bool PerDeptId(Employee item)
        {
            return item.DeptId == 20;
        }

        public static void PrintEmps (Employee item)
        {
            Console.WriteLine(item);
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static bool IsEven (int item)
        {
            return item%2 ==0;
        }
    }
}
