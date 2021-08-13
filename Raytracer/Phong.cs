using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer
{
    class Phong : IMaterial
    {
        ColorRgb materialColor;
        double diffuseCoeff;
        double specular;
        double specularExponent;

        public Phong(ColorRgb materialColor,
            double diffuse,
            double specular,
            double specularExponent)
        {
            this.materialColor = materialColor;
            this.diffuseCoeff = diffuse;
            this.specular = specular;
            this.specularExponent = specularExponent;
        }

        public ColorRgb Radiance(PointLight light, HitInfo hit)
        {
            Vector3 inDirection = (light.Position - hit.HitPoint).Normalized;
            double diffuseFactor = inDirection.Dot(hit.Normal);

            if (diffuseFactor < 0) { return ColorRgb.Black; }

            ColorRgb result = light.Color * materialColor * diffuseFactor * diffuseCoeff;
            double phongFactor = PhongFactor(inDirection, hit.Normal, -hit.Ray.Direction);

            if (phongFactor != 0)
            { result += materialColor * specular * phongFactor; }

            return result;
        }

        double PhongFactor(Vector3 inDirection, Vector3 normal, Vector3 toCameraDirection)
        {
            Vector3 reflected = Vector3.Reflect(inDirection, normal);
            double cosAngle = reflected.Dot(toCameraDirection);

            if (cosAngle <= 0) { return 0; }

            return Math.Pow(cosAngle, specularExponent);
        }

        public ColorRgb Shade(Raytracer tracer, HitInfo hit)
        {
            ColorRgb totalColor = ColorRgb.Black;

            foreach (var light in hit.World.Lights)
            {
                Vector3 inDirection = (light.Position - hit.HitPoint).Normalized;
                double diffuseFactor = inDirection.Dot(hit.Normal);

        if (diffuseFactor < 0) { continue; }

                if (hit.World.AnyObstacleBetween(hit.HitPoint, light.Position))
                { continue; }

                ColorRgb result = light.Color * materialColor * diffuseFactor * diffuseCoeff;
                double phongFactor = PhongFactor(inDirection, hit.Normal, -hit.Ray.Direction);

                if (phongFactor != 0)
                { result += materialColor * specular * phongFactor; }

                totalColor += result;
            }

            return totalColor;
        }

    }
}
