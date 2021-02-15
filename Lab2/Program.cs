using System;
using ShapeLibrary;
using System.Numerics;
using System.Collections.Generic;
using System.Globalization;
using StringLibrary;

namespace Lab2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var shapeList = new List<Shape>();
            float triangleSum = 0, totalArea = 0;
            Shape3D my3DShape = null;
           

            
            for (int i = 0; i < 20; i++)
                shapeList.Add(Shape.GenerateShape(new Vector3(3.0f, 3.0f, 4.0f)));

            foreach (var shape in shapeList)
            {
                if (shape is Shape3D)
                {
                    if (my3DShape == null)
                        my3DShape = (Shape3D)shape;

                    var maxVol = (Shape3D)shape;

                    if (maxVol.Volume > my3DShape.Volume)
                        my3DShape = maxVol;
                }
                if (shape is Triangle)
                {
                    var triangle = (Triangle)shape;
                    triangleSum += triangle.Circumference;
                }
                Console.WriteLine($"{shape}");
                totalArea += shape.Area;
            }
            Console.WriteLine($"\nAverage area of all shapes: {totalArea / 20:0.0}");
            Console.WriteLine($"Circumference of all triangles: {triangleSum:0.0}");
            Console.WriteLine($"The 3D shape with the largest volume is: {my3DShape}\nWith a volume of: {my3DShape.Volume:0.0}");


           


        }
    }
}
