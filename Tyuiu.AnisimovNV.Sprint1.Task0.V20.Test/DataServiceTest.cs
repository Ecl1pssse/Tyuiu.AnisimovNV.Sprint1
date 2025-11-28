using Tyuiu.AnisimovNV.Sprint1.Task0.V20.Lib;
using Xunit;

namespace Tyuiu.AnisimovNV.Sprint1.Task1.V20.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.Equal(13, res);
        }
    }
}