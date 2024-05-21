using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            var valsList = vals.ToList();

            if (valsList.Contains(false))
            {
                return true;
            }
            else
            {
                return false;
            }
          
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers != null)
            {
                int sum = 0;

                List<int> numberList = new List<int>();
                numberList = numbers.ToList();

                for (int i = 0; i < numberList.Count(); i++)
                {
                    if (numberList[i] % 2 != 0)
                    {
                        sum += numberList[i];
                    }
                    else
                    {
                        sum += 0;
                    }
                }

                if (sum % 2 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {

            bool containsUpper = false;
            bool containsLower = false;
            bool containsNumber = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    containsUpper = true;
                }

                if (char.IsLower(password[i]))
                {
                    containsLower = true;
                }

                if (char.IsNumber(password[i]))
                {
                    containsNumber = true;
                }
                
            }

            if(containsUpper == true && containsLower == true && containsNumber == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public char GetFirstLetterOfString(string val)
        {
            char[] chars = new char[val.Length];
            for (int i = 0; i < val.Length; i++)
            {
                chars[i] = val[i];
            }
            return chars[0];

        }

        public char GetLastLetterOfString(string val)
        {
            char[] chars = new char[val.Length];
            for (int i = 0; i < val.Length; i++)
            {
                chars[i] = val[i];
            }
            return chars[chars.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
           
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var oddsList = new List<int>();
            for (int i = 0; i <100; i++)
            {
                if (i%2 != 0)
                {
                    oddsList.Add(i);
                }
            }
            return oddsList.ToArray();


        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
   
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

        }
    }
}
