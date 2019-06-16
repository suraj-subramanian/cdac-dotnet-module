using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            ISuraj obj = new Test();
            obj.Insert();
            obj.Update();
            obj.Delete();

        }
    }


    public interface ISuraj
    {
        void Insert();
        void Update();
        void Delete();
    }

    public class Test : ISuraj
    {
        public void Delete()
        {
            Console.WriteLine("Test Delete");
        }

        public void Insert()
        {
            Console.WriteLine("Test Insert");
        }

        public void Update()
        {
            Console.WriteLine("Test Update");
        }
    }



}
