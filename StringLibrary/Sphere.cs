using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using StringLibrary;

namespace ShapeLibrary
{
    public class Sphere : Shape3D
    {
        private Vector3 _center;
        private float _radius;
        public Sphere(Vector3 center, float radius)
        {
            _center = center;
            _radius = radius;
        }
        //formel för sfärens volym
        public override float Volume => (float)((4 * Math.PI * (Math.Pow(_radius, 3))) / 3);

        public override Vector3 Center => new Vector3(_center.X, _center.Y, _center.Z);
        //formel för sfärens area
        public override float Area => (float)(4 * Math.PI * (Math.Pow(_radius, 2)));

        public override string ToString() => $"Sphere@ ({_center.X:0.0}, {_center.Y:0.0}, {_center.Z:0.0}): Radius = {_radius:0.0}";

        
    }
}
