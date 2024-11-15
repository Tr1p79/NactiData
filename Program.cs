using System;

namespace NactiData
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Načtení prvního čísla
                Console.Write("Zadejte první číslo: ");
                if (!double.TryParse(Console.ReadLine(), out double cislo1))
                {
                    throw new ArgumentException("První parametr musí být platné číslo.");
                }

                // Načtení druhého čísla
                Console.Write("Zadejte druhé číslo: ");
                if (!double.TryParse(Console.ReadLine(), out double cislo2))
                {
                    throw new ArgumentException("Druhý parametr musí být platné číslo.");
                }

                // Načtení třetího čísla
                Console.Write("Zadejte třetí číslo: ");
                if (!double.TryParse(Console.ReadLine(), out double cislo3))
                {
                    throw new ArgumentException("Třetí parametr musí být platné číslo.");
                }

                Console.WriteLine("\nVýsledky:");
                Console.WriteLine("------------------");

                // Výpočet a výpis součtu
                double soucet = cislo1 + cislo2 + cislo3;
                Console.WriteLine($"Součet čísel: {soucet}");

                // Výpočet a výpis součinu
                double soucin = cislo1 * cislo2 * cislo3;
                Console.WriteLine($"Součin čísel: {soucin}");

                // Kontrola dělení nulou a výpočet třetí hodnoty
                if (cislo3 == 0)
                {
                    throw new DivideByZeroException("Nelze dělit nulou.");
                }
                double deleni = (cislo1 + cislo2) / cislo3;
                Console.WriteLine($"(První + druhé) / třetí: {deleni}");

                Console.WriteLine("\nStiskněte libovolnou klávesu pro ukončení...");
                Console.ReadKey();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"\nChyba: {ex.Message}");
                Console.WriteLine("\nStiskněte libovolnou klávesu pro ukončení...");
                Console.ReadKey();
                Environment.Exit(1);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"\nChyba: {ex.Message}");
                Console.WriteLine("\nStiskněte libovolnou klávesu pro ukončení...");
                Console.ReadKey();
                Environment.Exit(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nNeočekávaná chyba: {ex.Message}");
                Console.WriteLine("\nStiskněte libovolnou klávesu pro ukončení...");
                Console.ReadKey();
                Environment.Exit(1);
            }
        }
    }
}