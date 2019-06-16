using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void Main1(string[] args)
        {
            System.Console.WriteLine("Helloo");
            Console.ReadLine();
        }
    }

    class ClassA
    {
        private int p2;
        private int p3=55;  //read only property
        public int P1 { set; get; } //auto property
        public int P2   //p2 validation greater than 0
        {
            set
            {
                if (value > 0)
                    p2 = value;
                else
                    Console.WriteLine("Ivalid value");
            }
            get
            {
                return p2;
            }
        }

        public int P3
        {
            get
            {
                return p3;
            }
        }


        public static void Main()
        {
            ClassA a = new ClassA
            {
                P1 = 10,
                P2 = 20
            };
            Console.WriteLine("P1: "+a.P1);
            Console.WriteLine("P2: "+a.P2);
            Console.WriteLine("P3: "+a.P3);
            Console.ReadLine();
        }
    }

}
