using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome.Apparats
{
    public class PizzaOven : Oven
    {
        public PizzaOven(string brand, string room, int maxTemperature)
        : base(brand, room, maxTemperature)
        {
        } 

        //public override void TurnOn()
        //{
        //    Console.WriteLine("Pizza oven starts at extra high temperature.");
        //}
    }
}


//1.Vad säger kompilatorn? 
// Den meddelandet vi får säger att vi kan inte overrideia den methoden eftersom den är sealed i Oven klassen.

//2.Varför får PizzaOven inte override:a TurnOn()?
// Vi får inte overridea TurnOn() eftersom den är sealed i Oven klassen. Det betyder att ingen klass som
// kommer att ärva från Oven kan override denna metod.

//3.När kan det vara rimligt att använda sealed override?
// Det kan vara rimligt att använda sealed override när vi vill stoppa vidare ändringar av en metod i andra
// subklasser. 

//4.Vad kan PizzaOven fortfarande göra i stället? Kan den override:a någon annan metod?
// PizzaOven kan fortfarande overridea andra metoder som inte är sealed i Oven klassen, till exempel GetInfo eller GetDailyEnergyUsage.