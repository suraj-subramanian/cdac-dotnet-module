using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAssignment1
{

    class Program
    {
        public static void Main()
        {
            Employee o1 = new Employee("Suraj", 10000, 10);
            Employee o2 = new Employee("Pradnya", 12000);
            Employee o3 = new Employee("Sarvesh");
            Employee o4 = new Employee();


            Console.WriteLine(o3.EmpNo+" "+o3.GetNetSalary());
            Console.WriteLine(o1.EmpNo + " " + o1.GetNetSalary());
            Console.WriteLine(o4.EmpNo + " " + o4.GetNetSalary());
            Console.WriteLine(o2.EmpNo + " " + o2.GetNetSalary());

            Console.ReadLine();

        }
    }

    class Employee
    {
        private static int empNoSeed=0;

        private int empNo;
        public int EmpNo {
            private set {
                empNo = value;
                  }
            get {
                return EmpNo1;
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
                else {
                    name = "N/A";
                    Console.WriteLine("Invalid name!");
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
                    Console.WriteLine("Invalid Basic!");
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
                    Console.WriteLine("Invalid DeptNo!");
            }
            get
            {
                return deptNo;
            }
        }

        public int EmpNo1 { get => empNo; set => empNo = value; }


        //public Employee()
        //{
        //    this.empNo = ++empNoSeed;
        //}

        //public Employee(String name)
        //{
        //    this.empNo = ++empNoSeed;
        //    this.name = name;
        //}

        //public Employee(String name,Decimal basic)
        //{
        //    this.empNo = ++empNoSeed;
        //    this.name = name;
        //    this.basic = basic;
        //}

        public Employee(String name="N/A",Decimal basic=10000,short deptNo=1)
        {
            this.EmpNo1 = ++empNoSeed;
            this.name = name;
            this.basic = basic;
            this.deptNo = deptNo;
        }


        //Methods
        public Decimal GetNetSalary()
        {
            return this.basic;
        }



    }

}
