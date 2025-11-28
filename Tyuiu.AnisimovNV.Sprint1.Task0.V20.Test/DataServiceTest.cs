using Xunit;
using Tyuiu.AnisimovNV.Sprint1.Task0.V20.Lib;

namespace Tyuiu.AnisimovNV.Sprint1.Task0.V20.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.Equal(13, res);
        }
    }
}