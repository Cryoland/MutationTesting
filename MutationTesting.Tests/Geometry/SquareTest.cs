using MutationTesting.Geometry;
using System;
using Xunit;

namespace MDD.Geometry
{
    public class SquareTest
    {
        [Theory]
        [Trait("Constructor", "Exceptions")]
        [InlineData(10, 5)]
        public void Handle_Neq_Parameters(long w, long h)
        {
            var ex = Assert.Throws<ArgumentException>(() => new Square(w, h));

            Assert.Equal("Parameters are not equal.", ex.Message);
        }
    }
}
