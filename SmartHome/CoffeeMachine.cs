using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class CoffeeMachine : Appliance
    {

        public int CupsPerBrew { get; set; }

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
