using System;
using System.Collections.Generic;
using System.Text;

namespace TIM_GIA_TRI_TUYET_DOI
{
    public class AbsoluteNumberCalculator
    {
        public static int FindAbsolute(int number)
        {
            if (number < 0) return -number;
            else return number;
        }
    }
}
