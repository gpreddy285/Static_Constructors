using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latest
{
    public  class Employee
    {
        int EmpId;
        string EmpName;
        double Empsalary;
        static string company;
        public Employee(int EmpId, string EmpName, double Empsalary)
        {
           this. EmpId = EmpId;
            this.EmpName = EmpName;
           this. Empsalary = Empsalary;
        }
        static Employee()
        {
            company = "Microsoft";
        }
        public void EmpDisplay()
        {
            Console.WriteLine("Employee id is :"+EmpId);
            Console.WriteLine("Employee name is :" + EmpName);
            Console.WriteLine("Employee salary is :" + Empsalary);
        }
        public static void EmpCompany()
        {
            Console.WriteLine("Company name is :"+company);
        }
        public void hikesalary()
        {
            double hike = Empsalary * 0.1;
            double totalsalary = hike + Empsalary;
            
             Console.WriteLine("Total salary is :"+totalsalary);
        }
        
    }
}
