using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DevyatovEV.Sprint6.Task0.V23.Lib
{
    public class DataService : ISprint6Task0V23
    {
        public double Calculate(int x)
        {
            if (x + 2 == 0)
            {
                throw new ArgumentException("Знаменатель дроби равен нулю! x не может быть -2");
            }

            double argument = (double)(x + 1) / (x + 2);
            if (argument <= 0)
            {
                throw new ArgumentException("Аргумент логарифма должен быть положительным!");
            }

            double result = Math.Log(argument);
            return Math.Round(result, 3);
        }
    }
}