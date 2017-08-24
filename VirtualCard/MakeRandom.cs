using System;

namespace VirtualCard
{
    class MakeRandom
    {
        static Random rand = new Random();
        static String a = "";
        static String b = "";
        static long convertedNumber;
        static long convertedCvc;
        static int[] number = new int[16];
        static int[] cvc = new int[3];

        static public int[] MakeRandomCardNumber
        {
            get
            {
                for (int i = 0; i < number.Length; i++)
                {
                    number[i] = rand.Next(0, 9);
                }
                return number;
            }
        }

        static public long ShowCardNumber()
        {
            foreach (long test in MakeRandomCardNumber)
            {
                a += test.ToString();
            }
            return convertedNumber = long.Parse(a);
        }

        static public int[] MakeRandomCvc
        {
            get
            {
                for (int i = 0; i < cvc.Length; i++)
                {
                    cvc[i] = rand.Next(0, 9);
                }
                return cvc;
            }
        }

        static public long ShowCvc()
        {
            foreach (long test in MakeRandomCvc)
            {
                b += test.ToString();
            }
            return convertedCvc = long.Parse(b);
        }
    }
}
