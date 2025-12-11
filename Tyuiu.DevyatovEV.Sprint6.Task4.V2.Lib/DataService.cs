using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DevyatovEV.Sprint6.Task4.V2.Lib
{
    public class DataService : ISprint6Task4V2
    {
        public double[] GetMassFunction(int startX, int endX)
        {
            int length = endX - startX + 1;
            double[] values = new double[length];

            for (int i = 0; i < length; i++)
            {
                double x = startX + i;

                // Проверка деления на ноль: знаменатель x - 0.7
                double denominator = x - 0.7;

                if (Math.Abs(denominator) < 0.000001)
                {
                    values[i] = 0; // При делении на ноль вернуть 0
                }
                else
                {
                    // Вычисление: F(x) = cos(x)/(x - 0.7) - sin(x) * 12 * x + 2
                    double part1 = Math.Cos(x) / denominator;      // cos(x)/(x - 0.7)
                    double part2 = Math.Sin(x) * 12 * x;          // sin(x) * 12 * x
                    double fx = part1 - part2 + 2;                // cos(x)/(x-0.7) - sin(x)*12x + 2

                    // Округление до двух знаков после запятой
                    values[i] = Math.Round(fx, 2, MidpointRounding.AwayFromZero);
                }
            }

            return values;
        }
    }
}