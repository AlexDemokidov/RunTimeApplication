using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Area
{
    public static class CalcArea
    {
        public static double Circle(double radius)
        {
            return Round(Math.PI*radius*radius, 2);
        }
        public static double Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if ((firstSide > secondSide) & (firstSide > thirdSide)) {
                if (firstSide * firstSide == secondSide * secondSide + thirdSide * thirdSide)
                    return secondSide * thirdSide / 2;
            } else if ((secondSide > firstSide) & (secondSide > thirdSide)) {
                    if (secondSide * secondSide == firstSide * firstSide + thirdSide * thirdSide)
                        return firstSide * thirdSide / 2;
            } else if ((thirdSide > firstSide) & (thirdSide > secondSide)) {
                        if (thirdSide * thirdSide == firstSide * firstSide + secondSide * secondSide)
                            return firstSide * secondSide / 2;
            } 
            var p = (firstSide+secondSide+thirdSide)/2;
            return Round(Math.Sqrt(p*(p-firstSide)*(p-secondSide)*(p-thirdSide)), 2);
        }
    }
}
