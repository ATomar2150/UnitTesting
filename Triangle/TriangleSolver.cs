using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public static class TriangleSolver
    {
        public static string Analyze(long fSide, long sSide, long tSide)
        {
            //checking if sides are valid.
            string message = "";
            if ((fSide + sSide > tSide) && (fSide + tSide > sSide) && (sSide + tSide > fSide))
            {

                if (fSide == sSide && sSide == tSide)
                {
                    message = "Given numbers ARE sides of an EQUILATERAL Triangle.";
                }
                else if (fSide == sSide || fSide == tSide || sSide == tSide)
                {
                    message = "Given numbers ARE sides of an ISOSCELES Triangle.";
                }
                else
                {
                    message = "Given numbers ARE sides of an SCALENE Triangle.";
                }
            }
            else
            {
                message = "Given numbers CAN NOT be sides of a Triangle.";
            }
            return message;
        }
    }
}
