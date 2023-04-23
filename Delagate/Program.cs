using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delagate
{
    internal class Program
    {
        public delegate double MathDelegate(double value1, double value2);

        public static double Add(double value1, double value2)
        {
            return value1 + value2;
        }
        public static double Subtract(double value1, double value2)
        {
            return value1 - value2;
        }
        //        Console.ReadLine();

        static void Hello(string s)
        {
            Console.WriteLine("  Hello, {0}!", s);
        }

        static void Goodbye(string s)
        {
            Console.WriteLine("  Goodbye, {0}!", s);
        }

        delegate void Del(string s);


        static void Main(string[] args)
        {
            MathDelegate mathDelegate = Add;
            var result = mathDelegate(5, 2);
            Console.WriteLine(result);
            // вывод: 7

            mathDelegate = Subtract;
            result = mathDelegate(5, 2);
            Console.WriteLine(result);
            Del a, b, c, d;

            // Создаем делегат a ссылающийся на метод  Hello:
            a = Hello;

            // Создаем делегат b ссылающийся на метод  Goodbye:
            b = Goodbye;

            // Формируем композицию делегатов a и b - c: 
            c = a + b;

            // Удаляем a из композиции делегатов c, создавая делегат d, который в результате вызывает только метод  Goodbye:
            d = c - a;

            Console.WriteLine("Invoking delegate a:");
            a("A");
            Console.WriteLine("Invoking delegate b:");
            b("B");
            Console.WriteLine("Invoking delegate c:");
            c("C");
            Console.WriteLine("Invoking delegate d:");
            d("D");

            Console.ReadLine();
        }
    }
}
