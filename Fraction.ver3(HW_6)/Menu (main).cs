using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Class_Fraction
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
            "Logic comparing",
            "Transformation",
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
                                        Console.WriteLine("\n==============================================================================================\n" +
                                            "Attention! The value of the numerator and denominator must be at least 1 and a maximum of 20." +
                                            "\n==============================================================================================\n");
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
                                            Fraction f3 = new Fraction();
                                            f3 = f1 + f2;
                                            Console.Write("(Fraction) " + f1 + " + " +
                                                " (fraction) " + f2 + " = " + f3);
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
                                        Console.WriteLine("\n==============================================================================================\n" +
                                            "Attention! The value of the numerator and denominator must be at least 1 and a maximum of 20." +
                                            "\n==============================================================================================\n");
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
                                            Fraction f3 = new Fraction();
                                            f3 = f1 - f2;
                                            Console.Write("(Fraction) " + f1 + " - " +
                                                " (fraction) " + f2 + " = " + f3);
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
                                        Console.WriteLine("\n==============================================================================================\n" +
                                            "Attention! The value of the numerator and denominator must be at least 1 and a maximum of 20." +
                                            "\n==============================================================================================\n");
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
                                            Fraction f3 = new Fraction();
                                            f3 = f1 * f2;
                                            Console.Write("(Fraction) " + f1 + " * " +
                                                " (fraction) " + f2 + " = " + f3);
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
                                        Console.WriteLine("\n==============================================================================================\n" +
                                            "Attention! The value of the numerator and denominator must be at least 1 and a maximum of 20." +
                                            "\n==============================================================================================\n");
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
                                            Fraction f3 = new Fraction();
                                            f3 = f1 / f2;
                                            Console.Write("(Fraction) " + f1 + " / " +
                                                " (fraction) " + f2 + " = " + f3);
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
                                        Console.WriteLine("\n==============================================================================================\n" +
                                            "Attention! The value of the numerator and denominator must be at least 1 and a maximum of 20." +
                                            "\n==============================================================================================\n");
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
                                case 5:
                                    {
                                        Fraction f1 = new Fraction();
                                        Fraction f2 = new Fraction();
                                        Console.WriteLine("\n==============================================================================================\n" +
                                            "Attention! The value of the numerator and denominator must be at least 1 and a maximum of 20." +
                                            "\n==============================================================================================\n");
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
                                            bool condition1 = (f1 + f2) >= 1;
                                            bool condition2 = false;
                                            if (condition1) condition2 = (f1 + f2) >= 2;
                                            Console.WriteLine($"Condition №-1 : ({f1} + {f2}) >= 1 ?");
                                            Console.WriteLine($"Condition №-1 : ({f1} + {f2}) >= 2 ?");
                                            if (condition1 && condition2) Console.WriteLine("Both conditions are met");
                                            else if (condition1 || condition2) Console.WriteLine("One of the conditions is met");
                                            else Console.WriteLine("Both conditions are not met");
                                            Console.ReadKey();
                                        }
                                    }
                                    break;
                                case 6:
                                    {
                                        Transformation();
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

        static void Transformation()
        {
            List<string> menu_items = new List<string>()
            {
                "Converting a fraction to a real number",
                "Converting a real number to a fraction",
                "Converting a fraction to a array bytes",
                "Exit"
            };

            int selected_item_index = 0;

            while (true)
            {
                Console.Clear();

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

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (selected_item_index > 0)
                        {
                            selected_item_index--;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (selected_item_index < menu_items.Count - 1)
                        {
                            selected_item_index++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        {
                            if (selected_item_index == menu_items.Count - 1)
                            {
                                return;
                            }
                            else
                            {
                                switch (selected_item_index)
                                {
                                    case 0:
                                        {
                                            Fraction f1 = new Fraction();
                                            Console.WriteLine("\n==============================================================================================\n" +
                                                "Attention! The value of the numerator and denominator must be at least 1 and a maximum of 20." +
                                                "\n==============================================================================================\n");
                                            if (f1.input() == null)
                                            {
                                                Console.WriteLine("Exit to the main menu.....");
                                                Console.ReadKey();
                                            }
                                            else
                                            {
                                                double real_number = f1;
                                                Console.WriteLine($"A real number from the fraction {f1} = {real_number}");
                                                Console.ReadKey();
                                            }
                                        }
                                        break;
                                    case 1:
                                        {
                                            double real_number;

                                            Console.Write("Input real_number : ");
                                            string input = Console.ReadLine();

                                            if (double.TryParse(input, out real_number))
                                            {
                                                Console.WriteLine("You input real number : " + real_number);
                                                Fraction f1 = (Fraction)real_number;
                                                Console.WriteLine($"Your real number {real_number} == (fraction) {f1}");
                                                f1.Print();
                                            }
                                            else
                                            {
                                                Console.WriteLine("You input incorrect value");
                                            }
                                            Console.ReadKey();
                                        }
                                        break;
                                    case 2:
                                        {
                                            Fraction f1 = new Fraction();
                                            Console.WriteLine("\n==============================================================================================\n" +
                                                "Attention! The value of the numerator and denominator must be at least 1 and a maximum of 20." +
                                                "\n==============================================================================================\n");
                                            if (f1.input() == null)
                                            {
                                                Console.WriteLine("Exit to the main menu.....");
                                                Console.ReadKey();
                                            }
                                            else
                                            {
                                                byte[] arr_fraction_bytes = (byte[])f1;
                                                Console.WriteLine($"A array bytes(little-endian byte order) from the fraction {f1} = {BitConverter.ToString(arr_fraction_bytes)}");
                                                Console.ReadKey();
                                            }
                                        }
                                        break;
                                }
                            }
                            break;
                        }
                }
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        static void Main()
        {
            Menu();
        }
    }
}
