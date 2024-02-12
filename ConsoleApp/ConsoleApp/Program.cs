using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleApp app = new ConsoleApp();
            app.Run();
        }
    }
    class ConsoleApp
    {
        private double costoTotale = 0;

        public void Run()
        {
            while (true)
            {
                DisplayMenu();

                Console.WriteLine("Inserisci il numero del cibo desiderato: ");
                int scelta;
                while (!int.TryParse(Console.ReadLine(), out scelta))
                {
                    Console.WriteLine("Scelta non valida. Riprova.");
                }

                if (scelta >= 1 && scelta <= 10)
                {
                    AggiungiOrdine(scelta);
                    Console.WriteLine($"Cibo {scelta} aggiunto all'ordine.");
                }
                else if (scelta == 11)
                {
                    StampaContoFinale();
                    return;
                }
                else
                {
                    Console.WriteLine("Scelta non valida. Riprova!");
                };
            }
        }


        private void DisplayMenu()
        {
            Console.WriteLine("==============MENU==============");
            Console.WriteLine("1: Coca Cola 150 ml (Euro 2.50)");
            Console.WriteLine("2: Insalata di pollo (Euro 5.20)");
            Console.WriteLine("3: Pizza Margherita (Euro 10.00)");
            Console.WriteLine("4: Pizza 4 Formaggi (Euro 12.50)");
            Console.WriteLine("5: Pz patatine fritte (Euro 3.50)");
            Console.WriteLine("6: Insalata di riso (Euro 8.00)");
            Console.WriteLine("7: Frutta di stagione (Euro 5.00)");
            Console.WriteLine("8: Pizza fritta (Euro 5.00)");
            Console.WriteLine("9: Piadina vegetariana (Euro 6.00)");
            Console.WriteLine("10: Panino Hamburger (Euro 7.90)");
            Console.WriteLine("11: Stampa conto finale e conferma");
            Console.WriteLine("==============MENU==============");
        }

        private void AggiungiOrdine(int numeroPiatto)
        {
            double prezzo = GetPrezzoPiatto(numeroPiatto);
            costoTotale += prezzo;
        }

        private double GetPrezzoPiatto(int numeroPiatto)
        {
            switch (numeroPiatto)
            {
                case 1: return 2.50;
                case 2: return 5.20;
                case 3: return 10.00;
                case 4: return 12.50;
                case 5: return 3.50;
                case 6: return 8.00;
                case 7: return 5.00;
                case 8: return 5.00;
                case 9: return 6.00;
                case 10: return 7.90;
                default: return 0.00;
            }
        }

        private void StampaContoFinale()
        {
            Console.WriteLine("==============CONTO FINALE==============");
            Console.WriteLine($"Totale: Euro {costoTotale + 3.00:F2}");
            Console.WriteLine("==============CONTO FINALE==============");

            Console.ReadLine();
        }
        
        
    }

}

