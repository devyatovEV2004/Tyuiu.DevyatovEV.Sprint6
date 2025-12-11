using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DevyatovEV.Sprint6.Task5.V29.Lib
{
    public class DataService : ISprint6Task5V29
    {
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            List<double> numbers = new List<double>();
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] parts = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string part in parts)
                {
                    if (double.TryParse(part.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double num))
                    {
                        num = Math.Round(num, 3, MidpointRounding.AwayFromZero);

                        if (num >= 10)
                        {
                            numbers.Add(num);
                        }
                    }
                }
            }

            return numbers.ToArray();
        }
    }
}