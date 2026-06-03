using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class RobotVacuum : Appliance
    {

        public int BatteryLevel { get; set; }
       
        public RobotVacuum(string brand, string room, int batterylevel) : base (brand , room)
        {
            BatteryLevel = batterylevel;
        }

        public override string GetInfo()
        {
            return $"{Brand} is in the {Room}";
        }

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} robot starts vacuuming. ");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} robot stops vacuuming");
        }

        public override double GetDailyEnergyUsage()
        {
            return 0.4;
        }

    }
}
