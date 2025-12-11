using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DevyatovEV.Sprint6.Task2.V12.Lib
{
    public class DataService : ISprint6Task2V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] resultArray = new double[length];

            for (int i = 0; i < length; i++)
            {
                double x = startValue + i;

                // Знаменатель: cos(x) + x
                double denominator = Math.Cos(x) + x;

                // Проверка деления на ноль
                if (Math.Abs(denominator) < 0.000001)
                {
                    resultArray[i] = 0; // При делении на ноль вернуть 0
                }
                else
                {
                    // Вычисление: F(x) = (2x+6)/(cos(x)+x) - 3
                    double numerator = 2 * x + 6;
                    double fx = numerator / denominator - 3;

                    // Округление до двух знаков после запятой
                    resultArray[i] = Math.Round(fx, 2);
                }
            }

            return resultArray;
        }
    }
}