using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_11
{
    class Counter
    {
        public int Apples { get; set; }
            public static int operator +(Counter c1, int apl)
            {
                return c1.Apples + apl;
            }
            public static Counter operator +(Counter c1, Counter c2)
            {
               return new Counter { Apples = c1.Apples + c2.Apples };
            }



            public static bool operator >(Counter c1, Counter c2)
            {
                return c1.Apples > c2.Apples;
            }
            public static bool operator <(Counter c1, Counter c2)
            {
                return c1.Apples < c2.Apples;
            }



            public static bool operator <=(Counter c1, Counter c2)
            {
                return c1.Apples <= c2.Apples;
            }
            public static bool operator >=(Counter c1, Counter c2)
            {
                return c1.Apples >= c2.Apples;
            }



            public static int operator -(Counter c1, Counter c2)
            {
                return c1.Apples - c2.Apples;
            }
            public static bool operator ==(Counter c1, Counter c2)
            {
               return c1.Apples == c2.Apples;
            }
            public static bool operator !=(Counter c1, Counter c2)
            {
                return c1.Apples != c2.Apples;
            }
    }
}
