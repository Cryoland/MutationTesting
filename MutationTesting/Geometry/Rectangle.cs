using MutationTesting.Geometry.Interfaces;
using System;

namespace MutationTesting.Geometry
{
    public class Rectangle : IShape
    {
        public readonly long width;
        public readonly long height;

        public Rectangle(long w, long h)
        {
            if (w <= 0 || h <= 0)
                throw new ArgumentException("Wrong input parameters.");

            width = w;
            height = h;
        }

        public long GetPerimeter()
        {
            return checked(2 * width * height);
        }

        public long GetArea()
        {
            return checked(width * height);
        }
    }
}
