using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1
{
    /// <summary>
    /// Коло/круг
    /// </summary>
    struct Circle
    {
        /// <summary>
        /// Радіус
        /// </summary>
        public double Radius { get; set; }

        public static Circle operator +(Circle c1, Circle c2)
        {
            // площа: 
            // s = pi * r ^ 2;

            return new Circle()
            {
                Radius = Math.Sqrt(c1.Radius * c1.Radius + 
                c2.Radius * c2.Radius)
            };
        }

    }
}
