using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcyle's Implementation.");
        }

        public bool HasSideCar = true;

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle override.");
        }
    }
}
