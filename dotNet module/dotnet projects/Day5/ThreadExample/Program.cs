using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread o1 = new Thread(new ThreadStart(Func1));
            Thread o2 = new Thread(Func2);
            o2.Priority = ThreadPriority.Lowest;
            o1.Start();
            o2.Start();

            o2.Abort();
            o1.Join();
            
            for (int i = 0; i < 100; i++)
                Console.WriteLine("Main()"+i);

            Console.ReadLine();

        }

        static void Func1()
        {
            for(int i=0;i<100;i++)
                Console.WriteLine("Func1()"+i);
        }

        static void Func2()
        {
            for (int i = 0; i < 100; i++)
                Console.WriteLine("Func2()"+i);
        }

    }
}
