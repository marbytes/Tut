using System;

namespace TutotialApp
{
    class Program
    {
        static void Main(string[] args)
        // Gestartet mit dem ganz normalen Hallo welt, habe ich mich hier mit den Funktionen und der Synthax vertraut gemacht.
        // Als Nächstes habe ich den ReadKey verwendet um die Funktionalität der Anzeige zu erhöhen.
        // Dann habe ich verschiedene Methoden erstellt und aufgerufen.
        // Zusätzlich habe ich die Ausgabe von Datum und Uhrzeit als Methode eingefügt.
        {
            Program.HalloWelt();
            Console.WriteLine("Jetzt kommt Datum und Uhrzeit:");
            Program.Zeit();
            Program.ScrCMD();                                          
            Program.ScrMeth();
            Console.ReadKey();                                         // ReadKey nutzen wir hier damit die Console nicht gleich beendet wird, sondern bis zu einer Eingabe die Textzeile ausgibt.
            Console.WriteLine("Zum Schluss noch die Zusammenfassung:");
            Program.Zusammenfassung();
            Console.ReadKey();
        }

        static void HalloWelt()
        {
            Console.WriteLine("   Hello World!! Lets get startet!");    // Einfache Textausgabe in der Console. WriteLine macht dabei direkt einen Zeilenumbruch. Grundbaustein im Consolen Program
            Console.WriteLine("   Press AnyKey to continue...");
            Console.ReadKey();                   

        }

        static void ScrCMD()
        {
            Console.WriteLine("   #####################");
            Console.WriteLine("   #### TutorialApp ####");
            Console.WriteLine("   #### 01 / 2019   ####");
            Console.WriteLine("   #### CMD Ausgabe ####");
            Console.WriteLine("   ####  WriteLine  ####");
            Console.WriteLine("   #####################");
        }
        static void ScrMeth()
        {
            Console.WriteLine("   #####################");
            Console.WriteLine("   #### TutorialApp ####");
            Console.WriteLine("   #### 01 / 2019   ####");
            Console.WriteLine("   #### Verknüpfung ####");
            Console.WriteLine("   ####   Methode   ####");
            Console.WriteLine("   #####################");
        }

        static void Zeit()
        {

            Console.WriteLine(DateTime.Now);
            
        }

        static void Zusammenfassung()
        {
            Console.WriteLine("Hier fassen wir zusammen, was wir bereits verwendet haben.");
            Console.WriteLine("1. Console.WriteLine verwendet.");
            Console.WriteLine("2. Console.ReadKey   verwendet.");
            Console.WriteLine("3. Methode erstellt und aufgerufen.");
            Console.WriteLine("4. Mit DateTime.Now Systemvariablen verwendet.");
            Console.WriteLine("5. Als nächstes: Variablen & Schleifen.");

        }
    }

}
