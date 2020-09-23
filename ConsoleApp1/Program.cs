using System;
using System.Linq;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestAttribute();
            Console.WriteLine("Hello World!");
        }

        static void TestAttribute()
        {
            var types = from t in Assembly.GetExecutingAssembly().GetTypes()
                        where
t.GetCustomAttributes<SampleAttribute>().Count() > 0
                        select t;
            foreach(var t in types)
            {
                Console.WriteLine(t.Name);
            }
        }
    }
}
