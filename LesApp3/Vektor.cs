using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp3
{
    /// <summary>
    /// Вектор
    /// </summary>
    struct Vektor
    {
        public Point Start { get; set; }
        public Point Finish { get; set; }

        /// <summary>
        /// Сума векторів
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Vektor operator +(Vektor a, Vektor b)
        {
            Vektor vA = new Vektor()
            {
                Start = new Point() { X = 0, Y = 0},
                Finish = new Point()
                {
                    X = a.Finish.X - a.Start.X,
                    Y = a.Finish.Y - a.Start.Y
                }
            };
            Vektor vB = new Vektor()
            {
                Start = new Point() { X = 0, Y = 0 },
                Finish = new Point()
                {
                    X = b.Finish.X - b.Start.X,
                    Y = b.Finish.Y - b.Start.Y
                }
            };

            return new Vektor()
            {
                Start = new Point() { X = 0, Y = 0 },
                Finish = new Point()
                {
                    X = vA.Finish.X + vB.Finish.X,
                    Y = vA.Finish.Y + vB.Finish.Y
                }
            };
        }

        /// <summary>
        /// Різниця векторів
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Vektor operator -(Vektor a, Vektor b)
        {
            Vektor vA = new Vektor()
            {
                Start = new Point() { X = 0, Y = 0 },
                Finish = new Point()
                {
                    X = a.Finish.X - a.Start.X,
                    Y = a.Finish.Y - a.Start.Y
                }
            };
            Vektor vB = new Vektor()
            {
                Start = new Point() { X = 0, Y = 0 },
                Finish = new Point()
                {
                    X = b.Finish.X - b.Start.X,
                    Y = b.Finish.Y - b.Start.Y
                }
            };

            return new Vektor()
            {
                Start = new Point() { X = 0, Y = 0 },
                Finish = new Point()
                {
                    X = vA.Finish.X - vB.Finish.X,
                    Y = vA.Finish.Y - vB.Finish.Y
                }
            };
        }

        public override string ToString()
        {
            Vektor temp = new Vektor()
            {
                Start = new Point() { X = 0, Y = 0 },
                Finish = new Point()
                {
                    X = this.Finish.X - this.Start.X,
                    Y = this.Finish.Y - this.Start.Y
                }
            };

            return "{" + this.Finish.X + ", " + this.Finish.Y + "}";
        }
    }
}
