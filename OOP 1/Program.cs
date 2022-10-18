using System;
using System.Runtime.CompilerServices;

namespace OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new Circle(6);
            var k = new Circle(5);
            c.GetArea();
            c.GetCircumference();
            c.GetVolume();
            k.GetArea();
            k.GetCircumference();
            k.GetVolume();

            var t = new Triangle(10);
            t.GetArea();
            t.GetCircumference();
            t.GetVolume();
        }
    }
    class Triangle
    {
        public float _triangleBen { get; set; }
        public float _triangleArea { get; set; }
        public float _triangleCircumference { get; set; }
        public float _triangleVolume { get; set; }
        public Triangle(float triangleBen)
        {
            _triangleBen = triangleBen;
        }
        public void GetArea()
        {
            _triangleArea = (_triangleBen * _triangleBen * (float) Math.Sqrt(3)) / 4;
            Console.WriteLine(_triangleArea);
        }
        public void GetCircumference()
        {
            _triangleCircumference = _triangleBen * 3;
            Console.WriteLine(_triangleCircumference);
        }
        public void GetVolume()
        {
            _triangleVolume = ((_triangleBen * _triangleBen) * _triangleBen) / 3;
            Console.WriteLine(_triangleVolume);
        }
    }
    class Circle
    {
        public float _pi { get; set; }  
        public int _radius { get; set; }
        public float _area { get; set; }
        public float _circumference { get; set; }
        public float _volume { get; set; }
        public Circle(int radie)
        {
            _pi = 3.1415f;
            _radius = radie;
        }
        public void GetArea()
        {
            _area = (float)_radius * (float)_radius *_pi;
            Console.WriteLine(_area);
        }
        public void GetCircumference()
        {
            _circumference = 2 *_pi * (float)_radius;
            Console.WriteLine(_circumference);
        }
        public void GetVolume()
        {
            _volume = (4 * _pi * (float) Math.Pow((double)_radius, 3)) / 3;
            Console.WriteLine(_volume);
        }

    }
}
