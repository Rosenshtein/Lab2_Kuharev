using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Lab2.MenuFunc;


namespace Lab2
{
    public class MenuFunc
    {
        public class BasicFunc
        {
         

            public static void PrintArray(int[] array, string desk = "")
            {
                Console.WriteLine("Ваш массив: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($" {array[i]} ", array);
                }

                if (desk != "") 
                    Console.Write($"({desk})", desk); 

                Console.WriteLine();
            }

            public static void PrintInfo(int i)
            {
                Console.Write($"Введите элемент [{i}]: ", i);
            }

            public static int SetSizeArray()
            {
                Console.Write("Введите размерность массива: ");
                int size = ReadInt();
                return size;
            }

            public static string GetFileName()
            {
                Console.Write("Введите имя файла с расширением: ");
                string fileName = (Console.ReadLine()!);
                while (fileName == null)
                {
                    Console.Write("Имя не можем быть пустым!");
                    Console.Write("Введите имя файла с расширением: ");
                    fileName = (Console.ReadLine()!);
                }
                return fileName;

            }


            public static bool FileEx(string fileName)
            {
                if (!File.Exists(fileName))
                {
                    Console.WriteLine("Файл не найден!");
                    return false;
                }
                else 
                    return true; 
            }

            public static bool ChoiceOfSLFile()
            {

                string text = "Сохранить в файл?";

                Console.WriteLine(text);
                Console.WriteLine("1 - да, 0 - нет");
                int choice = ReadInt(); ;
                if (choice == 1) 
                    return true; 
                else 
                    return false; 
            }


            public static void SaveToFile(int[] array, int[] array1)
            {

                if (ChoiceOfSLFile())
                {
                    while (true)
                    {
                        try
                        {
                            string path = Path.Combine(AppContext.BaseDirectory, GetFileName());
                            using (StreamWriter sw = new StreamWriter(path, false, new UTF8Encoding(true)))
                            {
                                sw.WriteLine("Original array:");
                                foreach (var number in array)
                                {
                                    sw.Write(" " + number); // записываем каждое число с новой строки
                                }
                                sw.WriteLine("\n Sorted array:");
                                foreach (var number1 in array1)
                                {
                                    sw.Write(" " + number1); // записываем каждое число с новой строки
                                }
                            
                            }

                            Console.WriteLine($"Массив успешно сохранён в файл: {path}");
                            break;
                        }


                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ошибка при сохранении файла: {ex.Message}");
                        }
                    }
                }
            }

            /// <summary>
            /// Считывает число с консоли, пока пользователь не введёт корректное значение.
            /// </summary>
            /// <param name="prompt">Сообщение для пользователя</param>
            /// <returns>Введённое число</returns>
            public static int ReadInt()
            {
                int result;
                while (true)
                {
                    string? input = Console.ReadLine();

                    if (int.TryParse(input, out result))
                        return result;

                    Console.WriteLine("Ошибка: введите число!");
                }
            }

            public static int[] LoadFromFile()
            {
                string path = Path.Combine(AppContext.BaseDirectory, GetFileName());
                if (!File.Exists(path))
                {
                    Console.WriteLine("Файл не найден");
                    return new int[0];
                }

                List<int> numbers = new List<int>();

                try
                {
                    foreach (var line in File.ReadLines(path))
                    {
                        // Разделяем строку на слова, цифры через пробел, запятую или точку с запятой
                        var parts = line.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (var part in parts)
                        {
                            if (int.TryParse(part, out int num))
                                numbers.Add(num);  // добавляем только корректные числа
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
                }
               
                    Console.WriteLine($"Успешно загружено {numbers.Count} чисел из файла");
                    return numbers.ToArray();
               
            }

        }

            public class PointArrayKBInput
            {


                public static void ArrayKeyboardInput(int[] array)
                {
                    int input = 0;

                    for (int i = 0; i < array.Length; i++)
                    {

                        BasicFunc.PrintInfo(i);
                        input = BasicFunc.ReadInt();
                        array[i] = input;
                        input = 0;
                    }

                }


                public PointArrayKBInput()
                {
                    int size = BasicFunc.SetSizeArray();
                    int[] array = new int[size];
                    ArrayKeyboardInput(array);
                    BasicFunc.PrintArray(array);

                    int[] array1 = new int[size];
                    array1 = CombSort.Sort(array);
                    BasicFunc.PrintArray(array1, "Отсортированный");
                    BasicFunc.SaveToFile(array, array1);
                }
            }

            public class PointGenArray
            {
                public void GenerateRandomArray(int[] array, int min, int max)
                {
                    Random rnd = new Random();

                    for (int i = 0; i < array.Length; i++)
                        array[i] = rnd.Next(min, max);

                }


                public int SetMinMax(string name)
                {
                    Console.Write($"Введите значение для {name}: ");
                    return BasicFunc.ReadInt(); ;
                }

                public PointGenArray()
                {
                    int size = BasicFunc.SetSizeArray();
                    int[] array = new int[size];
                    int min = SetMinMax("min");
                    int max = SetMinMax("max");
                    GenerateRandomArray(array, min, max);
               

                    BasicFunc.PrintArray(array);
                    int[] sortedArray = new int[size];
                    sortedArray = CombSort.Sort(array);
                    BasicFunc.PrintArray(sortedArray, "Отсортированный");
                    BasicFunc.SaveToFile(array, sortedArray);

                }
            }

            

            public class PointInfo
            {
                public PointInfo()
                {
                    Console.WriteLine("Выполнил студент группы 444 Кухарев Никита. \n" +
                                      "Программа реализует метод сортировки расческой (Comb Sort)");
                }
            }

            public class GetArrayFromFile
            {

                public int[] Array { get; private set; } // массив хранится в объекте

                public GetArrayFromFile()
                {
                    Array = BasicFunc.LoadFromFile();  // загружаем массив один раз

                    if (Array.Length > 0)
                        ProcessArray();
                    else
                        Console.WriteLine("Нет данных для обработки.");
                }

                // Метод для обработки массива
                public void ProcessArray()
                {
                    BasicFunc.PrintArray(Array);
                    int[] sortedArray = new int[Array.Length];
                    sortedArray = CombSort.Sort(Array);
                    BasicFunc.PrintArray(sortedArray, "Отсортированный");
                    BasicFunc.SaveToFile(Array, sortedArray);
                }
            }


    }
}


