using Xunit;
using Tyuiu.AnisimovNV.Sprint1.Task6.V6.Lib;

namespace Tyuiu.AnisimovNV.Sprint1.Task6.V6.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidDeleteFirstLetter()
        {
            DataService ds = new DataService();
            string value = "ѕривет мир программирование";
            string wait = "ривет ир рограммирование";
            var res = ds.DeleteFirstLetter(value);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidDeleteFirstLetterWithPunctuation()
        {
            DataService ds = new DataService();
            string value = "Hello, world! Programming is fun.";
            string wait = "ello orld rogramming s un";
            var res = ds.DeleteFirstLetter(value);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidDeleteFirstLetterSingleLetterWords()
        {
            DataService ds = new DataService();
            string value = "I am a student";
            string wait = "am student";
            var res = ds.DeleteFirstLetter(value);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidDeleteFirstLetterEmptyString()
        {
            DataService ds = new DataService();
            string value = "";
            string wait = "";
            var res = ds.DeleteFirstLetter(value);
            Assert.Equal(wait, res);
        }

        [Fact]
        public void ValidDeleteFirstLetterRussianText()
        {
            DataService ds = new DataService();
            string value = "Ёто тестовый текст дл€ проверки";
            string wait = "то естовый екст л€ роверки";
            var res = ds.DeleteFirstLetter(value);
            Assert.Equal(wait, res);
        }
    }
}