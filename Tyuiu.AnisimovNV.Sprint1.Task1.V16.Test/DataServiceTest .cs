using Xunit;
using Tyuiu.AnisimovNV.Sprint1.Task1.V16.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AnisimovNV.Sprint1.Task1.V16.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double a = 3.0;
            double y = 4.0;

            // x*5*a+2*y = 2*5*3+2*4 = 30+8 = 38
            var res = ds.Calculate(x, a, y);
            Assert.Equal(38, res);
        }
    }
}