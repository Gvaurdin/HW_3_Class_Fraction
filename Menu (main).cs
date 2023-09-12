using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            List<string> menu_items = new List<string>
        {
            "Addition",
            "Subtraction",
            "Multiplication",
            "Division",
            "Comparing",
            "Exit"
        };

            // Индекс выбранного пункта меню
            int selected_item_index = 0;

            while (true)
            {
                Console.Clear();

                // Выводим пункты меню с подсветкой выбранного пункта
                Console.WriteLine("\tFraction calculator\n" +
                    "Select action :");
                for (int i = 0; i < menu_items.Count; i++)
                {
                    if (i == selected_item_index)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.WriteLine("\t\t" + menu_items[i]);
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("\n==============================================================\n");
                // Считываем нажатую клавишу
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                // Обработка нажатой клавиши
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (selected_item_index > 0)
                        {
                            // Перемещаем подсветку вверх
                            selected_item_index--;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (selected_item_index < menu_items.Count - 1)
                        {
                            // Перемещаем подсветку вниз
                            selected_item_index++;
                        }
                        break;

                    case ConsoleKey.Enter:
                        if (selected_item_index == menu_items.Count - 1)
                        {
                            // Пользователь выбрал выход, завершаем программу
                            Environment.Exit(0);
                        }
                        else
                        {
                            switch (selected_item_index)
                            {
                                case 0:
                                    {
                                        Fraction f1 = new Fraction();
                                        Fraction f2 = new Fraction();
                                        if(f1.input() == null)
                                        {
                                            Console.WriteLine("Exit to the main menu.....");
                                            Console.ReadKey();
                                        }
                                        else if(f2.input() == null)
                                        {
                                            Console.WriteLine("Exit to the main menu.....");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n==============================================================\n");
                                            Fraction f3 = new Fraction();
                                            f3 = f1 + f2;
                                            Console.Write("(Fraction) " + f1 + " + " +
                                                " (fraction) " + f2 + " = " + f3 + " = ");
                                            f3.Print();
                                            Console.WriteLine();
                                            Console.ReadKey();
                                        }
                                    }
                                    break;
                                case 1:
                                    {
                                        Fraction f1 = new Fraction();
                                        Fraction f2 = new Fraction();
                                        if (f1.input() == null)
                                        {
                                            Console.WriteLine("Exit to the main menu.....");
                                            Console.ReadKey();
                                        }
                                        else if (f2.input() == null)
                                        {
                                            Console.WriteLine("Exit to the main menu.....");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n==============================================================\n");
                                            Fraction f3 = new Fraction();
                                            f3 = f1 - f2;
                                            Console.Write("(Fraction) " + f1 + " - " +
                                                " (fraction) " + f2 + " = " + f3 + " = ");
                                            f3.Print();
                                            Console.WriteLine();
                                            Console.ReadKey();
                                        }
                                    }
                                    break;
                                case 2:
                                    {
                                        Fraction f1 = new Fraction();
                                        Fraction f2 = new Fraction();
                                        if (f1.input() == null)
                                        {
                                            Console.WriteLine("Exit to the main menu.....");
                                            Console.ReadKey();
                                        }
                                        else if (f2.input() == null)
                                        {
                                            Console.WriteLine("Exit to the main menu.....");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n==============================================================\n");
                                            Fraction f3 = new Fraction();
                                            f3 = f1 * f2;
                                            Console.Write("(Fraction) " + f1 + " * " +
                                                " (fraction) " + f2 + " = " + f3 + " = ");
                                            f3.Print();
                                            Console.WriteLine();
                                            Console.ReadKey();
                                        }
                                    }
                                    break;
                                case 3:
                                    {
                                        Fraction f1 = new Fraction();
                                        Fraction f2 = new Fraction();
                                        if (f1.input() == null)
                                        {
                                            Console.WriteLine("Exit to the main menu.....");
                                            Console.ReadKey();
                                        }
                                        else if (f2.input() == null)
                                        {
                                            Console.WriteLine("Exit to the main menu.....");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n==============================================================\n");
                                            Fraction f3 = new Fraction();
                                            f3 = f1 / f2;
                                            Console.Write("(Fraction) " + f1 + " / " +
                                                " (fraction) " + f2 + " = " + f3 + " = ");
                                            f3.Print();
                                            Console.WriteLine();
                                            Console.ReadKey();
                                        }
                                    }
                                    break;
                                case 4:
                                    {
                                        Fraction f1 = new Fraction();
                                        Fraction f2 = new Fraction();
                                        if (f1.input() == null)
                                        {
                                            Console.WriteLine("Exit to the main menu.....");
                                            Console.ReadKey();
                                        }
                                        else if (f2.input() == null)
                                        {
                                            Console.WriteLine("Exit to the main menu.....");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            if (f1 > f2)
                                            {
                                                Console.WriteLine("Answer : (Fraction) " + f1 + " > " + "(fraction) " + f2);
                                            }
                                            else if (f1 < f2)
                                            {
                                                Console.WriteLine("Answer : (Fraction) " + f1 + " < " + "(fraction) " + f2);
                                            }
                                            else if (f1.Equals(f2))
                                            {
                                                Console.WriteLine("Answer : (Fraction) " + f1 + " = " + "(fraction) " + f2);
                                            }
                                            else Console.WriteLine("There was some kind of problem....");

                                            Console.ReadKey();
                                        }
                                    }
                                    break;

                            }
                        }
                        break;
                }

                // Сброс фона в черный после обработки клавиши
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        static void Main()
        {
            Menu();
        }
    }
}
