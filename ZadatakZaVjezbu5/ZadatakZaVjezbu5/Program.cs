using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakZaVjezbu5
{
    internal class Program
    {

        class Search
        {
            public int BinarySearch(int[] array, int x)
            {
                return Array.BinarySearch(array, x);
            }
        }


        static void Main(string[] args)
        {

            Search search = new Search();

            int[] array = new int[100];
            int s = 1;
            int r = 75;

            for (int i = 0; i < 100; i++)
            {
                array[i] = s;
                s = s + 2;
            }

            Console.WriteLine(search.BinarySearch(array, r));
            Console.WriteLine(array[37]);



            Console.ReadKey();

        }
    }
}
