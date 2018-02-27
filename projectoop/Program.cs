using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectoop.inheritance;
using projectoop.poly;
namespace projectoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle a = new Circle();a.Draw();
            
            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
