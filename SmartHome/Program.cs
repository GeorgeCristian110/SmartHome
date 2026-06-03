using System.ComponentModel.Design;

namespace SmartHome
{
    public class Program
    {
        static void Main()
        {
            List<Appliance> devices = new List<Appliance>();

            // Skapa minst fyra objekt: 
            // Washer, Refrigerator, Oven och RobotVacuum. 
            // Lägg till dem i listan devices. 
            Washer washer = new Washer("LG", "Loundry room", 7);
            devices.Add(washer);
            Refrigerator refrigerator = new Refrigerator("Samsung", "Kitchen", 3.4m);
            devices.Add(refrigerator);
            Oven oven = new Oven("Electrolux", "Kitchen", 200);
            devices.Add(oven);
            RobotVacuum robotVacuum = new RobotVacuum("Xiaomi", "Living room", 100);
            devices.Add(robotVacuum);
            CoffeeMachine coffeeMachine = new CoffeeMachine("Bosch", "Kitchen", 8);
            devices.Add(coffeeMachine);

            RunMorningRoutine(devices);

            Console.WriteLine();

            ReportAllEnergy(devices);
        }

        static void RunMorningRoutine(List<Appliance> devices)
        {
            foreach (Appliance device in devices)
            {
                Console.WriteLine(device.GetInfo());
                device.TurnOn();
                device.TurnOff();
                Console.WriteLine();
                
            }
        }

        static void ReportAllEnergy(List<Appliance> devices)
        {
            foreach (Appliance device in devices)
            {
                double totalEnergy = device.GetDailyEnergyUsage();

                Console.WriteLine($"{device.Brand} is consuming {totalEnergy} kwh per day");

            }
        }
    }
}

// 1. Kontrollera vilken typ device är. 
// 2. Casta till rätt typ. 
// 3. Anropa rätt energimetod.

// 1. Kontrollera vilken typ device är. 
// 2. Casta till rätt typ. 
// 3. Anropa rätt startmetod. 
// 4. Anropa rätt stoppmetod. 

//1.  Varför behövde du kontrollera vilken typ varje objekt hade? 
// Eftersom listan som vi har är av typen object så vet C# inte vilka metoder varje objekt har.
// Så då måste vi kontrollera deras typ och visa att objekten är en Washer och har en metod.

//2.  Vad händer om du lägger till en ny klass CoffeeMachine? 
// Om jag tillägger en nytt klass så måste jag addera den sen till listan och skapa ett till else if block 
// för varhe metod som vi använder.

//3.  Vilka metoder måste du ändra om du lägger till CoffeeMachine? 
// Jag måstre ändra både RunMorningRoutine and ReportAllEnergy.

//4.  Vad är problemet med att listan är List<object>? 
// Problemet med denna lista är att man vet inte vilken typ av objekt som den innehåller.
// På grund av detta så är man tvungen att kontrollera typen och sedan nämna objekten vid varje anvädning.

//5.  Vad händer om du råkar glömma en apparattyp i ReportAllEnergy()?
// Det händer ingenting i fallet att man använder programmet koden kommer köras utan errors. 
// När vi sedan får resulataten so kommer vi få allt förutom den glömda appareten.

// När jag lade till den behövde jag ändra båda metoderna och addera den i listan.