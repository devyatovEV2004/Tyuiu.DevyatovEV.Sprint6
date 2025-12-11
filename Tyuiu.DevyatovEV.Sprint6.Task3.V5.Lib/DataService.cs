using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DevyatovEV.Sprint6.Task3.V5.Lib
{
    public class DataService : ISprint6Task3V5
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Копируем исходную матрицу
            int[,] result = (int[,])matrix.Clone();

            // Собираем значения третьего столбца (индекс 2)
            int[] thirdColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                thirdColumn[i] = result[i, 2];
            }

            // Сортируем значения третьего столбца по возрастанию
            Array.Sort(thirdColumn);

            // Вставляем отсортированные значения обратно в третий столбец
            for (int i = 0; i < rows; i++)
            {
                result[i, 2] = thirdColumn[i];
            }

            return result;
        }
    }
}