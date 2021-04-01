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
                CheckForNegatives(formattedNumbers);
                sum = formattedNumbers.Sum();
            }
            
            return sum;
        }

        private static void CheckForNegatives(List<int> formattedNumbers)
        {
            List<int> negativeNumbers = new List<int>();
            foreach (int number in formattedNumbers)
            {
                if (IsNegative(number))
                {
                    negativeNumbers.Add(number);
                }
            }

            if (negativeNumbers.Any())
            {
                throw new Exception(
                    $"Negatives not allowed : {string.Join(" ", negativeNumbers.Select(x => x.ToString()).ToArray())}");
            }

    

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
                    if (!string.IsNullOrEmpty(number.Trim()))
                    {
                        int convertedValue = Int32.Parse(number);
                        convertedList.Add(convertedValue);
                    }
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
            return rawNumbers.Split(new Char[] {',', '\n', '\\', ';'});
        }
        
        public static bool IsNegative( int number)
        {
            return number < 0;
        }

    }
}