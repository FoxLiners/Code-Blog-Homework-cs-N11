using System;

namespace DZ_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int One = Convert.ToInt32(Console.ReadLine());
            int Two = Convert.ToInt32(Console.ReadLine());
            
            
            
            
            Counter c1 = new Counter { Apples = One };
            Counter c2 = new Counter { Apples = Two };
            
            
            
            int a = c1 + 43;
            int b = c1 - c2;

            bool c = c1 > c2;
            bool d = c1 < c2;

            bool e = c1 >= c2;
            bool f = c1 <= c2;

            bool g = c1 == c2;
            bool h = c1 != c2;
            
            
            
            
            Console.WriteLine(a);

            Console.WriteLine(b);


            Console.WriteLine(c);

            Console.WriteLine(d);


            Console.WriteLine(e);

            Console.WriteLine(f);


            Console.WriteLine(g);

            Console.WriteLine(h);



        }
    }
}
