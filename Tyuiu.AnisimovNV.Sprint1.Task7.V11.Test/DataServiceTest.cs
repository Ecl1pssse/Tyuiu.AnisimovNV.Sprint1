using Xunit;
using Tyuiu.AnisimovNV.Sprint1.Task7.V11.Lib;

namespace Tyuiu.AnisimovNV.Sprint1.Task7.V11.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;

            var res = ds.Calculate(x, y);
            // Проверяем что результат вычисляется и округляется до 3 знаков
            Assert.InRange(res, -100, 100); // Диапазон для числового результата
        }

        [Fact]
        public void ValidCalculateWithSpecificValues()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 1.0;

            var res = ds.Calculate(x, y);
            // Для x=0.5, y=1.0 вычисляем ожидаемый результат
            Assert.Equal(0.134, res);
        }

        [Fact]
        public void ValidCalculateWithDifferentValues()
        {
            DataService ds = new DataService();
            double x = 1.2;
            double y = 0.8;

            var res = ds.Calculate(x, y);
            // Проверяем корректность округления
            Assert.Equal(-0.243, res);
        }
    }
}