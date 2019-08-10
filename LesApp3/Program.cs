using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://ua.onlinemschool.com/math/library/vector/add_subtract/

namespace LesApp3
{
    class Program
    {
        static void Main()
        {
            // Join Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // створення веторів
            Vektor v1 = new Vektor()
            {
                Start = new Point() { X = 0, Y = 0 },
                Finish = new Point() { X = 1, Y = 2 }
            };
            Vektor v2 = new Vektor()
            {
                Start = new Point() { X = 0, Y = 0 },
                Finish = new Point() { X = 4, Y = 8 }
            };

            // вивід
            Console.WriteLine("\n\tv1 = " + v1.ToString());
            Console.WriteLine("\tv2 = " + v2.ToString());

            Console.WriteLine("\n\tv1 + v2 = " + (v1 + v2).ToString());
            Console.WriteLine("\tv1 - v2 = " + (v1 - v2).ToString());

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
