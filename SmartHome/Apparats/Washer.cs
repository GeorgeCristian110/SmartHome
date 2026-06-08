using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome.Apparats
{
    public class Washer : Appliance, ISchedulable
    {
        public int CapacityKg { get; set; }

        public DateTime NextRun { get;  set; }

        public Washer(string brand, string room, int capacityKg) : base (brand , room)
        {
            CapacityKg = capacityKg;
        }

        public void Schedule(DateTime time)
        {
            NextRun = time;
            Console.WriteLine($"{Brand} washer is scheduled to start washing at {NextRun}");
        }

        public override string GetInfo()
        {
            return $"{Brand} washer is in the {Room}";
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
