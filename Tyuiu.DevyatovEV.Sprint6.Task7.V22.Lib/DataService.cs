using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DevyatovEV.Sprint6.Task7.V22.Lib
{
    public class DataService : ISprint6Task7V22
    {
        public int[,] GetMatrix(string path)
        {
            if (!File.Exists(path)) throw new FileNotFoundException($"Файл не найден: {path}");

            var lines = File.ReadAllLines(path);
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var values = lines[i].Split(';').Select(s => s.Trim()).Where(s => !string.IsNullOrEmpty(s)).ToArray();
                if (values.Length != cols) throw new InvalidDataException($"Несоответствие количества столбцов в строке {i + 1}");

                for (int j = 0; j < cols; j++)
                    if (!int.TryParse(values[j], out matrix[i, j]))
                        throw new FormatException($"Неверный формат числа в строке {i + 1}, столбец {j + 1}: '{values[j]}'");
            }

            return matrix;
        }

        public int[,] ProcessMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = (int[,])matrix.Clone();

            for (int i = 0; i < rows; i++)
            {
                if (cols > 5)
                {
                    int value = result[i, 5];
                    if (value > 0 && value % 2 == 0)
                    {
                        result[i, 5] = 111;
                    }
                }
            }

            return result;
        }

        public void SaveMatrix(int[,] matrix, string path)
        {
            int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
            var lines = new string[rows];
            for (int i = 0; i < rows; i++)
                lines[i] = string.Join(";", Enumerable.Range(0, cols).Select(j => matrix[i, j].ToString()));
            File.WriteAllLines(path, lines);
        }
    }
}