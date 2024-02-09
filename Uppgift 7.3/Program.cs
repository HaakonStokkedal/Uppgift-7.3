using System.Collections.Generic;
namespace Uppgift_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> storlekar = new Dictionary<string, int>();
            storlekar["Sverige"] = 45000000;
            storlekar["Norge"] = 38500000;
            storlekar["Danmark"] = 4300000;
            storlekar["Finland"] = 33800000;

            Console.WriteLine("Skriv in namnet på något av fäljande länder för att få fram dess area:");
            Console.WriteLine("Sverige, Norge, Danmark och Finland");
            string val = Console.ReadLine();
            Console.WriteLine($"Storleken av {val} är {storlekar[val]} km^2.");

            Console.ReadKey();
        } 
    }
}