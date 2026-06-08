using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome.Apparats
{
    public class SmartLamp : Appliance
    {
        public int Brightness { get; set; }
        
        public SmartLamp(string brand, string room, int brightness)
        : base(brand, room)
        { 
            // Spara brightness. 
            Brightness = brightness;
        }

        public override string GetInfo()
        {
            return $"{Brand} lamp is in the {Room}";
        }
         
        public override void TurnOn()
        {
            // Skriv ut att lampan tänds. 
            IsOn = true;
            Console.WriteLine($"{Brand} lamp is turning on with brightness {Brightness}%");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} lamp is turning off");
        }

        public override double GetDailyEnergyUsage()
        {
            return 0.5;
        }
    }
}

//Frågor
//1.Blir utskriften samma? 
//  Nej, när man anropar TurnOn på lamp2 så kommer den att köra metoden i Appliance klassen och inte i SmartLamp klassen.

//2.Vilken metod körs när variabeln har typen SmartLamp? 
//  När variabeln har typen SmartLamp så kommer den att köra metoden TurnOn i SmartLamp klassen.

//3.Vilken metod körs när variabeln har typen Appliance? 
//  När variabeln har typen Appliance så kommer den att köra metoden TurnOn i Appliance klassen.

//4.  Varför är detta farligt eller förvirrande? 
//    Detta kan vara farligt eller förvirrande eftersom genom att använda new istället för override så
//    kommer det att leda till olika beteenden beroende på variabel samt svårare att underhålla och debugga.

//5.  Vad händer om du byter new till override?
//    Om jag byter new till override så kommer det att köra metoden i
//    SmartLamp klassen oavsett vilken typ av variabeln denna är och både resultaterna kommer bli samma.

// New keyworden kan man använda för att gömma en metod i basklassen medans override kan vi använda 
// för att påverka beteendet av en metod i child klassen som kommer leda till att den kör metoden oavsett vilken
// typ av variabeln är. 