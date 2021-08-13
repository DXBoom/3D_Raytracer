using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer
{
    interface ISampleDistributor
    {
        Vector2 MapSample(Vector2 sample);
    }
}
