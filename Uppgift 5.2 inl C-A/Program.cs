using System;

namespace Uppgift_5._2_C_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många heltal vill du skriva in?");
            int antal = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in dina heltal på olika rader");
            int[] siffror = new int[antal];
            for (int i = 0; i < antal; i++)
            {
                siffror[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Här är talen du skrev in");
            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine("TAL " + (i+1) + " :" + siffror[i]);
            }
        }
    }
}