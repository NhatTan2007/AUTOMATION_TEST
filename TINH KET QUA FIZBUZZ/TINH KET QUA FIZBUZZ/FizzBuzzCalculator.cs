using System;
using System.Collections.Generic;
using System.Text;

namespace TINH_KET_QUA_FIZBUZZ
{
    public class FizzBuzzCalculator
    {
        public static string CalculateFizzBuzz(int numberInput)
        {
            bool IsDivisible3 = numberInput % 3 == 0;
            bool IsDivisible5 = numberInput % 5 == 0;
            bool IsDivisible3And5 = numberInput % 3 == 0 && numberInput % 5 == 0;
            if (IsDivisible3And5) return "FizzBuzz";
            else if (IsDivisible3) return "Fizz";
            else if (IsDivisible5) return "Buzz";
            else return $"{numberInput}";
        } 
    }
}
