using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorApp
{
    public static class StringCalculator
    {
        public static int Add(string rawNumbers)
        {
            return Calculate(rawNumbers);
        }

        private static int Calculate(string rawNumbers)
        {
            int sum = 0;
            
            if (!string.IsNullOrEmpty(rawNumbers))
            {
                List<int> formattedNumbers = GetNumbers(rawNumbers);
                sum = formattedNumbers.Sum();
            }
            
            return sum;
        }

        private static List<int> GetNumbers(string rawNumbers)
        {
            string [] extractedNumbers = ExtractNumbers(rawNumbers);
            return ConvertToNumeric(extractedNumbers);
        }

        private static List<int> ConvertToNumeric(string[] extractedNumbers)
        {
            List<int> convertedList = new List<int>();
            foreach (string number in extractedNumbers)
            {
                try
                {
                    int convertedValue = Int32.Parse(number);
                    convertedList.Add(convertedValue);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            return convertedList;
        }

        private static string[] ExtractNumbers(string rawNumbers)
        {
            return rawNumbers.Split(',');
        }
    }
}