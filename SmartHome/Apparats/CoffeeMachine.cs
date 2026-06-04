using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome.Apparats
{
    public class CoffeeMachine : Appliance, ISchedulable
    {
        public int CupsPerBrew { get; set; }

        public DateTime NextRun { get; set; }

        public void Schedule(DateTime time)
        {
            NextRun = time;
            Console.WriteLine($"{Brand} coffee machine is scheduled to start at {NextRun}");
        }

        public CoffeeMachine (string brand, string room, int cupsPerBrew) : base(brand, room)
        {
            CupsPerBrew = cupsPerBrew;
        }

        public override string GetInfo()
        {
            return $"{Brand} is in the {Room}";
        }

        public override void TurnOn()
        {
            IsOn = true ;
            Console.WriteLine($"{Brand} coffee machine is brewing.");
        }

        public override void TurnOff()
        {
            IsOn = false ;
            Console.WriteLine($"{Brand} coffee machine is done brewing. ");
        }

        public override double GetDailyEnergyUsage()
        {
            return 0.3;
        }
    }
}
