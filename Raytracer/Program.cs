using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Raytracer
{
    class Program
    {
        static void Main(string[] args)
        {
           
                // Stworzenie świata (kolor tła)
                World world = new World(Color.White);

            IMaterial WhiteMat = new Phong(Color.White, 0.8, 0, 1000);
            IMaterial RedMat = new Phong(Color.Red, 0.8, 0, 1000);
            IMaterial BlueMat = new Phong(Color.Blue, 0.8, 0, 1000);
            IMaterial Reflect = new Reflective(Color.White, 0.4, 0, 1000, 1.0);

            world.Add(new Plane(new Vector3(0, -2, 0), // punkt płaszczyzny
               new Vector3(0, 1, 0), // normalna płaszczyzny
               WhiteMat)); // kolor

            world.Add(new Plane(new Vector3(-4.5, 0, 0), new Vector3(-4.5, 1, 0), // punkt płaszczyzny
            new Vector3(-4.5, 0, 1), // normalna płaszczyzny
            RedMat)); // kolor

            world.Add(new Plane(new Vector3(4.5, 0, 0), new Vector3(4.5, -1, 0), // punkt płaszczyzny
           new Vector3(4.5, 0, 1), // normalna płaszczyzny
           BlueMat)); // kolor

            world.Add(new Plane(new Vector3(3, 0, -3f), // punkt płaszczyzny
                 new Vector3(0, 0, -1), // normalna płaszczyzny
                WhiteMat)); // kolor

            world.Add(new Plane(new Vector3(0, 5, -5), // punkt płaszczyzny
              new Vector3(0, 1, 0), // normalna płaszczyzny
              WhiteMat)); // kolor

            world.Add(new Sphere(new Vector3(-1.6, -0.5, -5.0f), 1.2f, Reflect));

            world.Add(new Sphere(new Vector3(1.6, -1, -5.0f), 1.2f, Reflect));





            world.AddLight(new PointLight(new Vector3(0, 4.8, -5), Color.White));

            // Kamera perspektywiczna
            ICamera camera2 = new Pinhole(new Vector3(0, 0.5, -10),
            new Vector3(0, 0, 0),
            new Vector3(0, -1, 0),
            new Vector2(3,3),2);

            Raytracer tracer = new Raytracer(5);

            // Raytracing
            const int SampleCt = 9;

            Sampler antiAlias = new Sampler(new Regular(),new SquareDistributor(),SampleCt,1); 

            Bitmap image2 = tracer.Raytrace(world, camera2, new Size(300, 300), antiAlias);
            image2.Save("../../render/raytraced-per.png");
        }
    }
}
