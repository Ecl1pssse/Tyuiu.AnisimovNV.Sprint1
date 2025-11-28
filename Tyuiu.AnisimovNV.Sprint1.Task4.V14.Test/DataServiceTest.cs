using Xunit;
using Tyuiu.AnisimovNV.Sprint1.Task4.V14.Lib;

namespace Tyuiu.AnisimovNV.Sprint1.Task4.V14.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 1.0;

            // Формула: sqrt(7 + |2-1|) / (3*2*1^2) = sqrt(8) / 6 ? 2.828 / 6 ? 0.471
            var res = ds.Calculate(x, y);
            Assert.Equal(0.471, res);
        }

        [Fact]
        public void ValidCalculateWithDifferentValues()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 2.0;

            // sqrt(7 + |3-2|) / (3*3*4) = sqrt(8)/36 ? 2.828/36 ? 0.079
            var res = ds.Calculate(x, y);
            Assert.Equal(0.079, res);
        }

        [Fact]
        public void ValidCalculatePrecise()
        {
            DataService ds = new DataService();
            double x = 1.5;
            double y = 0.5;

            var res = ds.Calculate(x, y);
            // Проверяем что результат округлен до 3 знаков
            Assert.Equal(1.257, res);
        }
    }
}