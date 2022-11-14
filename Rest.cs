using System;
using System.Collections.Generic;

namespace CalcLib
{
    public static class Rest
    {
        public static bool IsSimple(int p)
        {
            for (int i = 2; i <= p - 2; i++)
            {
                decimal d = i;
                try
                {
                    for (int j = 2; j <= p - 1; j++)
                        d *= i;
                    if (d % p != 1)
                        return false;
                }
                catch
                {
                    if (p % i == 0)
                        return false;
                }
            }
            return true;
        }
        public static int GenerateSimple(int a)
        {
            Random random = new Random();
            List<int> list = new List<int>();

            for (int i = 1; i <= a; i++)
                if (IsSimple(i))
                    list.Add(i);
            return list[random.Next(1, list.Count)];
        }
        public static int Euclid(int a, int b)
        {
            int temp = a;
            a = Math.Max(a, b);
            b = Math.Min(temp, b);

            do
            {
                int r = a % b;
                if (r == 0)
                    return b;
                a = b;
                b = r;
            } while (true);
        }
        public static int SimpleCount(int n)
        {
            int result = n;

            for (int i = 2; i * i <= n; ++i)
                if (n % i == 0)
                {
                    while (n % i == 0)
                        n /= i;
                    result -= result / i;
                }
            if (n > 1)
                result -= result / n;
            return result;
        }
        public static int Reverse(int p, int a)
        {
            for (int i = 1; i < p; i++)
                if ((a * i) % p == 1)
                    return i;
            throw new ArgumentException("-");
        }
    }
}