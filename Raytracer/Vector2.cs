using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer
{
    struct Vector2
    {
        double x;
        double y;

        public Vector2(double x, double y)
            : this()
        {
            this.x = x;
            this.y = y;
        }

        public double X
        { get { return x; } set { x = value; } }

        public double Y
        { get { return y; } set { y = value; } }

        public static Vector2 operator *(Vector2 vec, double val)
        {
            return new Vector2(vec.X * val, vec.Y * val);
        }
    }
}
