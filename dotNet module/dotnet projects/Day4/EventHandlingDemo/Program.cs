using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlingDemo
{
    //step1:create a delegate class having the same signature as the event handler
    //Event handler always has void return type
    public delegate void InvalidValueEventHandler();

    class Program
    {
       
        static void Main(string[] args)
        {
            int value;
            value = Convert.ToInt32( Console.ReadLine());

            MyEventHandler obj = new MyEventHandler();
            //InvalidValueEventHandler Del1 = new InvalidValueEventHandler(Obj_InvalidValue);
            //Del1 += new InvalidValueEventHandler(InvalidValue);

            obj.InvalidValue += Obj_InvalidValue1;
            obj.InvalidValue += Obj_InvalidValue2;



            if (value > 0)
                Console.WriteLine("All OK!");
            //else
            //    InvalidValue;


            Console.ReadLine();
        }

        private static void Obj_InvalidValue1()
        {
            Console.WriteLine("Event 1 Occured!!");
        }

        public static void Obj_InvalidValue2()
        {
            Console.WriteLine("Event 2 Occured!!");
        }
    }



    //public class MyEventHandler
    public class MyEventHandler
    {
        public event InvalidValueEventHandler InvalidValue;

    }

}
