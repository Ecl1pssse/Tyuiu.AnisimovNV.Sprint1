using Xunit;
using Tyuiu.AnisimovNV.Sprint1.Task3.V8.Lib;

namespace Tyuiu.AnisimovNV.Sprint1.Task3.V8.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidIncomeAmount()
        {
            DataService ds = new DataService();
            double deposit = 2500;
            double rate = 20;
            double days = 30;

            var res = ds.IncomeAmount(deposit, rate, days);
            Assert.Equal(41.10, res);
        }

        [Fact]
        public void ValidIncomeAmountDifferentValues()
        {
            DataService ds = new DataService();
            double deposit = 10000;
            double rate = 15;
            double days = 60;

            var res = ds.IncomeAmount(deposit, rate, days);
            Assert.Equal(246.58, res);
        }
    }
}