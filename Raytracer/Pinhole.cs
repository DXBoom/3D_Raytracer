using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer
{
    class Pinhole : ICamera
    {
        OrthonormalBasis onb;
        Vector3 origin;
        double distance;
        Vector2 scale;

        public Pinhole(Vector3 origin,Vector3 lookAt,Vector3 up,Vector2 scale,double distance)
        {
            this.onb = new OrthonormalBasis(origin - lookAt, up);
            this.origin = origin;
            this.scale = scale;
            this.distance = distance;
        }

        public Ray GetRayTo(Vector2 relLoc)
        {
            Vector2 vpLoc = new Vector2(relLoc.X * scale.X, relLoc.Y * scale.Y);
            return new Ray(origin, RayDirection(vpLoc));
        }

        Vector3 RayDirection(Vector2 v)
        {
            return onb * new Vector3(v.X, v.Y, -distance);
        }

    }
}
