using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Virtual_Methods
{
    class Square : IShape
    {
        private float _side;

        public Square(int side)
        {
            _side = side;
        }

        public Square()
        {
            _side = 0;
        }

        public float Side
        {
           get { return _side; }
           set { _side = value; }
        }

        public void Draw()
        {
            Console.WriteLine("Hi, I am a square");
        }

        public float GetArea()
        {
            return _side * _side;
        }

    }
}
