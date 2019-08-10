using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    class Program
    {
        static void Main()
        {
            // Join Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // Створення просторової точки
            PointOnThePlane xy = new PointOnThePlane()
            {
                X = 10,
                Y = 20
            };
            PointInVolume xyz = new PointInVolume()
            {
                X = 15,
                Y = 25,
                Z = 35
            };

            // перетворення до іншого типу
            PointInVolume cxyz = xy;
            PointOnThePlane cxy = (PointOnThePlane)xyz;

            // вивід результатів
            Console.WriteLine("\n\tPoint xy" + xy.ToString());
            Console.WriteLine("\n\tPoint xyz" + xyz.ToString());
            Console.WriteLine("\n\tPoint cxy" + cxy.ToString());
            Console.WriteLine("\n\tPoint cxyz" + cxyz.ToString());

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
