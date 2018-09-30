using System;

namespace hw1
{
    class MathUtil
    {
        public static int AddFromOneTo(int n)
        {
            return AddFromX2Y(1, n);
        }

        public static int AddFromX2Y(int x, int y)
        {
            return (x + y) * (Math.Abs(x - y) + 1) / 2;
        }

        public static Boolean IsPrime(int x)
        {
            if (x == 1)
            {
                return false;
            }
            // Test from 2 to sqrt(x)
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}