using SmartHome.Apparats;
using System.ComponentModel.Design;

namespace SmartHome
{
    public class Program
    {
        static void Main()
        {
            SmartHomeController controller = new SmartHomeController();            
            controller.AddDevice(new Washer("LG", "Loundry room", 7));
            controller.AddDevice(new Refrigerator("Samsung", "Kitchen", 3.4m));
            controller.AddDevice(new Oven("Electrolux", "Kitchen", 200));
            controller.AddDevice(new RobotVacuum("Xiaomi", "Living room", 100));
            controller.AddDevice(new CoffeeMachine("Bosch", "Kitchen", 8));
            controller.AddDevice(new GamingConsole("Sony", "Bedroom", 5));
            controller.PrintStatusReport();

            controller.ScheduleAllSchedulableDevices(DateTime.Now.AddHours(2));

            Console.WriteLine();

            controller.TurnOnAll();

            Console.WriteLine();

            double totalEnergy = controller.GetTotalDailyEnergyUsage();
            Console.WriteLine($"Total daily energy usage: {totalEnergy} kWh");

            Console.WriteLine();

            controller.TurnOffAll();
        }
    }
}

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


//public void ScheduleAllDevicesWrong(DateTime time)
//{
//    foreach (Appliance device in _devices)
//    {
//        device.Schedule(time);
//    }
// This wont work because Schedule is not defined in the Appliance class,
// and we are not allowed to use if/switch to check for specific classes.
//}


//1.Varför kan vi inte anropa Schedule() direkt på en variabel av typen Appliance? 
//  Eftersom Schedule() är inte definierad i Appliance klassen så kan vi inte anropa
//  den direkt på en variabel av typen Appliance.

//2.Varför fungerar det efter att vi castar till ISchedulable? 
// När vi castar till IScchedulable så vissar vi C# att detta objekt har de metoder som ISchedulable 
// kräver och då kan man anropa Schedule på den objektet.

//3.  Vad betyder det att RobotVacuum både är en Appliance och en ISchedulable? 
// Detta betyder att RobotVacuum är en subklass av Appliance och samtidgit kan den implementer
// interfacet. Då har den både enegnskaper och metoder från Appliance och det som interfacet kräver.

//4.Varför ska inte Schedule() ligga direkt i Appliance? 
// Vi ska ej tillägga den direkt i Appliance klassen eftersom inte alla aparater kan schemaläggas.
// Om vi skulle vilja göra det så måste vi göra alla aparater schemaläggbara.

//5.Vad är skillnaden mellan arv och interface i det här exemplet? 
// Arv använder vi för att dela de gemensama egenskaperna och metoderna mellan de olika apparaterna.
// Interface implementeras när vi vill att olika klasser ska ha en gemensam metod som andra klasser inte behöver.