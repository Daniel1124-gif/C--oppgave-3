using System;

namespace C__oppgave_3;

class Kalkulator
{
    static void Main()
    {
        Console.WriteLine("Velkommen til kalkulatoren!");

        while (true)
        {
            // Be om å skrive inn tallene som skal brukes
            Console.WriteLine("\nSkriv inn tallene du vil bruke, adskilt med mellomrom (f.eks. 1 2 3):");
            string input = Console.ReadLine();
            string[] tallStr = input.Split(' ');

            // Konverter tallene fra tekst til tall
            double[] tall = new double[tallStr.Length];
            for (int i = 0; i < tallStr.Length; i++)
            {
                if (!double.TryParse(tallStr[i], out tall[i]))
                {
                    Console.WriteLine("Ugyldig tall. Vennligst skriv inn gyldige tall.");
                    continue;
                }
            }

            // Velg operasjon
            Console.WriteLine("\nVelg operasjon (+, -, *, /):");
            string operasjon = Console.ReadLine();

            // Utfør beregning basert på operasjonen
            double resultat = tall[0]; // Start med det første tallet
            switch (operasjon)
            {
                case "+":
                    for (int i = 1; i < tall.Length; i++)
                    {
                        resultat += tall[i];
                    }
                    break;
                case "-":
                    for (int i = 1; i < tall.Length; i++)
                    {
                        resultat -= tall[i];
                    }
                    break;
                case "*":
                    for (int i = 1; i < tall.Length; i++)
                    {
                        resultat *= tall[i];
                    }
                    break;
                case "/":
                    for (int i = 1; i < tall.Length; i++)
                    {
                        if (tall[i] == 0)
                        {
                            Console.WriteLine("Feil: Kan ikke dele med 0!");
                            continue;
                        }
                        resultat /= tall[i];
                    }
                    break;
                default:
                    Console.WriteLine("Ugyldig operasjon.");
                    continue;
            }

            // Vis resultatet
            Console.WriteLine($"Resultatet er: {resultat}");

            // Spør om brukeren vil fortsette eller avslutte
            Console.WriteLine("\nVil du gjøre en ny beregning? (ja/nei)");
            string fortsette = Console.ReadLine().ToLower();
            if (fortsette != "ja")
            {
                break;
            }
        }

        Console.WriteLine("Takk for at du brukte kalkulatoren. Ha en fin dag!");
    }
}
