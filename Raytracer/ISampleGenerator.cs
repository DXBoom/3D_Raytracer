using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer
{
    interface ISampleGenerator
    {
        Vector2[] Sample(int count);
    }

}
