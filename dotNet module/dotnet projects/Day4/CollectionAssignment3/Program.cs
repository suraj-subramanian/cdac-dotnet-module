using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment3
{
    class Program
    {
        static void Main1()
        {
            Student[] arr = new Student[2];

            arr[0].RollNo = 1;
            arr[0].Name = "Jack";
            arr[0].Subject1 = 55;
            arr[0].Subject2 = 80;

            arr[1].RollNo = 2;
            arr[1].Name = "Jones";
            arr[1].Subject1 = 59;
            arr[1].Subject2 = 87;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Roll no: "+ arr[i].RollNo);
                Console.WriteLine("Name: " + arr[i].Name);
                Console.WriteLine("Subject1 : " + arr[i].Subject1);
                Console.WriteLine("Subject2 : " + arr[i].Subject2);
            }

            Console.ReadLine();
        }

        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Suraj", 88, 99));
            students.Add(new Student(2, "Jack", 98, 79));

            foreach(Student s in students)
            {
                Console.WriteLine(s.RollNo);
                Console.WriteLine(s.Name);
                Console.WriteLine(s.Subject1);
                Console.WriteLine(s.Subject2);
            }



            Console.WriteLine("Enter roll no to delete:");
            int del_no = Convert.ToInt32(Console.ReadLine());

            Student temp = null;
            foreach(Student s in students)
            {
                if (s.RollNo == del_no)
                {
                    temp = s;
                    break;
                }
                   
            }

            if(temp!=null)
                students.Remove(temp);
            else
                Console.WriteLine("Student not Found!");
 

            foreach (Student s in students)
            {
                Console.WriteLine(s.RollNo);
                Console.WriteLine(s.Name);
                Console.WriteLine(s.Subject1);
                Console.WriteLine(s.Subject2);
            }


            Console.ReadLine();

        }
    }

    public class Student
    {
        private int rollNo;
        private string name;
        private decimal subject1;
        private decimal subject2;

        public int RollNo
        {
            get
            {
                return rollNo;
            }
            set
            {
                if (value > 0)
                    rollNo = value;
                else
                {
                    Console.WriteLine("Invalid Roll no.");
                }
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                    name = value;
                else
                {
                    Console.WriteLine("Invalid Name");
                }
            }
        }

        public decimal Subject1
        {
            get
            {
                return subject1;
            }
            set
            {
                if (value >= 0 && value <= 100)
                    subject1 = value;
                else
                    Console.WriteLine("Invalid Subject1");
            }
        }

        public decimal Subject2
        {
            get
            {
                return subject2;
            }
            set
            {
                if (value >= 0 && value <= 100)
                    subject2 = value;
                else
                    Console.WriteLine("Invalid Subject2");
            }
        }

        public Student(int rollNo = 0,string name = "",decimal subject1 = 0,decimal subject2 = 0)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.subject1 = subject1;
            this.subject2 = subject2;
        }


        public decimal GetPercentage()
        {
            return (Subject1 + Subject2 / 200) * 100;
        }
    }
}
