using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using StringLibrary;

namespace ShapeLibrary
{
    public class Cuboid : Shape3D
    {
        private bool _isCube = false;
        private float _width, _height, _depth;
        private Vector3 _center;

        public Cuboid(Vector3 center, Vector3 size)
        {
            _center = center;
            _width = size.X;
            _height = size.Y;
            _depth = size.Z;

            //Om alla värden är lika är isCube sann
            if (size.X == size.Y && size.Y == size.Z) 
                _isCube = true;
        }

        public Cuboid(Vector3 center, float width)
        {
            _center = center;
            _width = width;
            _height = width;
            _depth = width;

            _isCube = true;
        }


        //räkna ut kubens/rätblockets volym
        public override float Volume
        {
            get {if (_isCube == true)
                    return (float)(Math.Pow(_depth, 3));
                else                    
                    return (float)(_width * _height * _depth);
            }
        }

        public override Vector3 Center => new Vector3(_center.X, _center.Y, _center.Z);
        //formel för att räkna ut arean för kuben/rätblocket
        public override float Area => (float)((2 * _depth * _width) + (2 * _depth * _height) + (2 * _height * _width));


        public override string ToString()
        {
            if (_isCube == true)
            {
                return $"Cube@ ({_center.X:0.0}, {_center.Y:0.0}, {_center.Z:0.0}) Width = {_width:0.0}, Height = {_height:0.0}, Depth = {_depth:0.0}";
            }
            else
            {
                return $"Cuboid@ ({_center.X:0.0}, {_center.Y:0.0}, {_center.Z:0.0}) Width = {_width:0.0}, Height = {_height:0.0}, Depth = {_depth:0.0}";
            }
        }



        public string IsCube
        {
            get
            {
                if (_isCube != true)
                    return "False";
                else
                {
                    return "True";
                }
            }
        }
    }
}
