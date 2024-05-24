using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    public class Demo
    {
        public void print1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void print2()
        {
            for (int i = 11; i <= 20; i++)
            {
                Console.WriteLine(i);

            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            Thread t1 = new Thread(new ThreadStart(demo.print1)); //deletegates 
            Thread t2 = new Thread(new ThreadStart(demo.print2));
            t1.Start();
            t2.Start();

        }
    }
}
