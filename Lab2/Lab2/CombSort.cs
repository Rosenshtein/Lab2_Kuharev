using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class CombSort
    {
        static int GetNextGap(int gap)
        {
            //The "shrink factor", empirically shown to be 1.3
            gap = (gap * 10) / 13;
            if (gap < 1)
            {
                return 1;
            }
            return gap;
        }

        static public int[] Sort(int[] array)
        {
           
            int[] arr = (int[])array.Clone();

            int length = arr.Length;
            int gap = length;
            bool swapped = true;

            while (gap != 1 || swapped)
            {
                gap = GetNextGap(gap);
                swapped = false;

                for (int i = 0; i < length - gap; i++)
                {
                    if (arr[i] > arr[i + gap])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + gap];
                        arr[i + gap] = temp;

                        swapped = true;
                    }
                }
            }

            // возвращаем уже отсортированную копию
            return arr;
        }


    }
}
