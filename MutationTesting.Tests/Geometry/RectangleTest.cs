using MutationTesting.Geometry;
using System;
using Xunit;

namespace MDD.Geometry
{
    public class RectangleTest
    {
        [Theory]
        [Trait("Constructor", "Exceptions")]
        [InlineData(-1, -1)]
        [InlineData(-1, 0)]
        [InlineData(-1, 1)]
        [InlineData(0, -1)]
        [InlineData(0, 0)]
        [InlineData(0, 1)]
        [InlineData(1, -1)]
        [InlineData(1, 0)]
        public void Handle_Wrong_Input_Paraneters(long w, long h)
        {
            var ex = Assert.Throws<ArgumentException>(() => new Rectangle(w, h));

            Assert.Equal("Wrong input parameters.", ex.Message);
        }

        [Theory]
        [Trait("Methods", "Results")]
        [InlineData(1, 1)]
        [InlineData(10, 1)]
        [InlineData(1, 10)]
        [InlineData(10, 10)]
        [InlineData(long.MaxValue / 10, 5)]
        public void Perimeter_Is_A_Double_Sum_Of_Witdh_And_Height(long w, long h)
        {
            Assert.Equal(2 * w * h, new Rectangle(w, h).GetPerimeter());
        }

        [Theory]
        [Trait("Methods", "Results")]
        [InlineData(2, 2)]
        [InlineData(10, 2)]
        [InlineData(2, 10)]
        [InlineData(20, 20)]
        [InlineData(long.MaxValue / 10, 10)]
        public void Square_Is_A_Double_Product_Of_Witdh_And_Height(long w, long h)
        {
            Assert.Equal(w * h, new Rectangle(w, h).GetArea());
        }

        [Theory]
        [Trait("Methods", "Overflows")]
        [InlineData(long.MaxValue / 10, 5 * 2)]
        public void Handle_Arithmetic_Overflow_Calculating_Perimeter(long w, long h)
        {
            var ex = Assert.Throws<OverflowException>(() => new Rectangle(w, h).GetPerimeter());

            Assert.Equal("Arithmetic operation resulted in an overflow.", ex.Message);
        }

        [Theory]
        [Trait("Methods", "Overflows")]
        [InlineData(long.MaxValue / 10, 10 * 2)]
        public void Handle_Arithmetic_Overflow_Calculating_Area(long w, long h)
        {
            var ex = Assert.Throws<OverflowException>(() => new Rectangle(w, h).GetArea());

            Assert.Equal("Arithmetic operation resulted in an overflow.", ex.Message);
        }
    }
}
