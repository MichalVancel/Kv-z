using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvíz
{
    public class Otazka
    {
        private const string WayQ1 = @"C:\Users\Lenovo\Desktop\Prax\Kvíz\1.txt";
        private const string WayQ2 = @"C:\Users\Lenovo\Desktop\Prax\Kvíz\2.txt";

        public void Load()
        {
            Console.WriteLine(File.ReadAllText(WayQ1));
            Console.WriteLine(File.ReadAllText(WayQ2));
        }
        public void Answer()
        {
            Console.WriteLine("Odpovedz na 1. a 2. otázku");
            Console.WriteLine("Odpovede oddeľ medzerníkom a napíš správnu dvojicu");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1 2":
                    Console.WriteLine("Super máš to dobre");
                    break;
                default:
                    Console.WriteLine("Zle správna odpoveď je 1 - 15 a 2 - SPŠIT");
                    break;

            }
            

        }

    }
}


