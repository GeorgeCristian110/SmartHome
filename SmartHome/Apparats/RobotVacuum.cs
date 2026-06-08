using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome.Apparats
{
    public class RobotVacuum : Appliance, ISchedulable 
    {
        public int BatteryLevel { get; set; }

        public DateTime NextRun { get;  set; }

        public void Schedule(DateTime time)
        {
            NextRun = time;
            Console.WriteLine($"{Brand} robot vacuum is scheduled to run at {NextRun}");
        }

        public RobotVacuum(string brand, string room, int batterylevel) : base (brand , room)
        {
            BatteryLevel = batterylevel;
        }

        public override string GetInfo()
        {
            return $"{Brand} robot vacuum is in the {Room}";
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
