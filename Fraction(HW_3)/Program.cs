using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace HW_3_Class_Fraction
{
    internal class Program
    {
        class Fraction
        {
            public int CH { get; set; } = 1;
            public int ZN { get; set; } = 2;
            int integer = 0;
            public Fraction(int cH, int zN)
            {
                CH = cH;
                ZN = zN;
            }
            public Fraction() { }

            public void Print()
            {
                Fraction f = new Fraction();
                f.CH = CH;
                f.ZN = ZN;
                Fraction_Reduction(f);
                if (f.CH == f.ZN) Console.WriteLine(f.integer);
                else if (f.CH != f.ZN && f.integer > 0)
                {
                    Console.WriteLine($"{f.integer}({f.CH}/{f.ZN})");
                }
                else Console.WriteLine($"{CH}/{ZN}");
            }



            public override string ToString()
            {
                return ($"{CH}/{ZN}");
            }

            public void Fraction_Reduction(Fraction f)
            {
                if (Get_Common_Divisor() != 0)
                {
                    int common_divisor = Get_Common_Divisor();
                    f.CH /= common_divisor;
                    f.ZN /= common_divisor;
                    if (f.CH == f.ZN) { f.integer = 1; }
                    else if (f.CH > f.ZN)
                    {
                        f.integer += f.CH / f.ZN;
                        f.CH = (f.CH % f.ZN);
                    }
                }
                else return;
            }

            public int Get_Common_Divisor()
            {
                int ch = CH, zn = ZN;
                ch = Math.Abs(ch);
                zn = Math.Abs(zn);
                while (ch != 0 && zn != 0)
                {
                    if (ch % zn > 0)
                    {
                        int tmp = ch;
                        ch = zn;
                        zn = tmp % zn;
                    }
                    else break;
                }
                if (zn != 0 && ch != 0) return zn;
                else return 0;
            }

            bool CheckDenominator()
            {
                if (ZN == 0) return true;
                else return false;
            }


            public static Fraction operator +(Fraction a, Fraction b)
            {
                return new Fraction(a.CH * b.ZN + b.CH * a.ZN,
                    a.ZN * b.ZN);
            }

            public static Fraction operator -(Fraction a, Fraction b)
            {

                return new Fraction(a.CH * b.ZN - b.CH * a.ZN,
                    a.ZN * b.ZN);
            }

            public static Fraction operator *(Fraction a, Fraction b)
            {
                return new Fraction(a.CH * b.CH, a.ZN * b.ZN);
            }

            public static Fraction operator *(Fraction a, int num)
            {
                return new Fraction(a.CH * num, a.ZN);
            }

            public static Fraction operator /(Fraction a, Fraction b)
            {
                return new Fraction(a.CH * b.ZN, b.CH * a.ZN);
            }

            public static bool operator >(Fraction a, Fraction b)
            {
                if (!a.CheckDenominator() && !b.CheckDenominator())
                {
                    return (double)a.CH / a.ZN > (double)b.CH / b.ZN;
                }
                else return false;
            }
            public static bool operator <(Fraction a, Fraction b)
            {
                if (!a.CheckDenominator() && !b.CheckDenominator())
                {
                    return (double)a.CH / a.ZN < (double)b.CH / b.ZN;
                }
                else return false;
            }

            public override bool Equals(object obj)
            {
                if (obj == null || !(obj is Fraction))
                    return false;
                Fraction other = (Fraction)obj;
                if (!this.CheckDenominator() && !other.CheckDenominator())
                {
                    return ((double)this.CH / this.ZN == (double)other.CH / other.ZN);
                }
                else return false;
            }
        }
        static void Main()
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
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }


    }
}
