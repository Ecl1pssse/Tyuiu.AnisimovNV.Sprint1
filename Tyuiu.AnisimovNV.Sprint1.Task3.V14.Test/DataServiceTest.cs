using Xunit;
using Tyuiu.AnisimovNV.Sprint1.Task3.V14.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AnisimovNV.Sprint1.Task3.V14.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidCalculateFormula()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 1.0;

            var res = ds.CalculateFormula(x, y);
            Assert.Equal(0.471, res);
        }

        [Fact]
        public void ValidCalculateFormulaWithDifferentValues()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 2.0;

            var res = ds.CalculateFormula(x, y);
            // sqrt(7 + |3-2|) / (3*3*4) = sqrt(8)/36 ? 2.828/36 ? 0.079
            Assert.Equal(0.079, res);
        }
    }
}