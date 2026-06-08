using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome.Apparats
{
    public class AirConditioner : Appliance, ISchedulable
    {

        public int TargetTemperature { get; set; }
        public DateTime NextRun { get; set ; }
        
        public AirConditioner(string brand, string room, int targetTemperature) : base(brand, room)
        {
            TargetTemperature = targetTemperature;
        }
        
        public void Schedule(DateTime time)
        {
            NextRun = time;
            Console.WriteLine($"{Brand} air conditioner scheduled for {time}");
        }

        public override string GetInfo()
        {
         return $"{Brand} air conditioner is in the {Room} and set to {TargetTemperature}°C";
        }

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} air conditioner is turned on.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} air conditioner is turned off.");
        }

        public override double GetDailyEnergyUsage()
        {
            return 6.9;
        }
    }
}
