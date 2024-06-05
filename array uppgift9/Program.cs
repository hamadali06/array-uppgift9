using System;

namespace Inlamning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namn = new List<string>();
            while (true)
            {
                Console.WriteLine("Skriv in ett namn eller tryck på den knappen som kallas tror jag enter:");
                string inNamn = Console.ReadLine();
                if (string.IsNullOrEmpty(inNamn)) break;
                namn.Add(inNamn);
            }
            Console.WriteLine("Skriv ett namn att söka efter:");
            string sökNamn = Console.ReadLine();
            int antal = namn.Count(n => n == sökNamn);
            Console.WriteLine($"Namnet {sökNamn} förekommer så här många gånger {antal} gånger.");
        }
    }
}
