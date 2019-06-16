using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            EventHandlerClass obj = new EventHandlerClass();
            obj.myEvent += Obj_myEvent;

            Employee o1 = new Employee("Suraj", 10000, 10);
            Employee o2 = new Employee("Pradnya", 12000);
            Employee o3 = new Employee("Sarvesh");
            Employee o4 = new Employee();


            Console.WriteLine(o3.EmpNo + " " + o3.GetNetSalary());
            Console.WriteLine(o1.EmpNo + " " + o1.GetNetSalary());
            Console.WriteLine(o4.EmpNo + " " + o4.GetNetSalary());
            Console.WriteLine(o2.EmpNo + " " + o2.GetNetSalary());

            Console.ReadLine();


        }

        private static void Obj_myEvent()
        {
            Console.WriteLine("Event Occured!!");
        }
    }

    class Employee
    {
        private static int empNoSeed = 0;

        private int empNo;
        public int EmpNo
        {
            private set
            {
                empNo = value;
            }
            get
            {
                return empNo;
            }
        }
        private String name;
        private Decimal basic;
        private short deptNo;
        public String Name
        {
            set
            {
                if (value != "")
                    name = value;
                else
                {
                    name = "N/A";
                    throw new EmployeeException("Invalid name!");
                }
            }
            get
            {
                return name;
            }
        }

        public Decimal Basic
        {
            set
            {
                if (value >= 10000 && value <= 50000)
                    basic = value;
                else
                    throw new EmployeeException("Invalid Basic!");
            }
            get
            {
                return basic;
            }
        }


        public short DeptNo
        {
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    throw new EmployeeException("Invalid DeptNo");
            }
            get
            {
                return deptNo;
            }
        }


        public Employee(String name = "N/A", Decimal basic = 10000, short deptNo = 1)
        {
            this.empNo = ++empNoSeed;
            this.name = name;
            this.basic = basic;
            this.deptNo = deptNo;
        }


        //Methods
        public Decimal GetNetSalary()
        {
            return this.basic;
        }


        //public void MyEventHandler()
        //{
        //    Console.WriteLine("Event Occured!!");
        //}
    }


    public class EmployeeException : ApplicationException
    {
        private string message;


        public EmployeeException(string message):base(message)
        {
            this.message = message;
        }


    }

    public delegate void MyDelegate();

    public class EventHandlerClass
    {
        public event MyDelegate myEvent;
    }

}
