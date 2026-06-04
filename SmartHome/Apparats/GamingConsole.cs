using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome.Apparats
{
    public class GamingConsole : Appliance
    {
        public int RunTimeHours { get; set; }


        public GamingConsole(string brand, string room, int runHours) : base(brand, room)
        {
            RunTimeHours = runHours;
        }

        public override string GetInfo()
        {
            return $"{Brand} is in the {Room}";
        }

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} gaming console is starting up.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} gaming console is shutting down.");

        }

        public override double GetDailyEnergyUsage()
        {
            return 4.5;
        }
    }
    
}
