using System;
using System.Collections.Generic;
using System.Text;

namespace TINH_NGAY_TIEP_THEO
{
    public class NextDayCalculator
    {
        public static string NextDay(DateTime inputDay)
        {
            int dayOfMonthInput = inputDay.Day;
            int monthOfYearInput = inputDay.Month;
            int yearInput = inputDay.Year;
            int dayOfMonthOutput = dayOfMonthInput; ;
            int monthOfYearOutput = monthOfYearInput; ;
            int yearOutput = yearInput;
            switch (monthOfYearInput)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    if (dayOfMonthInput == 31)
                    {
                        dayOfMonthOutput = 1;
                        monthOfYearOutput = monthOfYearInput + 1;
                    } else
                    {
                        dayOfMonthOutput = dayOfMonthInput + 1;
                    }
                    return $"{dayOfMonthOutput}/{monthOfYearOutput}/{yearOutput}";
                case 12:
                    if (dayOfMonthInput == 31)
                    {
                        dayOfMonthOutput = 1;
                        monthOfYearOutput = 1;
                        yearOutput = yearInput + 1;
                    }
                    else dayOfMonthOutput = dayOfMonthInput + 1;
                    return $"{dayOfMonthOutput}/{monthOfYearOutput}/{yearOutput}";
                case 4:
                case 6:
                case 9:
                case 11:
                    if (dayOfMonthInput == 30)
                    {
                        dayOfMonthOutput = 1;
                        monthOfYearOutput = monthOfYearInput + 1;
                    }
                    else
                    {
                        dayOfMonthOutput = dayOfMonthInput + 1;
                    }
                    return $"{dayOfMonthOutput}/{monthOfYearOutput}/{yearOutput}";
                case 2:
                    if ((dayOfMonthInput == 28 && !IsLeepYear(yearInput)) || (dayOfMonthInput == 29 && IsLeepYear(yearInput)))
                    {
                        dayOfMonthOutput = 1;
                        monthOfYearOutput = monthOfYearInput + 1;
                    }
                    else
                    {
                        dayOfMonthOutput = dayOfMonthInput + 1;
                    }
                    return $"{dayOfMonthOutput}/{monthOfYearOutput}/{yearOutput}";
            }
            return "-1";
        }

        private static bool IsLeepYear(int year)
        {
            bool isYearDivisible4 = year % 4 == 0;
            bool isYearDivisible400 = year % 400 == 0;
            bool isYearDivisible100 = year % 100 == 0;
            if (isYearDivisible4)
            {
                if (isYearDivisible100)
                {
                    if (isYearDivisible400) return true;
                    else return false;
                }
                else return true;
            }
            else return false;
        }
    }
}
