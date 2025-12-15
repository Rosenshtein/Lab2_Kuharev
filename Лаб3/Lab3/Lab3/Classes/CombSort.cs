using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Classes
{
    internal static class CombSort
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


        public static bool TryGetArrayFromText(string text, out int[] arr, out string error)
        {
            arr = Array.Empty<int>();
            error = "";

            if (string.IsNullOrWhiteSpace(text))
            {
                error = "Введите числа.";
                return false;
            }

            // Разделители: пробел, запятая, ;, перенос строки, таб
            var parts = text.Split(new[] { ' ', ',', ';', '\n', '\r', '\t' },
                                   StringSplitOptions.RemoveEmptyEntries);

            var result = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                if (!int.TryParse(parts[i], out result[i]))
                {
                    error = $"Некорректное число: \"{parts[i]}\" (позиция {i + 1})";
                    return false;
                }
            }

            arr = result;
            return true;
        }

        public static void GenerateRandomArray(int[] array, int min, int max)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(min, max);

        }

    }
}
