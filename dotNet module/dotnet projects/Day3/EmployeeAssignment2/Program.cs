using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadLine();
        }
    }


    interface IDbFunctions
    {

    }

    abstract class Employee:IDbFunctions
    {
        protected static int empNoSeed = 0;

        protected int empNo;
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
        protected string name;
        protected decimal basic;
        protected short deptNo;
        public string Name
        {
            set
            {
                if (value != "")
                    name = value;
                else
                {
                    name = "N/A";
                    Console.WriteLine("Invalid name!");
                }
            }
            get
            {
                return name;
            }
        }

        public abstract decimal Basic
        {
            set;
            get;
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


        public Employee(string name = "N/A", decimal basic = 10000, short deptNo = 1)
        {
            empNo = ++empNoSeed;
            this.name = name;
            this.basic = basic;
            this.deptNo = deptNo;
        }


        //Methods
        public abstract decimal GetNetSalary();


    }

    class Manager : Employee,IDbFunctions
    {
        private string designation;

        public string Designation
        {
            set
            {
                if (value != "")
                    designation = value;
                else
                {
                    designation = "NULL";
                    Console.WriteLine("Invalid designation");
                }
            }
            get
            {
                return designation;
            }
        }

        public override decimal Basic
        {
            get {
                return basic;
            }
            set {
                if (value >= 50000 && value <= 500000)
                    basic = value;
                else
                {
                    basic = 50000;
                    Console.WriteLine("Invalid Basic!");
                }
            }
        }

        public Manager(string name = "N/A", decimal basic = 10000, short deptNo = 1,string designation=""):base(name,basic,deptNo)
        {
            this.designation = designation;
        }

        public override decimal GetNetSalary()
        {
            return Basic *(decimal)1.8;
        }



    }

    class Programmer : Employee,IDbFunctions
    {
        private string technologiesKnown;

        public string TechnologiesKnown
        {
            get
            {
                return technologiesKnown;
            }
            set
            {
                if (value != "")
                    technologiesKnown = value;
                else
                {
                    technologiesKnown = "NULL";
                    Console.WriteLine("Invalid Technology!y");
                }
            }
        }
        public override decimal Basic
        {
            get
            {
                return basic;
            }
            set
            {
                if (value >= 30000 && value <= 300000)
                    basic = value;

            }
        }

        public Programmer(string name = "N/A", decimal basic = 10000, short deptNo = 1,string technologiesKnown=""):base(name,basic,deptNo)
        {
            this.technologiesKnown = technologiesKnown;
        }

        public override decimal GetNetSalary()
        {
            return Basic*(decimal)1.6;
        }
    }

    class GeneralManager : Manager,IDbFunctions
    {
        public override decimal Basic {
            get {
                return basic;     
            }
            set {
                if (value >= 30000 && value <= 300000)
                    basic = value;
            }
        }

        public string AdditionalInformation { get; set; }


        public GeneralManager(string name = "N/A", decimal basic = 10000, short deptNo = 1,string designation="",string additionalInformation=""):base(name,basic,deptNo,designation)
        {
            this.AdditionalInformation = additionalInformation;
        }

        public override decimal GetNetSalary()
        {
            return Basic * (decimal)1.9;
        }
    }
}
