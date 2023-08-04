namespace TrialAdvCSDay06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Repository
            var emps = Repository.Employees;

            //foreach (var emp in emps)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion

            #region Filteration V01
            //var filteredEmps = Filteration.FilterPerDeptId(emps);
            //filteredEmps= Filteration.FilterPerSalary(emps);
            //filteredEmps = Filteration.FilterPerAge(emps);

            //foreach (var item in filteredEmps)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Filteration V02
            //var filteredEmps = Filteration.FilterPerAny(emps);

            //foreach (var item in filteredEmps)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Delegate
            // Shr7 Eng. Tharwat...
            #endregion

            #region Delegate Declaration
            //MyDelegate1 del1 = new MyDelegate1(Trial.PerDeptId);
            //Employee e1 = new Employee { ID =1 , Name = "salah" , Age =22, Salary=5678, DeptId=20};
            //Console.WriteLine(Trial.PerDeptId(e1));
            //Console.WriteLine("======");
            //Console.WriteLine(del1(e1));

            ////////////////////////////////
            //Console.WriteLine("==========");
            //MyDelegate2 del2 = new MyDelegate2(Trial.PrintEmps);
            //Trial.PrintEmps(e1);
            //del2(e1);
            ///////////////////
            //Console.WriteLine("==========");
            //MyDelegate3 del3 = new MyDelegate3(Trial.Add);
            //Console.WriteLine(Trial.Add(11,22));
            //Console.WriteLine(del3(111, 222));
            #endregion

            #region Delegate Declaration Enhanced
            //MyDelegate1 del1 = new MyDelegate1(Trial.PerDeptId);
            //MyDelegate1 del2 = Trial.PerDeptId;

            //// Anonymus Function:
            //Employee e1 = new Employee { ID = 1, Name = "Nabil", Age=26, Salary=1234, DeptId=20 };
            //MyDelegate1 del1 = delegate (Employee e1)
            //{
            //    return e1.Salary > 1000;
            //};

            //MyDelegate1 del2 = delegate (Employee e1)
            //{
            //    return e1.Name.Contains("m");
            //};

            //MyDelegate4<Employee> del4 = Trial.PerDeptId;
            //MyDelegate4<Employee> del5 = delegate (Employee e1)
            //{
            //    return e1.Age > 25;
            //};

            //MyDelegate4<int> del6 = Trial.IsEven;
            //MyDelegate4<int> del7 = delegate (int e1)
            //{
            //    return e1 %2 !=0;
            //};

            //Console.WriteLine(del1(e1));
            //Console.WriteLine(del2(e1));

            #endregion

            #region lambda Expression [Anonymus Function] (i.p) =>{return body}
            ////(Employee e1) => { return e1.Age > 22; };

            //MyDelegate1 del1 = (Employee item) =>
            //{
            //    return item.Age > 25;
            //};

            //MyDelegate1 del2 = (item) => { return item.Salary > 5000; };

            //MyDelegate1 del3 = xyz => xyz.Salary > 5000; // last enhancement
            #endregion

            #region Filteration V03
            //MyDelegate1 del1 = FilterType.PerSalary;

            //del1 = abc => abc.DeptId == 30;

            //var filteredEmps = Filteration.FilterPerDelegate(emps,del1);
            //filteredEmps = Filteration.FilterPerDelegate(emps, ahmed => ahmed.Age >25 ) ;

            //foreach (var emp in filteredEmps)
            //{
            //    Console.WriteLine(emp);
            //}

            #endregion

            #region Built-in Delegates

            #region Predicate : poits fn takes 1 param generic and returns bool
            //Predicate<Employee> p1 = abc => abc.DeptId == 10;
            //Predicate<int> p2 = abc => abc%2 ==0;


            //Console.WriteLine(p1(new Employee { DeptId = 10 }));
            //Console.WriteLine(p2(22));
            #endregion

            #region Action :takes from 0 up to 16 generic params & return void
            //Action a1 = () => Console.WriteLine("Hello");
            //Action<Employee> a2 = a => Console.WriteLine(a);
            //Action<int, int, int> a3 = (x, y,z) => Console.WriteLine($"{x + y + z}");

            //Employee e1 = new Employee { ID = 1, Name = "Nabil", Age=26, Salary=1234, DeptId=20 };

            //a1();
            //a1.Invoke();

            //a2(e1 );
            //a2.Invoke(e1);


            //a3(11, 22, 33);
            //a3.Invoke(11, 22, 33);

            #endregion


            #region Func : takes from 0 up to 16 generic params and return generic DT
            //Func<int> f1 = () => 22;
            //Func<int,int,int> f2 = (s,t) => s+t;
            //Func<int, int,string> f3 = (a,b) => $"{a+b}";
            //Func<Employee, bool> predicate1 = e => e.Salary > 3000;
            //Func<Employee, Employee, bool> f5 = (e1,e2) => e1.Salary> e2.Salary;

            //Console.WriteLine(f5(emps[0], emps[2]));
            //Console.WriteLine(f5.Invoke(emps[1], emps[2]));

            #endregion

            #region List of integers
            var nums = new List<int>() { 1,2,3,4,5,3,3,2,5,6,7,6,4,33,33,55,77};

            List<int> evenNums = nums.FindAll(x => x %2 !=0);

            nums.RemoveAll(e => e %2 == 0);

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
            #endregion

            #endregion
        }
    }
}