using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome.Apparats
{
    public class Oven : Appliance
    {

        public int MaxTemperature { get; set; }
        
        public Oven (string brand, string room, int maxTemperature) : base (brand, room)
        {
            MaxTemperature = maxTemperature;
        }

        public override string GetInfo()
        {
            return $"{Brand} oven is in the {Room}";
        }

        public sealed override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} oven is starting to heat up");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} oven is stopping to heat up ");
        }

        public override double GetDailyEnergyUsage()
        {
            return 2.5;
        }

    }
}
