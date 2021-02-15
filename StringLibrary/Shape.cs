using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace StringLibrary
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        private static readonly Random r = new Random();


        public static Shape GenerateShape()
        {

            var randomShape = r.Next(0, 7);

            switch (randomShape)
            {
                //cirkel
                case 0:
                    return new Circle(new Vector2(RandomFloat(1, 5), RandomFloat(1, 5)), RandomFloat(1, 5));
                //fyrkant
                case 1:
                    return new Rectangle(new Vector2(RandomFloat(1, 5), RandomFloat(1, 5)), RandomFloat(1, 5));
                //rektangel
                case 2:
                    return new Rectangle(new Vector2(RandomFloat(1, 5), RandomFloat(1, 5)),
                         new Vector2(RandomFloat(1, 5), RandomFloat(1, 5)));
                //rätblock
                case 3:
                    return new Cuboid(new Vector3(RandomFloat(1, 5), RandomFloat(1, 5), RandomFloat(1, 5)),
                        new Vector3(RandomFloat(1, 5), RandomFloat(1, 5), RandomFloat(1, 5)));
                //kub
                case 4:
                    return new Cuboid(new Vector3(RandomFloat(1, 5), RandomFloat(1, 5), RandomFloat(1, 5)), RandomFloat(1, 5));
                //sfär
                case 5:
                    return new Sphere(new Vector3(RandomFloat(1, 5), RandomFloat(1, 5), RandomFloat(1, 5)), RandomFloat(1, 5));
                //triangel
                case 6:
                    return new Triangle(new Vector2(RandomFloat(1, 5), RandomFloat(1, 5)),
                      new Vector2(RandomFloat(1, 5), RandomFloat(1, 5)),
                      new Vector2(RandomFloat(1, 5), RandomFloat(1, 5)));
            }

            return null;
        }

        public static Shape GenerateShape(Vector3 centerPos)
        {
            var randomShape = r.Next(0, 7);

            switch (randomShape)
            {
                //cirkel
                case 0:
                    return new Circle(new Vector2(centerPos.X, centerPos.Y), RandomFloat(1, 5));
                //fyrkant
                case 1:
                    return new Rectangle(new Vector2(centerPos.X, centerPos.Y), RandomFloat(1, 5));
                //rektangel
                case 2:
                    return new Rectangle(new Vector2(centerPos.X, centerPos.Y),
                        new Vector2(RandomFloat(1, 5), RandomFloat(1, 5)));
                //rätblock
                case 3:
                    return new Cuboid(new Vector3(centerPos.X, centerPos.Y, centerPos.Z),
                        new Vector3(RandomFloat(1, 5), RandomFloat(1, 5), RandomFloat(1, 5)));
                //kub
                case 4:
                    return new Cuboid(new Vector3(centerPos.X, centerPos.Y, centerPos.Z), RandomFloat(1, 5));
                //sfär 
                case 5:
                    return new Sphere(new Vector3(centerPos.X, centerPos.Y, centerPos.Z), RandomFloat(1, 5));
                //triangel
                case 6:
                    // slumpar 2 positioner och räknar ut tredje med centerPos
                    var p1X = RandomFloat(1, 5);
                    var p1Y = RandomFloat(1, 5);
                    var p2X = RandomFloat(1, 5);
                    var p2Y = RandomFloat(1, 5);
                    var p3X = centerPos.X * 3 - (p1X + p2X);
                    var p3Y = centerPos.Y * 3 - (p1Y + p2Y);
                    return new Triangle(new Vector2(p1X, p1Y), new Vector2(p2X, p2Y), new Vector2(p3X, p3Y));
            }

            return null;
        }

        public static float RandomFloat(double min, double max)
        {
            return (float)(r.NextDouble() * (max - min) + min);
        }
    }

}
