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
            string [] extractedStringNumbers = ExtractNumbers(rawNumbers);
            return ConvertToNumeric(extractedStringNumbers);
        }

        private static List<int> ConvertToNumeric(string[] extractedStringNumbers)
        {
            List<int> convertedList = new List<int>();
            foreach (string number in extractedStringNumbers)
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