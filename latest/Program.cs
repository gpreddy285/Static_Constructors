using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latest
{
    //class student
    //{
    //    int sid;
    //    string sname;
    //    static string college;

    //    public student(int sid, string sname)
    //    {
    //        this.sid = sid;
    //        this.sname = sname;
    //    }
    //    static student()
    //    {
    //        college = "Andhra University";
    //    }
    //    public void studentdisplay()
    //    {
    //        Console.WriteLine("Student id is :" + sid);
    //        Console.WriteLine("Student name is :" + sname);
    //    }
    //    public static void collegedisplay()
    //    {
    //        Console.WriteLine("College name is :" + college);
    //    }

    //}


    internal class Program
    {
        static void Main(string[] args)
        {
            //student sn = new student(332, "prasad");
            //sn.studentdisplay();
            //student.collegedisplay();Emp
            //Employee emp1 = new Employee(332,"prasad",120000);
            //emp1.EmpDisplay();
            //Employee.EmpCompany();
            //emp1.hikesalary();
            //Bank bn = new Bank();
            //bn.Deposit(3000);
            //bn.Withdraw(1000);
            //double result = bn.Getbalance();
            //Console.WriteLine("Total Balance Is :" + result);
            BankEx be = new BankEx();
            be.Deposit(10000);
            be.Withdraw(1234, 6500);
            double result1 = be.totalbalance();
            Console.WriteLine("Total Balance in your account is :" + result1);



        }
    }
}
