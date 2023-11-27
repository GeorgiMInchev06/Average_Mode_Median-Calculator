using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAverageModeMedian
{
    public class Calculating
    {
        public double CalculateMode(double[] numbers)
        {
            var frequencyDict = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (frequencyDict.ContainsKey(number))
                {
                    frequencyDict[number]++;
                }
                else
                {
                    frequencyDict[number] = 1;
                }
            }

            int maxFrequency = frequencyDict.Values.Max();

            var modes = frequencyDict.Where(pair => pair.Value == maxFrequency).Select(pair => pair.Key).ToList();

            return modes.Count > 0 ? modes[0] : double.NaN;
        }

        public double CalculateMedian(double[] numbers)
        {
            Array.Sort(numbers);

            int n = numbers.Length;

            if (n % 2 == 0)
            {
                int middleIndex1 = n / 2 - 1;
                int middleIndex2 = n / 2;
                return (numbers[middleIndex1] + numbers[middleIndex2]) / 2.0;
            }
            else
            {
                int middleIndex = n / 2;
                return numbers[middleIndex];
            }
        }
    }
}
