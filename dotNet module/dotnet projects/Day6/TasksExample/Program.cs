using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action action =Fun1;
            //Task t1 = new Task(action);
            //t1.Start();

            
            Action<int> a = Fun1;
            Task t1 = new Task(a));




            Console.ReadLine();
        }


        static void Fun1(int x)
        {
            for(int i=0;i<10;i++)
                Console.WriteLine("Fun1 "+x);
        }
    }
}
