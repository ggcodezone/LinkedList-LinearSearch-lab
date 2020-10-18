using System;

namespace Linearsearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //linear search
            int[] Itemlist = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 }; //items to search through
            Console.WriteLine("Enter number to search for:");
            int givenNumber = Convert.ToInt32(Console.ReadLine());
            bool searchFound = false;
            for (int i = 0; i < Itemlist.Length; i++)
            {
                if (Itemlist[i] == givenNumber)
                    Console.WriteLine("Search was successful.");
                Console.WriteLine($"The given number{givenNumber} is in {i} index or {i + 1} position.");
                searchFound = true;
            }
            if (!searchFound)
            {
            Console.WriteLine("Search was not successful.");
            Console.ReadKey();
            }
        }
        
            

    }
}
