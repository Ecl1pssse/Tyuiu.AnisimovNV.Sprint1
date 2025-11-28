using System;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AnisimovNV.Sprint1.Task6.V6.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            // Разделяем строку на слова, удаляем первую букву из каждого слова и объединяем обратно
            string[] words = value.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 1)
                {
                    words[i] = words[i].Substring(1);
                }
                else
                {
                    words[i] = ""; // Если слово из одной буквы - удаляем его
                }
            }

            return string.Join(" ", words).Trim();
        }
    }
}