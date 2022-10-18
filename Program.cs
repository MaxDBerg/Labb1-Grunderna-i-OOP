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
            c.Getcircumference();
            c.GetVolume();
            k.GetArea();
            k.Getcircumference();
            k.GetVolume();
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
        public void Getcircumference()
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
