using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    /// <summary>
    /// Точка в просторі
    /// </summary>
    struct PointInVolume
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public static explicit operator PointOnThePlane(PointInVolume xyz)
        {
            return new PointOnThePlane() { X = xyz.X, Y = xyz.Y };
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}
