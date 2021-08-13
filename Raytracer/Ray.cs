using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer
{
    struct Ray
    {
        public const double Epsilon = 0.00001;
        public const double Huge = double.MaxValue;

        Vector3 origin;
        Vector3 direction;

        public Ray(Vector3 origin, Vector3 direction)
            : this()
        {
            this.origin = origin;
            this.direction = direction.Normalized;
        }

        public Vector3 Origin { get { return origin; } }
        public Vector3 Direction { get { return direction; } }

        public Vector3 getPointOnRayInDistantFromStart(double dist)
        {
            double xp = this.origin.X + dist * this.direction.X;
            double yp = this.origin.Y + dist * this.direction.Y;
            double zp = this.origin.Z + dist * this.direction.Z;

            return new Vector3(xp, yp, zp);
        }
    }
}
