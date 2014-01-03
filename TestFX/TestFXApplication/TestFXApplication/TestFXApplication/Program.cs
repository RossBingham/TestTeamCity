using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFXApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( TestFX.TestFXResource.GetTestFxResourceString());
            Console.WriteLine( "Press any key to continue. ");
            Console.ReadKey();
        }
    }
}
