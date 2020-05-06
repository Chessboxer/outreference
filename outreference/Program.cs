using System;

namespace outreference
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 3;
            Console.WriteLine(x);
            Five(x);
            Console.WriteLine(x);

        }


        static void Five(int a)
        {
            a = 5;
            Console.WriteLine(a);
        }
    }

}
