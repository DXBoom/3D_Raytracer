using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer
{
    class Triangle
    {/*
        Vector3 a;
        Vector3 b;
        Vector3 c;
        Vector3 n;
        public Vector3 A { get { return a; } }
        public Vector3 B { get { return b; } }
        public Vector3 C { get { return c; } }

        public Triangle(Vector3 a, Vector3 b, Vector3 c, Vector3 n)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            n = n.Normalized;
        }



        public bool checkHitTriangle(Plane plane, Ray ray)
        {
            Vector3 crossPoint = plane.getIntersectionPoint(ray);

            Vector3 pa = this.a - crossPoint;
            Vector3 pb = this.b - crossPoint;
            Vector3 pc = this.c - crossPoint;
            Vector3 ab = this.b - this.a;
            Vector3 ac = this.c - this.a;
            Vector3 bc = this.b - this.b;

            Double paLength = pa.Length;
            Double pbLength = pb.Length;
            Double pcLength = pc.Length;
            Double abLength = ab.Length;
            Double acLength = ac.Length;
            Double bcLength = bc.Length;

            Double heronP = 0.5 * (abLength + acLength + bcLength);

            double mainTriangleArea = heronAreaOfTriangle(abLength, bcLength, acLength);

            double triangleArea1 = heronAreaOfTriangle(paLength, pcLength, acLength);
            double triangleArea2 = heronAreaOfTriangle(abLength, pbLength, paLength);
            double triangleArea3 = heronAreaOfTriangle(pbLength, bcLength, pcLength);

            int counter = 0;
            if (triangleArea1 + triangleArea2 > mainTriangleArea)
                counter += 1;
            if (triangleArea2 + triangleArea3 > mainTriangleArea)
                counter += 1;
            if (triangleArea1 + triangleArea3 > mainTriangleArea)
                counter += 1;

            return counter <= 0;
        }

        public double heronAreaOfTriangle(double a, double b, double c)
        {
            double heronP = 0.5 * (a + b + c);

            return Math.Sqrt((heronP * (heronP - a) * (heronP - b) * (heronP - c)));
        }

        public bool getHitTriangleInfo(Ray ray, Plane plane)
        {

            if (plane.intersectPlane(ray) == false)
            {
                return false;
            }
            else
            {
                Vector3 ab = this.b - this.a;
                Vector3 ac = this.c - this.a;

                Vector3 crossVectors = Vector3.Cross(ab, ac).Normalized;




            }


            return true;
        }

        */
    }
    

}
