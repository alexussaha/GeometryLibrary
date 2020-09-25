using System;

namespace GeometryLibrary
{
    public static class Area
    {
        #region StaticMethodsArea
        public static double TriangleArea(double a, double b, double c)
        {
            double p = (a + b + c)/2;
            return  Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static double CircleArea(double r)
        {
            return Math.PI * Math.Pow(r,2);
        }

        #endregion

    }
}
