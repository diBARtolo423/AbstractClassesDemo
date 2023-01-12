using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle() 
        {
        }

        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycles are cool");
        }

        public bool HasSideCart { get; set; } = false;
       
        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycles are faster");
        }
    }
}
