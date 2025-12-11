using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DevyatovEV.Sprint6.Task1.V21.Lib
{
    public class DataService : ISprint6Task1V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] resultArray = new double[len];

            for (int i = 0; i < len; i++)
            {
                double x = startValue + i;

                // Проверка деления на ноль: знаменатель 2-2x не должен быть равен 0
                double denominator = 2 - 2 * x;

                if (Math.Abs(denominator) < 0.000001) // если знаменатель близок к 0 (x = 1)
                {
                    resultArray[i] = 0; // При делении на ноль вернуть 0
                }
                else
                {
                    // Вычисляем F(x) = cos(x) + sin(x)/(2-2x) - 4x
                    double fx = Math.Cos(x) + Math.Sin(x) / denominator - 4 * x;
                    resultArray[i] = Math.Round(fx, 2); // Округляем до 2 знаков
                }
            }

            return resultArray;
        }
    }
}