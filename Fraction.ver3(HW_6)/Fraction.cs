using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Fraction
{
    internal class Fraction
    {
        public int CH { get; set; } = 0;
        private int zn;

        public int ZN
        {
            get { return zn; }
            set
            {
                if(value != 0)
                zn = value;
                else Console.WriteLine("Error. Denumenator != 0");
            }
        }

        int integer = 0;
        public Fraction(int cH, int zN)
        {
            CH = cH;
            ZN = zN;
        }
        public Fraction() { }

        public static explicit operator Fraction(double number)
        {
            int zn = 1;
            while (number != Math.Floor(number))
            {
                 number *= 10;
                 zn *= 10;
            }
            int ch = (int)number;
            return new Fraction(ch, zn);
        }

        public static implicit operator double (Fraction f)
        {
            if (!f.CheckDenominator())
            {
                return (double)f.CH / f.ZN;
            }
            else return 0;
        }

        /*
         * Тип BigInteger является неизменяемым типом, который представляет произвольно большое целое число,
         * значение которого теоретически не имеет верхней или нижней границы
         * Для доступа необходимо войти в обозреватель решений, далее в ссылках подключить SystemNumerics,
         * далее подключить SystemNummerics в исполнительном файле!
         */
        //public static implicit operator BigInteger(Fraction f)
        //{
        //    if (!f.CheckDenominator())
        //    {
        //        return (BigInteger)f.CH / f.ZN;
        //    }
        //    else return 0;
        //}

        public static explicit operator byte[] (Fraction f)
        {
            if (!f.CheckDenominator())
            {
                int ch = f.CH;
                int zn = f.zn;

                byte[] ch_bytes = BitConverter.GetBytes(ch);
                byte[] zn_bytes = BitConverter.GetBytes(zn);

                byte[] result_bytes = new byte[ch_bytes.Length + zn_bytes.Length];

                Array.Copy(ch_bytes, result_bytes, ch_bytes.Length);
                Array.Copy(zn_bytes,0, result_bytes,ch_bytes.Length, zn_bytes.Length);
                return result_bytes;
            }
            /*
             * zn_bytes - исходный массив, из которого мы копируем данные.
             * 0 - начальный индекс в массиве denominatorBytes.Мы начинаем копирование с самого начала этого массива.
             * result_bytes - целевой массив, в который мы копируем данные.
             * ch_bytes.Length - начальный индекс в массиве resultBytes, с которого начинается вставка данных из zn_bytes.
             * zn_bytes.Length - количество элементов, которое мы копируем из zn_bytes в result_bytes.
             * Это копирует данные знаменателя в массив result_bytes начиная с позиции, следующей за числителем.
             */
            else return null;
        }


        public void Print()
        {
            Fraction f = new Fraction();
            f.CH = CH;
            f.ZN = ZN;
            Fraction_Reduction(f);
            if (f.CH == f.ZN || f.CH == 0) Console.WriteLine(" = " + f.integer);
            else if (f.CH != f.ZN && f.integer > 0)
            {
                Console.WriteLine($" = {f.integer}({f.CH}/{f.ZN})");
            }
            else if (f.CH != CH || f.ZN != ZN) Console.WriteLine($" = {f.CH}/{f.ZN}");
            else return;
        }



        public override string ToString()
        {
            return ($"{CH}/{ZN}");
        }

        public Fraction input()
        {
            int numerator;
            int denominator;
            do
            {
                Console.Write("Enter to value`s numerator : ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out numerator) || numerator > 20)
                {
                    Console.WriteLine("Incorrect input. The numerator must be an integer no greater than 20.");
                }
            } while (numerator > 20 || numerator == 0);
    
            do
            {
                Console.Write("Enter to value`s denominator : ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out denominator) || denominator > 20)
                {
                    Console.WriteLine("Incorrect input. The numerator must be an integer no greater than 20.");
                }
            } while (denominator > 20 || denominator == 0);
            if (denominator == 0 && denominator == 0)
            {
                Console.WriteLine("The values were entered incorrectly. Fraction not created");
                return null;
            }
            else
            {
                CH = numerator;
                ZN = denominator;
                Console.WriteLine("Fraction created successfully" +
                    "\n=====================================================\n");
                return new Fraction(CH, ZN);
            }
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

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static bool operator == (Fraction f1, Fraction f2)
        {
            return f1.Equals(f2);
        }

        public static bool operator != (Fraction f1, Fraction f2)
        {
            return !(f1 == f2);
        }

        public static bool operator <= (Fraction f1, int number)
        {
            if (!f1.CheckDenominator())
            {
                return (double)f1.CH/f1.ZN <= number;
            }
            else return false;
        }

        public static bool operator >= (Fraction f1, int number)
        {
            if (!f1.CheckDenominator())
            {
                return (double)f1.CH/f1.ZN >= number;
            }
            else return false;
        }

        public static bool operator true(Fraction f)
        {
            return f.CH != 0 ? true : false;
        }
        public static bool operator false(Fraction f)
        {
            return f.CH == 0 ? true : false;
        }

        public static Fraction operator | (Fraction f1, Fraction f2)
        {
            if (f1.CH != 0 || f2.CH != 0)
            {
                return f2;
            }
            else return new Fraction();
        }

        public static bool operator | (Fraction f1, bool condition)
        {
            return condition || (f1.CH != 0);
        }

        public static bool operator & (Fraction f1, bool condition)
        {
            return condition && (f1.CH != 0);
        }

        public static Fraction operator & (Fraction f1, Fraction f2)
        {
            if (f1.CH != 0 && f2.CH != 0)
            {
                return f2;
            }
            else return new Fraction();
        }
    }
}
