using System;
using System.Collections.Generic;
using System.Text;

namespace TINH_KET_QUA_FIZBUZZ
{
    public class FizzBuzzTranslate
    {
        private static bool IsNumberExists(int numberInput, int numberToFind)
        {
            if ((numberInput.ToString()).IndexOf(numberToFind.ToString()) == -1) return false;
            else return true;
        }

        public static string TranslateToFizzBuzz(int numberInput)
        {
            if (IsNumberExists(numberInput, 3)) return "Fizz";
            else if (IsNumberExists(numberInput, 5)) return "Buzz";
            else if (IsNumberExists(numberInput, 3) && IsNumberExists(numberInput, 5)) return "FizzBuzz";
            else return $"{numberInput}";
        }

        

        public static string TranslateNumber(int numberInput)
        {
            string numberToString = numberInput.ToString();
            int numberLength = numberToString.Length;
            string nameTranslateOfTens = "";
            string nameTranslateOfUnits = "";
            int tensOfNumberInput;
            int unitsOfNumberInput;
            switch (numberLength)
            {
                case 1:
                    unitsOfNumberInput = (int)Char.GetNumericValue(numberToString[0]);
                    nameTranslateOfUnits = TranslateUnits(numberInput);
                    break;
                case 2:
                    tensOfNumberInput = (int)Char.GetNumericValue(numberToString[0]);
                    unitsOfNumberInput = (int)Char.GetNumericValue(numberToString[1]);
                    if (numberInput < 20)
                    {
                        nameTranslateOfTens = "Mười";
                        if (unitsOfNumberInput != 0 && unitsOfNumberInput != 5) nameTranslateOfUnits = TranslateUnits(unitsOfNumberInput);
                        else if (unitsOfNumberInput == 5) nameTranslateOfUnits = "lăm";
                    }
                    else
                    {
                        nameTranslateOfTens = TranslateUnits(tensOfNumberInput) + " mươi";
                        if (unitsOfNumberInput != 0 && unitsOfNumberInput != 1 && unitsOfNumberInput != 5) nameTranslateOfUnits = TranslateUnits(unitsOfNumberInput);
                        else if (unitsOfNumberInput == 1) nameTranslateOfUnits = "mốt";
                        else if (unitsOfNumberInput == 5) nameTranslateOfUnits = "lăm";
                    }
                    break;
                default:
                    return "Please check your number";
            }
            return $"{nameTranslateOfTens} {nameTranslateOfUnits}".Trim();
        }

        //public string TranslateTens(int tensInput)
        //{
        //    switch (tensInput)
        //    {
        //        case 1:
        //            return "Mười";
        //        case 2:
        //            return "Hai mươi";
        //        case 3:
        //            return "Ba mươi";
        //        case 4:
        //            return "Bốn mươi";
        //        case 5:
        //            return "Năm mươi";
        //        case 6:
        //            return "Sáu mươi";
        //        case 7:
        //            return "Bảy mươi";
        //        case 8:
        //            return "Tám mươi";
        //        case 9:
        //            return "Chín mươi";
        //        default:
        //            return "Please check again your number";
        //    }
        //}

        private static string  TranslateUnits(int unitsInput)
        {
            switch (unitsInput)
            {
                case 0:
                    return "Không";
                case 1:
                    return "Một";
                case 2:
                    return "Hai";
                case 3:
                    return "Ba";
                case 4:
                    return "Bốn";
                case 5:
                    return "Năm";
                case 6:
                    return "Sáu";
                case 7:
                    return "Bảy";
                case 8:
                    return "Tám";
                case 9:
                    return "Chín";
                default:
                    return "Please check again your number";
            }
        }
    }
}
