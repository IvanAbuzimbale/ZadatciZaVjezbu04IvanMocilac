using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatciZaVjezbu04IvanMocilac
{
    class Sort
    {
        public static void QuickSort(int[] arr, int left, int right)
        {
            int l = left;
            int r = right;
            int s = arr[(left + right) / 2];

            do
            {
                while (arr[l] > s && l < right)
                {
                    l++;
                }
                while (arr[r] < s && r > left)
                {
                    r--;
                }
                if (l <= r)
                {
                    int a = arr[l];
                    arr[l] = arr[r];
                    arr[r] = a;
                    l++;
                    r--;
                }
            } while (l <= r);

            if (left < r)
            {
                QuickSort(arr, left, r);
            }

            if (l < right)
            {
                QuickSort(arr, l, right);
            }
        }
    }
}
