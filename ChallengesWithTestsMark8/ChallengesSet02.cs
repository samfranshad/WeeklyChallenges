using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string lowerLetters = "abcdefghijklmnopqrstuvwxyz";
            string upperLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (lowerLetters.Contains(c) || upperLetters.Contains(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int elementCount = 0;
            for (int i = 0; i < vals.Length; i++)
            {
                elementCount++;
            }
            if (elementCount%2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number%2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num%2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double sum = 0;
            if (numbers != null && numbers.Sum() != 0)
            {
                sum += numbers.Min();
                sum += numbers.Max();
                return sum;
            }
            else if (numbers != null && numbers.Sum() == 0)
            {
                return numbers.Sum();
            }
            else
            {
                return 0;
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers != null)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                return sum;
            }
            else
            {
                return 0;
            }
            
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers != null)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        sum += numbers[i];
                    }
                    else
                    {
                        sum += 0;
                    }
                }
                return sum;
            }
            else
            {
                return 0;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers != null)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                }
                if (sum % 2 == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            for (long i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }
            return count;


        }
    }
}
