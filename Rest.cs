using System;

namespace CalcLib
{
    public static class Rest
    {
        public static int Add(int m, int a, int b)
        {
            if (IsCorrect(m, a, b))
                return (a + b) % m;
            throw new ArgumentException("Error!");
        }
        public static int ReversAdd(int m, int a)
        {
            if (IsCorrect(m, a))
            {
                for (int i = 1; i < m; i++)
                    if ((a + i) % m == 0)
                        return i;
            }
            throw new ArgumentException("Error!");
        }
        public static int Subtract(int m, int a, int b)
        {
            if (IsCorrect(m, a, b))
                return (a + ReversAdd(m, b)) % m;
            throw new ArgumentException("Error!");
        }
        public static int Multiply(int m, int a, int b)
        {
            if (IsCorrect(m, a, b))
                return (a * b) % m;
            throw new ArgumentException("Error!");
        }
        public static int ReversMultiply(int m, int a)
        {
            if (IsCorrect(m, a))
            {
                for (int i = 1; i < m; i++)
                    if ((a * i) % m == 1)
                        return i;
                throw new ArgumentException("-");
            }
            throw new ArgumentException("Error!");
        }
        public static int Division(int m, int a, int b)
        {
            if (IsCorrect(m, a, b))
                return (a * ReversMultiply(m, b)) % m;
            throw new ArgumentException("Error!");
        }
        public static int Pov(int m, int a, int b)
        {
            if (IsCorrect(m, a, b))
            {
                int aMult = a;

                for (int i = 1; i < b; i++)
                    aMult *= a;

                return aMult % m;
            }
            throw new ArgumentException("Error!");
        }
        private static bool IsCorrect(int m, int a, int b = 1)
        {
            return m > a && m > b && a > 0 && b > 0;
        }
    }
}