using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialAdvCSDay06
{
    public delegate bool MyDelegate1(Employee e1);

    public delegate void MyDelegate2(Employee item);

    public delegate int MyDelegate3(int left, int right);

    public delegate bool MyDelegate4<T>(T item);

    public delegate U MyDelegate5<in T, out U> (T item);

}