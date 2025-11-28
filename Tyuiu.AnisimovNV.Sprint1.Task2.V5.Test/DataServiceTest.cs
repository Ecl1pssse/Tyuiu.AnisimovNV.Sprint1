using Xunit;
using Tyuiu.AnisimovNV.Sprint1.Task2.V5.Lib;

namespace Tyuiu.AnisimovNV.Sprint1.Task2.V5.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidCalculation()
        {
            DataService ds = new DataService();
            int result = ds.Calculate(3);
            Assert.Equal(54, result);
        }
    }
}