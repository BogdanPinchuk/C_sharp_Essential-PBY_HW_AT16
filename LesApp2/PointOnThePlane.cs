using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    /// <summary>
    /// Точка на площині
    /// </summary>
    struct PointOnThePlane
    {
        public int X { get; set; }
        public int Y { get; set; }

        /// <summary>
        /// Неявне перетворення
        /// </summary>
        /// <param name="xy"></param>
        public static implicit operator PointInVolume(PointOnThePlane xy)
        {
            return new PointInVolume() { X = xy.X, Y = xy.Y, Z = 0 };
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
