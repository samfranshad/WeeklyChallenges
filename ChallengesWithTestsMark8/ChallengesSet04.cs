using System;
using System.Reflection.Metadata;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
                else
                {
                    sum -= numbers[i];
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var lengthOne = str1.Length;
            var lengthTwo = str2.Length;
            var lengthThree = str3.Length;
            var lengthFour = str4.Length;

            if (lengthOne <= lengthTwo && lengthOne <= lengthThree && lengthOne <= lengthFour)
            {
                return lengthOne;
            }
            else if (lengthTwo <= lengthOne && lengthTwo <= lengthThree && lengthTwo <= lengthFour)
            {
                return lengthTwo;
            }
            else if (lengthThree <= lengthOne && lengthThree <= lengthTwo && lengthThree <= lengthFour)
            {
                return lengthThree;
            }
            else
            {
                return lengthFour;
            }
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            if (number1 <= number2 && number1 <= number3 && number1 <= number4)
            {
                return number1;
            }
            else if (number2 <= number1 && number2 <= number3 && number2 <= number4)
            {
                return number2;
            }
            else if (number3 <= number1 && number3 <= number2 && number3 <= number4)
            {
                return number3;
            }
            else
            {
                return number4;
            }
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {

            biz.Name = "TrueCoders";

        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if ((sideLength1 + sideLength2 > sideLength3) && (sideLength2 + sideLength3 > sideLength1) && (sideLength1 + sideLength3 > sideLength2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            bool result = double.TryParse(input, out var number);
            return result;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nullCounter = 0;

            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    nullCounter++;
                }
            }

            if (nullCounter > objs.Length/2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers != null)
            {
                double evensSum = 0;
                double evensCount = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        evensCount++;
                        evensSum += numbers[i];
                    }
                }

                if (evensCount == 0)
                {
                    return 0;
                }
                else
                {
                    double evensAverage = evensSum / evensCount;
                    return evensAverage;
                }
            }
            else
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            int result = 1;

            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = number; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
