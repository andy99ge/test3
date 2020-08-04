using System;

namespace myapp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var ts=DateTime.Now.ToString();

            Console.WriteLine("current imt is {0}",ts);



            var id=Guid.NewGuid().ToString("N");

            Console.WriteLine(id);
        }
    }
}
