using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DevyatovEV.Sprint6.Task6.V5.Lib
{
    public class DataService : ISprint6Task6V5
    {
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            string content = File.ReadAllText(path);
            StringBuilder result = new StringBuilder();

            char[] separators = new char[] { ' ', '\t', '\r', '\n', ',', '.', '!', '?', ';', ':', '-', '(', ')', '[', ']', '{', '}', '"', '\'' };
            string[] words = content.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (word.IndexOf('l') >= 0 || word.IndexOf('L') >= 0)
                {
                    if (result.Length > 0)
                        result.Append(" ");
                    result.Append(word);
                }
            }

            return result.Length > 0 ? result.ToString() : "Слов с буквой 'l' не найдено.";
        }
    }
}