using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstEmpTask
{
    class Program
    {
        static void Main(string[] args)
        {
             //InsertEmpData();
             //InsertDeptData();
            ShowData(); 
            //showddata methodd
        }
        
        private static void InsertEmpData()
        {
            EmployeeContext emp = new EmployeeContext();
            Console.WriteLine("Enter Employee ID:");
            int eid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            string ename = Console.ReadLine();
            Console.WriteLine("Enter Employee Designation:");
            string edesig = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary:");
            double esal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Department ID:");
            int did = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();

            Employee emp1 = new Employee { Eid = eid, Ename = ename, Edesig = edesig, Esal = esal, Did = did };
            emp.Employees.Add(emp1);
            emp.SaveChanges();
        }

        private static void InsertDeptData()
        {
            EmployeeContext EC = new EmployeeContext();
            Console.WriteLine("Enter Department ID:");
            int did = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Department Name:");
            string dname = Console.ReadLine();
            Console.WriteLine("Enter Department Location:");
            string edeloc = Console.ReadLine();
            Console.ReadKey();

            Department dept = new Department { Did = did, Dname = dname, Dlocation = edeloc };
            EC.Departments.Add(dept);
            EC.SaveChanges();
        }

        private static void ShowData()
        {
            EmployeeContext ec1 = new EmployeeContext();
            var emp1 = ec1.Employees;
            var emp2 = ec1.Departments;
            foreach (var pr in emp1 )
            {
                Console.Write("-----------------------------------------------------------\n");
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", pr.Eid, pr.Ename,pr.Edesig,pr.Esal,pr.Did);
            }
            foreach (var prd in emp2)
            {
                Console.Write("-----------------------------------------------------------\n");
                Console.WriteLine("{0}\t{1}\t{2}",prd.Did,prd.Dname,prd.Dlocation);
                Console.ReadKey();
            }
        }
    }
}
