using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Unesi neku recenicu:");
        string recenica = Console.ReadLine();

        string[] rijeci = recenica.Split(' ');

        string prvaRijec = rijeci[0];
        string zadnjaRijec = rijeci[rijeci.Length - 1];

        Console.WriteLine("Prva rijec: " + prvaRijec);
        Console.WriteLine("Zadnja rijec: " + zadnjaRijec);

        Console.ReadKey();
    }
}

