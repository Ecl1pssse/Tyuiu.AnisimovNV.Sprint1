using Xunit;
using Tyuiu.AnisimovNV.Sprint1.Task5.V1.Lib;

namespace Tyuiu.AnisimovNV.Sprint1.Task5.V1.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidDistanceBetweenDots()
        {
            DataService ds = new DataService();
            double x1 = 1;
            double y1 = 1;
            double x2 = 4;
            double y2 = 5;

            // Расстояние между (1,1) и (4,5): sqrt((4-1)^2 + (5-1)^2) = sqrt(9 + 16) = sqrt(25) = 5
            var res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.Equal(5, res);
        }

        [Fact]
        public void ValidDistanceBetweenDotsWithDecimals()
        {
            DataService ds = new DataService();
            double x1 = 2.5;
            double y1 = 3.7;
            double x2 = 6.1;
            double y2 = 8.2;

            // Расстояние округляется до целого
            var res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            // sqrt((6.1-2.5)^2 + (8.2-3.7)^2) = sqrt(12.96 + 20.25) = sqrt(33.21) ? 5.76 -> 6
            Assert.Equal(6, res);
        }

        [Fact]
        public void ValidDistanceBetweenSamePoints()
        {
            DataService ds = new DataService();
            double x1 = 3;
            double y1 = 3;
            double x2 = 3;
            double y2 = 3;

            var res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.Equal(0, res);
        }
    }
}