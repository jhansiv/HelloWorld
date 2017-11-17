using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello World!!!");
            Console.ReadLine();

            ConsumeAPI objsync = new ConsumeAPI();
            objsync.GetData();
        }
    }
}
