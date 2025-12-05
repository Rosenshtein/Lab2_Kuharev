using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab2.MenuFunc;

namespace Lab2
{
    internal static class Menu
    {
        public static void MainMenu()
        {
            MenuPrint();
            MenuProg();
        }

        internal static void MenuPrint()
        {
            string[] menu = new string[] {
                "Сортировка массива методом расчёски",
                "+----Меню:-----------------------------------+",
                "| 1. Ввод массива с клавиатуры               |",
                "| 2. Генерация массива случайных целых чисел |",
                "| 3. Загрузка массива из файла.              |",
                "| 4. Информация о программе                  |",
                "| 5. Выход                                   |",
                "+--------------------------------------------+"};


            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }
        }


        internal static void MenuProg()
        {
            int choice = 0;
            while (choice != -1)
            {
                Console.Write("\nВаш выбор: ");

                choice = BasicFunc.ReadInt();

                switch (choice)
                {
                    case 1:
                        MenuFunc.PointArrayKBInput pointArray = new PointArrayKBInput();
                        break;
                    case 2:
                        PointGenArray pointGenArray = new PointGenArray();
                        break;
                    case 3:
                        GetArrayFromFile getArrayFromFile = new GetArrayFromFile();
                        break;
                    case 4:
                        PointInfo pointInfo = new PointInfo();
                        break;
                    case 5:
                        choice = -1;
                        break;

                    default:
                        Console.WriteLine("Такого пункта меню нет!");
                        break;
                }

            }
            Console.WriteLine("Выход из программы...");
        }
    }
}
