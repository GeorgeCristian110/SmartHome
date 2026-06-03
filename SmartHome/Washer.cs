using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class Washer : Appliance
    {
        public int CapacityKg { get; set; }
        
        public Washer(string brand, string room, int capacityKg) : base (brand , room)
        {
            CapacityKg = capacityKg;
        }

        public override string GetInfo()
        {
            return $"{Brand} is in the {Room}";
        }

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} starts washing. ");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} stops washing");
        }

        public override double GetDailyEnergyUsage()
        {
            return 1.2;
        }
    }
}
