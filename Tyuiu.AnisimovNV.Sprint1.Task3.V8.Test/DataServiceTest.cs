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
            double deposit = 5000;
            double rate = 10;
            double days = 40;

            var res = ds.IncomeAmount(deposit, rate, days);
            Assert.Equal(54.795, res); // Теперь должно совпасть
        }

        [Fact]
        public void ValidIncomeAmountExample()
        {
            DataService ds = new DataService();
            double deposit = 2500;
            double rate = 20;
            double days = 30;

            var res = ds.IncomeAmount(deposit, rate, days);
            Assert.Equal(41.096, res); // 41.09589 -> 41.096
        }
    }
}