using System;


namespace Taschenrechner_iteration_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // User Sory "Addieren": Als Benutzer möchte ich zwei Zahlen 
            // eingeben um deren Summe zu berechnen zu lassen.

            Console.WriteLine("Bitte die erste Zahl eingeben");

            string ersterSummand = Console.ReadLine();

            Console.WriteLine("Bitte die zweite Zahl eingeben");

            string zweiterSummand = Console.ReadLine();
            string summe = ersterSummand + zweiterSummand;

            Console.WriteLine(summe);

            Console.ReadKey();

            // Wandle Text in Ganzzahlen

            int ersterSummandAlsZahl = Convert.ToInt32(ersterSummand);
            int zweiterSummandAlsZahl = Convert.ToInt32(zweiterSummand);

            Console.WriteLine("Gewandelter erter Sumand {0}", ersterSummandAlsZahl);
            Console.WriteLine("Gewandelter zweiter Sumand {0}", zweiterSummandAlsZahl);

            // Berechnung durchführen
            int summeAlsZahl = ersterSummandAlsZahl + zweiterSummandAlsZahl;

            // Ausgabe
            Console.WriteLine("Die Summe als Zahlen: {0}", summeAlsZahl);
            

            Console.ReadKey();

        }
    }
}
