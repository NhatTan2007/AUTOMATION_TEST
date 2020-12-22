using System;
using System.Text;

namespace TINH_KET_QUA_FIZBUZZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            bool checkInput = false;
            int numberInput;
            do
            {
                Console.Write("Nhập vào số nguyên không âm (<100): ");
                checkInput = int.TryParse(Console.ReadLine(), out numberInput);
            } while (!checkInput || numberInput < 0 || numberInput >= 100);

            Console.WriteLine(FizzBuzzCalculator.CalculateFizzBuzz(numberInput));
            Console.WriteLine(FizzBuzzTranslate.TranslateToFizzBuzz(numberInput));
            Console.WriteLine(FizzBuzzTranslate.TranslateNumber(numberInput));
        }
    }
}
