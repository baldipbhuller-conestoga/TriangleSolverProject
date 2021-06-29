using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleSolverProject
{
    public static class TriangleSolver
    {
        public static string Analyze (int firstSide, int secondSide, int thirdSide)
        {
            // Initial result and will change depending on checks
            string result = "Not a Triangle";

            // Check condition if a triangle can be formed
            if (firstSide + secondSide > thirdSide && 
                secondSide + thirdSide > firstSide && 
                firstSide + thirdSide > secondSide)
            {
                // Check for type of triangle
                if (firstSide == secondSide && secondSide == thirdSide)
                {
                    result = "Triangle - Equilateral";
                }
                else if (firstSide == secondSide || firstSide == thirdSide || secondSide == thirdSide)
                {
                    result = "Triangle - Isosceles";
                }
                else
                {
                    result = "Triangle - Scalene";
                }
            }

            return result;
        }
    }
}
