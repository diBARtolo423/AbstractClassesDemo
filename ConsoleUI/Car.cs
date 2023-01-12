using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {

        }

        public override void DriveAbstract()
        {
            Console.WriteLine("Viper's are fast");
        }

        public bool HasTrunk { get; set; } = true;
    }

}
