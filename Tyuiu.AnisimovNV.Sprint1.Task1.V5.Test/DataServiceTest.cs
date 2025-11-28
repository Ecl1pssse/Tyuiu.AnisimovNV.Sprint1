using Xunit;
using Tyuiu.AnisimovNV.Sprint1.Task1.V16.Lib;

namespace Tyuiu.AnisimovNV.Sprint1.Task1.V16.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidCalculation()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(2, 3, 4);
            // 2 * 5 * 3 + 2 * 4 = 30 + 8 = 38
            Assert.Equal(38, result);
        }
    }
}