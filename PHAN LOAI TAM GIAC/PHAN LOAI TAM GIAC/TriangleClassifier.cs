using System;
using System.Collections.Generic;
using System.Text;

namespace PHAN_LOAI_TAM_GIAC
{
    public class TriangleClassifier
    {
        public static string CheckTypeOfTriangle(int lengthSideA, int lengthSideB, int lengthSideC)
        {
            bool IsTriangle = lengthSideA + lengthSideB > lengthSideC && lengthSideA + lengthSideC > lengthSideB && lengthSideB + lengthSideC > lengthSideA;
            if (IsTriangle)
            {
                bool IsEquilateralTriangle = lengthSideA == lengthSideB && lengthSideB == lengthSideC;
                bool IsIsoscelesTriangle = lengthSideA == lengthSideB || lengthSideB == lengthSideC || lengthSideA == lengthSideC;
                if (IsEquilateralTriangle) return "This is an Equilateral Triangle";
                else if (IsIsoscelesTriangle) return "This is an Isosceles Triangle";
                else return "This is a Scalene Triangle";
            }
            else return "This is not a Triangle";
        }
    }
}
