﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1
{
    class Program
    {
        static void Main()
        {
            // Join Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // створення кругів
            Circle c1 = new Circle() { Radius = 10 };
            Circle c2 = new Circle() { Radius = 20 };

            // круг - як результат суми двох інших
            Circle c3 = c1 + c2;

            // вивід результатів
            Console.WriteLine($"Радіус круга с1 = {c1.Radius:N3}");
            Console.WriteLine($"Радіус круга с2 = {c2.Radius:N3}");
            Console.WriteLine($"Радіус круга с3 = {c3.Radius:N3}");

            // repeat
            DoExitOrRepeat();
        }

        /// <summary>
        /// Метод виходу або повторення методу Main()
        /// </summary>
        static void DoExitOrRepeat()
        {
            Console.WriteLine("\n\nСпробувати ще раз: [т, н]");
            Console.Write("\t");
            var button = Console.ReadKey(true);

            if ((button.KeyChar.ToString().ToLower() == "т") ||
                (button.KeyChar.ToString().ToLower() == "n")) // можливо забули переключити розкладку клавіатури
            {
                Console.Clear();
                Main();
                // без використання рекурсії
                //Process.Start(Assembly.GetExecutingAssembly().Location);
                //Environment.Exit(0);
            }
            else
            {
                // закриває консоль
                Environment.Exit(0);
            }
        }
    }
}
