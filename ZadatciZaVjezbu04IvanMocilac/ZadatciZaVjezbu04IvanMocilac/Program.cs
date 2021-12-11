using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatciZaVjezbu04IvanMocilac
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 9, 16, 7, 5, 17, 4, 14, 39, 1 };
            Sort.QuickSort(arr, 0, arr.Length - 1);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
