using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_Class_Fraction
{
    internal class Menu__main_
    {
        static void Menu()
        {
            // Создаем список пунктов меню
            List<string> menuItems = new List<string>
        {
            "Пункт меню 1",
            "Пункт меню 2",
            "Пункт меню 3",
            "Выход"
        };

            // Индекс выбранного пункта меню
            int selectedItemIndex = 0;

            while (true)
            {
                Console.Clear();

                // Выводим пункты меню с подсветкой выбранного пункта
                for (int i = 0; i < menuItems.Count; i++)
                {
                    if (i == selectedItemIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.WriteLine(menuItems[i]);
                }

                // Считываем нажатую клавишу
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                // Обработка нажатой клавиши
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (selectedItemIndex > 0)
                        {
                            // Перемещаем подсветку вверх
                            selectedItemIndex--;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (selectedItemIndex < menuItems.Count - 1)
                        {
                            // Перемещаем подсветку вниз
                            selectedItemIndex++;
                        }
                        break;

                    case ConsoleKey.Enter:
                        if (selectedItemIndex == menuItems.Count - 1)
                        {
                            // Пользователь выбрал "Выход", завершаем программу
                            Environment.Exit(0);
                        }
                        else
                        {
                            // Выполните действие, соответствующее выбранному пункту меню
                            Console.WriteLine("Вы выбрали: " + menuItems[selectedItemIndex]);
                            Console.ReadLine(); // Пауза для наглядности
                        }
                        break;
                }

                // Сброс фона в черный после обработки клавиши
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        static void Main()
        {

        }
    }
}
