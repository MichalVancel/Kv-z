using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvíz
{
    public class Otazka
    {
        private const string Way1 = @"C:\Users\Lenovo\Desktop\Prax\Kvíz\1.txt";
        private const string Way2 = @"C:\Users\Lenovo\Desktop\Prax\Kvíz\2.txt";

        public void LoadQ1()
        {
            Console.WriteLine(File.ReadAllText(Way1));
            Console.WriteLine("Vyber možnosť");
            string answer = Console.ReadLine();
            if(answer == "a")
            {
                Console.WriteLine("Otázku máš správne");
            }
            else
            {
                Console.WriteLine("Máš to zle");
            }

        }
        public void LoadQ2()
        {
            System.Threading.Thread.Sleep(2500);
            Console.Clear();
            Console.WriteLine(File.ReadAllText(Way2));
            Console.WriteLine("Vyber možnosť");
            string answer = Console.ReadLine();
            if (answer == "d")
            {
                Console.WriteLine("Otázku máš správne");
            }
            else
            {
                Console.WriteLine("Máš to zle");
            }
        }

    }
}
