using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer
{
    interface ICamera
    {
        Ray GetRayTo(Vector2 relativeLocation);
    }
}
