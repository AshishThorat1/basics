using System;

namespace AllInOneCSharp
{
    class Padding
    {
        static void Main(string[] args)
        {
            String str1, str2;
            str1 = "Hello";
            str2 = "World";
            Console.WriteLine("Right Padded string is as follows - {0}", str1.PadRight(20, '#'));
            Console.WriteLine("Left Padded string is as follows - {0}", str2.PadLeft(20, '#'));
            Console.ReadKey();
        }
    }
}
