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
            Assert.Equal(54.795, res);
        }

        [Fact]
        public void ValidIncomeAmountPrecise()
        {
            DataService ds = new DataService();
            double deposit = 5000;
            double rate = 10;
            double days = 40;

            var res = ds.IncomeAmount(deposit, rate, days);
            // ѕровер€ем точное значение
            Assert.Equal(54.795, res, 3); // 3 знака точности
        }
    }
}