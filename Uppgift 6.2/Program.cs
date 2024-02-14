using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv in två tal");
        Console.WriteLine("Skriv in ett tal");
        int tal1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Skriv in ett till tal");
        int tal2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Det största talet är {Störst(tal1, tal2)}");
    }

    static int Störst(int tal1, int tal2)
    {
        if (tal1 > tal2)
        {
            return tal1;
        }
        else
        {
            return tal2;
        }
    }
}