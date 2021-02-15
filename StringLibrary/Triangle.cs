using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using StringLibrary;

namespace ShapeLibrary
{
  public class Triangle : Shape2D, IEnumerator<Triangle>, IEnumerable<Triangle>
    {
        

        Vector2 _p1, _p2, _p3;
        private Vector2 _tCenter;
        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            _p1 = p1;
            _p2 = p2;
            _p3 = p3;
            _tCenter.X = (float)((p1.X + p2.X + p3.X) / 3);
            _tCenter.Y = (float)((p1.Y + p2.Y + p3.Y) / 3);
        }

      
        //formel för triangels omkrets
        public override float Circumference =>
            (float)((Math.Sqrt((Math.Pow(_p1.X - _p2.X, 2) + Math.Pow(_p1.Y - _p2.Y, 2)))) +
                    (Math.Sqrt((Math.Pow(_p2.X - _p3.X, 2) + Math.Pow(_p2.Y - _p3.Y, 2)))) +
                    (Math.Sqrt((Math.Pow(_p3.X - _p1.X, 2) + Math.Pow(_p3.Y - _p1.Y, 2)))));

        public override Vector3 Center => new Vector3(_tCenter.X, _tCenter.Y, 0f);
        //formel för triangelns area
        public override float Area => (float)0.5 * Math.Abs((_p1.X * (_p2.Y - _p3.Y)) + (_p2.X * (_p3.Y - _p1.Y)) + (_p3.X * (_p1.Y - _p2.Y)));

        public override string ToString()
        {
            return $"Triangle@ ({_tCenter.X:0.0}, {_tCenter.Y:0.0}): p1({_p1.X:0.0}, {_p1.Y:0.0}), p2({_p2.X:0.0}, {_p2.Y:0.0}), p3({_p3.X:0.0}, {_p3.Y:0.0})";
        }







        //för VG delen (går inte så bra)
        public Triangle _triangle;
        public int _index;
        public List<Triangle> _triangles = new List<Triangle>();
        public int Count => _triangles.Count;
        public Triangle this[int idx] => _triangles[idx];


        public Triangle(Triangle triangle)
        {
            _triangle = triangle;
            _index = -1;
        }

        public Triangle Current => _triangle[_index];

        object IEnumerator.Current =>  Current;

        public IEnumerator<Triangle> GetEnumerator()
        {
             return new Triangle(this);
        }

        IEnumerator<Triangle> IEnumerable<Triangle>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            return ++_index < _triangle.Count;
        }

        public void Reset()
        {
            _index = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {
        }
    }
}
