using System;
using System.Collections.Generic; //chat gbt said to add this i dont know why.

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        
        {
        var myNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
        var evens = new List<int>();
            
        var odds = new List<int>();

        foreach (int num in myNumbers)  //these look different than in class but chat gbt said to do it this way.
        {
        if (num % 2 == 0)
        {
        evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }

            foreach (int num in evens)
            {
                Console.WriteLine($"{num} are my evens.");
            }
            foreach (int num in odds)
            {
                Console.WriteLine($"{num} are my odds."); 
            }
         }
    }
}