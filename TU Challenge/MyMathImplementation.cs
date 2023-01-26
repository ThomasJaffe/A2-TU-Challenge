using System.ComponentModel;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static bool IsMajeur(int x)
        {
            if (x < 0)
            {
                throw new ArgumentException();
            }
            else if (x > 100)
            {
                throw new ArgumentException();
            }
            else
            {
                if (x > 18)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public static bool IsEven (int x) {
            if (x%2 == 0) {
                return true;
            } else {
                return false;
            }
        }

        public static bool IsDivisible(int x, int y)
        {
            if (x % y == 0) {
                return true;
            } else {
                return false;
            }
        }

        public static bool IsPrimary(int x) {
            int i;
            for (i = 2; i <= x - 1; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            if (i == x)
            {
                return true;
            }
            return false; ;
        }

        public static void GetAllPrimary(int x) {

        }

        public static int Power2(int x) {
            return x ^ 2;
        }

        public static int Power(int x, int y) { 
            return x ^ y;
        }
    }
}
