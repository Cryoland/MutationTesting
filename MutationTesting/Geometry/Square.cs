using System;
using System.Collections.Generic;
using System.Text;

namespace MutationTesting.Geometry
{
    public class Square : Rectangle
    {
        public Square(long w, long h) : base(w, h)
        {
            if (w != h)
                throw new ArgumentException("Parameters are not equal.");
        }
    }
}
