using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using StringLibrary;

namespace ShapeLibrary
{
  public class Rectangle : Shape2D
    {
        bool _isSquare = false;
        Vector2 _center;
        private float _width, _height;

        public Rectangle(Vector2 center, Vector2 size)
        {
            _center = center;
            _height = size.X;
            _width = size.Y;

            if(size.X == size.Y)
            {
                _isSquare = true;
            }
        }
        public Rectangle(Vector2 center, float width)
        {
            _center = center;
            _height = width;
            _width = width;
            _isSquare = true;
        }
        //formel för rektangelns omkrets
        public override float Circumference => (float)(_width * 2) + (_height * 2);

        public override Vector3 Center => new Vector3(_center.X, _center.Y, 0f);
        //formel för rektangelns area
        public override float Area => (float)(_width * _height);

        public override string ToString()
        {
            if (_isSquare == true)
                return $"Square@ ({_center.X:0.0},{_center.Y:0.0}) Width: {_width:0.0}, Height: {_height:0.0}";
            else
                return $"Square@ ({_center.X:0.0},{_center.Y:0.0}) Width: {_width:0.0}, Height: {_height:0.0}";
        }


        public string IsSquare
        {
            get {if (_isSquare != true)
                    return "False";
                else
                    return "True";
            }

        }
    }
}
